// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Purview
{
    public partial class PurviewKafkaConfigurationResource : IJsonModel<PurviewKafkaConfigurationData>
    {
        private static PurviewKafkaConfigurationData s_dataDeserializationInstance;
        private static PurviewKafkaConfigurationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PurviewKafkaConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PurviewKafkaConfigurationData>)Data).Write(writer, options);

        PurviewKafkaConfigurationData IJsonModel<PurviewKafkaConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PurviewKafkaConfigurationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PurviewKafkaConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PurviewKafkaConfigurationData>(Data, options, AzureResourceManagerPurviewContext.Default);

        PurviewKafkaConfigurationData IPersistableModel<PurviewKafkaConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PurviewKafkaConfigurationData>(data, options, AzureResourceManagerPurviewContext.Default);

        string IPersistableModel<PurviewKafkaConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PurviewKafkaConfigurationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
