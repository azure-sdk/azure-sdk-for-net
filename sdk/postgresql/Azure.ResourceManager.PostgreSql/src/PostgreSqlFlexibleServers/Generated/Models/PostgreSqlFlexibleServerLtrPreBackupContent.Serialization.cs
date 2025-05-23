// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerLtrPreBackupContent : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerLtrPreBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerLtrPreBackupContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PostgreSqlFlexibleServerLtrPreBackupContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerLtrPreBackupContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        PostgreSqlFlexibleServerLtrPreBackupContent IJsonModel<PostgreSqlFlexibleServerLtrPreBackupContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerLtrPreBackupContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerLtrPreBackupContent(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerLtrPreBackupContent DeserializePostgreSqlFlexibleServerLtrPreBackupContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlFlexibleServerBackupSettings backupSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupSettings"u8))
                {
                    backupSettings = PostgreSqlFlexibleServerBackupSettings.DeserializePostgreSqlFlexibleServerBackupSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PostgreSqlFlexibleServerLtrPreBackupContent(backupSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPostgreSqlContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerLtrPreBackupContent)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerLtrPreBackupContent IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePostgreSqlFlexibleServerLtrPreBackupContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerLtrPreBackupContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerLtrPreBackupContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
