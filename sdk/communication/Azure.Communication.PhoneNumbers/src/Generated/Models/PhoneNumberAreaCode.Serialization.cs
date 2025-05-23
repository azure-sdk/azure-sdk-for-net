// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.PhoneNumbers
{
    public partial class PhoneNumberAreaCode
    {
        internal static PhoneNumberAreaCode DeserializePhoneNumberAreaCode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string areaCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("areaCode"u8))
                {
                    areaCode = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneNumberAreaCode(areaCode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PhoneNumberAreaCode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePhoneNumberAreaCode(document.RootElement);
        }
    }
}
