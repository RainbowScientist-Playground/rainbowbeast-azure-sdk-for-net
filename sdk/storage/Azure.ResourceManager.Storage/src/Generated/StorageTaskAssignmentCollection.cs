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

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageTaskAssignmentResource"/> and their operations.
    /// Each <see cref="StorageTaskAssignmentResource"/> in the collection will belong to the same instance of <see cref="StorageAccountResource"/>.
    /// To get a <see cref="StorageTaskAssignmentCollection"/> instance call the GetStorageTaskAssignments method from an instance of <see cref="StorageAccountResource"/>.
    /// </summary>
    public partial class StorageTaskAssignmentCollection : ArmCollection, IEnumerable<StorageTaskAssignmentResource>, IAsyncEnumerable<StorageTaskAssignmentResource>
    {
        private readonly ClientDiagnostics _storageTaskAssignmentClientDiagnostics;
        private readonly StorageTaskAssignmentsRestOperations _storageTaskAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageTaskAssignmentCollection"/> class for mocking. </summary>
        protected StorageTaskAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageTaskAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageTaskAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageTaskAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", StorageTaskAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageTaskAssignmentResource.ResourceType, out string storageTaskAssignmentApiVersion);
            _storageTaskAssignmentRestClient = new StorageTaskAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageTaskAssignmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates a new storage task assignment sub-resource with the specified parameters. If a storage task assignment is already created and a subsequent create request is issued with different properties, the storage task assignment properties will be updated. If a storage task assignment is already created and a subsequent create or update request is issued with the exact same set of properties, the request will succeed.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="data"> The parameters to create a Storage Task Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageTaskAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageTaskAssignmentName, StorageTaskAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageTaskAssignmentRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<StorageTaskAssignmentResource>(new StorageTaskAssignmentOperationSource(Client), _storageTaskAssignmentClientDiagnostics, Pipeline, _storageTaskAssignmentRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates a new storage task assignment sub-resource with the specified parameters. If a storage task assignment is already created and a subsequent create request is issued with different properties, the storage task assignment properties will be updated. If a storage task assignment is already created and a subsequent create or update request is issued with the exact same set of properties, the request will succeed.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="data"> The parameters to create a Storage Task Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageTaskAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string storageTaskAssignmentName, StorageTaskAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageTaskAssignmentRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, data, cancellationToken);
                var operation = new StorageArmOperation<StorageTaskAssignmentResource>(new StorageTaskAssignmentOperationSource(Client), _storageTaskAssignmentClientDiagnostics, Pipeline, _storageTaskAssignmentRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the storage task assignment properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> is null. </exception>
        public virtual async Task<Response<StorageTaskAssignmentResource>> GetAsync(string storageTaskAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageTaskAssignmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageTaskAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the storage task assignment properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> is null. </exception>
        public virtual Response<StorageTaskAssignmentResource> Get(string storageTaskAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _storageTaskAssignmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageTaskAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the storage task assignments in an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of storage task assignment Ids to be included in the list response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageTaskAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageTaskAssignmentResource> GetAllAsync(int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageTaskAssignmentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageTaskAssignmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageTaskAssignmentResource(Client, StorageTaskAssignmentData.DeserializeStorageTaskAssignmentData(e)), _storageTaskAssignmentClientDiagnostics, Pipeline, "StorageTaskAssignmentCollection.GetAll", "value", "nextLink", maxpagesize, cancellationToken);
        }

        /// <summary>
        /// List all the storage task assignments in an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of storage task assignment Ids to be included in the list response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageTaskAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageTaskAssignmentResource> GetAll(int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageTaskAssignmentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageTaskAssignmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageTaskAssignmentResource(Client, StorageTaskAssignmentData.DeserializeStorageTaskAssignmentData(e)), _storageTaskAssignmentClientDiagnostics, Pipeline, "StorageTaskAssignmentCollection.GetAll", "value", "nextLink", maxpagesize, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageTaskAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageTaskAssignmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageTaskAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageTaskAssignmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageTaskAssignmentResource>> GetIfExistsAsync(string storageTaskAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageTaskAssignmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageTaskAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new StorageTaskAssignmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/storageTaskAssignments/{storageTaskAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTaskAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageTaskAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskAssignmentName"/> is null. </exception>
        public virtual NullableResponse<StorageTaskAssignmentResource> GetIfExists(string storageTaskAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var scope = _storageTaskAssignmentClientDiagnostics.CreateScope("StorageTaskAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageTaskAssignmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTaskAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageTaskAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new StorageTaskAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageTaskAssignmentResource> IEnumerable<StorageTaskAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageTaskAssignmentResource> IAsyncEnumerable<StorageTaskAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
