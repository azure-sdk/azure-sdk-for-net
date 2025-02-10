namespace Azure.AI.Connections
{
    public partial class AIConnectionsClient
    {
        protected AIConnectionsClient() { }
        public AIConnectionsClient(System.Uri endpoint, string subscriptionId, string resourceGroupName, string projectName, Azure.Core.TokenCredential credential) { }
        public AIConnectionsClient(System.Uri endpoint, string subscriptionId, string resourceGroupName, string projectName, Azure.Core.TokenCredential credential, Azure.AI.Connections.AIConnectionsClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class AIConnectionsClientOptions : Azure.Core.ClientOptions
    {
        public AIConnectionsClientOptions(Azure.AI.Connections.AIConnectionsClientOptions.ServiceVersion version = Azure.AI.Connections.AIConnectionsClientOptions.ServiceVersion.V2024_07_01_Preview) { }
        public enum ServiceVersion
        {
            V2024_07_01_Preview = 1,
        }
    }
    public enum AuthenticationType
    {
        ApiKey = 0,
        EntraId = 1,
        SAS = 2,
        None = 3,
    }
    public enum ConnectionType
    {
        AzureOpenAI = 0,
        Serverless = 1,
        AzureBlobStorage = 2,
        AzureAIServices = 3,
        AzureAISearch = 4,
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AIConnectionsClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Connections.AIConnectionsClient, Azure.AI.Connections.AIConnectionsClientOptions> AddAIConnectionsClient<TBuilder>(this TBuilder builder, System.Uri endpoint, string subscriptionId, string resourceGroupName, string projectName) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Connections.AIConnectionsClient, Azure.AI.Connections.AIConnectionsClientOptions> AddAIConnectionsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
