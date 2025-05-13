namespace Azure.Messaging.EventGrid.Namespaces
{
    public partial class AcknowledgeResult : System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>
    {
        internal AcknowledgeResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> FailedLockTokens { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SucceededLockTokens { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureMessagingEventGridNamespacesClientOptions : Azure.Core.ClientOptions
    {
        public AzureMessagingEventGridNamespacesClientOptions(Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions.ServiceVersion version = Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions.ServiceVersion.V2024_06_01) { }
        public enum ServiceVersion
        {
            V2023_11_01 = 1,
            V2024_06_01 = 2,
        }
    }
    public partial class AzureMessagingEventGridNamespacesContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureMessagingEventGridNamespacesContext() { }
        public static Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class EventGridReceiverClient
    {
        protected EventGridReceiverClient() { }
        public EventGridReceiverClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public EventGridReceiverClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions options) { }
        public EventGridReceiverClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public EventGridReceiverClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class EventGridSenderClient
    {
        protected EventGridSenderClient() { }
        public EventGridSenderClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public EventGridSenderClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions options) { }
        public EventGridSenderClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public EventGridSenderClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class FailedLockToken : System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>, System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>
    {
        internal FailedLockToken() { }
        public Azure.ResponseError Error { get { throw null; } }
        public string LockToken { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.FailedLockToken System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.FailedLockToken System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.FailedLockToken>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class MessagingEventGridNamespacesModelFactory
    {
        public static Azure.Messaging.EventGrid.Namespaces.AcknowledgeResult AcknowledgeResult(System.Collections.Generic.IEnumerable<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> failedLockTokens = null, System.Collections.Generic.IEnumerable<string> succeededLockTokens = null) { throw null; }
        public static Azure.Messaging.EventGrid.Namespaces.FailedLockToken FailedLockToken(string lockToken = null, Azure.ResponseError error = null) { throw null; }
        public static Azure.Messaging.EventGrid.Namespaces.RejectResult RejectResult(System.Collections.Generic.IEnumerable<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> failedLockTokens = null, System.Collections.Generic.IEnumerable<string> succeededLockTokens = null) { throw null; }
        public static Azure.Messaging.EventGrid.Namespaces.ReleaseResult ReleaseResult(System.Collections.Generic.IEnumerable<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> failedLockTokens = null, System.Collections.Generic.IEnumerable<string> succeededLockTokens = null) { throw null; }
        public static Azure.Messaging.EventGrid.Namespaces.RenewLocksResult RenewLocksResult(System.Collections.Generic.IEnumerable<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> failedLockTokens = null, System.Collections.Generic.IEnumerable<string> succeededLockTokens = null) { throw null; }
    }
    public partial class RejectResult : System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>
    {
        internal RejectResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> FailedLockTokens { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SucceededLockTokens { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.RejectResult System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.RejectResult System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RejectResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReleaseDelay : System.IEquatable<Azure.Messaging.EventGrid.Namespaces.ReleaseDelay>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReleaseDelay(string value) { throw null; }
        public static Azure.Messaging.EventGrid.Namespaces.ReleaseDelay NoDelay { get { throw null; } }
        public static Azure.Messaging.EventGrid.Namespaces.ReleaseDelay OneHour { get { throw null; } }
        public static Azure.Messaging.EventGrid.Namespaces.ReleaseDelay OneMinute { get { throw null; } }
        public static Azure.Messaging.EventGrid.Namespaces.ReleaseDelay TenMinutes { get { throw null; } }
        public static Azure.Messaging.EventGrid.Namespaces.ReleaseDelay TenSeconds { get { throw null; } }
        public bool Equals(Azure.Messaging.EventGrid.Namespaces.ReleaseDelay other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Messaging.EventGrid.Namespaces.ReleaseDelay left, Azure.Messaging.EventGrid.Namespaces.ReleaseDelay right) { throw null; }
        public static implicit operator Azure.Messaging.EventGrid.Namespaces.ReleaseDelay (string value) { throw null; }
        public static bool operator !=(Azure.Messaging.EventGrid.Namespaces.ReleaseDelay left, Azure.Messaging.EventGrid.Namespaces.ReleaseDelay right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ReleaseResult : System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>
    {
        internal ReleaseResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> FailedLockTokens { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SucceededLockTokens { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.ReleaseResult System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.ReleaseResult System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.ReleaseResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RenewLocksResult : System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>
    {
        internal RenewLocksResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Messaging.EventGrid.Namespaces.FailedLockToken> FailedLockTokens { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SucceededLockTokens { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.RenewLocksResult System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Messaging.EventGrid.Namespaces.RenewLocksResult System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Messaging.EventGrid.Namespaces.RenewLocksResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class MessagingEventGridNamespacesClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridReceiverClient, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions> AddEventGridReceiverClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridReceiverClient, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions> AddEventGridReceiverClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridReceiverClient, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions> AddEventGridReceiverClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridSenderClient, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions> AddEventGridSenderClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridSenderClient, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions> AddEventGridSenderClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Messaging.EventGrid.Namespaces.EventGridSenderClient, Azure.Messaging.EventGrid.Namespaces.AzureMessagingEventGridNamespacesClientOptions> AddEventGridSenderClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
