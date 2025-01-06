// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Documents.Tests
{
    public class DocumentAnalysisClientLiveTest : DocumentAnalysisTestBase
    {
        public DocumentAnalysisClientLiveTest(bool isAsync, DocumentAnalysisClientOptions.ServiceVersion serviceVersion)
            : base(isAsync, serviceVersion, null /* RecordedTestMode.Record /* to record */)
        {
        }

        [Test]
        [ServiceVersion(Min = DocumentAnalysisClientOptions.ServiceVersion.V2024_11_15_Preview)]
        public async Task AnalyzeText_PiiEntityDetectionLROTaskAsync()
        {
            MultiLanguageDocumentInput multiLanguageTextInput = new MultiLanguageDocumentInput()
            {
                Documents =
                {
                    new MultiLanguageInput("A", new AzureBlobDocumentLocation("<bloburl>"), new AzureBlobDocumentLocation("<targeturl>"))
                    {
                        Language = "en"
                    },
                }
            };

            var operationActions = new AnalyzeDocumentsOperationAction[]
            {
                new PiiEntityRecognitionOperationAction
                {
                    Name = "PiiEntityDetectionTaskSample",
                },
            };

            Response<AnalyzeDocumentsOperationState> response = await client.AnalyzeDocumentsOperationAsync(multiLanguageTextInput, operationActions);

            AnalyzeDocumentsOperationState analyzeDocumentsOperationState = response.Value;
            Assert.IsNotNull(response);
            Assert.IsNotNull(analyzeDocumentsOperationState);
            Assert.IsNotNull(analyzeDocumentsOperationState.Actions);
            Assert.IsNotNull(analyzeDocumentsOperationState.Actions.Items);

            foreach (AnalyzeDocumentsOperationResult analyzeOperationResult in analyzeDocumentsOperationState.Actions.Items)
            {
                if (analyzeOperationResult is PiiEntityRecognitionOperationResult piiEntityRecognitionOperationResult)
                {
                    Assert.IsNotNull(piiEntityRecognitionOperationResult);
                    Assert.IsNotNull(piiEntityRecognitionOperationResult.Results);
                    Assert.IsNotNull(piiEntityRecognitionOperationResult.Results.Documents);

                    foreach (DocumentAnalysisDocumentResult responseDocument in piiEntityRecognitionOperationResult.Results.Documents)
                    {
                        Assert.IsNotNull(responseDocument.Id);
                        Assert.IsNotNull(responseDocument.Target);
                        foreach (AzureBlobDocumentLocation document in responseDocument.Target)
                        {
                            Assert.IsNotNull(document.Location);
                        }
                    }
                }
            }
        }

        [Test]
        [ServiceVersion(Min = DocumentAnalysisClientOptions.ServiceVersion.V2024_11_15_Preview)]
        public async Task AnalyzeText_AbstractiveSummarizationLROTaskAsync()
        {
            MultiLanguageDocumentInput multiLanguageTextInput = new MultiLanguageDocumentInput()
            {
                Documents =
                {
                    new MultiLanguageInput("A", new AzureBlobDocumentLocation("<bloburl>"), new AzureBlobDocumentLocation("<targeturl>"))
                    {
                        Language = "en"
                    },
                }
            };

            var operationActions = new AnalyzeDocumentsOperationAction[]
            {
                new AbstractiveSummarizationOperationAction
                {
                    Name = "AbstractiveSummarizationOperationActionSample",
                },
            };

            Response<AnalyzeDocumentsOperationState> response = await client.AnalyzeDocumentsOperationAsync(multiLanguageTextInput, operationActions);

            AnalyzeDocumentsOperationState analyzeDocumentsOperationState = response.Value;
            Assert.IsNotNull(response);
            Assert.IsNotNull(analyzeDocumentsOperationState);
            Assert.IsNotNull(analyzeDocumentsOperationState.Actions);
            Assert.IsNotNull(analyzeDocumentsOperationState.Actions.Items);

            foreach (AnalyzeDocumentsOperationResult analyzeTextOperationResult in analyzeDocumentsOperationState.Actions.Items)
            {
                if (analyzeTextOperationResult is AbstractiveSummarizationOperationResult summarizationResult)
                {
                    Assert.IsNotNull(summarizationResult);
                    Assert.IsNotNull(summarizationResult.Results);
                    Assert.IsNotNull(summarizationResult.Results.Documents);

                    foreach (DocumentAnalysisDocumentResult summaryDocument in summarizationResult.Results.Documents)
                    {
                        Assert.IsNotNull(summaryDocument.Id);
                        Assert.IsNotNull(summaryDocument.Target);
                        foreach (AzureBlobDocumentLocation document in summaryDocument.Target)
                        {
                            Assert.IsNotNull(document.Location);
                        }
                    }
                }
            }
        }

        [Test]
        [ServiceVersion(Min = DocumentAnalysisClientOptions.ServiceVersion.V2024_11_15_Preview)]
        public async Task AnalyzeText_ExtractiveSummarizationLROTaskAsync()
        {
            MultiLanguageDocumentInput multiLanguageTextInput = new MultiLanguageDocumentInput()
            {
                Documents =
                {
                    new MultiLanguageInput("A", new AzureBlobDocumentLocation("<bloburl>"), new AzureBlobDocumentLocation("<targeturl>"))
                    {
                        Language = "en"
                    },
                }
            };

            var operationActions = new AnalyzeDocumentsOperationAction[]
            {
                new ExtractiveSummarizationOperationAction
                {
                    Name = "ExtractiveSummarizationOperationActionSample",
                },
            };

            Response<AnalyzeDocumentsOperationState> response = await client.AnalyzeDocumentsOperationAsync(multiLanguageTextInput, operationActions);

            AnalyzeDocumentsOperationState analyzeDocumentsOperationState = response.Value;
            Assert.IsNotNull(response);
            Assert.IsNotNull(analyzeDocumentsOperationState);
            Assert.IsNotNull(analyzeDocumentsOperationState.Actions);
            Assert.IsNotNull(analyzeDocumentsOperationState.Actions.Items);

            foreach (AnalyzeDocumentsOperationResult analyzeTextOperationResult in analyzeDocumentsOperationState.Actions.Items)
            {
                if (analyzeTextOperationResult is ExtractiveSummarizationOperationResult extractiveSummarizationLROResult)
                {
                    Assert.IsNotNull(extractiveSummarizationLROResult);
                    Assert.IsNotNull(extractiveSummarizationLROResult.Results);
                    Assert.IsNotNull(extractiveSummarizationLROResult.Results.Documents);

                    foreach (DocumentAnalysisDocumentResult extractedSummaryDocument in extractiveSummarizationLROResult.Results.Documents)
                    {
                        Assert.IsNotNull(extractedSummaryDocument.Id);
                        Assert.IsNotNull(extractedSummaryDocument.Target);
                        foreach (AzureBlobDocumentLocation document in extractedSummaryDocument.Target)
                        {
                            Assert.IsNotNull(document.Location);
                        }
                    }
                }
            }
        }
    }
}
