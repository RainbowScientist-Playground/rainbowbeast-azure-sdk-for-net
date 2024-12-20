// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Representation of basic resource information. </summary>
    public partial class IpamResourceBasics
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

        /// <summary> Initializes a new instance of <see cref="IpamResourceBasics"/>. </summary>
        internal IpamResourceBasics()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IpamResourceBasics"/>. </summary>
        /// <param name="resourceId"> ResourceId of the Azure resource. </param>
        /// <param name="addressPrefixes"> List of IP address prefixes of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IpamResourceBasics(ResourceIdentifier resourceId, IReadOnlyList<string> addressPrefixes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            AddressPrefixes = addressPrefixes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ResourceId of the Azure resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> List of IP address prefixes of the resource. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
    }
}
