// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceWorkspaceApiVersionSetResource"/> and their operations.
    /// Each <see cref="ServiceWorkspaceApiVersionSetResource"/> in the collection will belong to the same instance of <see cref="WorkspaceContractResource"/>.
    /// To get a <see cref="ServiceWorkspaceApiVersionSetCollection"/> instance call the GetServiceWorkspaceApiVersionSets method from an instance of <see cref="WorkspaceContractResource"/>.
    /// </summary>
    public partial class ServiceWorkspaceApiVersionSetCollection : ArmCollection, IEnumerable<ServiceWorkspaceApiVersionSetResource>, IAsyncEnumerable<ServiceWorkspaceApiVersionSetResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics;
        private readonly WorkspaceApiVersionSetRestOperations _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiVersionSetCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceApiVersionSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiVersionSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceApiVersionSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceApiVersionSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceApiVersionSetResource.ResourceType, out string serviceWorkspaceApiVersionSetWorkspaceApiVersionSetApiVersion);
            _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient = new WorkspaceApiVersionSetRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceApiVersionSetWorkspaceApiVersionSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceContractResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceContractResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a Api Version Set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceApiVersionSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string versionSetId, ApiVersionSetData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceApiVersionSetResource>(Response.FromValue(new ServiceWorkspaceApiVersionSetResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or Updates a Api Version Set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceApiVersionSetResource> CreateOrUpdate(WaitUntil waitUntil, string versionSetId, ApiVersionSetData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, data, ifMatch, cancellationToken);
                var uri = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceApiVersionSetResource>(Response.FromValue(new ServiceWorkspaceApiVersionSetResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Api Version Set specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceApiVersionSetResource>> GetAsync(string versionSetId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Api Version Set specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual Response<ServiceWorkspaceApiVersionSetResource> Get(string versionSetId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of API Version Sets in the specified workspace with a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceApiVersionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceApiVersionSetResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceApiVersionSetResource(Client, ApiVersionSetData.DeserializeApiVersionSetData(e)), _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics, Pipeline, "ServiceWorkspaceApiVersionSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of API Version Sets in the specified workspace with a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceApiVersionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceApiVersionSetResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceApiVersionSetResource(Client, ApiVersionSetData.DeserializeApiVersionSetData(e)), _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics, Pipeline, "ServiceWorkspaceApiVersionSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionSetId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual Response<bool> Exists(string versionSetId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceWorkspaceApiVersionSetResource>> GetIfExistsAsync(string versionSetId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceApiVersionSetResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual NullableResponse<ServiceWorkspaceApiVersionSetResource> GetIfExists(string versionSetId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionSetId, nameof(versionSetId));

            using var scope = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetClientDiagnostics.CreateScope("ServiceWorkspaceApiVersionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiVersionSetWorkspaceApiVersionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionSetId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceApiVersionSetResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceApiVersionSetResource> IEnumerable<ServiceWorkspaceApiVersionSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceApiVersionSetResource> IAsyncEnumerable<ServiceWorkspaceApiVersionSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
