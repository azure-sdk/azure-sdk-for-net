// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.AI.Language.Documents
{
    /// <summary>
    /// Options that allow configuration of requests sent to the Document Analysis service.
    /// </summary>
    public partial class DocumentAnalysisClientOptions : ClientOptions
    {
        /// <summary>
        /// Gets or sets the audience to use for authentication with Azure Active Directory (AAD). The audience is not considered when using a shared key.
        /// </summary>
        /// <value>If <c>null</c>, <see cref="DocumentsAudience.AzurePublicCloud" /> will be assumed.</value>
        internal DocumentsAudience? Audience { get; set; }
    }
}
