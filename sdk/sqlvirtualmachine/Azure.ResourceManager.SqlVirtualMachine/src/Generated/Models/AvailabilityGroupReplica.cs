// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Availability group replica configuration. </summary>
    public partial class AvailabilityGroupReplica
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupReplica"/>. </summary>
        public AvailabilityGroupReplica()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupReplica"/>. </summary>
        /// <param name="sqlVmInstanceId"> Sql VirtualMachine Instance Id. </param>
        /// <param name="role"> Replica Role in availability group. </param>
        /// <param name="commit"> Replica commit mode in availability group. </param>
        /// <param name="failover"> Replica failover mode in availability group. </param>
        /// <param name="readableSecondary"> Replica readable secondary mode in availability group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailabilityGroupReplica(ResourceIdentifier sqlVmInstanceId, AvailabilityGroupReplicaRole? role, AvailabilityGroupReplicaCommitMode? commit, AvailabilityGroupReplicaFailoverMode? failover, ReadableSecondaryMode? readableSecondary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SqlVmInstanceId = sqlVmInstanceId;
            Role = role;
            Commit = commit;
            Failover = failover;
            ReadableSecondary = readableSecondary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sql VirtualMachine Instance Id. </summary>
        public ResourceIdentifier SqlVmInstanceId { get; set; }
        /// <summary> Replica Role in availability group. </summary>
        public AvailabilityGroupReplicaRole? Role { get; set; }
        /// <summary> Replica commit mode in availability group. </summary>
        public AvailabilityGroupReplicaCommitMode? Commit { get; set; }
        /// <summary> Replica failover mode in availability group. </summary>
        public AvailabilityGroupReplicaFailoverMode? Failover { get; set; }
        /// <summary> Replica readable secondary mode in availability group. </summary>
        public ReadableSecondaryMode? ReadableSecondary { get; set; }
    }
}
