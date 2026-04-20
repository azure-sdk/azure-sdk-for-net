// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator.Primitives;
using Microsoft.TypeSpec.Generator.Providers;
using Microsoft.TypeSpec.Generator.Statements;
using System;
using System.Collections.Generic;

namespace Azure.Generator.Management.Primitives
{
    internal class FlattenedPropertyProvider : PropertyProvider
    {
        /// <summary>
        /// The property that this property is flattened from.
        /// </summary>
        public PropertyProvider FlattenedProperty { get; }

        /// <summary>
        /// The property that this property is directed to.
        /// </summary>
        public PropertyProvider OriginalProperty { get; }

        /// <summary>
        /// True when this flattened property's type was lifted to <c>Nullable&lt;T&gt;</c>
        /// because the inner is a non-nullable value type but the wrapping parent
        /// (e.g. <c>properties?:</c>) may be absent at runtime. The public property
        /// surface is <c>T?</c>, but the public constructor parameter is kept as the
        /// original non-nullable <c>T</c> to enforce that required leaves are provided.
        /// </summary>
        public bool IsLiftedFromValueType { get; }

        public FlattenedPropertyProvider(FormattableString? description, MethodSignatureModifiers modifiers, CSharpType type, string name, PropertyBody body, TypeProvider enclosingType, PropertyProvider flattenedFrom, PropertyProvider originalProperty, CSharpType? explicitInterface = null, PropertyWireInformation? wireInfo = null, bool isRef = false, IEnumerable<AttributeStatement>? attributes = null, bool isLiftedFromValueType = false)
            : base(description, modifiers, type, name, body, enclosingType, explicitInterface, wireInfo, isRef, attributes)
        {
            FlattenedProperty = flattenedFrom;
            OriginalProperty = originalProperty;
            IsLiftedFromValueType = isLiftedFromValueType;
        }
    }
}
