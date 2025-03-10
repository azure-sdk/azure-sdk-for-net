// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AVS.ClusterFailed event. </summary>
    public partial class AvsClusterFailedEventData : AvsClusterEventData
    {
        /// <summary> Initializes a new instance of <see cref="AvsClusterFailedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        internal AvsClusterFailedEventData(string operationId) : base(operationId)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
        }

        /// <summary> Initializes a new instance of <see cref="AvsClusterFailedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <param name="addedHostNames"> Hosts added to the cluster in this event, if any. </param>
        /// <param name="removedHostNames"> Hosts removed from the cluster in this event, if any. </param>
        /// <param name="inMaintenanceHostNames"> Hosts in Maintenance mode in the cluster, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="failureMessage"> Failure reason of an event. </param>
        internal AvsClusterFailedEventData(string operationId, IReadOnlyList<string> addedHostNames, IReadOnlyList<string> removedHostNames, IReadOnlyList<string> inMaintenanceHostNames, IDictionary<string, BinaryData> serializedAdditionalRawData, string failureMessage) : base(operationId, addedHostNames, removedHostNames, inMaintenanceHostNames, serializedAdditionalRawData)
        {
            FailureMessage = failureMessage;
        }

        /// <summary> Initializes a new instance of <see cref="AvsClusterFailedEventData"/> for deserialization. </summary>
        internal AvsClusterFailedEventData()
        {
        }

        /// <summary> Failure reason of an event. </summary>
        public string FailureMessage { get; }
    }
}
