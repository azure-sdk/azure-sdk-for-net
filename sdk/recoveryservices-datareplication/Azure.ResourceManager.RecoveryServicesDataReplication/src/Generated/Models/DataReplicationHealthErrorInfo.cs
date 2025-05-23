// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Health error model. </summary>
    public partial class DataReplicationHealthErrorInfo
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

        /// <summary> Initializes a new instance of <see cref="DataReplicationHealthErrorInfo"/>. </summary>
        internal DataReplicationHealthErrorInfo()
        {
            AffectedResourceCorrelationIds = new ChangeTrackingList<string>();
            ChildErrors = new ChangeTrackingList<DataReplicationInnerHealthErrorInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationHealthErrorInfo"/>. </summary>
        /// <param name="affectedResourceType"> Gets or sets the type of affected resource type. </param>
        /// <param name="affectedResourceCorrelationIds"> Gets or sets the list of affected resource correlation Ids. This can be used to uniquely identify the count of items affected by a specific category and severity as well as count of item affected by an specific issue. </param>
        /// <param name="childErrors"> Gets or sets a list of child health errors associated with this error. </param>
        /// <param name="code"> Gets or sets the error code. </param>
        /// <param name="healthCategory"> Gets or sets the health category. </param>
        /// <param name="category"> Gets or sets the error category. </param>
        /// <param name="severity"> Gets or sets the error severity. </param>
        /// <param name="source"> Gets or sets the error source. </param>
        /// <param name="createdOn"> Gets or sets the error creation time. </param>
        /// <param name="isCustomerResolvable"> Gets or sets a value indicating whether the error is customer resolvable. </param>
        /// <param name="summary"> Gets or sets the error summary. </param>
        /// <param name="message"> Gets or sets the error message. </param>
        /// <param name="causes"> Gets or sets possible causes of the error. </param>
        /// <param name="recommendation"> Gets or sets recommended action to resolve the error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationHealthErrorInfo(ResourceType? affectedResourceType, IReadOnlyList<string> affectedResourceCorrelationIds, IReadOnlyList<DataReplicationInnerHealthErrorInfo> childErrors, string code, string healthCategory, string category, string severity, string source, DateTimeOffset? createdOn, bool? isCustomerResolvable, string summary, string message, string causes, string recommendation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AffectedResourceType = affectedResourceType;
            AffectedResourceCorrelationIds = affectedResourceCorrelationIds;
            ChildErrors = childErrors;
            Code = code;
            HealthCategory = healthCategory;
            Category = category;
            Severity = severity;
            Source = source;
            CreatedOn = createdOn;
            IsCustomerResolvable = isCustomerResolvable;
            Summary = summary;
            Message = message;
            Causes = causes;
            Recommendation = recommendation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the type of affected resource type. </summary>
        public ResourceType? AffectedResourceType { get; }
        /// <summary> Gets or sets the list of affected resource correlation Ids. This can be used to uniquely identify the count of items affected by a specific category and severity as well as count of item affected by an specific issue. </summary>
        public IReadOnlyList<string> AffectedResourceCorrelationIds { get; }
        /// <summary> Gets or sets a list of child health errors associated with this error. </summary>
        public IReadOnlyList<DataReplicationInnerHealthErrorInfo> ChildErrors { get; }
        /// <summary> Gets or sets the error code. </summary>
        public string Code { get; }
        /// <summary> Gets or sets the health category. </summary>
        public string HealthCategory { get; }
        /// <summary> Gets or sets the error category. </summary>
        public string Category { get; }
        /// <summary> Gets or sets the error severity. </summary>
        public string Severity { get; }
        /// <summary> Gets or sets the error source. </summary>
        public string Source { get; }
        /// <summary> Gets or sets the error creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets a value indicating whether the error is customer resolvable. </summary>
        public bool? IsCustomerResolvable { get; }
        /// <summary> Gets or sets the error summary. </summary>
        public string Summary { get; }
        /// <summary> Gets or sets the error message. </summary>
        public string Message { get; }
        /// <summary> Gets or sets possible causes of the error. </summary>
        public string Causes { get; }
        /// <summary> Gets or sets recommended action to resolve the error. </summary>
        public string Recommendation { get; }
    }
}
