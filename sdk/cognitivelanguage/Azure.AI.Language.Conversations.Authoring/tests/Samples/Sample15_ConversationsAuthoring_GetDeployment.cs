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
    public partial class Sample15_ConversationsAuthoring_GetDeployment : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void GetDeployment()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample15_ConversationsAuthoring_GetDeployment
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
<<<<<<< HEAD
            Response<ConversationAuthoringProjectDeployment> response = client.GetDeployment(projectName, deploymentName);
=======

            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            Response<ConversationAuthoringProjectDeployment> response = deploymentClient.GetDeployment();
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            ConversationAuthoringProjectDeployment deployment = response.Value;

            Console.WriteLine($"Deployment Name: {deployment.DeploymentName}");
            Console.WriteLine($"Model Id: {deployment.ModelId}");
            Console.WriteLine($"Last Trained On: {deployment.LastTrainedOn}");
            Console.WriteLine($"Last Deployed On: {deployment.LastDeployedOn}");
            Console.WriteLine($"Deployment Expired On: {deployment.DeploymentExpiredOn}");
            Console.WriteLine($"Model Training Config Version: {deployment.ModelTrainingConfigVersion}");

            // Print assigned resources info
            if (deployment.AssignedResources != null)
            {
                foreach (var assignedResource in deployment.AssignedResources)
                {
                    Console.WriteLine($"Resource ID: {assignedResource.ResourceId}");
                    Console.WriteLine($"Region: {assignedResource.Region}");
<<<<<<< HEAD
=======

                    if (assignedResource.AssignedAoaiResource != null)
                    {
                        Console.WriteLine($"AOAI Kind: {assignedResource.AssignedAoaiResource.Kind}");
                        Console.WriteLine($"AOAI Resource ID: {assignedResource.AssignedAoaiResource.ResourceId}");
                        Console.WriteLine($"AOAI Deployment Name: {assignedResource.AssignedAoaiResource.DeploymentName}");
                    }
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                }
            }
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task GetDeploymentAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new AzureKeyCredential(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample15_ConversationsAuthoring_GetDeploymentAsync
            string projectName = "{projectName}";
            string deploymentName = "{deploymentName}";
<<<<<<< HEAD
            Response<ConversationAuthoringProjectDeployment> response = await client.GetDeploymentAsync(projectName, deploymentName);
=======

            ConversationAuthoringDeployment deploymentClient = client.GetDeployment(projectName, deploymentName);

            Response<ConversationAuthoringProjectDeployment> response = await deploymentClient.GetDeploymentAsync();
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            ConversationAuthoringProjectDeployment deployment = response.Value;

            Console.WriteLine($"Deployment Name: {deployment.DeploymentName}");
            Console.WriteLine($"Model Id: {deployment.ModelId}");
            Console.WriteLine($"Last Trained On: {deployment.LastTrainedOn}");
            Console.WriteLine($"Last Deployed On: {deployment.LastDeployedOn}");
            Console.WriteLine($"Deployment Expired On: {deployment.DeploymentExpiredOn}");
            Console.WriteLine($"Model Training Config Version: {deployment.ModelTrainingConfigVersion}");

            // Print assigned resources info
            if (deployment.AssignedResources != null)
            {
                foreach (var assignedResource in deployment.AssignedResources)
                {
                    Console.WriteLine($"Resource ID: {assignedResource.ResourceId}");
                    Console.WriteLine($"Region: {assignedResource.Region}");
<<<<<<< HEAD
=======

                    if (assignedResource.AssignedAoaiResource != null)
                    {
                        Console.WriteLine($"AOAI Kind: {assignedResource.AssignedAoaiResource.Kind}");
                        Console.WriteLine($"AOAI Resource ID: {assignedResource.AssignedAoaiResource.ResourceId}");
                        Console.WriteLine($"AOAI Deployment Name: {assignedResource.AssignedAoaiResource.DeploymentName}");
                    }
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
                }
            }
            #endregion
        }
    }
}
