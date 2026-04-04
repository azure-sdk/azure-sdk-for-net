// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.Language.Conversations.Authoring;
using Azure.AI.Language.Conversations.Authoring.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;
#region Snippet:Conversations_Identity_Namespace
using Azure.Identity;
using Azure.Core;
#endregion

namespace Azure.AI.Language.Conversations.Authoring.Tests.Samples
{
    public partial class CreateClient : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        public void CreateAuthoringClientForSpecificApiVersion()
        {
            #region Snippet:CreateAuthoringClientForSpecificApiVersion
            Uri endpoint = new Uri("{endpoint}");
            AzureKeyCredential credential = new AzureKeyCredential("{api-key}");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
            credential = new(TestEnvironment.ApiKey);
#endif
            ConversationAnalysisAuthoringClientOptions options = new ConversationAnalysisAuthoringClientOptions(ConversationAnalysisAuthoringClientOptions.ServiceVersion.V2025_11_15_Preview);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential, options);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential, options);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            #endregion
        }

        [Test]
        public void AuthoringClient_CreateWithDefaultAzureCredential()
        {
            #region Snippet:AnalyzeConversationAuthoring_CreateWithDefaultAzureCredential
            Uri endpoint = new Uri("{endpoint}");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
#endif
            DefaultAzureCredential credential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            #endregion
        }

        [Test]
        public void BadArgument()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:AuthoringClient_BadRequest
            try
            {
                string invalidProjectName = "InvalidProject";
<<<<<<< HEAD
=======
                ConversationAuthoringProject projectClient = client.GetProject(invalidProjectName);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                ConversationAuthoringCreateProjectDetails projectData = new ConversationAuthoringCreateProjectDetails(
                  projectKind: "Conversation",
                  projectName: invalidProjectName,
                  language: "invalid-lang"
                )
                {
                    Description = "This is a test for invalid configuration."
                };
                using RequestContent content = RequestContent.Create(projectData);
<<<<<<< HEAD
                Response response = client.CreateProject(invalidProjectName, content);
=======
                Response response = projectClient.CreateProject(content);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
