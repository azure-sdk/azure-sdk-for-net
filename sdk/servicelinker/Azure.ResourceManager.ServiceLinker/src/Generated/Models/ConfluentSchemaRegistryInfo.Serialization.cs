// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class ConfluentSchemaRegistryInfo : IUtf8JsonSerializable, IJsonModel<ConfluentSchemaRegistryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfluentSchemaRegistryInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfluentSchemaRegistryInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentSchemaRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentSchemaRegistryInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
        }

        ConfluentSchemaRegistryInfo IJsonModel<ConfluentSchemaRegistryInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentSchemaRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentSchemaRegistryInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfluentSchemaRegistryInfo(document.RootElement, options);
        }

        internal static ConfluentSchemaRegistryInfo DeserializeConfluentSchemaRegistryInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpoint = default;
            TargetServiceType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new TargetServiceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfluentSchemaRegistryInfo(type, serializedAdditionalRawData, endpoint);
        }

        BinaryData IPersistableModel<ConfluentSchemaRegistryInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentSchemaRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceLinkerContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConfluentSchemaRegistryInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ConfluentSchemaRegistryInfo IPersistableModel<ConfluentSchemaRegistryInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentSchemaRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConfluentSchemaRegistryInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfluentSchemaRegistryInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfluentSchemaRegistryInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
