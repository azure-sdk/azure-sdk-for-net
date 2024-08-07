// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Supported parameters for a Healthcare task. </summary>
    public partial class HealthcareActionContent
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

        /// <summary> Initializes a new instance of <see cref="HealthcareActionContent"/>. </summary>
        public HealthcareActionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareActionContent"/>. </summary>
        /// <param name="loggingOptOut"> logging opt out. </param>
        /// <param name="modelVersion"> model version. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets. </param>
        /// <param name="fhirVersion"> The FHIR Spec version that the result will use to format the fhirBundle. For additional information see https://www.hl7.org/fhir/overview.html. </param>
        /// <param name="documentType"> Document type that can be provided as input for Fhir Documents. Expect to have fhirVersion provided when used. Behavior of using None enum is the same as not using the documentType parameter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareActionContent(bool? loggingOptOut, string modelVersion, StringIndexType? stringIndexType, FhirVersion? fhirVersion, HealthcareDocumentType? documentType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoggingOptOut = loggingOptOut;
            ModelVersion = modelVersion;
            StringIndexType = stringIndexType;
            FhirVersion = fhirVersion;
            DocumentType = documentType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Specifies the method used to interpret string offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> The FHIR Spec version that the result will use to format the fhirBundle. For additional information see https://www.hl7.org/fhir/overview.html. </summary>
        public FhirVersion? FhirVersion { get; set; }
        /// <summary> Document type that can be provided as input for Fhir Documents. Expect to have fhirVersion provided when used. Behavior of using None enum is the same as not using the documentType parameter. </summary>
        public HealthcareDocumentType? DocumentType { get; set; }
    }
}
