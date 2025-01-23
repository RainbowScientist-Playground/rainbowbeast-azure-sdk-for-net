// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary></summary>
    public partial class ManagedServiceIdentity : IJsonModel<ManagedServiceIdentity>
    {
        internal ManagedServiceIdentity()
        {
        }

        void IJsonModel<ManagedServiceIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ManagedServiceIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceIdentity)} does not support writing '{format}' format.");
            }
            if (options.Format != "W" && Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
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

        ManagedServiceIdentity IJsonModel<ManagedServiceIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ManagedServiceIdentity JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ManagedServiceIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceIdentity)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServiceIdentity(document.RootElement, options);
        }

        internal static ManagedServiceIdentity DeserializeManagedServiceIdentity(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? principalId = default;
            Guid? tenantId = default;
            ManagedServiceIdentityType @type = default;
            IDictionary<string, UserAssignedIdentity> userAssignedIdentities = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("principalId"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = new Guid(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("tenantId"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = new Guid(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    @type = new ManagedServiceIdentityType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("userAssignedIdentities"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, UserAssignedIdentity> dictionary = new Dictionary<string, UserAssignedIdentity>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        dictionary.Add(prop0.Name, UserAssignedIdentity.DeserializeUserAssignedIdentity(prop0.Value, options));
                    }
                    userAssignedIdentities = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ManagedServiceIdentity(principalId, tenantId, @type, userAssignedIdentities ?? new ChangeTrackingDictionary<string, UserAssignedIdentity>(), additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ManagedServiceIdentity>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ManagedServiceIdentity>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceIdentity)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedServiceIdentity IPersistableModel<ManagedServiceIdentity>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ManagedServiceIdentity PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ManagedServiceIdentity>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeManagedServiceIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceIdentity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServiceIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="managedServiceIdentity"> The <see cref="ManagedServiceIdentity"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(ManagedServiceIdentity managedServiceIdentity)
        {
            if (managedServiceIdentity == null)
            {
                return null;
            }
            Utf8JsonBinaryContent content = new Utf8JsonBinaryContent();
            content.JsonWriter.WriteObjectValue(managedServiceIdentity, ModelSerializationExtensions.WireOptions);
            return content;
        }

        /// <param name="result"> The <see cref="Response"/> to deserialize the <see cref="ManagedServiceIdentity"/> from. </param>
        public static explicit operator ManagedServiceIdentity(Response result)
        {
            using Response response = result;
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeManagedServiceIdentity(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
