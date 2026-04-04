// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Language.Conversations.Authoring;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Authoring.Tests.Samples
{
    public partial class Sample13_ConversationsAuthoring_DeleteDeployment : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void DeleteDeployment()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample13_ConversationsAuthoring_DeleteDeployment
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
<<<<<<< HEAD
            Operation operation = client.DeleteDeployment(WaitUntil.Completed, projectName, deploymentName);
=======
            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            Operation operation = deploymentClient.DeleteDeployment(
                waitUntil: WaitUntil.Completed
            );
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            // Extract operation-location from response headers
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location) ? location : "Not found";
            Console.WriteLine($"Delete operation-location: {operationLocation}");
            Console.WriteLine($"Delete operation completed with status: {operation.GetRawResponse().Status}");
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task DeleteDeploymentAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample13_ConversationsAuthoring_DeleteDeploymentAsync
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
<<<<<<< HEAD
            Operation operation = await client.DeleteDeploymentAsync(WaitUntil.Completed, projectName, deploymentName);
=======
            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            Operation operation = await deploymentClient.DeleteDeploymentAsync(
                waitUntil: WaitUntil.Completed
            );
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            // Extract operation-location from response headers
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location) ? location : "Not found";
            Console.WriteLine($"Delete operation-location: {operationLocation}");
            Console.WriteLine($"Delete operation completed with status: {operation.GetRawResponse().Status}");
            #endregion
        }
    }
}
