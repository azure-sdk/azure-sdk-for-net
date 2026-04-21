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

            // PropertyFlatten can lift multiple required leaves under a single parent
            // (e.g. `properties.A`, `properties.B`, `properties.C` all surface on the
            // model). Setting a single leaf to null must NOT clear the entire parent —
            // doing so would also wipe sibling leaves. Instead we treat null as a no-op.
            // The parent-clearing semantics (used by SafeFlatten) are appropriate only
            // for the 1-to-1 lifted case.
            var setter = new List<MethodBodyStatement>();
            var internalPropertyExpression = This.Property(internalProperty.Name);

            if (isPropertyLiftedToNullable)
            {
                // Property surface is nullable; only assign when the incoming value is
                // present. Lazily create the parent so unrelated leaves can also assign.
                // For value-type inners use the Nullable<T> API; for reference-type inners
                // use a simple null check and pass Value through directly.
                var isInnerValueType = innerProperty.Type.IsValueType;
                ValueExpression hasValueGuard = isInnerValueType
                    ? Value.Property(nameof(Nullable<int>.HasValue))
                    : Value.NotEqual(Null);
                ValueExpression unwrappedValue = isInnerValueType
                    ? Value.Property(nameof(Nullable<int>.Value))
                    : Value;
                var ifHasValue = new IfStatement(hasValueGuard)
                {
                    new IfStatement(internalPropertyExpression.Is(Null))
                    {
                        internalPropertyExpression.Assign(New.Instance(innerModel.Type!)).Terminate()
                    },
                    internalPropertyExpression.Property(innerProperty.Name).Assign(unwrappedValue).Terminate()
                };
                setter.Add(ifHasValue);
            }
            else
            {
                setter.Add(
                    new IfStatement(internalPropertyExpression.Is(Null))
                    {
                        internalPropertyExpression.Assign(New.Instance(innerModel.Type!)).Terminate()
                    });
                setter.Add(internalPropertyExpression.Property(innerProperty.Name).Assign(Value).Terminate());
            }
            return setter;
        }

        public static MethodBodyStatement? BuildSetterForSafeFlatten(bool includeSetterCheck, ModelProvider innerModel, PropertyProvider internalProperty, PropertyProvider innerProperty, bool isPropertyLiftedToNullable)
        {
            // To not introduce breaking change, for collection types, we keep the setter for collection-type properties during safe flatten.
            var setter = new List<MethodBodyStatement>();
            var internalPropertyExpression = This.Property(internalProperty.Name);
            // For a lifted property, the public setter receives a nullable value. Use the
            // appropriate guard / unwrap depending on whether the inner type is a value type
            // (Nullable<T> API) or a reference type (simple null check).
            var isInnerValueType = innerProperty.Type.IsValueType;
            ValueExpression? hasValueGuard = isPropertyLiftedToNullable
                ? (isInnerValueType ? Value.Property(nameof(Nullable<int>.HasValue)) : Value.NotEqual(Null))
                : null;
            ValueExpression unwrappedValue = isPropertyLiftedToNullable && isInnerValueType
                ? Value.Property(nameof(Nullable<int>.Value))
                : Value;
            if (includeSetterCheck)
            {
                if (isPropertyLiftedToNullable)
                {
                    var ifStatement = new IfStatement(hasValueGuard!)
                    {
                        new IfStatement(internalPropertyExpression.Is(Null))
                        {
                            internalPropertyExpression.Assign(New.Instance(innerModel.Type!)).Terminate(),
                            internalPropertyExpression.Property(innerProperty.Name).Assign(unwrappedValue).Terminate()
                        }
                    };
                    setter.Add(new IfElseStatement(ifStatement, internalPropertyExpression.Assign(Null).Terminate()));
                }
                else
                {
                    setter.Add(new IfStatement(internalPropertyExpression.Is(Null))
                    {
                        internalPropertyExpression.Assign(New.Instance(innerModel.Type!)).Terminate()
                    });
                    setter.Add(internalPropertyExpression.Property(innerProperty.Name).Assign(Value).Terminate());
                }
            }
            else
            {
                if (isPropertyLiftedToNullable)
                {
                    setter.Add(internalPropertyExpression.Assign(new TernaryConditionalExpression(hasValueGuard!, New.Instance(innerModel.Type!, unwrappedValue), Default)).Terminate());
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
