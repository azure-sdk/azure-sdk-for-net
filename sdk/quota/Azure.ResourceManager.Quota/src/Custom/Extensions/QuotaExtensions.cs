// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ManagementGroups;
using Azure.ResourceManager.Quota.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Quota
{
    public static partial class QuotaExtensions
    {
        /// <summary>
        /// Gets all the quota allocated to a subscription for the specified resource provider and location.
        /// </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource"/> the method will execute against. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static async Task<Response<SubscriptionQuotaAllocationsListResource>> GetSubscriptionQuotaAllocationsListAsync(this ManagementGroupResource managementGroupResource, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask.ConfigureAwait(false);
            throw new NotSupportedException("This method is obsolete. Use the ArmClient scope-based extension methods instead.");
        }

        /// <summary>
        /// Gets all the quota allocated to a subscription for the specified resource provider and location.
        /// </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource"/> the method will execute against. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Response<SubscriptionQuotaAllocationsListResource> GetSubscriptionQuotaAllocationsList(this ManagementGroupResource managementGroupResource, string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use the ArmClient scope-based extension methods instead.");
        }

        /// <summary>
        /// List the operations for the provider
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<QuotaOperationResult> GetQuotaOperationsAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use GetAllAsync instead.");
        }

        /// <summary>
        /// List the operations for the provider
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<QuotaOperationResult> GetQuotaOperations(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use GetAll instead.");
        }
    }
}
