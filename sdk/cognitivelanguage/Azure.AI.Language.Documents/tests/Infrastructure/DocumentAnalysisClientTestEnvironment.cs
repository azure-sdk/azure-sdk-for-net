// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.AI.Language.Documents.Tests
{
    public class DocumentAnalysisClientTestEnvironment : TestEnvironment
    {
        public Uri Endpoint => new(GetRecordedVariable("AZURE_DOCUMENTS_ENDPOINT"));

        // Add other client parameters here as above.
        public string ApiKey => GetRecordedVariable("AZURE_DOCUMENTS_KEY", options => options.IsSecret());
    }
}
