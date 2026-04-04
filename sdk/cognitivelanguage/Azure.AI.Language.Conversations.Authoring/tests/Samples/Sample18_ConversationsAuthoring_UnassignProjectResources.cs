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
    public partial class Sample18_ConversationsAuthoring_UnassignProjectResources : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void UnassignProjectResources()
        {
            Uri sampleEndpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential sampleCredential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(sampleEndpoint, sampleCredential);
=======
            var sampleClient = new ConversationAnalysisAuthoringClient(sampleEndpoint, sampleCredential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample18_ConversationsAuthoring_UnassignProjectResources
            // Set project name and create client for the project
            string sampleProjectName = "{projectName}";
<<<<<<< HEAD
            // Define assigned resource ID to be unassigned
            var sampleUnassignIds = new ConversationAuthoringDeleteDeploymentDetails
            {
                AssignedResourceIds =
=======
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

            // Start the operation
<<<<<<< HEAD
            Operation sampleOperation = client.UnassignProjectResources(
                WaitUntil.Started,
                sampleProjectName,
                sampleUnassignIds
=======
            Operation sampleOperation = sampleProjectClient.UnassignProjectResources(
                waitUntil: WaitUntil.Started,
                details: sampleUnassignIds
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            Console.WriteLine($"UnassignProjectResources initiated. Status: {sampleOperation.GetRawResponse().Status}");

            // Print jobId from Operation-Location
            if (sampleOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location))
            {
                string sampleJobId = new Uri(location).Segments.Last().Split('?')[0];
                Console.WriteLine($"Job ID: {sampleJobId}");
            }
            else
            {
                Console.WriteLine("Operation-Location header not found.");
            }
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task UnassignProjectResourcesAsync()
        {
            Uri sampleEndpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential sampleCredential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(sampleEndpoint, sampleCredential);
=======
            var sampleClient = new ConversationAnalysisAuthoringClient(sampleEndpoint, sampleCredential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample18_ConversationsAuthoring_UnassignProjectResourcesAsync
            // Set project name and create client for the project
            string sampleProjectName = "{projectName}";
<<<<<<< HEAD
            // Define assigned resource ID to be unassigned
            var sampleUnassignIds = new ConversationAuthoringDeleteDeploymentDetails
            {
                AssignedResourceIds =
=======
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

            // Call the operation
<<<<<<< HEAD
            Operation sampleOperation = await client.UnassignProjectResourcesAsync(
                WaitUntil.Started,
                sampleProjectName,
                sampleUnassignIds
=======
            Operation sampleOperation = await sampleProjectClient.UnassignProjectResourcesAsync(
                waitUntil: WaitUntil.Started,
                details: sampleUnassignIds
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            Console.WriteLine($"UnassignProjectResourcesAsync initiated. Status: {sampleOperation.GetRawResponse().Status}");

            // Print jobId from Operation-Location
            if (sampleOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location))
            {
                string sampleJobId = new Uri(location).Segments.Last().Split('?')[0];
                Console.WriteLine($"Job ID: {sampleJobId}");
            }
            else
            {
                Console.WriteLine("Operation-Location header not found.");
            }
            #endregion
        }
    }
}
