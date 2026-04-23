// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using Azure.ResourceManager.BillingBenefits.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    public partial class ContributorData
    {
        /// <summary>
        /// Represents type of the object being operated on. Possible values are primary or contributor.
        /// </summary>
        /// <remarks>
        /// Backward-compatibility shim. Use <see cref="BenefitEntityType"/> instead.
        /// </remarks>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsolete and will be removed in a future release. Use BenefitEntityType instead.")]
        public MaccEntityType EntityType => BenefitEntityType.GetValueOrDefault();
    }
}
