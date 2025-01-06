// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
#region Snippet:DocumentAnalysisClient_Namespace
using Azure.AI.Language.Documents;
#endregion
using Azure.AI.Language.Documents.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;
using System.Collections.Generic;
#region Snippet:Documents_Identity_Namespace
using Azure.Identity;
#endregion

namespace Azure.AI.Language.Documents.Tests.Samples
{
    public partial class CreateClient : SamplesBase<DocumentAnalysisClientTestEnvironment>
    {
        [Test]
        public void CreateDocumentAnalysisClientForSpecificApiVersion()
        {
            #region Snippet:CreateDocumentAnalysisClientForSpecificApiVersion
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
            AzureKeyCredential credential = new("your apikey");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
            credential = new(TestEnvironment.ApiKey);
#endif
            DocumentAnalysisClientOptions options = new DocumentAnalysisClientOptions(DocumentAnalysisClientOptions.ServiceVersion.V2024_11_15_Preview);
            var client = new DocumentAnalysisClient(endpoint, credential, options);
            #endregion
        }

        [Test]
        public void CreateTextClient()
        {
            #region Snippet:CreateDocumentAnalysisClient
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
            AzureKeyCredential credential = new("your apikey");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
            credential = new(TestEnvironment.ApiKey);
#endif
            DocumentAnalysisClient client = new DocumentAnalysisClient(endpoint, credential);
            #endregion
        }

        [Test]
        public void DocumentAnalysisClient_CreateWithDefaultAzureCredential()
        {
            #region Snippet:DocumentAnalysisClient_CreateWithDefaultAzureCredential
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
#endif
            DefaultAzureCredential credential = new DefaultAzureCredential();
            DocumentAnalysisClient client = new DocumentAnalysisClient(endpoint, credential);
            #endregion
        }

        [Test]
        public void BadArgument()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
            DocumentAnalysisClient client = new DocumentAnalysisClient(endpoint, credential);

            #region Snippet:DocumentAnalysisClient_BadRequest
            try
            {
                var body = new MultiLanguageDocumentInput()
                {
                    Documents =
                            {
                                new MultiLanguageInput("D", null, null),
                            }
                };

                var actions = new List<AnalyzeDocumentsOperationAction>()
                {
                    new PiiEntityRecognitionOperationAction()
                    {
                        Parameters = new PiiActionContent()
                        {
                            ModelVersion = "NotValid", // Invalid model version will is a bad request.
                        },
                    },
                };

                var response = client.AnalyzeDocumentsOperation(body, actions);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
