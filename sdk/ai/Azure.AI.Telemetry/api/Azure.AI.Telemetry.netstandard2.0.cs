namespace Azure.AI.Telemetry
{
    public partial class AITelemetryClient
    {
        protected AITelemetryClient() { }
        public AITelemetryClient(System.Uri endpoint, string subscriptionId, string resourceGroupName, string projectName, Azure.Core.TokenCredential credential) { }
        public AITelemetryClient(System.Uri endpoint, string subscriptionId, string resourceGroupName, string projectName, Azure.Core.TokenCredential credential, Azure.AI.Telemetry.AITelemetryClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class AITelemetryClientOptions : Azure.Core.ClientOptions
    {
        public AITelemetryClientOptions(Azure.AI.Telemetry.AITelemetryClientOptions.ServiceVersion version = Azure.AI.Telemetry.AITelemetryClientOptions.ServiceVersion.V2024_07_01_Preview) { }
        public enum ServiceVersion
        {
            V2024_07_01_Preview = 1,
        }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AITelemetryClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Telemetry.AITelemetryClient, Azure.AI.Telemetry.AITelemetryClientOptions> AddAITelemetryClient<TBuilder>(this TBuilder builder, System.Uri endpoint, string subscriptionId, string resourceGroupName, string projectName) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Telemetry.AITelemetryClient, Azure.AI.Telemetry.AITelemetryClientOptions> AddAITelemetryClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
