// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
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
    /// <summary> A Class representing a FlowLog along with the instance operations that can be performed on it. </summary>
    public partial class FlowLog : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FlowLog"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkWatcherName, string flowLogName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _flowLogClientDiagnostics;
        private readonly FlowLogsRestOperations _flowLogRestClient;
        private readonly FlowLogData _data;

        /// <summary> Initializes a new instance of the <see cref="FlowLog"/> class for mocking. </summary>
        protected FlowLog()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FlowLog"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FlowLog(ArmClient client, FlowLogData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FlowLog"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FlowLog(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _flowLogClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string flowLogApiVersion);
            _flowLogRestClient = new FlowLogsRestOperations(_flowLogClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, flowLogApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkWatchers/flowLogs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FlowLogData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a flow log resource by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<FlowLog>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLog.Get");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _flowLogClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a flow log resource by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FlowLog> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLog.Get");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _flowLogClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified flow log resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLog.Delete");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_flowLogClientDiagnostics, Pipeline, _flowLogRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified flow log resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLog.Delete");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_flowLogClientDiagnostics, Pipeline, _flowLogRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update tags of the specified flow log.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_UpdateTags
        /// </summary>
        /// <param name="parameters"> Parameters supplied to update flow log tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<FlowLog>> UpdateAsync(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLog.Update");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update tags of the specified flow log.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
        /// Operation Id: FlowLogs_UpdateTags
        /// </summary>
        /// <param name="parameters"> Parameters supplied to update flow log tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<FlowLog> Update(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLog.Update");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new FlowLog(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
