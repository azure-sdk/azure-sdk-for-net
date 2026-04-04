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
    public partial class Sample19_ConversationsAuthoring_GetUnassignProjectResourcesStatus : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void GetUnassignProjectResourcesStatus()
        {
            Uri sampleEndpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential sampleCredential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(sampleEndpoint, sampleCredential);

            #region Snippet:Sample19_ConversationsAuthoring_GetUnassignProjectResourcesStatus
            string sampleProjectName = "{projectName}";
            // Define assigned resource ID to be unassigned
            var sampleUnassignIds = new ConversationAuthoringDeleteDeploymentDetails
            {
                AssignedResourceIds =
=======
            var sampleClient = new ConversationAnalysisAuthoringClient(sampleEndpoint, sampleCredential);

            #region Snippet:Sample19_ConversationsAuthoring_GetUnassignProjectResourcesStatus
            string sampleProjectName = "{projectName}";
            ConversationAuthoringProject sampleProjectClient = sampleClient.GetProject(sampleProjectName);

            // Define assigned resource ID to be unassigned
            var sampleUnassignIds = new ConversationAuthoringProjectResourceIds
            {
                AzureResourceIds =
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                {
                    "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}"
                }
            };

            // Start the unassign operation
<<<<<<< HEAD
            Operation sampleUnassignOperation = client.UnassignProjectResources(
                WaitUntil.Started,
                sampleProjectName,
                sampleUnassignIds
=======
            Operation sampleUnassignOperation = sampleProjectClient.UnassignProjectResources(
                waitUntil: WaitUntil.Started,
                details: sampleUnassignIds
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            Console.WriteLine($"UnassignProjectResources initiated. Status: {sampleUnassignOperation.GetRawResponse().Status}");

            // Extract jobId from Operation-Location
            string sampleJobId = sampleUnassignOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location)
                ? new Uri(location).Segments.Last().Split('?')[0]
                : throw new InvalidOperationException("Operation-Location header not found.");

            Console.WriteLine($"Job ID: {sampleJobId}");

            // Call the API to get unassign job status
<<<<<<< HEAD
            Response<ConversationAuthoringDeploymentResourcesState> sampleStatusResponse =
                client.GetUnassignProjectResourcesStatus(sampleProjectName, sampleJobId);
=======
            Response<ConversationAuthoringProjectResourcesState> sampleStatusResponse =
                sampleProjectClient.GetUnassignProjectResourcesStatus(sampleJobId);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            Console.WriteLine($"Job Status: {sampleStatusResponse.Value.Status}");

            if (sampleStatusResponse.Value.Errors != null && sampleStatusResponse.Value.Errors.Any())
            {
                Console.WriteLine("Errors:");
                foreach (var sampleError in sampleStatusResponse.Value.Errors)
                {
                    Console.WriteLine($"- Code: {sampleError.Code}, Message: {sampleError.Message}");
                }
            }
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task GetUnassignProjectResourcesStatusAsync()
        {
            Uri sampleEndpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential sampleCredential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(sampleEndpoint, sampleCredential);

            #region Snippet:Sample19_ConversationsAuthoring_GetUnassignProjectResourcesStatusAsync
            string sampleProjectName = "{projectName}";
            // Define assigned resource ID to be unassigned
            var sampleUnassignIds = new ConversationAuthoringDeleteDeploymentDetails
            {
                AssignedResourceIds =
=======
            var sampleClient = new ConversationAnalysisAuthoringClient(sampleEndpoint, sampleCredential);

            #region Snippet:Sample19_ConversationsAuthoring_GetUnassignProjectResourcesStatusAsync
            string sampleProjectName = "{projectName}";
            ConversationAuthoringProject sampleProjectClient = sampleClient.GetProject(sampleProjectName);

            // Define assigned resource ID to be unassigned
            var sampleUnassignIds = new ConversationAuthoringProjectResourceIds
            {
                AzureResourceIds =
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                {
                    "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}"
                }
            };

            // Start the unassign operation
<<<<<<< HEAD
            Operation sampleUnassignOperation = await client.UnassignProjectResourcesAsync(
                WaitUntil.Started,
                sampleProjectName,
                sampleUnassignIds
=======
            Operation sampleUnassignOperation = await sampleProjectClient.UnassignProjectResourcesAsync(
                waitUntil: WaitUntil.Started,
                details: sampleUnassignIds
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            Console.WriteLine($"UnassignProjectResourcesAsync initiated. Status: {sampleUnassignOperation.GetRawResponse().Status}");

            // Extract jobId from Operation-Location
            string sampleJobId = sampleUnassignOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location)
                ? new Uri(location).Segments.Last().Split('?')[0]
                : throw new InvalidOperationException("Operation-Location header not found.");

            Console.WriteLine($"Job ID: {sampleJobId}");

            // Call the API to get unassign job status
<<<<<<< HEAD
            Response<ConversationAuthoringDeploymentResourcesState> sampleStatusResponse =
                await client.GetUnassignProjectResourcesStatusAsync(sampleProjectName, sampleJobId);
=======
            Response<ConversationAuthoringProjectResourcesState> sampleStatusResponse =
                await sampleProjectClient.GetUnassignProjectResourcesStatusAsync(sampleJobId);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            Console.WriteLine($"Job Status: {sampleStatusResponse.Value.Status}");

            if (sampleStatusResponse.Value.Errors != null && sampleStatusResponse.Value.Errors.Any())
            {
                Console.WriteLine("Errors:");
                foreach (var sampleError in sampleStatusResponse.Value.Errors)
                {
                    Console.WriteLine($"- Code: {sampleError.Code}, Message: {sampleError.Message}");
                }
            }
            #endregion
        }
    }
}
