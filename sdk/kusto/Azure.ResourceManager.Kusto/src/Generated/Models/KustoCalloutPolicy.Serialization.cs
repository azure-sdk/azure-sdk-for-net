// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoCalloutPolicy : IUtf8JsonSerializable, IJsonModel<KustoCalloutPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoCalloutPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KustoCalloutPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoCalloutPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoCalloutPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CalloutUriRegex))
            {
                writer.WritePropertyName("calloutUriRegex"u8);
                writer.WriteStringValue(CalloutUriRegex);
            }
            if (Optional.IsDefined(CalloutType))
            {
                writer.WritePropertyName("calloutType"u8);
                writer.WriteStringValue(CalloutType.Value.ToString());
            }
            if (Optional.IsDefined(OutboundAccess))
            {
                writer.WritePropertyName("outboundAccess"u8);
                writer.WriteStringValue(OutboundAccess.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CalloutId))
            {
                writer.WritePropertyName("calloutId"u8);
                writer.WriteStringValue(CalloutId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        KustoCalloutPolicy IJsonModel<KustoCalloutPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoCalloutPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoCalloutPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoCalloutPolicy(document.RootElement, options);
        }

        internal static KustoCalloutPolicy DeserializeKustoCalloutPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string calloutUriRegex = default;
            KustoCalloutPolicyCalloutType? calloutType = default;
            KustoCalloutPolicyOutboundAccess? outboundAccess = default;
            string calloutId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("calloutUriRegex"u8))
                {
                    calloutUriRegex = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("calloutType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    calloutType = new KustoCalloutPolicyCalloutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outboundAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundAccess = new KustoCalloutPolicyOutboundAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("calloutId"u8))
                {
                    calloutId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KustoCalloutPolicy(calloutUriRegex, calloutType, outboundAccess, calloutId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoCalloutPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoCalloutPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerKustoContext.Default);
                default:
                    throw new FormatException($"The model {nameof(KustoCalloutPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        KustoCalloutPolicy IPersistableModel<KustoCalloutPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoCalloutPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeKustoCalloutPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoCalloutPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoCalloutPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
