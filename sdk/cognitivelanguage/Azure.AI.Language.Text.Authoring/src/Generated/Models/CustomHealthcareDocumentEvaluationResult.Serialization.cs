// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring.Models
{
    public partial class CustomHealthcareDocumentEvaluationResult : IUtf8JsonSerializable, IJsonModel<CustomHealthcareDocumentEvaluationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomHealthcareDocumentEvaluationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomHealthcareDocumentEvaluationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHealthcareDocumentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHealthcareDocumentEvaluationResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("customHealthcareResult"u8);
            writer.WriteObjectValue(CustomHealthcareResult, options);
        }

        CustomHealthcareDocumentEvaluationResult IJsonModel<CustomHealthcareDocumentEvaluationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHealthcareDocumentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHealthcareDocumentEvaluationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomHealthcareDocumentEvaluationResult(document.RootElement, options);
        }

        internal static CustomHealthcareDocumentEvaluationResult DeserializeCustomHealthcareDocumentEvaluationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentHealthcareEvaluationResult customHealthcareResult = default;
            ProjectKind projectKind = default;
            string location = default;
            string language = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customHealthcareResult"u8))
                {
                    customHealthcareResult = DocumentHealthcareEvaluationResult.DeserializeDocumentHealthcareEvaluationResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new ProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomHealthcareDocumentEvaluationResult(projectKind, location, language, serializedAdditionalRawData, customHealthcareResult);
        }

        BinaryData IPersistableModel<CustomHealthcareDocumentEvaluationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHealthcareDocumentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomHealthcareDocumentEvaluationResult)} does not support writing '{options.Format}' format.");
            }
        }

        CustomHealthcareDocumentEvaluationResult IPersistableModel<CustomHealthcareDocumentEvaluationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHealthcareDocumentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomHealthcareDocumentEvaluationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomHealthcareDocumentEvaluationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomHealthcareDocumentEvaluationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new CustomHealthcareDocumentEvaluationResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomHealthcareDocumentEvaluationResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
