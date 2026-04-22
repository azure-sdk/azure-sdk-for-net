// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Humanizer;
using Microsoft.TypeSpec.Generator.Expressions;
using Microsoft.TypeSpec.Generator.Primitives;
using Microsoft.TypeSpec.Generator.Providers;
using Microsoft.TypeSpec.Generator.Snippets;
using Microsoft.TypeSpec.Generator.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.TypeSpec.Generator.Snippets.Snippet;

namespace Azure.Generator.Management.Utilities
{
    internal class PropertyHelpers
    {
        public static IReadOnlyList<PropertyProvider> GetAllProperties(ModelProvider propertyModelProvider)
        {
            var result = new List<PropertyProvider>();
            var baseType = propertyModelProvider.BaseModelProvider;
            var baseTypes = new Stack<ModelProvider>();

            // Recursively get properties from base types
            while (baseType is not null)
            {
                baseTypes.Push(baseType);
                baseType = baseType.BaseModelProvider;
            }
            while (baseTypes.TryPop(out var item))
            {
                result.AddRange(item.Properties);
                result.AddRange(item.CustomCodeView?.Properties ?? []);
            }
            result.AddRange(propertyModelProvider.Properties);
            result.AddRange(propertyModelProvider.CustomCodeView?.Properties ?? []);
            return result;
        }

        public static (bool IsReadOnly, bool? IncludeGetterNullCheck, bool IncludeSetterNullCheck) GetFlags(PropertyProvider property, PropertyProvider innerProperty)
        {
            var isInnerPropertyReadOnly = !innerProperty.Body.HasSetter;
            var isPropertyReadOnly = !property.Body.HasSetter;
            if (!isPropertyReadOnly && isInnerPropertyReadOnly)
            {
                if (HasDefaultPublicCtor(innerProperty.EnclosingType as ModelProvider))
                {
                    if (innerProperty.Type.Arguments.Count > 0)
                        return (true, true, false);
                    else
                        return (true, false, false);
                }
                else
                {
                    return (false, false, false);
                }
            }
            else if (!isPropertyReadOnly && !isInnerPropertyReadOnly)
            {
                if (HasDefaultPublicCtor(innerProperty.EnclosingType as ModelProvider))
                    return (false, false, true);
                else
                    return (false, false, false);
            }

            return (true, null, false);
        }

        private static bool HasDefaultPublicCtor(ModelProvider? innerModel)
        {
            if (innerModel is null)
                return false;

            foreach (var ctor in innerModel.Constructors)
            {
                if (ctor.Signature.Modifiers.HasFlag(MethodSignatureModifiers.Public) && !ctor.Signature.Parameters.Any())
                    return true;
            }

            return false;
        }

        public static MethodBodyStatement BuildGetter(bool? includeGetterNullCheck, PropertyProvider internalProperty, TypeProvider innerModel, PropertyProvider innerProperty)
        {
            var checkNullExpression = This.Property(internalProperty.Name).Is(Null);
            var shouldNullGuard = internalProperty.Type.IsNullable || internalProperty.WireInfo?.IsRequired == false || innerModel.Type.IsNullable;
            // For collection types, we initialize the internal property if it's null and return the inner property.
            if (innerProperty.Type.IsCollection && internalProperty.WireInfo?.IsRequired == true)
            {
                if (!internalProperty.Body.HasSetter)
                {
                    return Return(new TernaryConditionalExpression(checkNullExpression, Default, new MemberExpression(internalProperty, innerProperty.Name)));
                }

                return new List<MethodBodyStatement> {
                    new IfStatement(checkNullExpression)
                    {
                        internalProperty.Assign(New.Instance(innerModel.Type)).Terminate()
                    },
                    Return(new MemberExpression(internalProperty, innerProperty.Name))
                };
            }

            if (includeGetterNullCheck == true)
            {
                return new List<MethodBodyStatement> {
                    new IfStatement(checkNullExpression)
                    {
                        internalProperty.Assign(New.Instance(innerModel.Type)).Terminate()
                    },
                    Return(new MemberExpression(internalProperty, innerProperty.Name))
                };
            }
            else if (includeGetterNullCheck == false)
            {
                // For collection types with a settable internal property, initialize the internal property
                // to avoid returning null, which would cause NullReferenceException during serialization.
                if (innerProperty.Type.IsCollection && internalProperty.Body.HasSetter)
                {
                    return new List<MethodBodyStatement> {
                        new IfStatement(checkNullExpression)
                        {
                            internalProperty.Assign(New.Instance(innerModel.Type)).Terminate()
                        },
                        Return(new MemberExpression(internalProperty, innerProperty.Name))
                    };
                }
                return Return(new TernaryConditionalExpression(checkNullExpression, Default, new MemberExpression(internalProperty, innerProperty.Name)));
            }
            else
            {
                if (shouldNullGuard)
                {
                    return Return(new TernaryConditionalExpression(checkNullExpression, Default, new MemberExpression(internalProperty, innerProperty.Name)));
                }
                return Return(new MemberExpression(internalProperty, innerProperty.Name));
            }
        }

        public static MethodBodyStatement? BuildSetterForPropertyFlatten(ModelProvider innerModel, PropertyProvider internalProperty, PropertyProvider innerProperty, bool isPropertyLiftedToNullable)
        {
            if (innerProperty.Type.IsCollection)
            {
                return null;
            }

            // Preserve the original "lazy create parent + assign value" semantics. For a
            // lifted non-nullable value-type the public setter receives Nullable<T>; we unwrap
            // with .GetValueOrDefault() so the assignment compiles against the inner type.
            // For already-nullable inners and reference types, the public type matches the
            // inner type, so the value is passed through directly. Setting a leaf to null
            // does NOT clear sibling leaves on the same parent.
            var setter = new List<MethodBodyStatement>();
            var internalPropertyExpression = This.Property(internalProperty.Name);
            var needsUnwrap = isPropertyLiftedToNullable && innerProperty.Type.IsValueType && !innerProperty.Type.IsNullable;
            ValueExpression assignedValue = needsUnwrap
                ? Value.Invoke(nameof(Nullable<int>.GetValueOrDefault))
                : Value;

            setter.Add(new IfStatement(internalPropertyExpression.Is(Null))
            {
                internalPropertyExpression.Assign(New.Instance(innerModel.Type!)).Terminate()
            });
            setter.Add(internalPropertyExpression.Property(innerProperty.Name).Assign(assignedValue).Terminate());
            return setter;
        }

        public static MethodBodyStatement? BuildSetterForSafeFlatten(bool includeSetterCheck, ModelProvider innerModel, PropertyProvider internalProperty, PropertyProvider innerProperty, bool isPropertyLiftedToNullable)
        {
            // To not introduce breaking change, for collection types, we keep the setter for collection-type properties during safe flatten.
            var setter = new List<MethodBodyStatement>();
            var internalPropertyExpression = This.Property(internalProperty.Name);
            // For a lifted non-nullable value-type inner, the public setter receives Nullable<T>.
            // We unwrap with .GetValueOrDefault() so the original "lazy create parent + assign value"
            // behavior is preserved with minimal change. For already-nullable inners (e.g. T?) and
            // reference types, the public type matches the inner type, so we pass the value through.
            var isInnerNonNullableValueType = innerProperty.Type.IsValueType && !innerProperty.Type.IsNullable;
            var needsUnwrap = isPropertyLiftedToNullable && isInnerNonNullableValueType;
            ValueExpression assignedValue = needsUnwrap
                ? Value.Invoke(nameof(Nullable<int>.GetValueOrDefault))
                : Value;
            if (includeSetterCheck)
            {
                setter.Add(new IfStatement(internalPropertyExpression.Is(Null))
                {
                    internalPropertyExpression.Assign(New.Instance(innerModel.Type!)).Terminate()
                });
                setter.Add(internalPropertyExpression.Property(innerProperty.Name).Assign(assignedValue).Terminate());
            }
            else
            {
                if (needsUnwrap)
                {
                    // Inner model has no parameterless ctor (single required arg = the lifted leaf).
                    // When the lifted Nullable<T> value is null we have no T to construct with, so
                    // we fall back to default(parent) for that one unavoidable case.
                    var hasValueGuard = Value.Property(nameof(Nullable<int>.HasValue));
                    var unwrappedValue = Value.Property(nameof(Nullable<int>.Value));
                    setter.Add(internalPropertyExpression.Assign(new TernaryConditionalExpression(hasValueGuard, New.Instance(innerModel.Type!, unwrappedValue), Default)).Terminate());
                }
                else
                {
                    setter.Add(internalPropertyExpression.Assign(New.Instance(innerModel.Type, Value)).Terminate());
                }
            }
            return setter;
        }

        public static string GetCombinedPropertyName(PropertyProvider innerProperty, PropertyProvider immediateParentProperty)
        {
            var immediateParentPropertyName = GetPropertyName(immediateParentProperty);

            if (innerProperty.Type.Equals(typeof(bool)) || innerProperty.Type.Equals(typeof(bool?)))
            {
                return innerProperty.Name.Equals("Enabled", StringComparison.Ordinal) ? $"{immediateParentPropertyName}{innerProperty.Name}" : innerProperty.Name;
            }

            if (innerProperty.Name.Equals("Id", StringComparison.Ordinal))
                return $"{immediateParentPropertyName}{innerProperty.Name}";

            if (immediateParentPropertyName.EndsWith(innerProperty.Name, StringComparison.Ordinal))
                return immediateParentPropertyName;

            var parentWords = immediateParentPropertyName.SplitByCamelCase();
            bool suffixStripped = false;
            if (immediateParentPropertyName.EndsWith("Profile", StringComparison.Ordinal) ||
                immediateParentPropertyName.EndsWith("Policy", StringComparison.Ordinal) ||
                immediateParentPropertyName.EndsWith("Configuration", StringComparison.Ordinal) ||
                immediateParentPropertyName.EndsWith("Properties", StringComparison.Ordinal) ||
                immediateParentPropertyName.EndsWith("Settings", StringComparison.Ordinal))
            {
                parentWords = parentWords.Take(parentWords.Count() - 1);
                suffixStripped = true;
            }

            var parentWordArray = parentWords.ToArray();
            var parentWordsHash = new HashSet<string>(parentWordArray);
            var nameWords = innerProperty.Name.SplitByCamelCase().ToArray();
            var lastWord = string.Empty;
            for (int i = 0; i < nameWords.Length; i++)
            {
                var word = nameWords[i];
                lastWord = word;
                if (parentWordsHash.Contains(word))
                {
                    if (i == nameWords.Length - 2 && parentWordArray.Length >= 2 && word.Equals(parentWordArray[parentWordArray.Length - 2], StringComparison.Ordinal))
                    {
                        parentWords = parentWords.Take(parentWords.Count() - 2);
                        break;
                    }
                    {
                        return innerProperty.Name;
                    }
                }

                //need to pluralize or singularize the last word and check
                if (i == nameWords.Length - 1 && (parentWordsHash.Contains(lastWord.Pluralize()) || (suffixStripped && parentWordsHash.Contains(lastWord.Singularize()))))
                    return innerProperty.Name;
            }

            immediateParentPropertyName = string.Join("", parentWords);

            return $"{immediateParentPropertyName}{innerProperty.Name}";
        }

        private static string GetPropertyName(PropertyProvider property)
        {
            const string properties = "Properties";
            if (property.Name.Equals(properties, StringComparison.Ordinal))
            {
                string typeName = property.Type.Name;
                int index = typeName.IndexOf(properties);
                if (index > -1 && index + properties.Length == typeName.Length)
                    return typeName.Substring(0, index);

                return typeName;
            }
            return property.Name;
        }
    }
}
