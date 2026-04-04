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
    public partial class Sample16_ConversationsAuthoring_AssignProjectResources : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void AssignProjectResources()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential credential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample16_ConversationsAuthoring_AssignProjectResources
            // Arrange
            string sampleProjectName = "{projectName}";
<<<<<<< HEAD
=======
            ConversationAuthoringProject sampleProjectClient = client.GetProject(sampleProjectName);

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

            // Act
<<<<<<< HEAD
            Operation sampleOperation = client.AssignProjectResources(
                WaitUntil.Started,
                sampleProjectName,
                sampleAssignDetails
=======
            Operation sampleOperation = sampleProjectClient.AssignProjectResources(
                waitUntil: WaitUntil.Started,
                details: sampleAssignDetails
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            // Output operation details
            Console.WriteLine("Operation started successfully.");
            Console.WriteLine($"Operation Status: {sampleOperation.GetRawResponse().Status}");

            // Extract and print jobId from Operation-Location header
            string sampleOperationLocation = sampleOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location)
                ? location
                : null;

            if (!string.IsNullOrEmpty(sampleOperationLocation))
            {
                string sampleJobId = new Uri(sampleOperationLocation).Segments.Last().Split('?')[0];
                Console.WriteLine($"Operation-Location: {sampleOperationLocation}");
                Console.WriteLine($"Job ID: {sampleJobId}");
            }
            else
            {
                Console.WriteLine("Operation-Location header is null or empty.");
            }
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task AssignProjectResourcesAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            DefaultAzureCredential credential = new DefaultAzureCredential();
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample16_ConversationsAuthoring_AssignProjectResourcesAsync
            // Arrange
            string sampleProjectName = "{projectName}";
<<<<<<< HEAD
=======
            ConversationAuthoringProject sampleProjectClient = client.GetProject(sampleProjectName);

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

            // Act
<<<<<<< HEAD
            Operation sampleOperation = await client.AssignProjectResourcesAsync(
                WaitUntil.Started,
                sampleProjectName,
                sampleAssignDetails
=======
            Operation sampleOperation = await sampleProjectClient.AssignProjectResourcesAsync(
                waitUntil: WaitUntil.Started,
                details: sampleAssignDetails
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            );

            // Output operation details
            Console.WriteLine("Operation started successfully.");
            Console.WriteLine($"Operation Status: {sampleOperation.GetRawResponse().Status}");

            // Extract and print jobId from Operation-Location header
            string sampleOperationLocation = sampleOperation.GetRawResponse().Headers.TryGetValue("Operation-Location", out string location)
                ? location
                : null;

            if (!string.IsNullOrEmpty(sampleOperationLocation))
            {
                string sampleJobId = new Uri(sampleOperationLocation).Segments.Last().Split('?')[0];
                Console.WriteLine($"Operation-Location: {sampleOperationLocation}");
                Console.WriteLine($"Job ID: {sampleJobId}");
            }
            else
            {
                Console.WriteLine("Operation-Location header is null or empty.");
            }
            #endregion
        }
    }
}
