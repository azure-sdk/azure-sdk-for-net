// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.MongoCluster.Models
{
    public partial class MongoClusterEntraIdentityProvider
    {
        // Customization rationale:
        // The generator flattens `EntraIdentityProviderProperties.principalType` up onto the parent
        // model and produces a non-nullable property named `MongoClusterEntraIdentityProviderPrincipalType`
        // (long, prefix-mangled). The previous GA SDK exposed this as a nullable `MongoClusterEntraPrincipalType?`
        // get/set property under the same long name. We:
        //   1) replace the generated long-named property with a clean `PrincipalType` (typed `T?`) via [CodeGenMember],
        //   2) re-introduce the original long name as an [Obsolete] backward-compatibility shim that delegates here.
        /// <summary> The principal type of the user. </summary>
        [CodeGenMember("MongoClusterEntraIdentityProviderPrincipalType")]
        public MongoClusterEntraPrincipalType? PrincipalType
        {
            get => Properties?.PrincipalType;
            set
            {
                if (value.HasValue)
                {
                    Properties = new MongoClusterEntraIdentityProviderProperties(value.Value);
                }
                else
                {
                    Properties = null;
                }
            }
        }

        /// <summary>
        /// [Obsolete] Backward-compatibility shim. Use <see cref="PrincipalType"/> instead.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property has been renamed to PrincipalType.")]
        public MongoClusterEntraPrincipalType? MongoClusterEntraIdentityProviderPrincipalType
        {
            get => PrincipalType;
            set => PrincipalType = value;
        }
    }
}
