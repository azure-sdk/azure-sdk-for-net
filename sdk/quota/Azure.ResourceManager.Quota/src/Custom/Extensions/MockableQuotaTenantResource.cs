// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Threading;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota.Mocking
{
    public partial class MockableQuotaTenantResource
    {
        /// <summary>
        /// List the operations for the provider. This operation is obsolete; use GetAllAsync instead.
        /// <list type="bullet"><item><term>Request Path</term><description>/providers/Microsoft.Quota/operations</description></item></list>
        /// </summary>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AsyncPageable<QuotaOperationResult> GetQuotaOperationsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use GetAllAsync instead.");
        }

        /// <summary>
        /// List the operations for the provider. This operation is obsolete; use GetAll instead.
        /// <list type="bullet"><item><term>Request Path</term><description>/providers/Microsoft.Quota/operations</description></item></list>
        /// </summary>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Pageable<QuotaOperationResult> GetQuotaOperations(CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use GetAll instead.");
        }
    }
}
