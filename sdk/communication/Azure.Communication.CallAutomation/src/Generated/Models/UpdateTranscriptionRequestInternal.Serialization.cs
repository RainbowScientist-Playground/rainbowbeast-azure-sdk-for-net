// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class UpdateTranscriptionRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("locale"u8);
            writer.WriteStringValue(Locale);
            if (Optional.IsDefined(SpeechRecognitionModelEndpointId))
            {
                writer.WritePropertyName("speechRecognitionModelEndpointId"u8);
                writer.WriteStringValue(SpeechRecognitionModelEndpointId);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(OperationCallbackUri))
            {
                writer.WritePropertyName("operationCallbackUri"u8);
                writer.WriteStringValue(OperationCallbackUri);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
