// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Billing
{
    internal class BillingSubscriptionOperationSource : IOperationSource<BillingSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal BillingSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        BillingSubscriptionResource IOperationSource<BillingSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingSubscriptionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerBillingContext.Default);
            return new BillingSubscriptionResource(_client, data);
        }

        async ValueTask<BillingSubscriptionResource> IOperationSource<BillingSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingSubscriptionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerBillingContext.Default);
            return await Task.FromResult(new BillingSubscriptionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
