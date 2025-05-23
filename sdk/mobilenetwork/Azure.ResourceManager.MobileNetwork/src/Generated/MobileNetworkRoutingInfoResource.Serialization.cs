// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkRoutingInfoResource : IJsonModel<MobileNetworkRoutingInfoData>
    {
        private static MobileNetworkRoutingInfoData s_dataDeserializationInstance;
        private static MobileNetworkRoutingInfoData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MobileNetworkRoutingInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkRoutingInfoData>)Data).Write(writer, options);

        MobileNetworkRoutingInfoData IJsonModel<MobileNetworkRoutingInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkRoutingInfoData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MobileNetworkRoutingInfoData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MobileNetworkRoutingInfoData>(Data, options, AzureResourceManagerMobileNetworkContext.Default);

        MobileNetworkRoutingInfoData IPersistableModel<MobileNetworkRoutingInfoData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MobileNetworkRoutingInfoData>(data, options, AzureResourceManagerMobileNetworkContext.Default);

        string IPersistableModel<MobileNetworkRoutingInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MobileNetworkRoutingInfoData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
