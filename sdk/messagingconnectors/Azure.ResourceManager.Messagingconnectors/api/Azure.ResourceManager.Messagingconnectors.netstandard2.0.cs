namespace Azure.ResourceManager.Messagingconnectors
{
    public partial class ConnectorInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>, System.Collections.IEnumerable
    {
        protected ConnectorInstanceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConnectorInstanceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>
    {
        public ConnectorInstanceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Messagingconnectors.Models.Direction? ConnectorDirection { get { throw null; } }
        public Azure.ResourceManager.Messagingconnectors.Models.ConnectorState? ConnectorState { get { throw null; } }
        public Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig EventHubConfig { get { throw null; } set { } }
        public int? MaxTasks { get { throw null; } set { } }
        public Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Messagingconnectors.Models.ConverterType? ValueConverter { get { throw null; } set { } }
        Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectorInstanceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConnectorInstanceResource() { }
        public virtual Azure.ResourceManager.Messagingconnectors.ConnectorInstanceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Pause(System.BinaryData body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PauseAsync(System.BinaryData body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Resume(System.BinaryData body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResumeAsync(System.BinaryData body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> Update(Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> UpdateAsync(Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class MessagingconnectorsExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetConnectorInstance(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> GetConnectorInstanceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource GetConnectorInstanceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Messagingconnectors.ConnectorInstanceCollection GetConnectorInstances(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetConnectorInstances(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetConnectorInstancesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Messagingconnectors.Mocking
{
    public partial class MockableMessagingconnectorsArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableMessagingconnectorsArmClient() { }
        public virtual Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource GetConnectorInstanceResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableMessagingconnectorsResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableMessagingconnectorsResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetConnectorInstance(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource>> GetConnectorInstanceAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Messagingconnectors.ConnectorInstanceCollection GetConnectorInstances() { throw null; }
    }
    public partial class MockableMessagingconnectorsSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableMessagingconnectorsSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetConnectorInstances(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Messagingconnectors.ConnectorInstanceResource> GetConnectorInstancesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Messagingconnectors.Models
{
    public partial class ConnectorInstancePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>
    {
        public ConnectorInstancePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.ConnectorInstancePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectorProvisioningState : System.IEquatable<Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectorProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState left, Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState left, Azure.ResourceManager.Messagingconnectors.Models.ConnectorProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectorState : System.IEquatable<Azure.ResourceManager.Messagingconnectors.Models.ConnectorState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectorState(string value) { throw null; }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Creating { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Degraded { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Failed { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Initializing { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Paused { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Running { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Stopped { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Unknown { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConnectorState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Messagingconnectors.Models.ConnectorState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Messagingconnectors.Models.ConnectorState left, Azure.ResourceManager.Messagingconnectors.Models.ConnectorState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Messagingconnectors.Models.ConnectorState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Messagingconnectors.Models.ConnectorState left, Azure.ResourceManager.Messagingconnectors.Models.ConnectorState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConverterType : System.IEquatable<Azure.ResourceManager.Messagingconnectors.Models.ConverterType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConverterType(string value) { throw null; }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConverterType AvroConverter { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConverterType ByteArrayConverter { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConverterType CsvConverter { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConverterType JsonConverter { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConverterType StringConverter { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.ConverterType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Messagingconnectors.Models.ConverterType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Messagingconnectors.Models.ConverterType left, Azure.ResourceManager.Messagingconnectors.Models.ConverterType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Messagingconnectors.Models.ConverterType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Messagingconnectors.Models.ConverterType left, Azure.ResourceManager.Messagingconnectors.Models.ConverterType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Direction : System.IEquatable<Azure.ResourceManager.Messagingconnectors.Models.Direction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Direction(string value) { throw null; }
        public static Azure.ResourceManager.Messagingconnectors.Models.Direction Sink { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.Direction Source { get { throw null; } }
        public static Azure.ResourceManager.Messagingconnectors.Models.Direction Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Messagingconnectors.Models.Direction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Messagingconnectors.Models.Direction left, Azure.ResourceManager.Messagingconnectors.Models.Direction right) { throw null; }
        public static implicit operator Azure.ResourceManager.Messagingconnectors.Models.Direction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Messagingconnectors.Models.Direction left, Azure.ResourceManager.Messagingconnectors.Models.Direction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>
    {
        public EventHubConfig(string namespaceHostName, string eventHubName, string connectionString) { }
        public string ConnectionString { get { throw null; } set { } }
        public string EventHubName { get { throw null; } set { } }
        public string NamespaceHostName { get { throw null; } set { } }
        Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Messagingconnectors.Models.EventHubConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
