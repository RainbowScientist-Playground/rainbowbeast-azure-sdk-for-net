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
    /// A class representing a collection of <see cref="AzureFirewallResource"/> and their operations.
    /// Each <see cref="AzureFirewallResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AzureFirewallCollection"/> instance call the GetAzureFirewalls method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AzureFirewallCollection : ArmCollection, IEnumerable<AzureFirewallResource>, IAsyncEnumerable<AzureFirewallResource>
    {
        private readonly ClientDiagnostics _azureFirewallClientDiagnostics;
        private readonly AzureFirewallsRestOperations _azureFirewallRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallCollection"/> class for mocking. </summary>
        protected AzureFirewallCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureFirewallCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureFirewallClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", AzureFirewallResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureFirewallResource.ResourceType, out string azureFirewallApiVersion);
            _azureFirewallRestClient = new AzureFirewallsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureFirewallApiVersion);
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
        /// Creates or updates the specified Azure Firewall.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="data"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AzureFirewallResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string azureFirewallName, AzureFirewallData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<AzureFirewallResource>(new AzureFirewallOperationSource(Client), _azureFirewallClientDiagnostics, Pipeline, _azureFirewallRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the specified Azure Firewall.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="data"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AzureFirewallResource> CreateOrUpdate(WaitUntil waitUntil, string azureFirewallName, AzureFirewallData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, data, cancellationToken);
                var operation = new NetworkArmOperation<AzureFirewallResource>(new AzureFirewallOperationSource(Client), _azureFirewallClientDiagnostics, Pipeline, _azureFirewallRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified Azure Firewall.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual async Task<Response<AzureFirewallResource>> GetAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureFirewallResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Firewall.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<AzureFirewallResource> Get(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureFirewallResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Azure Firewalls in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureFirewallResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureFirewallResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureFirewallRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureFirewallRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AzureFirewallResource(Client, AzureFirewallData.DeserializeAzureFirewallData(e)), _azureFirewallClientDiagnostics, Pipeline, "AzureFirewallCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Azure Firewalls in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureFirewallResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureFirewallResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureFirewallRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureFirewallRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AzureFirewallResource(Client, AzureFirewallData.DeserializeAzureFirewallData(e)), _azureFirewallClientDiagnostics, Pipeline, "AzureFirewallCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<bool> Exists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual async Task<NullableResponse<AzureFirewallResource>> GetIfExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AzureFirewallResource>(response.GetRawResponse());
                return Response.FromValue(new AzureFirewallResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureFirewalls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureFirewallResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual NullableResponse<AzureFirewallResource> GetIfExists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AzureFirewallResource>(response.GetRawResponse());
                return Response.FromValue(new AzureFirewallResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureFirewallResource> IEnumerable<AzureFirewallResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureFirewallResource> IAsyncEnumerable<AzureFirewallResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
