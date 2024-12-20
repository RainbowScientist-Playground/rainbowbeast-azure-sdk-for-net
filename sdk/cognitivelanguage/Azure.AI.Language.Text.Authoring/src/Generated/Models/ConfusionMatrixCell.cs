// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents a cell in a confusion matrix. </summary>
    public partial class ConfusionMatrixCell
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

        /// <summary> Initializes a new instance of <see cref="ConfusionMatrixCell"/>. </summary>
        /// <param name="normalizedValue"> Represents normalized value in percentages. </param>
        /// <param name="rawValue"> Represents raw value. </param>
        internal ConfusionMatrixCell(float normalizedValue, float rawValue)
        {
            NormalizedValue = normalizedValue;
            RawValue = rawValue;
        }

        /// <summary> Initializes a new instance of <see cref="ConfusionMatrixCell"/>. </summary>
        /// <param name="normalizedValue"> Represents normalized value in percentages. </param>
        /// <param name="rawValue"> Represents raw value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfusionMatrixCell(float normalizedValue, float rawValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NormalizedValue = normalizedValue;
            RawValue = rawValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConfusionMatrixCell"/> for deserialization. </summary>
        internal ConfusionMatrixCell()
        {
        }

        /// <summary> Represents normalized value in percentages. </summary>
        public float NormalizedValue { get; }
        /// <summary> Represents raw value. </summary>
        public float RawValue { get; }
    }
}
