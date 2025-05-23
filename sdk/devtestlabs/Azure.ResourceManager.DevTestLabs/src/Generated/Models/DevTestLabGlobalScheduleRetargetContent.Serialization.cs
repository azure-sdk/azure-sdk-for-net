// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabGlobalScheduleRetargetContent : IUtf8JsonSerializable, IJsonModel<DevTestLabGlobalScheduleRetargetContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabGlobalScheduleRetargetContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabGlobalScheduleRetargetContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGlobalScheduleRetargetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabGlobalScheduleRetargetContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CurrentResourceId))
            {
                writer.WritePropertyName("currentResourceId"u8);
                writer.WriteStringValue(CurrentResourceId);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
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

        DevTestLabGlobalScheduleRetargetContent IJsonModel<DevTestLabGlobalScheduleRetargetContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGlobalScheduleRetargetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabGlobalScheduleRetargetContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabGlobalScheduleRetargetContent(document.RootElement, options);
        }

        internal static DevTestLabGlobalScheduleRetargetContent DeserializeDevTestLabGlobalScheduleRetargetContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier currentResourceId = default;
            ResourceIdentifier targetResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabGlobalScheduleRetargetContent(currentResourceId, targetResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabGlobalScheduleRetargetContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGlobalScheduleRetargetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevTestLabsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabGlobalScheduleRetargetContent)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabGlobalScheduleRetargetContent IPersistableModel<DevTestLabGlobalScheduleRetargetContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGlobalScheduleRetargetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabGlobalScheduleRetargetContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabGlobalScheduleRetargetContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabGlobalScheduleRetargetContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
