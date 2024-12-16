// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Naming", "AZC0031:Model name 'PrincipalDefinition' ends with 'Definition'. Suggest to rename it to an appropriate name.", Justification = "...")]
namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> PrincipalDefinition properties of Rule. </summary>
    public partial class PrincipalDefinition
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

        /// <summary> Initializes a new instance of <see cref="PrincipalDefinition"/>. </summary>
        public PrincipalDefinition()
        {
            Attributes = new ChangeTrackingList<IDictionary<string, string>>();
            ClientIds = new ChangeTrackingList<string>();
            Usernames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PrincipalDefinition"/>. </summary>
        /// <param name="attributes"> A list of key-value pairs that match the attributes of the clients. The attributes are case-sensitive and must match the attributes provided by the clients during authentication. </param>
        /// <param name="clientIds"> A list of client IDs that match the clients. The client IDs are case-sensitive and must match the client IDs provided by the clients during connection. </param>
        /// <param name="usernames"> A list of usernames that match the clients. The usernames are case-sensitive and must match the usernames provided by the clients during authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrincipalDefinition(IList<IDictionary<string, string>> attributes, IList<string> clientIds, IList<string> usernames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Attributes = attributes;
            ClientIds = clientIds;
            Usernames = usernames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of key-value pairs that match the attributes of the clients. The attributes are case-sensitive and must match the attributes provided by the clients during authentication. </summary>
        public IList<IDictionary<string, string>> Attributes { get; }
        /// <summary> A list of client IDs that match the clients. The client IDs are case-sensitive and must match the client IDs provided by the clients during connection. </summary>
        public IList<string> ClientIds { get; }
        /// <summary> A list of usernames that match the clients. The usernames are case-sensitive and must match the usernames provided by the clients during authentication. </summary>
        public IList<string> Usernames { get; }
    }
}
