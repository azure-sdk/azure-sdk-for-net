// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LambdaTestHyperExecute.Models
{
    public partial class LambdaTestHyperExecuteOrganizationProperties
    {
        /// <summary>
        /// [Obsolete] Backward-compatibility shim. Use <see cref="PartnerLicensesCount"/> instead.
        /// The underlying property is now non-nullable; setting <c>null</c> is a no-op (existing value preserved).
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property has been renamed to PartnerLicensesCount.")]
        public int? PartnerLicensesSubscribed
        {
            get => PartnerLicensesCount;
            set
            {
                if (value.HasValue)
                {
                    PartnerLicensesCount = value.Value;
                }
            }
        }
    }
}
