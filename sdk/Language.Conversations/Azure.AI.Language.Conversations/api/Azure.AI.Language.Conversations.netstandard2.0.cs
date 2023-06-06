namespace Azure.AI.Language.Conversations
{
    public partial class ConversationsClient
    {
        protected ConversationsClient() { }
        public ConversationsClient(string endpoint, Azure.Core.TokenCredential credential, Azure.AI.Language.Conversations.ConversationsClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class ConversationsClientOptions : Azure.Core.ClientOptions
    {
        public ConversationsClientOptions(Azure.AI.Language.Conversations.Generated.ConversationsClientOptions.ServiceVersion version = Azure.AI.Language.Conversations.Generated.ConversationsClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}