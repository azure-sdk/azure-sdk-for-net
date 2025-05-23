// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> Error definition. </summary>
    public partial class SapVirtualInstanceErrorDetail
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

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceErrorDetail"/>. </summary>
        internal SapVirtualInstanceErrorDetail()
        {
            Details = new ChangeTrackingList<SapVirtualInstanceErrorDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceErrorDetail"/>. </summary>
        /// <param name="code"> Service specific error code which serves as the substatus for the HTTP error code. </param>
        /// <param name="message"> Description of the error. </param>
        /// <param name="details"> Internal error details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapVirtualInstanceErrorDetail(string code, string message, IReadOnlyList<SapVirtualInstanceErrorDetail> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Service specific error code which serves as the substatus for the HTTP error code. </summary>
        public string Code { get; }
        /// <summary> Description of the error. </summary>
        public string Message { get; }
        /// <summary> Internal error details. </summary>
        public IReadOnlyList<SapVirtualInstanceErrorDetail> Details { get; }
    }
}
