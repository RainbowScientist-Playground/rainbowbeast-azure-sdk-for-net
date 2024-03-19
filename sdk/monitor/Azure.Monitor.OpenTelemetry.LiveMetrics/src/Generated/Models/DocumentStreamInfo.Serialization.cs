// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class DocumentStreamInfo
    {
        internal static DocumentStreamInfo DeserializeDocumentStreamInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IReadOnlyList<DocumentFilterConjunctionGroupInfo> documentFilterGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DocumentFilterGroups"u8))
                {
                    List<DocumentFilterConjunctionGroupInfo> array = new List<DocumentFilterConjunctionGroupInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentFilterConjunctionGroupInfo.DeserializeDocumentFilterConjunctionGroupInfo(item));
                    }
                    documentFilterGroups = array;
                    continue;
                }
            }
            return new DocumentStreamInfo(id, documentFilterGroups);
        }
    }
}
