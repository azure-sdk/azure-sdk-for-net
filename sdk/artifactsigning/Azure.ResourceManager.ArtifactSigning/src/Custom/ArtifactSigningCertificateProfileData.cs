// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using Azure.ResourceManager.ArtifactSigning.Models;

namespace Azure.ResourceManager.ArtifactSigning
{
    public partial class ArtifactSigningCertificateProfileData
    {
        /// <summary>
        /// Profile type of the certificate.
        /// </summary>
        /// <remarks>
        /// Backward-compatibility shim. Use <see cref="CertificateProfileType"/> instead.
        /// </remarks>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsolete and will be removed in a future release. Use CertificateProfileType instead.")]
        public CertificateProfileType ProfileType
        {
            get => CertificateProfileType.GetValueOrDefault();
            set => CertificateProfileType = value;
        }
    }
}
