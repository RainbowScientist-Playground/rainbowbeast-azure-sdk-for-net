// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of PacketCapture and their operations over its parent. </summary>
    public partial class PacketCaptureCollection : ArmCollection, IEnumerable<PacketCapture>, IAsyncEnumerable<PacketCapture>
    {
        private readonly ClientDiagnostics _packetCaptureClientDiagnostics;
        private readonly PacketCapturesRestOperations _packetCaptureRestClient;

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureCollection"/> class for mocking. </summary>
        protected PacketCaptureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PacketCaptureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _packetCaptureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PacketCapture.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(PacketCapture.ResourceType, out string packetCaptureApiVersion);
            _packetCaptureRestClient = new PacketCapturesRestOperations(_packetCaptureClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, packetCaptureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkWatcher.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkWatcher.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create and start a packet capture on the specified VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<PacketCapture>> CreateOrUpdateAsync(bool waitForCompletion, string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _packetCaptureRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PacketCapture>(new PacketCaptureOperationSource(Client), _packetCaptureClientDiagnostics, Pipeline, _packetCaptureRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
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
        /// Create and start a packet capture on the specified VM.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<PacketCapture> CreateOrUpdate(bool waitForCompletion, string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _packetCaptureRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<PacketCapture>(new PacketCaptureOperationSource(Client), _packetCaptureClientDiagnostics, Pipeline, _packetCaptureRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
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
        /// Gets a packet capture session by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Get
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public async virtual Task<Response<PacketCapture>> GetAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Get");
            scope.Start();
            try
            {
                var response = await _packetCaptureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _packetCaptureClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PacketCapture(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a packet capture session by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Get
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<PacketCapture> Get(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Get");
            scope.Start();
            try
            {
                var response = _packetCaptureRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken);
                if (response.Value == null)
                    throw _packetCaptureClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCapture(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all packet capture sessions within the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures
        /// Operation Id: PacketCaptures_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCapture" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PacketCapture> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PacketCapture>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _packetCaptureRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PacketCapture(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all packet capture sessions within the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures
        /// Operation Id: PacketCaptures_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCapture" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PacketCapture> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PacketCapture> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _packetCaptureRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PacketCapture(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Get
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Get
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<bool> Exists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(packetCaptureName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Get
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public async virtual Task<Response<PacketCapture>> GetIfExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _packetCaptureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PacketCapture>(null, response.GetRawResponse());
                return Response.FromValue(new PacketCapture(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/packetCaptures/{packetCaptureName}
        /// Operation Id: PacketCaptures_Get
        /// </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCaptureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> is null. </exception>
        public virtual Response<PacketCapture> GetIfExists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packetCaptureName, nameof(packetCaptureName));

            using var scope = _packetCaptureClientDiagnostics.CreateScope("PacketCaptureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _packetCaptureRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PacketCapture>(null, response.GetRawResponse());
                return Response.FromValue(new PacketCapture(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PacketCapture> IEnumerable<PacketCapture>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PacketCapture> IAsyncEnumerable<PacketCapture>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
