// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Destination replication properties. </summary>
    public partial class NetAppDestinationReplication
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppDestinationReplication"/>. </summary>
        internal NetAppDestinationReplication()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppDestinationReplication"/>. </summary>
        /// <param name="resourceId"> The resource ID of the remote volume. </param>
        /// <param name="replicationType"> Indicates whether the replication is cross zone or cross region. </param>
        /// <param name="region"> The remote region for the destination volume. </param>
        /// <param name="zone"> The remote zone for the destination volume. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppDestinationReplication(ResourceIdentifier resourceId, NetAppReplicationType? replicationType, string region, string zone, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            ReplicationType = replicationType;
            Region = region;
            Zone = zone;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the remote volume. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Indicates whether the replication is cross zone or cross region. </summary>
        public NetAppReplicationType? ReplicationType { get; }
        /// <summary> The remote region for the destination volume. </summary>
        public string Region { get; }
        /// <summary> The remote zone for the destination volume. </summary>
        public string Zone { get; }
    }
}
