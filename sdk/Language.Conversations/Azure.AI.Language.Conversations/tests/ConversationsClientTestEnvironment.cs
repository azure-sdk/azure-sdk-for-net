// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.AI.Language.Conversations.Tests
{
    public class ConversationsClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("Conversations_ENDPOINT");

        // Add other client paramters here as above.
    }
}
