// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;
using System.Linq;

namespace Azure.AI.Language.Documents
{
    [CodeGenModel("AnalyzeDocumentsClient")]

    public partial class DocumentAnalysisClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAnalysisClient"/> class.
        /// </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt;resource-name&gt;.cognitiveservices.azure.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DocumentAnalysisClient(Uri endpoint, TokenCredential credential, DocumentAnalysisClientOptions options = default)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new DocumentAnalysisClientOptions();

            var authorizationScope = $"{(string.IsNullOrEmpty(options.Audience?.ToString()) ? DocumentsAudience.AzurePublicCloud : options.Audience)}/.default";

            _tokenCredential = credential;

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(credential, authorizationScope) }, Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Submit a collection of text documents for analysis and get the results. Specify one or more unique tasks to be executed as a long-running operation. </summary>
        /// <param name="documentsInput"> Contains the documents to be analyzed. </param>
        /// <param name="actions"> List of tasks to be performed as part of the LRO. </param>
        /// <param name="displayName"> Name for the task. </param>
        /// <param name="defaultLanguage"> Default language to use for records requesting automatic language detection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documentsInput"/> or <paramref name="actions"/> is null. </exception>
        public virtual Response<AnalyzeDocumentsOperationState> AnalyzeDocumentsOperation(MultiLanguageDocumentInput documentsInput, IEnumerable<AnalyzeDocumentsOperationAction> actions, string displayName = null, string defaultLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(documentsInput, nameof(documentsInput));
            Argument.AssertNotNull(actions, nameof(actions));

            string scopeName = $"{nameof(DocumentAnalysisClient)}.{nameof(AnalyzeDocumentsOperation)}";
            using var scope = ClientDiagnostics.CreateScope(scopeName);
            scope.Start();

            var analyzeDocumentsInput = new AnalyzeDocumentsOperationInput(displayName, documentsInput, actions.ToList(), defaultLanguage, null);
            RequestContext context = FromCancellationToken(cancellationToken);

            try
            {
                using HttpMessage message = CreateAnalyzeDocumentsSubmitOperationRequest(analyzeDocumentsInput.ToRequestContent(), context);
                var operation = ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, scopeName, OperationFinalStateVia.OperationLocation, context, WaitUntil.Completed);
                Response response = operation.GetRawResponse();
                return Response.FromValue(AnalyzeDocumentsOperationState.FromResponse(response), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a collection of documents for analysis and get the results. Specify one or more unique tasks to be executed as a long-running operation. </summary>
        /// <param name="documentsInput"> Contains the input to be analyzed. </param>
        /// <param name="actions"> List of tasks to be performed as part of the LRO. </param>
        /// <param name="displayName"> Name for the task. </param>
        /// <param name="defaultLanguage"> Default language to use for records requesting automatic language detection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documentsInput"/> or <paramref name="actions"/> is null. </exception>
        public virtual async Task<Response<AnalyzeDocumentsOperationState>> AnalyzeDocumentsOperationAsync(MultiLanguageDocumentInput documentsInput, IEnumerable<AnalyzeDocumentsOperationAction> actions, string displayName = null, string defaultLanguage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(documentsInput, nameof(documentsInput));
            Argument.AssertNotNull(actions, nameof(actions));

            string scopeName = $"{nameof(DocumentAnalysisClient)}.{nameof(AnalyzeDocumentsOperation)}";
            using var scope = ClientDiagnostics.CreateScope(scopeName);
            scope.Start();

            var analyzeDocumentsInput = new AnalyzeDocumentsOperationInput(displayName, documentsInput, actions.ToList(), defaultLanguage, null);
            RequestContext context = FromCancellationToken(cancellationToken);

            try
            {
                using HttpMessage message = CreateAnalyzeDocumentsSubmitOperationRequest(analyzeDocumentsInput.ToRequestContent(), context);
                var operation = await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, scopeName, OperationFinalStateVia.OperationLocation, context, WaitUntil.Completed).ConfigureAwait(false);
                Response response = operation.GetRawResponse();
                return Response.FromValue(AnalyzeDocumentsOperationState.FromResponse(response), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
