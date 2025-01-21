// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentPropertiesExtended : IUtf8JsonSerializable, IJsonModel<ArmDeploymentPropertiesExtended>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentPropertiesExtended>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmDeploymentPropertiesExtended>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentPropertiesExtended>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentPropertiesExtended)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (options.Format != "W" && Optional.IsDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Outputs);
#else
                using (JsonDocument document = JsonDocument.Parse(Outputs))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Providers))
            {
                writer.WritePropertyName("providers"u8);
                writer.WriteStartArray();
                foreach (var item in Providers)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Dependencies))
            {
                writer.WritePropertyName("dependencies"u8);
                writer.WriteStartArray();
                foreach (var item in Dependencies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TemplateLink))
            {
                writer.WritePropertyName("templateLink"u8);
                writer.WriteObjectValue(TemplateLink, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(ParametersLink))
            {
                writer.WritePropertyName("parametersLink"u8);
                writer.WriteObjectValue(ParametersLink, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DebugSetting))
            {
                writer.WritePropertyName("debugSetting"u8);
                writer.WriteObjectValue(DebugSetting, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorDeployment))
            {
                writer.WritePropertyName("onErrorDeployment"u8);
                writer.WriteObjectValue(ErrorDeployment, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TemplateHash))
            {
                writer.WritePropertyName("templateHash"u8);
                writer.WriteStringValue(TemplateHash);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(OutputResources))
            {
                writer.WritePropertyName("outputResources"u8);
                writer.WriteStartArray();
                foreach (var item in OutputResources)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ValidatedResources))
            {
                writer.WritePropertyName("validatedResources"u8);
                writer.WriteStartArray();
                foreach (var item in ValidatedResources)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteStartArray();
                foreach (var item in Diagnostics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ArmDeploymentPropertiesExtended IJsonModel<ArmDeploymentPropertiesExtended>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentPropertiesExtended>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentPropertiesExtended)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentPropertiesExtended(document.RootElement, options);
        }

        internal static ArmDeploymentPropertiesExtended DeserializeArmDeploymentPropertiesExtended(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourcesProvisioningState? provisioningState = default;
            string correlationId = default;
            DateTimeOffset? timestamp = default;
            TimeSpan? duration = default;
            BinaryData outputs = default;
            IReadOnlyList<ResourceProviderData> providers = default;
            IReadOnlyList<ArmDependency> dependencies = default;
            ArmDeploymentTemplateLink templateLink = default;
            BinaryData parameters = default;
            ArmDeploymentParametersLink parametersLink = default;
            ArmDeploymentMode? mode = default;
            DebugSetting debugSetting = default;
            ErrorDeploymentExtended onErrorDeployment = default;
            string templateHash = default;
            IReadOnlyList<SubResource> outputResources = default;
            IReadOnlyList<SubResource> validatedResources = default;
            ResponseError error = default;
            IReadOnlyList<DeploymentDiagnosticsDefinition> diagnostics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ResourcesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputs = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("providers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderData> array = new List<ResourceProviderData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResourceProviderData>(item.GetRawText()));
                    }
                    providers = array;
                    continue;
                }
                if (property.NameEquals("dependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ArmDependency> array = new List<ArmDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArmDependency.DeserializeArmDependency(item, options));
                    }
                    dependencies = array;
                    continue;
                }
                if (property.NameEquals("templateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateLink = ArmDeploymentTemplateLink.DeserializeArmDeploymentTemplateLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parametersLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parametersLink = ArmDeploymentParametersLink.DeserializeArmDeploymentParametersLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = property.Value.GetString().ToArmDeploymentMode();
                    continue;
                }
                if (property.NameEquals("debugSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSetting = DebugSetting.DeserializeDebugSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("onErrorDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onErrorDeployment = ErrorDeploymentExtended.DeserializeErrorDeploymentExtended(property.Value, options);
                    continue;
                }
                if (property.NameEquals("templateHash"u8))
                {
                    templateHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    outputResources = array;
                    continue;
                }
                if (property.NameEquals("validatedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    validatedResources = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeploymentDiagnosticsDefinition> array = new List<DeploymentDiagnosticsDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeploymentDiagnosticsDefinition.DeserializeDeploymentDiagnosticsDefinition(item, options));
                    }
                    diagnostics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmDeploymentPropertiesExtended(
                provisioningState,
                correlationId,
                timestamp,
                duration,
                outputs,
                providers ?? new ChangeTrackingList<ResourceProviderData>(),
                dependencies ?? new ChangeTrackingList<ArmDependency>(),
                templateLink,
                parameters,
                parametersLink,
                mode,
                debugSetting,
                onErrorDeployment,
                templateHash,
                outputResources ?? new ChangeTrackingList<SubResource>(),
                validatedResources ?? new ChangeTrackingList<SubResource>(),
                error,
                diagnostics ?? new ChangeTrackingList<DeploymentDiagnosticsDefinition>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CorrelationId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  correlationId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CorrelationId))
                {
                    builder.Append("  correlationId: ");
                    if (CorrelationId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CorrelationId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CorrelationId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timestamp))
                {
                    builder.Append("  timestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(Timestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Duration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  duration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Duration))
                {
                    builder.Append("  duration: ");
                    var formattedTimeSpan = TypeFormatters.ToString(Duration.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Outputs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outputs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Outputs))
                {
                    builder.Append("  outputs: ");
                    builder.AppendLine($"'{Outputs.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Providers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  providers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Providers))
                {
                    if (Providers.Any())
                    {
                        builder.Append("  providers: ");
                        builder.AppendLine("[");
                        foreach (var item in Providers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  providers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Dependencies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dependencies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Dependencies))
                {
                    if (Dependencies.Any())
                    {
                        builder.Append("  dependencies: ");
                        builder.AppendLine("[");
                        foreach (var item in Dependencies)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  dependencies: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TemplateLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  templateLink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TemplateLink))
                {
                    builder.Append("  templateLink: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TemplateLink, options, 2, false, "  templateLink: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  parameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Parameters))
                {
                    builder.Append("  parameters: ");
                    builder.AppendLine($"'{Parameters.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ParametersLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  parametersLink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ParametersLink))
                {
                    builder.Append("  parametersLink: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ParametersLink, options, 2, false, "  parametersLink: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Mode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  mode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Mode))
                {
                    builder.Append("  mode: ");
                    builder.AppendLine($"'{Mode.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DebugSettingDetailLevel", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  debugSetting: ");
                builder.AppendLine("{");
                builder.Append("    detailLevel: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(DebugSetting))
                {
                    builder.Append("  debugSetting: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DebugSetting, options, 2, false, "  debugSetting: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorDeployment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  onErrorDeployment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ErrorDeployment))
                {
                    builder.Append("  onErrorDeployment: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ErrorDeployment, options, 2, false, "  onErrorDeployment: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TemplateHash), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  templateHash: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TemplateHash))
                {
                    builder.Append("  templateHash: ");
                    if (TemplateHash.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TemplateHash}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TemplateHash}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutputResources), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outputResources: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(OutputResources))
                {
                    if (OutputResources.Any())
                    {
                        builder.Append("  outputResources: ");
                        builder.AppendLine("[");
                        foreach (var item in OutputResources)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  outputResources: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidatedResources), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validatedResources: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ValidatedResources))
                {
                    if (ValidatedResources.Any())
                    {
                        builder.Append("  validatedResources: ");
                        builder.AppendLine("[");
                        foreach (var item in ValidatedResources)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  validatedResources: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Error), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  error: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Error))
                {
                    builder.Append("  error: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Error, options, 2, false, "  error: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Diagnostics), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  diagnostics: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Diagnostics))
                {
                    if (Diagnostics.Any())
                    {
                        builder.Append("  diagnostics: ");
                        builder.AppendLine("[");
                        foreach (var item in Diagnostics)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  diagnostics: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ArmDeploymentPropertiesExtended>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentPropertiesExtended>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentPropertiesExtended)} does not support writing '{options.Format}' format.");
            }
        }

        ArmDeploymentPropertiesExtended IPersistableModel<ArmDeploymentPropertiesExtended>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentPropertiesExtended>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmDeploymentPropertiesExtended(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentPropertiesExtended)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmDeploymentPropertiesExtended>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
