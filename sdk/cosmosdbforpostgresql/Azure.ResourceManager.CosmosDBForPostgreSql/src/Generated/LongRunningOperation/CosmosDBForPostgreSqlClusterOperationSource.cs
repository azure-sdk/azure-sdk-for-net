// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    internal class CosmosDBForPostgreSqlClusterOperationSource : IOperationSource<CosmosDBForPostgreSqlClusterResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBForPostgreSqlClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBForPostgreSqlClusterResource IOperationSource<CosmosDBForPostgreSqlClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBForPostgreSqlClusterData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);
            return new CosmosDBForPostgreSqlClusterResource(_client, data);
        }

        async ValueTask<CosmosDBForPostgreSqlClusterResource> IOperationSource<CosmosDBForPostgreSqlClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBForPostgreSqlClusterData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);
            return await Task.FromResult(new CosmosDBForPostgreSqlClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
