namespace Azure.ResourceManager.DurableTask
{
    public partial class AzureResourceManagerDurableTaskContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerDurableTaskContext() { }
        public static Azure.ResourceManager.DurableTask.AzureResourceManagerDurableTaskContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public static partial class DurableTaskExtensions
    {
        public static Azure.ResourceManager.DurableTask.DurableTaskHubResource GetDurableTaskHubResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource GetDurableTaskRetentionPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetDurableTaskScheduler(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> GetDurableTaskSchedulerAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource GetDurableTaskSchedulerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.DurableTask.DurableTaskSchedulerCollection GetDurableTaskSchedulers(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetDurableTaskSchedulers(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetDurableTaskSchedulersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource GetPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource GetSchedulerPrivateLinkResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class DurableTaskHubCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.DurableTaskHubResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.DurableTaskHubResource>, System.Collections.IEnumerable
    {
        protected DurableTaskHubCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskHubResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string taskHubName, Azure.ResourceManager.DurableTask.DurableTaskHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskHubResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string taskHubName, Azure.ResourceManager.DurableTask.DurableTaskHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskHubResource> Get(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.DurableTask.DurableTaskHubResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.DurableTask.DurableTaskHubResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskHubResource>> GetAsync(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.DurableTask.DurableTaskHubResource> GetIfExists(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.DurableTask.DurableTaskHubResource>> GetIfExistsAsync(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.DurableTask.DurableTaskHubResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.DurableTaskHubResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.DurableTask.DurableTaskHubResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.DurableTaskHubResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DurableTaskHubData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>
    {
        public DurableTaskHubData() { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskHubData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskHubData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskHubResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DurableTaskHubResource() { }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskHubData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string schedulerName, string taskHubName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskHubResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskHubResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskHubData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskHubData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskHubData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskHubResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.DurableTaskHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskHubResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.DurableTaskHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DurableTaskPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>
    {
        public DurableTaskPrivateEndpointConnectionData() { }
        public Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskRetentionPolicyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>
    {
        public DurableTaskRetentionPolicyData() { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskRetentionPolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DurableTaskRetentionPolicyResource() { }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string schedulerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DurableTaskSchedulerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>, System.Collections.IEnumerable
    {
        protected DurableTaskSchedulerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string schedulerName, Azure.ResourceManager.DurableTask.DurableTaskSchedulerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string schedulerName, Azure.ResourceManager.DurableTask.DurableTaskSchedulerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> Get(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> GetAsync(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetIfExists(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> GetIfExistsAsync(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DurableTaskSchedulerData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>
    {
        public DurableTaskSchedulerData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskSchedulerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskSchedulerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskSchedulerResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DurableTaskSchedulerResource() { }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskSchedulerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string schedulerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskHubResource> GetDurableTaskHub(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskHubResource>> GetDurableTaskHubAsync(string taskHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskHubCollection GetDurableTaskHubs() { throw null; }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource GetDurableTaskRetentionPolicy() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> GetPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>> GetPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.PrivateEndpointConnectionCollection GetPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> GetSchedulerPrivateLinkResource(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>> GetSchedulerPrivateLinkResourceAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceCollection GetSchedulerPrivateLinkResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskSchedulerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskSchedulerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskSchedulerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected PrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class PrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected PrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string schedulerName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SchedulerPrivateLinkResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SchedulerPrivateLinkResource() { }
        public virtual Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string schedulerName, string privateLinkResourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SchedulerPrivateLinkResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>, System.Collections.IEnumerable
    {
        protected SchedulerPrivateLinkResourceCollection() { }
        public virtual Azure.Response<bool> Exists(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> Get(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>> GetAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> GetIfExists(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>> GetIfExistsAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SchedulerPrivateLinkResourceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>
    {
        internal SchedulerPrivateLinkResourceData() { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties Properties { get { throw null; } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.DurableTask.Mocking
{
    public partial class MockableDurableTaskArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableDurableTaskArmClient() { }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskHubResource GetDurableTaskHubResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyResource GetDurableTaskRetentionPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource GetDurableTaskSchedulerResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.PrivateEndpointConnectionResource GetPrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResource GetSchedulerPrivateLinkResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableDurableTaskResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableDurableTaskResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetDurableTaskScheduler(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource>> GetDurableTaskSchedulerAsync(string schedulerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.DurableTask.DurableTaskSchedulerCollection GetDurableTaskSchedulers() { throw null; }
    }
    public partial class MockableDurableTaskSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableDurableTaskSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetDurableTaskSchedulers(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.DurableTask.DurableTaskSchedulerResource> GetDurableTaskSchedulersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.DurableTask.Models
{
    public static partial class ArmDurableTaskModelFactory
    {
        public static Azure.ResourceManager.DurableTask.DurableTaskHubData DurableTaskHubData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties properties = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties DurableTaskHubProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? provisioningState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState?), System.Uri dashboardUri = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData DurableTaskPrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties properties = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties DurableTaskPrivateLinkResourceProperties(string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, System.Collections.Generic.IEnumerable<string> requiredZoneNames = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.DurableTaskRetentionPolicyData DurableTaskRetentionPolicyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties properties = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties DurableTaskRetentionPolicyProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? provisioningState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails> retentionPolicies = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.DurableTaskSchedulerData DurableTaskSchedulerData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties properties = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch DurableTaskSchedulerPatch(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties DurableTaskSchedulerPatchProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? provisioningState, string endpoint, System.Collections.Generic.IEnumerable<string> ipAllowlist, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate sku) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties DurableTaskSchedulerPatchProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? provisioningState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState?), string endpoint = null, System.Collections.Generic.IEnumerable<string> ipAllowlist = null, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate sku = null, Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess?)) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties DurableTaskSchedulerProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? provisioningState, string endpoint, System.Collections.Generic.IEnumerable<string> ipAllowlist, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku sku) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties DurableTaskSchedulerProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? provisioningState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState?), string endpoint = null, System.Collections.Generic.IEnumerable<string> ipAllowlist = null, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku sku = null, Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData> privateEndpointConnections = null) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku DurableTaskSchedulerSku(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName name = default(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName), int? capacity = default(int?), Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState? redundancyState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState?)) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate DurableTaskSchedulerSkuUpdate(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName? name = default(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName?), int? capacity = default(int?), Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState? redundancyState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState?)) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties PrivateEndpointConnectionProperties(System.Collections.Generic.IEnumerable<string> groupIds = null, Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState? provisioningState = default(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.DurableTask.SchedulerPrivateLinkResourceData SchedulerPrivateLinkResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties properties = null) { throw null; }
    }
    public partial class DurableTaskHubProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>
    {
        public DurableTaskHubProperties() { }
        public System.Uri DashboardUri { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskHubProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DurableTaskPrivateEndpointConnectionProvisioningState : System.IEquatable<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DurableTaskPrivateEndpointConnectionProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DurableTaskPrivateEndpointServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DurableTaskPrivateEndpointServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DurableTaskPrivateLinkResourceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>
    {
        internal DurableTaskPrivateLinkResourceProperties() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IList<string> RequiredZoneNames { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkResourceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskPrivateLinkServiceConnectionState : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>
    {
        public DurableTaskPrivateLinkServiceConnectionState() { }
        public string ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointServiceConnectionStatus? Status { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DurableTaskProvisioningState : System.IEquatable<Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DurableTaskProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState left, Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState left, Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DurableTaskPurgeableOrchestrationState : System.IEquatable<Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DurableTaskPurgeableOrchestrationState(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState Canceled { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState Completed { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState Failed { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState Terminated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState left, Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState left, Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DurableTaskResourceRedundancyState : System.IEquatable<Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DurableTaskResourceRedundancyState(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState None { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState Zone { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState left, Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState left, Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DurableTaskRetentionPolicyDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>
    {
        public DurableTaskRetentionPolicyDetails(int retentionPeriodInDays) { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskPurgeableOrchestrationState? OrchestrationState { get { throw null; } set { } }
        public int RetentionPeriodInDays { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskRetentionPolicyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>
    {
        public DurableTaskRetentionPolicyProperties() { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyDetails> RetentionPolicies { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskRetentionPolicyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskSchedulerPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>
    {
        public DurableTaskSchedulerPatch() { }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskSchedulerPatchProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>
    {
        public DurableTaskSchedulerPatchProperties() { }
        public string Endpoint { get { throw null; } }
        public System.Collections.Generic.IList<string> IPAllowlist { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate Sku { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerPatchProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskSchedulerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>
    {
        public DurableTaskSchedulerProperties(System.Collections.Generic.IEnumerable<string> ipAllowlist, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku sku) { }
        public string Endpoint { get { throw null; } }
        public System.Collections.Generic.IList<string> IPAllowlist { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.DurableTask.DurableTaskPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku Sku { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DurableTaskSchedulerSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>
    {
        public DurableTaskSchedulerSku(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName name) { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName Name { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState? RedundancyState { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DurableTaskSchedulerSkuName : System.IEquatable<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DurableTaskSchedulerSkuName(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName Consumption { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName Dedicated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName left, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName left, Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DurableTaskSchedulerSkuUpdate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>
    {
        public DurableTaskSchedulerSkuUpdate() { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuName? Name { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskResourceRedundancyState? RedundancyState { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.DurableTaskSchedulerSkuUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OptionalPropertiesUpdateableProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>
    {
        public OptionalPropertiesUpdateableProperties() { }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateEndpointConnectionPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>
    {
        public PrivateEndpointConnectionPatch() { }
        public Azure.ResourceManager.DurableTask.Models.OptionalPropertiesUpdateableProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateEndpointConnectionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>
    {
        public PrivateEndpointConnectionProperties(Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState privateLinkServiceConnectionState) { }
        public System.Collections.Generic.IReadOnlyList<string> GroupIds { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public Azure.ResourceManager.DurableTask.Models.DurableTaskPrivateEndpointConnectionProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.DurableTask.Models.PrivateEndpointConnectionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccess : System.IEquatable<Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess left, Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess left, Azure.ResourceManager.DurableTask.Models.PublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
}
