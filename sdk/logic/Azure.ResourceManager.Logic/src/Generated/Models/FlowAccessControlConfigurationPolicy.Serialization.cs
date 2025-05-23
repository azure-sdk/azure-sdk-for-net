// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class FlowAccessControlConfigurationPolicy : IUtf8JsonSerializable, IJsonModel<FlowAccessControlConfigurationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FlowAccessControlConfigurationPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FlowAccessControlConfigurationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowAccessControlConfigurationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlowAccessControlConfigurationPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AllowedCallerIPAddresses))
            {
                writer.WritePropertyName("allowedCallerIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedCallerIPAddresses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OpenAuthenticationPolicies))
            {
                writer.WritePropertyName("openAuthenticationPolicies"u8);
                writer.WriteObjectValue(OpenAuthenticationPolicies, options);
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

        FlowAccessControlConfigurationPolicy IJsonModel<FlowAccessControlConfigurationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowAccessControlConfigurationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlowAccessControlConfigurationPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlowAccessControlConfigurationPolicy(document.RootElement, options);
        }

        internal static FlowAccessControlConfigurationPolicy DeserializeFlowAccessControlConfigurationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FlowAccessControlIPAddressRange> allowedCallerIPAddresses = default;
            OpenAuthenticationAccessPolicies openAuthenticationPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedCallerIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FlowAccessControlIPAddressRange> array = new List<FlowAccessControlIPAddressRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FlowAccessControlIPAddressRange.DeserializeFlowAccessControlIPAddressRange(item, options));
                    }
                    allowedCallerIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("openAuthenticationPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openAuthenticationPolicies = OpenAuthenticationAccessPolicies.DeserializeOpenAuthenticationAccessPolicies(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FlowAccessControlConfigurationPolicy(allowedCallerIPAddresses ?? new ChangeTrackingList<FlowAccessControlIPAddressRange>(), openAuthenticationPolicies, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FlowAccessControlConfigurationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowAccessControlConfigurationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLogicContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FlowAccessControlConfigurationPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        FlowAccessControlConfigurationPolicy IPersistableModel<FlowAccessControlConfigurationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowAccessControlConfigurationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFlowAccessControlConfigurationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FlowAccessControlConfigurationPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FlowAccessControlConfigurationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
