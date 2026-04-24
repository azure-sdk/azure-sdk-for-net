// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LambdaTestHyperExecute.Models
{
    public partial class LambdaTestHyperExecuteOfferPartnerProperties
    {
        /// <summary>
        /// [Obsolete] Backward-compatibility shim. Use <see cref="LicensesCount"/> instead.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property has been renamed to LicensesCount.")]
        public int LicensesSubscribed
        {
            get => LicensesCount;
            set => LicensesCount = value;
        }
    }
}
