// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    public partial class MongoClusterEntraIdentityProvider
    {
        /// <summary>
        /// [Obsolete] Backward-compatibility shim. Use <see cref="MongoClusterEntraIdentityProviderPrincipalKind"/> instead.
        /// The underlying property is now non-nullable; setting <c>null</c> is a no-op (existing value preserved).
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property has been renamed to MongoClusterEntraIdentityProviderPrincipalKind.")]
        public MongoClusterEntraPrincipalType? MongoClusterEntraIdentityProviderPrincipalType
        {
            get => MongoClusterEntraIdentityProviderPrincipalKind;
            set
            {
                if (value.HasValue)
                {
                    MongoClusterEntraIdentityProviderPrincipalKind = value.Value;
                }
            }
        }
    }
}
