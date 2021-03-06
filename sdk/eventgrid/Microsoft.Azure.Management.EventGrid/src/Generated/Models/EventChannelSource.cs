// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the source of an event channel.
    /// </summary>
    public partial class EventChannelSource
    {
        /// <summary>
        /// Initializes a new instance of the EventChannelSource class.
        /// </summary>
        public EventChannelSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventChannelSource class.
        /// </summary>
        /// <param name="source">The identifier of the resource that's the
        /// source of the events.
        /// This represents a unique resource in the partner's resource
        /// model.</param>
        public EventChannelSource(string source = default(string))
        {
            Source = source;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier of the resource that's the source of
        /// the events.
        /// This represents a unique resource in the partner's resource model.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

    }
}
