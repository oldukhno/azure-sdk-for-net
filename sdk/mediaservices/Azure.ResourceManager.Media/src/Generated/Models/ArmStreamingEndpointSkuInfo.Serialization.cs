// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ArmStreamingEndpointSkuInfo
    {
        internal static ArmStreamingEndpointSkuInfo DeserializeArmStreamingEndpointSkuInfo(JsonElement element)
        {
            Optional<ResourceType> resourceType = default;
            Optional<ArmStreamingEndpointCapacity> capacity = default;
            Optional<ArmStreamingEndpointSku> sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = ArmStreamingEndpointCapacity.DeserializeArmStreamingEndpointCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ArmStreamingEndpointSku.DeserializeArmStreamingEndpointSku(property.Value);
                    continue;
                }
            }
            return new ArmStreamingEndpointSkuInfo(Optional.ToNullable(resourceType), capacity.Value, sku.Value);
        }
    }
}
