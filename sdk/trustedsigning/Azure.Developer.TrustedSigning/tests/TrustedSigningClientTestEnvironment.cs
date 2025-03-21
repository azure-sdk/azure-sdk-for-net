// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Developer.TrustedSigning.Tests
{
    public class TrustedSigningClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("TrustedSigning_ENDPOINT");

        // Add other client paramters here as above.
    }
}
