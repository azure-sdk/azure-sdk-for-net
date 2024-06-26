// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The AzureStorageBlobContainerEndpointUpdateProperties. </summary>
    public partial class AzureStorageBlobContainerEndpointUpdateProperties : EndpointBaseUpdateProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureStorageBlobContainerEndpointUpdateProperties"/>. </summary>
        public AzureStorageBlobContainerEndpointUpdateProperties()
        {
            EndpointType = EndpointType.AzureStorageBlobContainer;
        }

        /// <summary> Initializes a new instance of <see cref="AzureStorageBlobContainerEndpointUpdateProperties"/>. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureStorageBlobContainerEndpointUpdateProperties(EndpointType endpointType, string description, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(endpointType, description, serializedAdditionalRawData)
        {
            EndpointType = endpointType;
        }
    }
}
