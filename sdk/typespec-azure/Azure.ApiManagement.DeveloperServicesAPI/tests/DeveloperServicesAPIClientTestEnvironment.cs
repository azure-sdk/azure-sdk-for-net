// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.ApiManagement.DeveloperServicesAPI.Tests
{
    public class DeveloperServicesAPIClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("DeveloperServicesAPI_ENDPOINT");

        // Add other client paramters here as above.
    }
}
