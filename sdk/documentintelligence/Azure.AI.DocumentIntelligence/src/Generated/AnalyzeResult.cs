// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Document analysis result. </summary>
    public partial class AnalyzeResult
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeResult"/>. </summary>
        /// <param name="apiVersion"> API version used to produce this result. </param>
        /// <param name="modelId"> Document model ID used to produce this result. </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. </param>
        /// <param name="content">
        /// Concatenate string representation of all textual and visual elements in reading
        /// order.
        /// </param>
        /// <param name="pages"> Analyzed pages. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/>, <paramref name="modelId"/>, <paramref name="content"/> or <paramref name="pages"/> is null. </exception>
        internal AnalyzeResult(string apiVersion, string modelId, StringIndexType stringIndexType, string content, IEnumerable<DocumentPage> pages)
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));
            Argument.AssertNotNull(modelId, nameof(modelId));
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(pages, nameof(pages));

            ApiVersion = apiVersion;
            ModelId = modelId;
            StringIndexType = stringIndexType;
            Content = content;
            Pages = pages.ToList();
            Paragraphs = new ChangeTrackingList<DocumentParagraph>();
            Tables = new ChangeTrackingList<DocumentTable>();
            Figures = new ChangeTrackingList<DocumentFigure>();
            Sections = new ChangeTrackingList<DocumentSection>();
            KeyValuePairs = new ChangeTrackingList<DocumentKeyValuePair>();
            Styles = new ChangeTrackingList<DocumentStyle>();
            Languages = new ChangeTrackingList<DocumentLanguage>();
            Documents = new ChangeTrackingList<AnalyzedDocument>();
            Warnings = new ChangeTrackingList<DocumentIntelligenceWarning>();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeResult"/>. </summary>
        /// <param name="apiVersion"> API version used to produce this result. </param>
        /// <param name="modelId"> Document model ID used to produce this result. </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. </param>
        /// <param name="contentFormat"> Format of the analyze result top-level content. </param>
        /// <param name="content">
        /// Concatenate string representation of all textual and visual elements in reading
        /// order.
        /// </param>
        /// <param name="pages"> Analyzed pages. </param>
        /// <param name="paragraphs"> Extracted paragraphs. </param>
        /// <param name="tables"> Extracted tables. </param>
        /// <param name="figures"> Extracted figures. </param>
        /// <param name="sections"> Extracted sections. </param>
        /// <param name="keyValuePairs"> Extracted key-value pairs. </param>
        /// <param name="styles"> Extracted font styles. </param>
        /// <param name="languages"> Detected languages. </param>
        /// <param name="documents"> Extracted documents. </param>
        /// <param name="warnings"> List of warnings encountered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeResult(string apiVersion, string modelId, StringIndexType stringIndexType, DocumentContentFormat? contentFormat, string content, IReadOnlyList<DocumentPage> pages, IReadOnlyList<DocumentParagraph> paragraphs, IReadOnlyList<DocumentTable> tables, IReadOnlyList<DocumentFigure> figures, IReadOnlyList<DocumentSection> sections, IReadOnlyList<DocumentKeyValuePair> keyValuePairs, IReadOnlyList<DocumentStyle> styles, IReadOnlyList<DocumentLanguage> languages, IReadOnlyList<AnalyzedDocument> documents, IReadOnlyList<DocumentIntelligenceWarning> warnings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiVersion = apiVersion;
            ModelId = modelId;
            StringIndexType = stringIndexType;
            ContentFormat = contentFormat;
            Content = content;
            Pages = pages;
            Paragraphs = paragraphs;
            Tables = tables;
            Figures = figures;
            Sections = sections;
            KeyValuePairs = keyValuePairs;
            Styles = styles;
            Languages = languages;
            Documents = documents;
            Warnings = warnings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeResult"/> for deserialization. </summary>
        internal AnalyzeResult()
        {
        }

        /// <summary> API version used to produce this result. </summary>
        public string ApiVersion { get; }
        /// <summary> Document model ID used to produce this result. </summary>
        public string ModelId { get; }
        /// <summary> Format of the analyze result top-level content. </summary>
        public DocumentContentFormat? ContentFormat { get; }
        /// <summary>
        /// Concatenate string representation of all textual and visual elements in reading
        /// order.
        /// </summary>
        public string Content { get; }
        /// <summary> Analyzed pages. </summary>
        public IReadOnlyList<DocumentPage> Pages { get; }
        /// <summary> Extracted paragraphs. </summary>
        public IReadOnlyList<DocumentParagraph> Paragraphs { get; }
        /// <summary> Extracted tables. </summary>
        public IReadOnlyList<DocumentTable> Tables { get; }
        /// <summary> Extracted figures. </summary>
        public IReadOnlyList<DocumentFigure> Figures { get; }
        /// <summary> Extracted sections. </summary>
        public IReadOnlyList<DocumentSection> Sections { get; }
        /// <summary> Extracted key-value pairs. </summary>
        public IReadOnlyList<DocumentKeyValuePair> KeyValuePairs { get; }
        /// <summary> Extracted font styles. </summary>
        public IReadOnlyList<DocumentStyle> Styles { get; }
        /// <summary> Detected languages. </summary>
        public IReadOnlyList<DocumentLanguage> Languages { get; }
        /// <summary> Extracted documents. </summary>
        public IReadOnlyList<AnalyzedDocument> Documents { get; }
        /// <summary> List of warnings encountered. </summary>
        public IReadOnlyList<DocumentIntelligenceWarning> Warnings { get; }
    }
}
