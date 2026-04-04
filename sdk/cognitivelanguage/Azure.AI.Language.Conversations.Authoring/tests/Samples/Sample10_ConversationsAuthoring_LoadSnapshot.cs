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
    public partial class Sample10_ConversationsAuthoring_LoadSnapshot : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void LoadSnapshot()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample10_ConversationsAuthoring_LoadSnapshot
            string projectName = "{projectName}";
            string trainedModelLabel = "{trainedModelLabel}";
<<<<<<< HEAD
            Operation operation = client.LoadSnapshot(WaitUntil.Completed, projectName, trainedModelLabel);
=======
            ConversationAuthoringTrainedModel trainedModelClient = client.GetTrainedModel(projectName, trainedModelLabel);

            Operation operation = trainedModelClient.LoadSnapshot(
                waitUntil: WaitUntil.Completed
            );
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            // Extract the operation-location header
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location) ? location : null;
            Console.WriteLine($"Operation Location: {operationLocation}");

            Console.WriteLine($"Snapshot loaded with operation status: {operation.GetRawResponse().Status}");
            #endregion
        }

        [Test]
        [AsyncOnly]
        public async Task LoadSnapshotAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
<<<<<<< HEAD
            ConversationAnalysisAuthoring client = new ConversationAnalysisAuthoring(endpoint, credential);
=======
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            #region Snippet:Sample10_ConversationsAuthoring_LoadSnapshotAsync
            string projectName = "{projectName}";
            string trainedModelLabel = "{trainedModelLabel}";
<<<<<<< HEAD
            Operation operation = await client.LoadSnapshotAsync(WaitUntil.Completed, projectName, trainedModelLabel);
=======
            ConversationAuthoringTrainedModel trainedModelClient = client.GetTrainedModel(projectName, trainedModelLabel);

            Operation operation = await trainedModelClient.LoadSnapshotAsync(
                waitUntil: WaitUntil.Completed);
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)

            // Extract the operation-location header
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location) ? location : null;
            Console.WriteLine($"Operation Location: {operationLocation}");

            Console.WriteLine($"Snapshot loaded with operation status: {operation.GetRawResponse().Status}");
            #endregion
        }
    }
}
