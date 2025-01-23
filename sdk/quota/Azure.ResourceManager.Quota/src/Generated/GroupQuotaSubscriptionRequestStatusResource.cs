// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a GroupQuotaSubscriptionRequestStatus along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GroupQuotaSubscriptionRequestStatusResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGroupQuotaSubscriptionRequestStatusResource method.
    /// Otherwise you can get one from its parent resource <see cref="GroupQuotaEntityResource"/> using the GetGroupQuotaSubscriptionRequestStatus method.
    /// </summary>
    public partial class GroupQuotaSubscriptionRequestStatusResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GroupQuotaSubscriptionRequestStatusResource"/> instance. </summary>
        /// <param name="managementGroupId"> The managementGroupId. </param>
        /// <param name="groupQuotaName"> The groupQuotaName. </param>
        /// <param name="requestId"> The requestId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string groupQuotaName, string requestId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptionRequests/{requestId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsClientDiagnostics;
        private readonly GroupQuotaSubscriptionRequestsRestOperations _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsRestClient;
        private readonly GroupQuotaSubscriptionRequestStatusData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/groupQuotas/subscriptionRequests";

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaSubscriptionRequestStatusResource"/> class for mocking. </summary>
        protected GroupQuotaSubscriptionRequestStatusResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaSubscriptionRequestStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GroupQuotaSubscriptionRequestStatusResource(ArmClient client, GroupQuotaSubscriptionRequestStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaSubscriptionRequestStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GroupQuotaSubscriptionRequestStatusResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsApiVersion);
            _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsRestClient = new GroupQuotaSubscriptionRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GroupQuotaSubscriptionRequestStatusData Data
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
        /// Get API to check the status of a subscriptionIds request by requestId.  Use the polling API - OperationsStatus URI specified in Azure-AsyncOperation header field, with retry-after duration in seconds to check the intermediate status. This API provides the finals status with the request details and status.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptionRequests/{requestId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GroupQuotaSubscriptionRequestStatusResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsClientDiagnostics.CreateScope("GroupQuotaSubscriptionRequestStatusResource.Get");
            scope.Start();
            try
            {
                var response = await _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsRestClient.GetAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaSubscriptionRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get API to check the status of a subscriptionIds request by requestId.  Use the polling API - OperationsStatus URI specified in Azure-AsyncOperation header field, with retry-after duration in seconds to check the intermediate status. This API provides the finals status with the request details and status.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptionRequests/{requestId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GroupQuotaSubscriptionRequestStatusResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsClientDiagnostics.CreateScope("GroupQuotaSubscriptionRequestStatusResource.Get");
            scope.Start();
            try
            {
                var response = _groupQuotaSubscriptionRequestStatusGroupQuotaSubscriptionRequestsRestClient.Get(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaSubscriptionRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
