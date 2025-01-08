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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkGatewayConnectionResource"/> and their operations.
    /// Each <see cref="VirtualNetworkGatewayConnectionResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VirtualNetworkGatewayConnectionCollection"/> instance call the GetVirtualNetworkGatewayConnections method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VirtualNetworkGatewayConnectionCollection : ArmCollection, IEnumerable<VirtualNetworkGatewayConnectionResource>, IAsyncEnumerable<VirtualNetworkGatewayConnectionResource>
    {
        private readonly ClientDiagnostics _virtualNetworkGatewayConnectionClientDiagnostics;
        private readonly VirtualNetworkGatewayConnectionsRestOperations _virtualNetworkGatewayConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionCollection"/> class for mocking. </summary>
        protected VirtualNetworkGatewayConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkGatewayConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkGatewayConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkGatewayConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkGatewayConnectionResource.ResourceType, out string virtualNetworkGatewayConnectionApiVersion);
            _virtualNetworkGatewayConnectionRestClient = new VirtualNetworkGatewayConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkGatewayConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a virtual network gateway connection in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkGatewayConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualNetworkGatewayConnectionResource>(new VirtualNetworkGatewayConnectionOperationSource(Client), _virtualNetworkGatewayConnectionClientDiagnostics, Pipeline, _virtualNetworkGatewayConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a virtual network gateway connection in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkGatewayConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualNetworkGatewayConnectionResource>(new VirtualNetworkGatewayConnectionOperationSource(Client), _virtualNetworkGatewayConnectionClientDiagnostics, Pipeline, _virtualNetworkGatewayConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified virtual network gateway connection by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkGatewayConnectionResource>> GetAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified virtual network gateway connection by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayConnectionResource> Get(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List VirtualNetworkGatewayConnections operation retrieves all the virtual network gateways connections created.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGatewayConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkGatewayConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkGatewayConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkGatewayConnectionResource(Client, VirtualNetworkGatewayConnectionData.DeserializeVirtualNetworkGatewayConnectionData(e)), _virtualNetworkGatewayConnectionClientDiagnostics, Pipeline, "VirtualNetworkGatewayConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List VirtualNetworkGatewayConnections operation retrieves all the virtual network gateways connections created.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGatewayConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkGatewayConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkGatewayConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkGatewayConnectionResource(Client, VirtualNetworkGatewayConnectionData.DeserializeVirtualNetworkGatewayConnectionData(e)), _virtualNetworkGatewayConnectionClientDiagnostics, Pipeline, "VirtualNetworkGatewayConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualNetworkGatewayConnectionResource>> GetIfExistsAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkGatewayConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/connections/{virtualNetworkGatewayConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGatewayConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualNetworkGatewayConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual NullableResponse<VirtualNetworkGatewayConnectionResource> GetIfExists(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _virtualNetworkGatewayConnectionClientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkGatewayConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkGatewayConnectionResource> IEnumerable<VirtualNetworkGatewayConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkGatewayConnectionResource> IAsyncEnumerable<VirtualNetworkGatewayConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
