// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricResultsResponseValuesItem
    {
        internal static MetricResultsResponseValuesItem DeserializeMetricResultsResponseValuesItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset starttime = default;
            DateTimeOffset endtime = default;
            Optional<TimeSpan> interval = default;
            Optional<string> @namespace = default;
            Optional<string> resourceregion = default;
            Optional<ResourceIdentifier> resourceid = default;
            IReadOnlyList<QueryBatchMetric> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("starttime"u8))
                {
                    starttime = property.Value.GetDateTimeOffset(null);
                    continue;
                }
                if (property.NameEquals("endtime"u8))
                {
                    endtime = property.Value.GetDateTimeOffset(null);
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"u8))
                {
                    resourceregion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<QueryBatchMetric> array = new List<QueryBatchMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryBatchMetric.DeserializeQueryBatchMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricResultsResponseValuesItem(starttime, endtime, Optional.ToNullable(interval), @namespace.Value, resourceregion.Value, resourceid.Value, value);
        }
    }
}
