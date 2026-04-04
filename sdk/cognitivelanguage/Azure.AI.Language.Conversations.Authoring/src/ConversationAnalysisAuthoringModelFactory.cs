// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

<<<<<<< HEAD
using Microsoft.TypeSpec.Generator.Customizations;
namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Model factory for Conversations Authoring models. </summary>
    [CodeGenType("LanguageConversationsAuthoringModelFactory")]
=======
namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Model factory for Conversations Authoring models. </summary>
    [CodeGenModel("AILanguageConversationsAuthoringModelFactory")]
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
    public static partial class ConversationAnalysisAuthoringModelFactory
    {
    }
}
