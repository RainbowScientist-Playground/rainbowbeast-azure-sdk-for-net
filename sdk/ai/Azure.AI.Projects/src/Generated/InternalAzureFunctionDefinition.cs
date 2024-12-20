// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> The definition of Azure function. </summary>
    internal partial class InternalAzureFunctionDefinition
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

        /// <summary> Initializes a new instance of <see cref="InternalAzureFunctionDefinition"/>. </summary>
        /// <param name="function"> The definition of azure function and its parameters. </param>
        /// <param name="inputBinding"> Input storage queue. The queue storage trigger runs a function as messages are added to it. </param>
        /// <param name="outputBinding"> Output storage queue. The function writes output to this queue when the input items are processed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="function"/>, <paramref name="inputBinding"/> or <paramref name="outputBinding"/> is null. </exception>
        public InternalAzureFunctionDefinition(InternalFunctionDefinition function, AzureFunctionBinding inputBinding, AzureFunctionBinding outputBinding)
        {
            Argument.AssertNotNull(function, nameof(function));
            Argument.AssertNotNull(inputBinding, nameof(inputBinding));
            Argument.AssertNotNull(outputBinding, nameof(outputBinding));

            Function = function;
            InputBinding = inputBinding;
            OutputBinding = outputBinding;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureFunctionDefinition"/>. </summary>
        /// <param name="function"> The definition of azure function and its parameters. </param>
        /// <param name="inputBinding"> Input storage queue. The queue storage trigger runs a function as messages are added to it. </param>
        /// <param name="outputBinding"> Output storage queue. The function writes output to this queue when the input items are processed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalAzureFunctionDefinition(InternalFunctionDefinition function, AzureFunctionBinding inputBinding, AzureFunctionBinding outputBinding, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Function = function;
            InputBinding = inputBinding;
            OutputBinding = outputBinding;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureFunctionDefinition"/> for deserialization. </summary>
        internal InternalAzureFunctionDefinition()
        {
        }

        /// <summary> The definition of azure function and its parameters. </summary>
        public InternalFunctionDefinition Function { get; set; }
        /// <summary> Input storage queue. The queue storage trigger runs a function as messages are added to it. </summary>
        public AzureFunctionBinding InputBinding { get; set; }
        /// <summary> Output storage queue. The function writes output to this queue when the input items are processed. </summary>
        public AzureFunctionBinding OutputBinding { get; set; }
    }
}
