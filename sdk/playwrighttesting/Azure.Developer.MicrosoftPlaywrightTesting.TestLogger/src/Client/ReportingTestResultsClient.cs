// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Developer.MicrosoftPlaywrightTesting.TestLogger.Client
{
    // Data plane generated client.
    /// <summary> The TestResults service client. </summary>
    internal partial class ReportingTestResultsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ReportingTestResultsClient for mocking. </summary>
        protected ReportingTestResultsClient()
        {
        }

        /// <summary> Initializes a new instance of ReportingTestResultsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ReportingTestResultsClient(Uri endpoint) : this(endpoint, new TestReportingClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ReportingTestResultsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ReportingTestResultsClient(Uri endpoint, TestReportingClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new TestReportingClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary>
        /// [Protocol Method] Uploads a batch of test results to the test run
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceId"> The <see cref="string"/> to use. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="authorization"> access token. </param>
        /// <param name="xCorrelationId"> Correlation-id used for tracing and debugging. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> UploadBatchTestResultsAsync(string workspaceId, RequestContent content, string authorization = null, string xCorrelationId = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(workspaceId, nameof(workspaceId));

            using var scope = ClientDiagnostics.CreateScope("ReportingTestResultsClient.UploadBatchTestResults");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUploadBatchTestResultsRequest(workspaceId, content, authorization, xCorrelationId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Uploads a batch of test results to the test run
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceId"> The <see cref="string"/> to use. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="authorization"> access token. </param>
        /// <param name="xCorrelationId"> Correlation-id used for tracing and debugging. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response UploadBatchTestResults(string workspaceId, RequestContent content, string authorization = null, string xCorrelationId = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(workspaceId, nameof(workspaceId));

            using var scope = ClientDiagnostics.CreateScope("ReportingTestResultsClient.UploadBatchTestResults");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUploadBatchTestResultsRequest(workspaceId, content, authorization, xCorrelationId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateUploadBatchTestResultsRequest(string workspaceId, RequestContent content, string authorization, string xCorrelationId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200400500);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/workspaces/", false);
            uri.AppendPath(workspaceId, true);
            uri.AppendPath("/test-results/upload-batch", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (authorization != null)
            {
                request.Headers.Add("Authorization", authorization);
            }
            if (xCorrelationId != null)
            {
                request.Headers.Add("x-correlation-id", xCorrelationId);
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200400500;
        private static ResponseClassifier ResponseClassifier200400500 => _responseClassifier200400500 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 400, 500 });
    }
}
