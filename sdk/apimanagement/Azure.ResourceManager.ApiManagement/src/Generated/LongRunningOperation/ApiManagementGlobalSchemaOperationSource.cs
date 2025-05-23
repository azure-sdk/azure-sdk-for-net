// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ApiManagementGlobalSchemaOperationSource : IOperationSource<ApiManagementGlobalSchemaResource>
    {
        private readonly ArmClient _client;

        internal ApiManagementGlobalSchemaOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApiManagementGlobalSchemaResource IOperationSource<ApiManagementGlobalSchemaResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ApiManagementGlobalSchemaData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerApiManagementContext.Default);
            return new ApiManagementGlobalSchemaResource(_client, data);
        }

        async ValueTask<ApiManagementGlobalSchemaResource> IOperationSource<ApiManagementGlobalSchemaResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ApiManagementGlobalSchemaData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerApiManagementContext.Default);
            return await Task.FromResult(new ApiManagementGlobalSchemaResource(_client, data)).ConfigureAwait(false);
        }
    }
}
