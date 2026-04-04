// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

<<<<<<< HEAD
using Microsoft.TypeSpec.Generator.Customizations;
namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Client options for <see cref="ConversationAnalysisAuthoring"/>. </summary>
    [CodeGenType("ConversationAnalysisAuthoringOptions")]
=======
namespace Azure.AI.Language.Conversations.Authoring
{
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
    public partial class ConversationAnalysisAuthoringClientOptions : ClientOptions
    {
        /// <summary>
        /// Gets or sets the audience to use for authentication with Azure Active Directory (AAD). The audience is not considered when using a shared key.
        /// </summary>
        /// <value>If <c>null</c>, <see cref="ConversationsAuthoringAudience.AzurePublicCloud" /> will be assumed.</value>
        internal ConversationsAuthoringAudience? Audience { get; set; }
    }
}
