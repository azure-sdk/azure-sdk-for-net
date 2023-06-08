namespace Azure.Messaging.EventGrid.Namespaces
{
    public partial class NamespacesClient
    {
        protected NamespacesClient() { }
        public NamespacesClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Messaging.EventGrid.Namespaces.NamespacesClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class NamespacesClientOptions : Azure.Core.ClientOptions
    {
        public NamespacesClientOptions(Azure.Messaging.EventGrid.Namespaces.Generated.NamespacesClientOptions.ServiceVersion version = Azure.Messaging.EventGrid.Namespaces.Generated.NamespacesClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}