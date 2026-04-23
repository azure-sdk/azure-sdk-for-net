// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LambdaTestHyperExecute.Models
{
    public static partial class ArmLambdaTestHyperExecuteModelFactory
    {
        /// <summary>
        /// [Obsolete] Backward-compatibility shim for the previous factory signature where
        /// <c>partnerLicensesSubscribed</c> was nullable. Forwards to the new factory using the
        /// renamed, non-nullable <c>partnerLicensesCount</c> parameter (<c>null</c> becomes <c>0</c>).
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static LambdaTestHyperExecuteOrganizationProperties LambdaTestHyperExecuteOrganizationProperties(
            LambdaTestHyperExecuteMarketplaceDetails marketplace,
            LambdaTestHyperExecuteUserDetails user,
            LambdaTestHyperExecuteOfferProvisioningState? provisioningState,
            int? partnerLicensesSubscribed,
            LambdaTestHyperExecuteSingleSignOnPropertiesV2 singleSignOnProperties)
            => LambdaTestHyperExecuteOrganizationProperties(
                marketplace,
                user,
                provisioningState,
                partnerLicensesSubscribed.GetValueOrDefault(),
                singleSignOnProperties);
    }
}
