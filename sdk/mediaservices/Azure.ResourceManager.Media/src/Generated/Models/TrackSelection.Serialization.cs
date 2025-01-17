// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class TrackSelection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TrackSelections))
            {
                writer.WritePropertyName("trackSelections");
                writer.WriteStartArray();
                foreach (var item in TrackSelections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static TrackSelection DeserializeTrackSelection(JsonElement element)
        {
            Optional<IList<TrackPropertyCondition>> trackSelections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackSelections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TrackPropertyCondition> array = new List<TrackPropertyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrackPropertyCondition.DeserializeTrackPropertyCondition(item));
                    }
                    trackSelections = array;
                    continue;
                }
            }
            return new TrackSelection(Optional.ToList(trackSelections));
        }
    }
}
