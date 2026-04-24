// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServiceFabricManagedClustersSku
    {
        /// <summary>
        /// [Obsolete] Backward-compatibility shim. Use <see cref="SkuKind"/> instead.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property has been renamed to SkuKind.")]
        public ServiceFabricManagedClustersSkuName Name
        {
            get => SkuKind;
            set => SkuKind = value;
        }
    }
}
