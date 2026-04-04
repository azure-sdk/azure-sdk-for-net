<<<<<<< HEAD
// Copyright (c) Microsoft Corporation. All rights reserved.
=======
﻿// Copyright (c) Microsoft Corporation. All rights reserved.
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
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
    public partial class Sample23_ConversationsAuthoring_GetDeploymentDeleteFromResourcesStatus : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void GetDeploymentDeleteFromResourcesStatus()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client =
                new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client =
                new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample23_ConversationsAuthoring_GetDeploymentDeleteFromResourcesStatus
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
            string jobId = "{jobId}";
<<<<<<< HEAD
            // Retrieve the job status
            Response<ConversationAuthoringDeploymentDeleteFromResourcesState> response =
                client.GetDeploymentDeleteFromResourcesStatus(projectName, deploymentName, jobId);
=======

            // Get the deployment-scoped client
            ConversationAuthoringDeployment deploymentClient =
                client.GetDeployment(projectName, deploymentName);

            // Retrieve the job status
            Response<ConversationAuthoringDeploymentDeleteFromResourcesState> response =
                deploymentClient.GetDeploymentDeleteFromResourcesStatus(jobId);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            ConversationAuthoringDeploymentDeleteFromResourcesState state = response.Value;

            Console.WriteLine($"Job ID: {state.JobId}");
            Console.WriteLine($"Status: {state.Status}");
            Console.WriteLine($"Created On: {state.CreatedOn}");
            Console.WriteLine($"Last Updated On: {state.LastUpdatedOn}");
            Console.WriteLine($"Expires On: {state.ExpiresOn}");
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task GetDeploymentDeleteFromResourcesStatusAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client =
                new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client =
                new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample23_ConversationsAuthoring_GetDeploymentDeleteFromResourcesStatusAsync
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
            string jobId = "{jobId}";
<<<<<<< HEAD
            // Retrieve the job status asynchronously
            Response<ConversationAuthoringDeploymentDeleteFromResourcesState> response =
                await client.GetDeploymentDeleteFromResourcesStatusAsync(projectName, deploymentName, jobId);
=======

            // Get the deployment-scoped client
            ConversationAuthoringDeployment deploymentClient =
                client.GetDeployment(projectName, deploymentName);

            // Retrieve the job status asynchronously
            Response<ConversationAuthoringDeploymentDeleteFromResourcesState> response =
                await deploymentClient.GetDeploymentDeleteFromResourcesStatusAsync(jobId);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            ConversationAuthoringDeploymentDeleteFromResourcesState state = response.Value;

            Console.WriteLine($"Job ID: {state.JobId}");
            Console.WriteLine($"Status: {state.Status}");
            Console.WriteLine($"Created On: {state.CreatedOn}");
            Console.WriteLine($"Last Updated On: {state.LastUpdatedOn}");
            Console.WriteLine($"Expires On: {state.ExpiresOn}");
            #endregion
        }
    }
}
