namespace Azure.Messaging.EventGrid.Namespaces
{
    public partial class EventGridClient
    {
        protected EventGridClient() { }
        public EventGridClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public EventGridClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions options) { }
        public EventGridClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public EventGridClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AcknowledgeCloudEvents(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AcknowledgeCloudEventsAsync(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PublishCloudEvent(string topicName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PublishCloudEventAsync(string topicName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PublishCloudEvents(string topicName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PublishCloudEventsAsync(string topicName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response ReceiveCloudEvents(string topicName, string eventSubscriptionName, int? maxEvents, System.TimeSpan? maxWaitTime, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ReceiveCloudEventsAsync(string topicName, string eventSubscriptionName, int? maxEvents, System.TimeSpan? maxWaitTime, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response RejectCloudEvents(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RejectCloudEventsAsync(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response ReleaseCloudEvents(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, int? releaseDelayInSeconds = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ReleaseCloudEventsAsync(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, int? releaseDelayInSeconds = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response RenewCloudEventLocks(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RenewCloudEventLocksAsync(string topicName, string eventSubscriptionName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class EventGridClientOptions : Azure.Core.ClientOptions
    {
        public EventGridClientOptions(Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions.ServiceVersion version = Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions.ServiceVersion.V2023_10_01_Preview) { }
        public enum ServiceVersion
        {
            V2023_06_01_Preview = 1,
            V2023_10_01_Preview = 2,
        }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class MessagingEventGridNamespacesClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridClient, Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions> AddEventGridClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridClient, Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions> AddEventGridClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridClient, Azure.Messaging.EventGrid.Namespaces.EventGridClientOptions> AddEventGridClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
