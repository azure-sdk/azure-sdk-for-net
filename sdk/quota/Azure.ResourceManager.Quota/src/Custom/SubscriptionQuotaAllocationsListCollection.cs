// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Quota
{
    public partial class SubscriptionQuotaAllocationsListCollection
    {
        /// <summary>
        /// Gets all the quota allocated to a subscription for the specified resource provider and location.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<Response<SubscriptionQuotaAllocationsListResource>> GetAsync(string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask.ConfigureAwait(false);
            throw new NotSupportedException("This method is obsolete. Use the scope-based Get(AzureLocation) overload instead.");
        }

        /// <summary>
        /// Gets all the quota allocated to a subscription for the specified resource provider and location.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Response<SubscriptionQuotaAllocationsListResource> Get(string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use the scope-based Get(AzureLocation) overload instead.");
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<Response<bool>> ExistsAsync(string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask.ConfigureAwait(false);
            throw new NotSupportedException("This method is obsolete. Use the scope-based Exists(AzureLocation) overload instead.");
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Response<bool> Exists(string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use the scope-based Exists(AzureLocation) overload instead.");
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual NullableResponse<SubscriptionQuotaAllocationsListResource> GetIfExists(string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException("This method is obsolete. Use the scope-based GetIfExists(AzureLocation) overload instead.");
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. </param>
        /// <param name="resourceProviderName"> The resource provider name. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<NullableResponse<SubscriptionQuotaAllocationsListResource>> GetIfExistsAsync(string subscriptionId, string groupQuotaName, string resourceProviderName, AzureLocation location, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask.ConfigureAwait(false);
            throw new NotSupportedException("This method is obsolete. Use the scope-based GetIfExists(AzureLocation) overload instead.");
        }
    }
}
