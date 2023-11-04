// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace OpenAI;

public partial class Completions
{
    internal static Completions DeserializeCompletions(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string id = default;
        DateTimeOffset created = default;
        OptionalProperty<IReadOnlyList<PromptFilterResult>> promptAnnotations = default;
        IReadOnlyList<Choice> choices = default;
        CompletionsUsage usage = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("id"u8))
            {
                id = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("created"u8))
            {
                created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("prompt_annotations"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                List<PromptFilterResult> array = new List<PromptFilterResult>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(PromptFilterResult.DeserializePromptFilterResult(item));
                }
                promptAnnotations = array;
                continue;
            }
            if (property.NameEquals("choices"u8))
            {
                List<Choice> array = new List<Choice>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(Choice.DeserializeChoice(item));
                }
                choices = array;
                continue;
            }
            if (property.NameEquals("usage"u8))
            {
                usage = CompletionsUsage.DeserializeCompletionsUsage(property.Value);
                continue;
            }
        }
        return new Completions(id, created, OptionalProperty.ToList(promptAnnotations), choices, usage);
    }

    /// <summary> Deserializes the model from a raw response. </summary>
    /// <param name="response"> The response to deserialize the model from. </param>
    internal static Completions FromResponse(MessageResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeCompletions(document.RootElement);
    }
}

