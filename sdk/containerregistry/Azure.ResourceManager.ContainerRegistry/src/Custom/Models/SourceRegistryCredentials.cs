// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Describes the credential parameters for accessing the source registry. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This type is no longer supported.")]
    public partial class SourceRegistryCredentials
    {
        /// <summary> The authentication mode. </summary>
        public SourceRegistryLoginMode? LoginMode { get; set; }
    }
}
