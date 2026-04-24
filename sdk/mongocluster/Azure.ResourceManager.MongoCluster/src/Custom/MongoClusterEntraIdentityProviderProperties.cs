// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    public partial class MongoClusterEntraIdentityProviderProperties
    {
        /// <summary>
        /// [Obsolete] Backward-compatibility shim. Use <see cref="PrincipalKind"/> instead.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property has been renamed to PrincipalKind.")]
        public MongoClusterEntraPrincipalType PrincipalType
        {
            get => PrincipalKind;
            set => PrincipalKind = value;
        }
    }
}
