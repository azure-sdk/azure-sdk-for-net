// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.TimeZones
{
    internal partial class RepresentativePoint
    {
        internal static RepresentativePoint DeserializeRepresentativePoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? latitude = default;
            float? longitude = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Latitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("Longitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longitude = property.Value.GetSingle();
                    continue;
                }
            }
            return new RepresentativePoint(latitude, longitude);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RepresentativePoint FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRepresentativePoint(document.RootElement);
        }
    }
}
