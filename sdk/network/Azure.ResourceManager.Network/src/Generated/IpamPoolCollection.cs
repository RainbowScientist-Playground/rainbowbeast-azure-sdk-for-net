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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="IpamPoolResource"/> and their operations.
    /// Each <see cref="IpamPoolResource"/> in the collection will belong to the same instance of <see cref="NetworkManagerResource"/>.
    /// To get an <see cref="IpamPoolCollection"/> instance call the GetIpamPools method from an instance of <see cref="NetworkManagerResource"/>.
    /// </summary>
    public partial class IpamPoolCollection : ArmCollection, IEnumerable<IpamPoolResource>, IAsyncEnumerable<IpamPoolResource>
    {
        private readonly ClientDiagnostics _ipamPoolClientDiagnostics;
        private readonly IpamPoolsRestOperations _ipamPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="IpamPoolCollection"/> class for mocking. </summary>
        protected IpamPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IpamPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IpamPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ipamPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", IpamPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IpamPoolResource.ResourceType, out string ipamPoolApiVersion);
            _ipamPoolRestClient = new IpamPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ipamPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkManagerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkManagerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates/Updates the Pool resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> IP Address Manager Pool resource name. </param>
        /// <param name="data"> Pool resource object to create/update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IpamPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string poolName, IpamPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipamPoolRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<IpamPoolResource>(new IpamPoolOperationSource(Client), _ipamPoolClientDiagnostics, Pipeline, _ipamPoolRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates/Updates the Pool resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> IP Address Manager Pool resource name. </param>
        /// <param name="data"> Pool resource object to create/update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IpamPoolResource> CreateOrUpdate(WaitUntil waitUntil, string poolName, IpamPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipamPoolRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken);
                var operation = new NetworkArmOperation<IpamPoolResource>(new IpamPoolOperationSource(Client), _ipamPoolClientDiagnostics, Pipeline, _ipamPoolRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specific Pool resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Pool resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<IpamPoolResource>> GetAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipamPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IpamPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific Pool resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Pool resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<IpamPoolResource> Get(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _ipamPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IpamPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets list of Pool resources at Network Manager level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Optional skip token. </param>
        /// <param name="skip"> Optional num entries to skip. </param>
        /// <param name="top"> Optional num entries to show. </param>
        /// <param name="sortKey"> Optional key by which to sort. </param>
        /// <param name="sortValue"> Optional sort value for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IpamPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IpamPoolResource> GetAllAsync(string skipToken = null, int? skip = null, int? top = null, string sortKey = null, string sortValue = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ipamPoolRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, skip, top, sortKey, sortValue);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ipamPoolRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, skip, top, sortKey, sortValue);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IpamPoolResource(Client, IpamPoolData.DeserializeIpamPoolData(e)), _ipamPoolClientDiagnostics, Pipeline, "IpamPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets list of Pool resources at Network Manager level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Optional skip token. </param>
        /// <param name="skip"> Optional num entries to skip. </param>
        /// <param name="top"> Optional num entries to show. </param>
        /// <param name="sortKey"> Optional key by which to sort. </param>
        /// <param name="sortValue"> Optional sort value for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IpamPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IpamPoolResource> GetAll(string skipToken = null, int? skip = null, int? top = null, string sortKey = null, string sortValue = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ipamPoolRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, skip, top, sortKey, sortValue);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ipamPoolRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, skip, top, sortKey, sortValue);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IpamPoolResource(Client, IpamPoolData.DeserializeIpamPoolData(e)), _ipamPoolClientDiagnostics, Pipeline, "IpamPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Pool resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ipamPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Pool resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<bool> Exists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _ipamPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Pool resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<NullableResponse<IpamPoolResource>> GetIfExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ipamPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IpamPoolResource>(response.GetRawResponse());
                return Response.FromValue(new IpamPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/ipamPools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpamPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IpamPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Pool resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual NullableResponse<IpamPoolResource> GetIfExists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _ipamPoolClientDiagnostics.CreateScope("IpamPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ipamPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IpamPoolResource>(response.GetRawResponse());
                return Response.FromValue(new IpamPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IpamPoolResource> IEnumerable<IpamPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IpamPoolResource> IAsyncEnumerable<IpamPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
