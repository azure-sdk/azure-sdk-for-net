// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Union
{
    public partial class GetResponse4 : IJsonModel<GetResponse4>
    {
        internal GetResponse4() => throw null;

        void IJsonModel<GetResponse4>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        GetResponse4 IJsonModel<GetResponse4>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual GetResponse4 JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<GetResponse4>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        GetResponse4 IPersistableModel<GetResponse4>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual GetResponse4 PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<GetResponse4>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="getResponse4"> The <see cref="GetResponse4"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(GetResponse4 getResponse4) => throw null;

        public static explicit operator GetResponse4(Response result) => throw null;
    }
}
