<<<<<<< HEAD
// Copyright (c) Microsoft Corporation. All rights reserved.
=======
﻿// Copyright (c) Microsoft Corporation. All rights reserved.
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Language.Conversations.Authoring;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Authoring.Tests.Samples
{
    public partial class Sample14_ConversationsAuthoring_DeployProject : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void DeployProject()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample14_ConversationsAuthoring_DeployProject
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
<<<<<<< HEAD
            ConversationAuthoringCreateDeploymentDetails trainedModeDetails = new ConversationAuthoringCreateDeploymentDetails("m1");

            Operation operation = client.DeployProject(
                WaitUntil.Completed,
                projectName,
                deploymentName,
=======

            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            ConversationAuthoringCreateDeploymentDetails trainedModeDetails = new ConversationAuthoringCreateDeploymentDetails("m1");

            Operation operation = deploymentClient.DeployProject(
                waitUntil: WaitUntil.Completed,
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                trainedModeDetails
            );

            // Extract operation-location from response headers
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location) ? location : "Not found";
            Console.WriteLine($"Delete operation-location: {operationLocation}");
            Console.WriteLine($"Delete operation completed with status: {operation.GetRawResponse().Status}");
            #endregion
        }

        [Test]
        [SyncOnly]
        public void DeployProject_WithAssignedResources()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample14_ConversationsAuthoring_DeployProjectWithAssignedResources
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";

            // Create AOAI resource reference
            AnalyzeConversationAuthoringDataGenerationConnectionInfo assignedAoaiResource =
                new AnalyzeConversationAuthoringDataGenerationConnectionInfo(
                    AnalyzeConversationAuthoringDataGenerationConnectionKind.AzureOpenAI,
                    deploymentName: "gpt-4o")
                {
                    ResourceId = "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}"
                };

            // Create Cognitive Services resource with AOAI linkage
<<<<<<< HEAD
            ConversationAuthoringDeploymentResource assignedResource =
                new ConversationAuthoringDeploymentResource(
=======
            ConversationAuthoringAssignedProjectResource assignedResource =
                new ConversationAuthoringAssignedProjectResource(
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                    resourceId: "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}",
                    region: "{region}")
                {
                    AssignedAoaiResource = assignedAoaiResource
                };

            // Set up deployment details with assigned resources
            ConversationAuthoringCreateDeploymentDetails deploymentDetails =
                new ConversationAuthoringCreateDeploymentDetails("ModelWithDG");
<<<<<<< HEAD
            deploymentDetails.AssignedResources.Add(assignedResource);
            // Start deployment
            Operation operation = client.DeployProject(WaitUntil.Started, projectName, deploymentName, deploymentDetails);
=======
            deploymentDetails.AzureResourceIds.Add(assignedResource);

            // Get deployment client
            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            // Start deployment
            Operation operation = deploymentClient.DeployProject(WaitUntil.Started, deploymentDetails);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            // Output result
            Console.WriteLine($"Deployment started with status: {operation.GetRawResponse().Status}");

            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location)
                ? location : "Not found";
            Console.WriteLine($"Operation-Location header: {operationLocation}");
            #endregion
        }

        [Test]
        [SyncOnly]
        public void DeployProject_WithAssignedResources_20251101()
        {
            #region Snippet:Sample14_ConversationsAuthoring_DeployProjectWithAssignedResources_20251101
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);

            // Use the 2025-11-01 GA version of the service
            ConversationAnalysisAuthoringClientOptions options = new ConversationAnalysisAuthoringClientOptions(ConversationAnalysisAuthoringClientOptions.ServiceVersion.V2025_11_01);

<<<<<<< HEAD
            ConversationAnalysisAuthoring client =
                new ConversationAnalysisAuthoring(endpoint, credential, options);
=======
            ConversationAnalysisAuthoringClient client =
                new ConversationAnalysisAuthoringClient(endpoint, credential, options);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";

<<<<<<< HEAD
            // Set up deployment details
            ConversationAuthoringCreateDeploymentDetails deploymentDetails =
                new ConversationAuthoringCreateDeploymentDetails("ModelWithDG");
            // Start deployment
            Operation operation = client.DeployProject(WaitUntil.Started, projectName, deploymentName, deploymentDetails);
=======
            // For 2025-11-01, the service expects azureResourceIds as an array of strings.
            List<string> azureResourceIds = new List<string>
    {
        "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}"
    };

            // Set up deployment details with resource ID strings
            ConversationAuthoringCreateDeploymentDetails deploymentDetails =
                new ConversationAuthoringCreateDeploymentDetails("ModelWithDG", azureResourceIds);

            // Get deployment client
            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            // Start deployment
            Operation operation = deploymentClient.DeployProject(WaitUntil.Started, deploymentDetails);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            #endregion

            // Output result
            Console.WriteLine($"Deployment started with status: {operation.GetRawResponse().Status}");

            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location)
                ? location : "Not found";
            Console.WriteLine($"Operation-Location header: {operationLocation}");
        }

        [Test]
        [AsyncOnly]
        public async Task DeployProjectAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample14_ConversationsAuthoring_DeployProjectAsync
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
<<<<<<< HEAD
            ConversationAuthoringCreateDeploymentDetails trainedModeDetails = new ConversationAuthoringCreateDeploymentDetails("m1");

            Operation operation = await client.DeployProjectAsync(
                WaitUntil.Completed,
                projectName,
                deploymentName,
=======

            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            ConversationAuthoringCreateDeploymentDetails trainedModeDetails = new ConversationAuthoringCreateDeploymentDetails("m1");

            Operation operation = await deploymentClient.DeployProjectAsync(
                waitUntil: WaitUntil.Completed,
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                trainedModeDetails
            );

            // Extract operation-location from response headers
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location) ? location : "Not found";
            Console.WriteLine($"Delete operation-location: {operationLocation}");
            Console.WriteLine($"Delete operation completed with status: {operation.GetRawResponse().Status}");
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task DeployProjectAsync_WithAssignedResources()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample14_ConversationsAuthoring_DeployProjectAsyncWithAssignedResources
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";

            // Create AOAI resource reference
            AnalyzeConversationAuthoringDataGenerationConnectionInfo assignedAoaiResource =
                new AnalyzeConversationAuthoringDataGenerationConnectionInfo(
                    AnalyzeConversationAuthoringDataGenerationConnectionKind.AzureOpenAI,
                    deploymentName: "gpt-4o")
                {
                    ResourceId = "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}"
                };

            // Create Cognitive Services resource with AOAI linkage
<<<<<<< HEAD
            ConversationAuthoringDeploymentResource assignedResource =
                new ConversationAuthoringDeploymentResource(
=======
            ConversationAuthoringAssignedProjectResource assignedResource =
                new ConversationAuthoringAssignedProjectResource(
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                    resourceId: "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}",
                    region: "{region}")
                {
                    AssignedAoaiResource = assignedAoaiResource
                };

            // Set up deployment details with assigned resources
            ConversationAuthoringCreateDeploymentDetails deploymentDetails =
                new ConversationAuthoringCreateDeploymentDetails("ModelWithDG");
<<<<<<< HEAD
            deploymentDetails.AssignedResources.Add(assignedResource);
            // Start deployment
            Operation operation = await client.DeployProjectAsync(WaitUntil.Started, projectName, deploymentName, deploymentDetails);
=======
            deploymentDetails.AzureResourceIds.Add(assignedResource);

            // Get deployment client
            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            // Start deployment
            Operation operation = await deploymentClient.DeployProjectAsync(WaitUntil.Started, deploymentDetails);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            // Output result
            Console.WriteLine($"Deployment started with status: {operation.GetRawResponse().Status}");

            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location)
                ? location : "Not found";
            Console.WriteLine($"Operation-Location header: {operationLocation}");
            #endregion
        }

        public async Task DeployProjectAsync_WithAssignedResources_20251101()
        {
            #region Snippet:Sample14_ConversationsAuthoring_DeployProjectAsyncWithAssignedResources_20251101
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);

            // Use the 2025-11-01 GA version of the service
            ConversationAnalysisAuthoringClientOptions options = new ConversationAnalysisAuthoringClientOptions(ConversationAnalysisAuthoringClientOptions.ServiceVersion.V2025_11_01);

<<<<<<< HEAD
            ConversationAnalysisAuthoring client =
                new ConversationAnalysisAuthoring(endpoint, credential, options);
=======
            ConversationAnalysisAuthoringClient client =
                new ConversationAnalysisAuthoringClient(endpoint, credential, options);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";

<<<<<<< HEAD
            // Set up deployment details
            ConversationAuthoringCreateDeploymentDetails deploymentDetails =
                new ConversationAuthoringCreateDeploymentDetails("ModelWithDG");
            // Start deployment asynchronously
            Operation operation = await client.DeployProjectAsync(WaitUntil.Started, projectName, deploymentName, deploymentDetails);
=======
            // For 2025-11-01, the service expects azureResourceIds as an array of strings.
            List<string> azureResourceIds = new List<string>
    {
        "/subscriptions/{subscription}/resourceGroups/{resourcegroup}/providers/Microsoft.CognitiveServices/accounts/{sampleAccount}"
    };

            // Set up deployment details with resource ID strings
            ConversationAuthoringCreateDeploymentDetails deploymentDetails =
                new ConversationAuthoringCreateDeploymentDetails("ModelWithDG", azureResourceIds);

            // Get deployment client
            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            // Start deployment asynchronously
            Operation operation = await deploymentClient.DeployProjectAsync(WaitUntil.Started, deploymentDetails);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
            #endregion
            // Output result
            Console.WriteLine($"Deployment started with status: {operation.GetRawResponse().Status}");

            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location)
                ? location : "Not found";
            Console.WriteLine($"Operation-Location header: {operationLocation}");
        }
    }
}
