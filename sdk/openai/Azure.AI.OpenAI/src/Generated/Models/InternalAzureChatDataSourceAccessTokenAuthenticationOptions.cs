// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.OpenAI;

namespace Azure.AI.OpenAI.Chat
{
    internal partial class InternalAzureChatDataSourceAccessTokenAuthenticationOptions : DataSourceAuthentication
    {
        public InternalAzureChatDataSourceAccessTokenAuthenticationOptions(string accessToken) : base("access_token")
        {
            Argument.AssertNotNull(accessToken, nameof(accessToken));

            AccessToken = accessToken;
        }

        internal InternalAzureChatDataSourceAccessTokenAuthenticationOptions(string @type, IDictionary<string, BinaryData> additionalBinaryDataProperties, string accessToken) : base(@type, additionalBinaryDataProperties)
        {
            AccessToken = accessToken;
        }

        /// <summary> Gets the AccessToken. </summary>
        public string AccessToken { get; set; }
    }
}
