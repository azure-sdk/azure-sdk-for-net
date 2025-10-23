﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dell.Storage.Models
{
    // TODO: remove this when https://github.com/Azure/typespec-azure/issues/3419 is fixed.
    /// <summary> The type used for update operations of the FileSystemResource. </summary>
    [CodeGenSerialization(nameof(Identity), SerializationValueHook = nameof(SerializeIdentity), DeserializationValueHook = nameof(DeserializeIdentity))]
    public partial class DellFileSystemPatch
    {
        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SerializeIdentity(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void DeserializeIdentity(JsonProperty property, ref ManagedServiceIdentity identity)
        {
            if (property.Value.ValueKind == JsonValueKind.Null)
            {
                return;
            }
            identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDellStorageContext.Default);
        }
    }
}
