<<<<<<< HEAD
// Copyright (c) Microsoft Corporation. All rights reserved.
=======
﻿// Copyright (c) Microsoft Corporation. All rights reserved.
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Language.Conversations.Authoring;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Authoring.Tests.Samples
{
    public partial class Sample17_ConversationsAuthoring_GetAssignProjectResourcesStatus : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void GetAssignProjectResourcesStatus()
        {
            Uri sampleEndpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential sampleCredential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(sampleEndpoint, sampleCredential);

            #region Snippet:Sample17_ConversationsAuthoring_GetAssignProjectResourcesStatus
            string sampleProjectName = "{projectName}";
=======
            var sampleClient = new ConversationAnalysisAuthoringClient(sampleEndpoint, sampleCredential);

            #region Snippet:Sample17_ConversationsAuthoring_GetAssignProjectResourcesStatus
            string sampleProjectName = "{projectName}";
            ConversationAuthoringProject sampleProjectClient = sampleClient.GetProject(sampleProjectName);

>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            var sampleResourceMetadata = new ConversationAuthoringResourceMetadata(
                azureResourceId: "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}",
                customDomain: "{customDomain}",
                region: "{region}"
            );

<<<<<<< HEAD
            var sampleAssignDetails = new ConversationAuthoringAssignDeploymentResourcesDetails(
=======
            var sampleAssignDetails = new ConversationAuthoringAssignProjectResourcesDetails(
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                new List<ConversationAuthoringResourceMetadata> { sampleResourceMetadata }
            );

            // Submit assignment operation
<<<<<<< HEAD
            Operation sampleAssignOperation = client.AssignProjectResources(
                WaitUntil.Started,
                sampleProjectName,
                sampleAssignDetails
=======
            Operation sampleAssignOperation = sampleProjectClient.AssignProjectResources(
                waitUntil: WaitUntil.Started,
                details: sampleAssignDetails
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            string sampleOperationLocation = sampleAssignOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out var location)
                ? location
                : throw new InvalidOperationException("Operation-Location header not found.");

            // Extract only the jobId part from the URL
            string sampleJobId = new Uri(location).Segments.Last().Split('?')[0];
            Console.WriteLine($"Job ID: {sampleJobId}");

            // Call status API
<<<<<<< HEAD
            Response<ConversationAuthoringDeploymentResourcesState> sampleStatusResponse = client.GetAssignProjectResourcesStatus(sampleProjectName, sampleJobId);
=======
            Response<ConversationAuthoringProjectResourcesState> sampleStatusResponse = sampleProjectClient.GetAssignProjectResourcesStatus(sampleJobId);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            Console.WriteLine($"Deployment assignment status: {sampleStatusResponse.Value.Status}");
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task GetAssignProjectResourcesStatusAsync()
        {
            Uri sampleEndpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential sampleCredential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(sampleEndpoint, sampleCredential);

            #region Snippet:Sample17_ConversationsAuthoring_GetAssignProjectResourcesStatusAsync
            string sampleProjectName = "{projectName}";
=======
            var sampleClient = new ConversationAnalysisAuthoringClient(sampleEndpoint, sampleCredential);

            #region Snippet:Sample17_ConversationsAuthoring_GetAssignProjectResourcesStatusAsync
            string sampleProjectName = "{projectName}";
            ConversationAuthoringProject sampleProjectClient = sampleClient.GetProject(sampleProjectName);

>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            // Build resource metadata
            var sampleResourceMetadata = new ConversationAuthoringResourceMetadata(
                azureResourceId: "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}",
                customDomain: "{customDomain}",
                region: "{region}"
            );

<<<<<<< HEAD
            var sampleAssignDetails = new ConversationAuthoringAssignDeploymentResourcesDetails(
=======
            var sampleAssignDetails = new ConversationAuthoringAssignProjectResourcesDetails(
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                new List<ConversationAuthoringResourceMetadata> { sampleResourceMetadata }
            );

            // Submit assignment operation
<<<<<<< HEAD
            Operation sampleAssignOperation = await client.AssignProjectResourcesAsync(
                WaitUntil.Started,
                sampleProjectName,
                sampleAssignDetails
=======
            Operation sampleAssignOperation = await sampleProjectClient.AssignProjectResourcesAsync(
                waitUntil: WaitUntil.Started,
                details: sampleAssignDetails
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            string sampleOperationLocation = sampleAssignOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location)
                ? location
                : throw new InvalidOperationException("Operation-Location header not found.");

            // Extract only the jobId part from the URL
            string sampleJobId = new Uri(location).Segments.Last().Split('?')[0];
            Console.WriteLine($"Job ID: {sampleJobId}");

            // Call status API
<<<<<<< HEAD
            Response<ConversationAuthoringDeploymentResourcesState> sampleStatusResponse = await client.GetAssignProjectResourcesStatusAsync(sampleProjectName, sampleJobId);
=======
            Response<ConversationAuthoringProjectResourcesState> sampleStatusResponse = await sampleProjectClient.GetAssignProjectResourcesStatusAsync(sampleJobId);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            Assert.IsNotNull(sampleStatusResponse);
            Console.WriteLine($"Deployment assignment status: {sampleStatusResponse.Value.Status}");
            #endregion
        }
    }
}
