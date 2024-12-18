// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Documents.Tests
{
    public class DocumentAnalysisClientTest : RecordedTestBase<DocumentAnalysisClientTestEnvironment>
    {
        public DocumentAnalysisClientTest(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public void DocumentAnalysisClientEndpointNull()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(
                () => new DocumentAnalysisClient(null, (AzureKeyCredential)null));
            Assert.AreEqual("endpoint", ex.ParamName);
        }

        [Test]
        public void DocumentAnalysisClientCredentialNull()
        {
            Uri endpoint = new("https://test.cognitive.microsoft.com", UriKind.Absolute);

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(
                () => new DocumentAnalysisClient(endpoint, (AzureKeyCredential)null));
            Assert.AreEqual("credential", ex.ParamName);
        }

        [Test]
        public void DocumentAnalysisClientEndpointNullUsingTokenCredential()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(
                () => new DocumentAnalysisClient(null, (TokenCredential)null));
            Assert.AreEqual("endpoint", ex.ParamName);
        }

        [Test]
        public void DocumentAnalysisClientCredentialNullUsingTokenCredential()
        {
            Uri endpoint = new("https://test.cognitive.microsoft.com", UriKind.Absolute);

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(
                () => new DocumentAnalysisClient(endpoint, (TokenCredential)null));
            Assert.AreEqual("credential", ex.ParamName);
        }

        #region Helpers

        private static BinaryData GetContentFromResponse(Response r)
        {
            // Workaround azure/azure-sdk-for-net#21048, which prevents .Content from working when dealing with responses
            // from the playback system.

            MemoryStream ms = new MemoryStream();
            r.ContentStream.CopyTo(ms);
            return new BinaryData(ms.ToArray());
        }
        #endregion
    }
}
