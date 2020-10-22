// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Learn.Computation.Models
{
    public partial class ComputeNode : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static ComputeNode DeserializeComputeNode(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LinuxComputeNode": return LinuxComputeNode.DeserializeLinuxComputeNode(element);
                    case "WindowsComputeNode": return WindowsComputeNode.DeserializeWindowsComputeNode(element);
                }
            }
            Optional<ETag> eTag = default;
            string name = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"))
                {
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new ComputeNode(eTag, name, kind);
        }
    }
}
