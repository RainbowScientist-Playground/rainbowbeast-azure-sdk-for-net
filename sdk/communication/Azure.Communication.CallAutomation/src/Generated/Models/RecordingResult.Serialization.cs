// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.CallAutomation.Models
{
    public partial class RecordingResult
    {
        internal static RecordingResult DeserializeRecordingResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recordingId = default;
            RecordingStorageInfo recordingStorageInfo = default;
            IReadOnlyList<ErrorDetails> errors = default;
            DateTimeOffset? recordingStartTime = default;
            long? recordingDurationMs = default;
            CallSessionEndReason? sessionEndReason = default;
            DateTimeOffset? recordingExpirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingId"u8))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordingStorageInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingStorageInfo = RecordingStorageInfo.DeserializeRecordingStorageInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ErrorDetails> array = new List<ErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorDetails.DeserializeErrorDetails(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("recordingStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recordingDurationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingDurationMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sessionEndReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionEndReason = new CallSessionEndReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recordingExpirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingExpirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new RecordingResult(
                recordingId,
                recordingStorageInfo,
                errors ?? new ChangeTrackingList<ErrorDetails>(),
                recordingStartTime,
                recordingDurationMs,
                sessionEndReason,
                recordingExpirationTime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RecordingResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRecordingResult(document.RootElement);
        }
    }
}
