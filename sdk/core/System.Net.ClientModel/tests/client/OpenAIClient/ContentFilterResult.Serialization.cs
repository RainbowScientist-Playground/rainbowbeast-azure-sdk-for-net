// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel.Core;
using System.Text.Json;
namespace OpenAI;

public partial class ContentFilterResult
    {
        internal static ContentFilterResult DeserializeContentFilterResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContentFilterSeverity severity = default;
            bool filtered = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"u8))
                {
                    severity = new ContentFilterSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filtered"u8))
                {
                    filtered = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ContentFilterResult(severity, filtered);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ContentFilterResult FromResponse(MessageResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeContentFilterResult(document.RootElement);
        }
    }

