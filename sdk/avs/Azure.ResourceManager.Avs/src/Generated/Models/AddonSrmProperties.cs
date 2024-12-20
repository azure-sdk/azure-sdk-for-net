// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of a Site Recovery Manager (SRM) addon. </summary>
    public partial class AddonSrmProperties : AvsPrivateCloudAddonProperties
    {
        /// <summary> Initializes a new instance of <see cref="AddonSrmProperties"/>. </summary>
        public AddonSrmProperties()
        {
            AddonType = AddonType.SRM;
        }

        /// <summary> Initializes a new instance of <see cref="AddonSrmProperties"/>. </summary>
        /// <param name="addonType"> Addon type. </param>
        /// <param name="provisioningState"> The state of the addon provisioning. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="licenseKey"> The Site Recovery Manager (SRM) license. </param>
        internal AddonSrmProperties(AddonType addonType, AddonProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, string licenseKey) : base(addonType, provisioningState, serializedAdditionalRawData)
        {
            LicenseKey = licenseKey;
            AddonType = addonType;
        }

        /// <summary> The Site Recovery Manager (SRM) license. </summary>
        public string LicenseKey { get; set; }
    }
}
