// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.Language.Conversations.Authoring;
using Azure.Core;
<<<<<<< HEAD
using Microsoft.TypeSpec.Generator.Customizations;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ConversationAnalysisAuthoring"/> to client builder. </summary>
    [CodeGenType("LanguageConversationsAuthoringClientBuilderExtensions")]
    public static partial class ConversationsAuthoringClientBuilderExtensions
    {
    }
}
=======

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ConversationAnalysisAuthoringClient"/> to client builder. </summary>
    [CodeGenModel("AILanguageConversationsAuthoringClientBuilderExtensions")]
    public static partial class ConversationsAuthoringClientBuilderExtensions
    {
    }
}
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
