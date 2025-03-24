namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class EmailConfigurationModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>, System.Collections.IEnumerable
    {
        protected EmailConfigurationModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string emailConfigurationName, Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string emailConfigurationName, Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> Get(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>> GetAsync(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> GetIfExists(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>> GetIfExistsAsync(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EmailConfigurationModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>
    {
        public EmailConfigurationModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EmailConfigurationModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EmailConfigurationModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string emailConfigurationName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>, System.Collections.IEnumerable
    {
        protected EventModelCollection() { }
        public virtual Azure.Response<bool> Exists(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> Get(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> GetAll(string odataOptions = null, string continuationToken = null, int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> GetAllAsync(string odataOptions = null, string continuationToken = null, int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>> GetAsync(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> GetIfExists(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>> GetIfExistsAsync(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>
    {
        internal EventModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string eventName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FabricAgentModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>, System.Collections.IEnumerable
    {
        protected FabricAgentModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fabricAgentName, Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fabricAgentName, Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> Get(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>> GetAsync(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> GetIfExists(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>> GetIfExistsAsync(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FabricAgentModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>
    {
        public FabricAgentModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FabricAgentModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FabricAgentModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fabricName, string fabricAgentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FabricModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>, System.Collections.IEnumerable
    {
        protected FabricModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fabricName, Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fabricName, Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> Get(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetAll(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetAllAsync(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> GetAsync(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetIfExists(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> GetIfExistsAsync(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FabricModelData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>
    {
        public FabricModelData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FabricModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FabricModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fabricName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource> GetFabricAgentModel(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource>> GetFabricAgentModelAsync(string fabricAgentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelCollection GetFabricAgentModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class JobModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>, System.Collections.IEnumerable
    {
        protected JobModelCollection() { }
        public virtual Azure.Response<bool> Exists(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> Get(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> GetAll(string odataOptions = null, string continuationToken = null, int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> GetAllAsync(string odataOptions = null, string continuationToken = null, int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>> GetAsync(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> GetIfExists(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>> GetIfExistsAsync(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class JobModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>
    {
        internal JobModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class JobModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected JobModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string jobName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>, System.Collections.IEnumerable
    {
        protected PolicyModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string policyName, Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policyName, Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> Get(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>> GetAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> GetIfExists(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>> GetIfExistsAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class PolicyModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>
    {
        public PolicyModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected PolicyModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string policyName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PrivateEndpointConnectionProxyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>, System.Collections.IEnumerable
    {
        protected PrivateEndpointConnectionProxyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionProxyName, Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionProxyName, Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> Get(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> GetAsync(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> GetIfExists(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> GetIfExistsAsync(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class PrivateEndpointConnectionProxyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>
    {
        public PrivateEndpointConnectionProxyData() { }
        public string ETag { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateEndpointConnectionProxyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected PrivateEndpointConnectionProxyResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string privateEndpointConnectionProxyName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> Validate(Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> ValidateAsync(Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ProtectedItemModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>, System.Collections.IEnumerable
    {
        protected ProtectedItemModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string protectedItemName, Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string protectedItemName, Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> Get(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> GetAll(string odataOptions = null, string continuationToken = null, int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> GetAllAsync(string odataOptions = null, string continuationToken = null, int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>> GetAsync(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> GetIfExists(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>> GetIfExistsAsync(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ProtectedItemModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>
    {
        public ProtectedItemModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProtectedItemModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ProtectedItemModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string protectedItemName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? forceDelete = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? forceDelete = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> GetRecoveryPointModel(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>> GetRecoveryPointModelAsync(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelCollection GetRecoveryPointModels() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel> PlannedFailover(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>> PlannedFailoverAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class RecoveryPointModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>, System.Collections.IEnumerable
    {
        protected RecoveryPointModelCollection() { }
        public virtual Azure.Response<bool> Exists(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> Get(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>> GetAsync(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> GetIfExists(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>> GetIfExistsAsync(string recoveryPointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class RecoveryPointModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>
    {
        internal RecoveryPointModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecoveryPointModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected RecoveryPointModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string protectedItemName, string recoveryPointName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class RecoveryServicesDataReplicationExtensions
    {
        public static Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource GetEmailConfigurationModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource GetEventModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource GetFabricAgentModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetFabricModel(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> GetFabricModelAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource GetFabricModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelCollection GetFabricModels(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetFabricModels(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetFabricModelsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource GetJobModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus> GetOperationResult(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>> GetOperationResultAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource GetPolicyModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource GetPrivateEndpointConnectionProxyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource GetProtectedItemModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource GetRecoveryPointModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource GetRecoveryServicesDataReplicationPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource GetRecoveryServicesDataReplicationPrivateLinkResourceDataResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource GetReplicationExtensionModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetVaultModel(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> GetVaultModelAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource GetVaultModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelCollection GetVaultModels(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetVaultModels(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetVaultModelsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel> PostCheckNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>> PostCheckNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel> PostDeploymentPreflight(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string deploymentId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>> PostDeploymentPreflightAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string deploymentId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected RecoveryServicesDataReplicationPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>
    {
        public RecoveryServicesDataReplicationPrivateEndpointConnectionData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected RecoveryServicesDataReplicationPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateLinkResourceDataCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>, System.Collections.IEnumerable
    {
        protected RecoveryServicesDataReplicationPrivateLinkResourceDataCollection() { }
        public virtual Azure.Response<bool> Exists(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> Get(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>> GetAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> GetIfExists(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>> GetIfExistsAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateLinkResourceDataData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>
    {
        internal RecoveryServicesDataReplicationPrivateLinkResourceDataData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateLinkResourceDataResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected RecoveryServicesDataReplicationPrivateLinkResourceDataResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string privateLinkResourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReplicationExtensionModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>, System.Collections.IEnumerable
    {
        protected ReplicationExtensionModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string replicationExtensionName, Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string replicationExtensionName, Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> Get(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>> GetAsync(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> GetIfExists(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>> GetIfExistsAsync(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ReplicationExtensionModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>
    {
        public ReplicationExtensionModelData() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReplicationExtensionModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ReplicationExtensionModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string replicationExtensionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VaultModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>, System.Collections.IEnumerable
    {
        protected VaultModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string vaultName, Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string vaultName, Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> Get(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetAll(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetAllAsync(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> GetAsync(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetIfExists(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> GetIfExistsAsync(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VaultModelData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>
    {
        public VaultModelData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VaultModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VaultModelResource() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataCollection GetAllRecoveryServicesDataReplicationPrivateLinkResourceData() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource> GetEmailConfigurationModel(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource>> GetEmailConfigurationModelAsync(string emailConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelCollection GetEmailConfigurationModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource> GetEventModel(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource>> GetEventModelAsync(string eventName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.EventModelCollection GetEventModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource> GetJobModel(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource>> GetJobModelAsync(string jobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.JobModelCollection GetJobModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource> GetPolicyModel(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource>> GetPolicyModelAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelCollection GetPolicyModels() { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyCollection GetPrivateEndpointConnectionProxies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource> GetPrivateEndpointConnectionProxy(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource>> GetPrivateEndpointConnectionProxyAsync(string privateEndpointConnectionProxyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource> GetProtectedItemModel(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource>> GetProtectedItemModelAsync(string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelCollection GetProtectedItemModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource> GetRecoveryServicesDataReplicationPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource>> GetRecoveryServicesDataReplicationPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionCollection GetRecoveryServicesDataReplicationPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource> GetRecoveryServicesDataReplicationPrivateLinkResourceData(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource>> GetRecoveryServicesDataReplicationPrivateLinkResourceDataAsync(string privateLinkResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource> GetReplicationExtensionModel(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource>> GetReplicationExtensionModelAsync(string replicationExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelCollection GetReplicationExtensionModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.RecoveryServicesDataReplication.Mocking
{
    public partial class MockableRecoveryServicesDataReplicationArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableRecoveryServicesDataReplicationArmClient() { }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelResource GetEmailConfigurationModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.EventModelResource GetEventModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelResource GetFabricAgentModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource GetFabricModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.JobModelResource GetJobModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelResource GetPolicyModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyResource GetPrivateEndpointConnectionProxyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelResource GetProtectedItemModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelResource GetRecoveryPointModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionResource GetRecoveryServicesDataReplicationPrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataResource GetRecoveryServicesDataReplicationPrivateLinkResourceDataResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelResource GetReplicationExtensionModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource GetVaultModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableRecoveryServicesDataReplicationResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableRecoveryServicesDataReplicationResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetFabricModel(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource>> GetFabricModelAsync(string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelCollection GetFabricModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus> GetOperationResult(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>> GetOperationResultAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetVaultModel(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource>> GetVaultModelAsync(string vaultName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelCollection GetVaultModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel> PostDeploymentPreflight(string deploymentId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>> PostDeploymentPreflightAsync(string deploymentId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MockableRecoveryServicesDataReplicationSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableRecoveryServicesDataReplicationSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetFabricModels(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelResource> GetFabricModelsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetVaultModels(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelResource> GetVaultModelsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel> PostCheckNameAvailability(Azure.Core.AzureLocation location, Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>> PostCheckNameAvailabilityAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public static partial class ArmRecoveryServicesDataReplicationModelFactory
    {
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties AzStackHciFabricModelCustomProperties(string azStackHciSiteId = null, System.Collections.Generic.IEnumerable<string> applianceName = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties cluster = null, string fabricResourceId = null, string fabricContainerId = null, string migrationSolutionId = null, string migrationHubUri = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel CheckNameAvailabilityResponseModel(bool? nameAvailable = default(bool?), string reason = null, string message = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.EmailConfigurationModelData EmailConfigurationModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties EmailConfigurationModelProperties(bool sendToOwners = false, System.Collections.Generic.IEnumerable<string> customEmailAddresses = null, string locale = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel ErrorModel(string code = null, string type = null, string severity = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), string message = null, string causes = null, string recommendation = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.EventModelData EventModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties EventModelProperties(string resourceType = null, string resourceName = null, string eventType = null, string eventName = null, System.DateTimeOffset? timeOfOccurrence = default(System.DateTimeOffset?), string severity = null, string description = null, string correlationId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> healthErrors = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties customProperties = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.FabricAgentModelData FabricAgentModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties FabricAgentModelProperties(string correlationId = null, string machineId = null, string machineName = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel authenticationIdentity = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel resourceAccessIdentity = null, bool? isResponsive = default(bool?), System.DateTimeOffset? lastHeartbeat = default(System.DateTimeOffset?), string versionNumber = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> healthErrors = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties customProperties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.FabricModelData FabricModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch FabricModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties FabricModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), string serviceEndpoint = null, string serviceResourceId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus? health = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> healthErrors = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties customProperties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties FailoverJobModelCustomProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails affectedObjectDetails = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties> protectedItemDetails = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties FailoverProtectedItemProperties(string protectedItemName = null, string vmName = null, string testVmName = null, string recoveryPointId = null, System.DateTimeOffset? recoveryPointOn = default(System.DateTimeOffset?), string networkName = null, string subnet = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel HealthErrorModel(string affectedResourceType = null, System.Collections.Generic.IEnumerable<string> affectedResourceCorrelationIds = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel> childErrors = null, string code = null, string healthCategory = null, string category = null, string severity = null, string source = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), bool? isCustomerResolvable = default(bool?), string summary = null, string message = null, string causes = null, string recommendation = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties HyperVMigrateFabricModelCustomProperties(string hyperVSiteId = null, string fabricResourceId = null, string fabricContainerId = null, string migrationSolutionId = null, string migrationHubUri = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties HyperVToAzStackHciEventModelCustomProperties(string eventSourceFriendlyName = null, string protectedItemFriendlyName = null, string sourceApplianceName = null, string targetApplianceName = null, string serverType = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput HyperVToAzStackHciNicInput(string nicId = null, string networkName = null, string targetNetworkId = null, string testNetworkId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection selectionTypeForFailover = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection), bool? isStaticIPMigrationEnabled = default(bool?), bool? isMacMigrationEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties HyperVToAzStackHciProtectedDiskProperties(string storageContainerId = null, string storageContainerLocalPath = null, string sourceDiskId = null, string sourceDiskName = null, string seedDiskName = null, string testMigrateDiskName = null, string migrateDiskName = null, bool? isOSDisk = default(bool?), long? capacityInBytes = default(long?), bool? isDynamic = default(bool?), string diskType = null, long? diskBlockSize = default(long?), long? diskLogicalSectorSize = default(long?), long? diskPhysicalSectorSize = default(long?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties HyperVToAzStackHciProtectedItemModelCustomProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation? activeLocation = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation?), string targetHciClusterId = null, string targetArcClusterCustomLocationId = null, string targetAzStackHciClusterName = null, string fabricDiscoveryMachineId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput> disksToInclude = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput> nicsToInclude = null, string sourceVmName = null, int? sourceCpuCores = default(int?), double? sourceMemoryInMegaBytes = default(double?), string targetVmName = null, string targetResourceGroupId = null, string storageContainerId = null, string hyperVGeneration = null, string targetNetworkId = null, string testNetworkId = null, int? targetCpuCores = default(int?), bool? isDynamicRam = default(bool?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig dynamicMemoryConfig = null, int? targetMemoryInMegaBytes = default(int?), string runAsAccountId = null, string sourceFabricAgentName = null, string targetFabricAgentName = null, string sourceApplianceName = null, string targetApplianceName = null, string osType = null, string osName = null, string firmwareType = null, string targetLocation = null, string customLocationRegion = null, string failoverRecoveryPointId = null, System.DateTimeOffset? lastRecoveryPointReceived = default(System.DateTimeOffset?), string lastRecoveryPointId = null, int? initialReplicationProgressPercentage = default(int?), int? resyncProgressPercentage = default(int?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties> protectedDisks = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties> protectedNics = null, string targetVmBiosId = null, System.DateTimeOffset? lastReplicationUpdateOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties HyperVToAzStackHciProtectedNicProperties(string nicId = null, string macAddress = null, string networkName = null, string targetNetworkId = null, string testNetworkId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection? selectionTypeForFailover = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties HyperVToAzStackHciRecoveryPointModelCustomProperties(System.Collections.Generic.IEnumerable<string> diskIds = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties HyperVToAzStackHciReplicationExtensionModelCustomProperties(string hyperVFabricArmId = null, string hyperVSiteId = null, string azStackHciFabricArmId = null, string azStackHciSiteId = null, string storageAccountId = null, string storageAccountSasSecretName = null, string asrServiceUri = null, string rcmServiceUri = null, string gatewayServiceUri = null, string sourceGatewayServiceId = null, string targetGatewayServiceId = null, string sourceStorageContainerName = null, string targetStorageContainerName = null, string resourceLocation = null, string subscriptionId = null, string resourceGroup = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel InnerHealthErrorModel(string code = null, string healthCategory = null, string category = null, string severity = null, string source = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), bool? isCustomerResolvable = default(bool?), string summary = null, string message = null, string causes = null, string recommendation = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties JobModelCustomProperties(string instanceType = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails affectedObjectDetails = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails JobModelCustomPropertiesAffectedObjectDetails(string description = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType? type = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData JobModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties JobModelProperties(string displayName = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState? state = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState?), System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), string objectId = null, string objectName = null, string objectInternalId = null, string objectInternalName = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType? objectType = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType?), string replicationProviderId = null, string sourceFabricProviderId = null, string targetFabricProviderId = null, System.Collections.Generic.IEnumerable<string> allowedActions = null, string activityId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel> tasks = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel> errors = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties customProperties = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus OperationStatus(string id = null, string name = null, string status = null, string startTime = null, string endTime = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.PolicyModelData PolicyModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties PolicyModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties customProperties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.PrivateEndpointConnectionProxyData PrivateEndpointConnectionProxyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties properties = null, string etag = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties PrivateEndpointConnectionProxyProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint remotePrivateEndpoint = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties PrivateEndpointConnectionResponseProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties ProtectedItemJobProperties(string scenarioName = null, string id = null, string name = null, string displayName = null, string state = null, System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.ProtectedItemModelData ProtectedItemModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch ProtectedItemModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate customProperties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties ProtectedItemModelProperties(string policyName = null, string replicationExtensionName = null, string correlationId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState? protectionState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState?), string protectionStateDescription = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState? testFailoverState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState?), string testFailoverStateDescription = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState? resynchronizationState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState?), string fabricObjectId = null, string fabricObjectName = null, string sourceFabricProviderId = null, string targetFabricProviderId = null, string fabricId = null, string targetFabricId = null, string fabricAgentId = null, string targetFabricAgentId = null, bool? resyncRequired = default(bool?), System.DateTimeOffset? lastSuccessfulPlannedFailoverOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastSuccessfulUnplannedFailoverOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastSuccessfulTestFailoverOn = default(System.DateTimeOffset?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties currentJob = null, System.Collections.Generic.IEnumerable<string> allowedJobs = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties lastFailedEnableProtectionJob = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties lastFailedPlannedFailoverJob = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties lastTestFailoverJob = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus? replicationHealth = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> healthErrors = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties customProperties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryPointModelData RecoveryPointModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties RecoveryPointModelProperties(System.DateTimeOffset recoveryPointOn = default(System.DateTimeOffset), Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType recoveryPointType = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType), Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties customProperties = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateEndpointConnectionData RecoveryServicesDataReplicationPrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.RecoveryServicesDataReplicationPrivateLinkResourceDataData RecoveryServicesDataReplicationPrivateLinkResourceDataData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties RecoveryServicesDataReplicationPrivateLinkResourceProperties(string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, System.Collections.Generic.IEnumerable<string> requiredZoneNames = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.ReplicationExtensionModelData ReplicationExtensionModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties properties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties ReplicationExtensionModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties customProperties = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel TaskModel(string taskName = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState? state = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState?), System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), string customInstanceType = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData> childrenJobs = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties TestFailoverCleanupJobModelCustomProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails affectedObjectDetails = null, string comments = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties TestFailoverJobModelCustomProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails affectedObjectDetails = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties> protectedItemDetails = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.VaultModelData VaultModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties properties = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch VaultModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties properties = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties VaultModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState?), string serviceResourceId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType? vaultType = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties VMwareToAzStackHciEventModelCustomProperties(string eventSourceFriendlyName = null, string protectedItemFriendlyName = null, string sourceApplianceName = null, string targetApplianceName = null, string serverType = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput VMwareToAzStackHciNicInput(string nicId = null, string label = null, string networkName = null, string targetNetworkId = null, string testNetworkId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection selectionTypeForFailover = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection), bool? isStaticIPMigrationEnabled = default(bool?), bool? isMacMigrationEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties VMwareToAzStackHciProtectedDiskProperties(string storageContainerId = null, string storageContainerLocalPath = null, string sourceDiskId = null, string sourceDiskName = null, string seedDiskName = null, string testMigrateDiskName = null, string migrateDiskName = null, bool? isOSDisk = default(bool?), long? capacityInBytes = default(long?), bool? isDynamic = default(bool?), string diskType = null, long? diskBlockSize = default(long?), long? diskLogicalSectorSize = default(long?), long? diskPhysicalSectorSize = default(long?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties VMwareToAzStackHciProtectedItemModelCustomProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation? activeLocation = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation?), string targetHciClusterId = null, string targetArcClusterCustomLocationId = null, string targetAzStackHciClusterName = null, string storageContainerId = null, string targetResourceGroupId = null, string targetLocation = null, string customLocationRegion = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput> disksToInclude = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput> nicsToInclude = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties> protectedDisks = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties> protectedNics = null, string targetVmBiosId = null, string targetVmName = null, string hyperVGeneration = null, string targetNetworkId = null, string testNetworkId = null, int? targetCpuCores = default(int?), bool? isDynamicRam = default(bool?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig dynamicMemoryConfig = null, int? targetMemoryInMegaBytes = default(int?), string osType = null, string osName = null, string firmwareType = null, string fabricDiscoveryMachineId = null, string sourceVmName = null, int? sourceCpuCores = default(int?), double? sourceMemoryInMegaBytes = default(double?), string runAsAccountId = null, string sourceFabricAgentName = null, string targetFabricAgentName = null, string sourceApplianceName = null, string targetApplianceName = null, string failoverRecoveryPointId = null, System.DateTimeOffset? lastRecoveryPointReceived = default(System.DateTimeOffset?), string lastRecoveryPointId = null, int? initialReplicationProgressPercentage = default(int?), int? migrationProgressPercentage = default(int?), int? resumeProgressPercentage = default(int?), int? resyncProgressPercentage = default(int?), long? resyncRetryCount = default(long?), bool? resyncRequired = default(bool?), Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState? resyncState = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState?), bool? performAutoResync = default(bool?), long? resumeRetryCount = default(long?), System.DateTimeOffset? lastReplicationUpdateOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties VMwareToAzStackHciProtectedNicProperties(string nicId = null, string macAddress = null, string label = null, bool? isPrimaryNic = default(bool?), string networkName = null, string targetNetworkId = null, string testNetworkId = null, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection? selectionTypeForFailover = default(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection?)) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties VMwareToAzStackHciRecoveryPointModelCustomProperties(System.Collections.Generic.IEnumerable<string> diskIds = null) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties VMwareToAzStackHciReplicationExtensionModelCustomProperties(string vmwareFabricArmId = null, string vmwareSiteId = null, string azStackHciFabricArmId = null, string azStackHciSiteId = null, string storageAccountId = null, string storageAccountSasSecretName = null, string asrServiceUri = null, string rcmServiceUri = null, string gatewayServiceUri = null, string sourceGatewayServiceId = null, string targetGatewayServiceId = null, string sourceStorageContainerName = null, string targetStorageContainerName = null, string resourceLocation = null, string subscriptionId = null, string resourceGroup = null) { throw null; }
    }
    public partial class AzStackHciClusterProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>
    {
        public AzStackHciClusterProperties(string clusterName, string resourceName, string storageAccountName, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties> storageContainers) { }
        public string ClusterName { get { throw null; } set { } }
        public string ResourceName { get { throw null; } set { } }
        public string StorageAccountName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties> StorageContainers { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzStackHciFabricModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>
    {
        public AzStackHciFabricModelCustomProperties(string azStackHciSiteId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties cluster, string migrationSolutionId) { }
        public System.Collections.Generic.IReadOnlyList<string> ApplianceName { get { throw null; } }
        public string AzStackHciSiteId { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties Cluster { get { throw null; } set { } }
        public string FabricContainerId { get { throw null; } }
        public string FabricResourceId { get { throw null; } }
        public string MigrationHubUri { get { throw null; } }
        public string MigrationSolutionId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CheckNameAvailabilityModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>
    {
        public CheckNameAvailabilityModel() { }
        public string Name { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CheckNameAvailabilityResponseModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>
    {
        internal CheckNameAvailabilityResponseModel() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public string Reason { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.CheckNameAvailabilityResponseModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectionDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>
    {
        public ConnectionDetails() { }
        public string GroupId { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string LinkIdentifier { get { throw null; } set { } }
        public string MemberName { get { throw null; } set { } }
        public string PrivateIPAddress { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentPreflightModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>
    {
        public DeploymentPreflightModel() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource> Resources { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentPreflightResource : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>
    {
        public DeploymentPreflightResource() { }
        public string ApiVersion { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.BinaryData Properties { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DeploymentPreflightResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DiskControllerInputs : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>
    {
        public DiskControllerInputs(string controllerName, int controllerId, int controllerLocation) { }
        public int ControllerId { get { throw null; } set { } }
        public int ControllerLocation { get { throw null; } set { } }
        public string ControllerName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EmailConfigurationModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>
    {
        public EmailConfigurationModelProperties(bool sendToOwners) { }
        public System.Collections.Generic.IList<string> CustomEmailAddresses { get { throw null; } }
        public string Locale { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public bool SendToOwners { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EmailConfigurationModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>
    {
        internal ErrorModel() { }
        public string Causes { get { throw null; } }
        public string Code { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string Message { get { throw null; } }
        public string Recommendation { get { throw null; } }
        public string Severity { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class EventModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>
    {
        protected EventModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>
    {
        internal EventModelProperties() { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties CustomProperties { get { throw null; } }
        public string Description { get { throw null; } }
        public string EventName { get { throw null; } }
        public string EventType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> HealthErrors { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ResourceName { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public string Severity { get { throw null; } }
        public System.DateTimeOffset? TimeOfOccurrence { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class FabricAgentModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>
    {
        protected FabricAgentModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FabricAgentModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>
    {
        public FabricAgentModelProperties(string machineId, string machineName, Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel authenticationIdentity, Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel resourceAccessIdentity, Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties customProperties) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel AuthenticationIdentity { get { throw null; } set { } }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties CustomProperties { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> HealthErrors { get { throw null; } }
        public bool? IsResponsive { get { throw null; } }
        public System.DateTimeOffset? LastHeartbeat { get { throw null; } }
        public string MachineId { get { throw null; } set { } }
        public string MachineName { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel ResourceAccessIdentity { get { throw null; } set { } }
        public string VersionNumber { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class FabricModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>
    {
        protected FabricModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FabricModelPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>
    {
        public FabricModelPatch() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FabricModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>
    {
        public FabricModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties customProperties) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties CustomProperties { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus? Health { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> HealthErrors { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ServiceEndpoint { get { throw null; } }
        public string ServiceResourceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FailoverJobModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>
    {
        internal FailoverJobModelCustomProperties() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties> ProtectedItemDetails { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverJobModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FailoverProtectedItemProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>
    {
        internal FailoverProtectedItemProperties() { }
        public string NetworkName { get { throw null; } }
        public string ProtectedItemName { get { throw null; } }
        public string RecoveryPointId { get { throw null; } }
        public System.DateTimeOffset? RecoveryPointOn { get { throw null; } }
        public string Subnet { get { throw null; } }
        public string TestVmName { get { throw null; } }
        public string VmName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GroupConnectivityInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>
    {
        public GroupConnectivityInformation() { }
        public System.Collections.Generic.IList<string> CustomerVisibleFqdns { get { throw null; } }
        public string GroupId { get { throw null; } set { } }
        public string InternalFqdn { get { throw null; } set { } }
        public string MemberName { get { throw null; } set { } }
        public string PrivateLinkServiceArmRegion { get { throw null; } set { } }
        public string RedirectMapId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HealthErrorModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>
    {
        internal HealthErrorModel() { }
        public System.Collections.Generic.IReadOnlyList<string> AffectedResourceCorrelationIds { get { throw null; } }
        public string AffectedResourceType { get { throw null; } }
        public string Category { get { throw null; } }
        public string Causes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel> ChildErrors { get { throw null; } }
        public string Code { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string HealthCategory { get { throw null; } }
        public bool? IsCustomerResolvable { get { throw null; } }
        public string Message { get { throw null; } }
        public string Recommendation { get { throw null; } }
        public string Severity { get { throw null; } }
        public string Source { get { throw null; } }
        public string Summary { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HealthStatus : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HealthStatus(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus Critical { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus Normal { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HyperVMigrateFabricModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>
    {
        public HyperVMigrateFabricModelCustomProperties(string hyperVSiteId, string migrationSolutionId) { }
        public string FabricContainerId { get { throw null; } }
        public string FabricResourceId { get { throw null; } }
        public string HyperVSiteId { get { throw null; } set { } }
        public string MigrationHubUri { get { throw null; } }
        public string MigrationSolutionId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVMigrateFabricModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciDiskInput : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>
    {
        public HyperVToAzStackHciDiskInput(string diskId, long diskSizeGB, string diskFileFormat, bool isOSDisk) { }
        public long? DiskBlockSize { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs DiskController { get { throw null; } set { } }
        public string DiskFileFormat { get { throw null; } set { } }
        public string DiskId { get { throw null; } set { } }
        public string DiskIdentifier { get { throw null; } set { } }
        public long? DiskLogicalSectorSize { get { throw null; } set { } }
        public long? DiskPhysicalSectorSize { get { throw null; } set { } }
        public long DiskSizeGB { get { throw null; } set { } }
        public bool? IsDynamic { get { throw null; } set { } }
        public bool IsOSDisk { get { throw null; } set { } }
        public string StorageContainerId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciEventModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>
    {
        internal HyperVToAzStackHciEventModelCustomProperties() { }
        public string EventSourceFriendlyName { get { throw null; } }
        public string ProtectedItemFriendlyName { get { throw null; } }
        public string ServerType { get { throw null; } }
        public string SourceApplianceName { get { throw null; } }
        public string TargetApplianceName { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciEventModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciNicInput : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>
    {
        public HyperVToAzStackHciNicInput(string nicId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection selectionTypeForFailover) { }
        public bool? IsMacMigrationEnabled { get { throw null; } set { } }
        public bool? IsStaticIPMigrationEnabled { get { throw null; } set { } }
        public string NetworkName { get { throw null; } }
        public string NicId { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection SelectionTypeForFailover { get { throw null; } set { } }
        public string TargetNetworkId { get { throw null; } set { } }
        public string TestNetworkId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciPlannedFailoverModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>
    {
        public HyperVToAzStackHciPlannedFailoverModelCustomProperties(bool shutdownSourceVm) { }
        public bool ShutdownSourceVm { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPlannedFailoverModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciPolicyModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>
    {
        public HyperVToAzStackHciPolicyModelCustomProperties(int recoveryPointHistoryInMinutes, int crashConsistentFrequencyInMinutes, int appConsistentFrequencyInMinutes) { }
        public int AppConsistentFrequencyInMinutes { get { throw null; } set { } }
        public int CrashConsistentFrequencyInMinutes { get { throw null; } set { } }
        public int RecoveryPointHistoryInMinutes { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciPolicyModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciProtectedDiskProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>
    {
        internal HyperVToAzStackHciProtectedDiskProperties() { }
        public long? CapacityInBytes { get { throw null; } }
        public long? DiskBlockSize { get { throw null; } }
        public long? DiskLogicalSectorSize { get { throw null; } }
        public long? DiskPhysicalSectorSize { get { throw null; } }
        public string DiskType { get { throw null; } }
        public bool? IsDynamic { get { throw null; } }
        public bool? IsOSDisk { get { throw null; } }
        public string MigrateDiskName { get { throw null; } }
        public string SeedDiskName { get { throw null; } }
        public string SourceDiskId { get { throw null; } }
        public string SourceDiskName { get { throw null; } }
        public string StorageContainerId { get { throw null; } }
        public string StorageContainerLocalPath { get { throw null; } }
        public string TestMigrateDiskName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciProtectedItemModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>
    {
        public HyperVToAzStackHciProtectedItemModelCustomProperties(string targetHciClusterId, string targetArcClusterCustomLocationId, string fabricDiscoveryMachineId, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput> disksToInclude, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput> nicsToInclude, string targetResourceGroupId, string storageContainerId, string hyperVGeneration, string runAsAccountId, string sourceFabricAgentName, string targetFabricAgentName, string customLocationRegion) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation? ActiveLocation { get { throw null; } }
        public string CustomLocationRegion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciDiskInput> DisksToInclude { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get { throw null; } set { } }
        public string FabricDiscoveryMachineId { get { throw null; } set { } }
        public string FailoverRecoveryPointId { get { throw null; } }
        public string FirmwareType { get { throw null; } }
        public string HyperVGeneration { get { throw null; } set { } }
        public int? InitialReplicationProgressPercentage { get { throw null; } }
        public bool? IsDynamicRam { get { throw null; } set { } }
        public string LastRecoveryPointId { get { throw null; } }
        public System.DateTimeOffset? LastRecoveryPointReceived { get { throw null; } }
        public System.DateTimeOffset? LastReplicationUpdateOn { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput> NicsToInclude { get { throw null; } }
        public string OSName { get { throw null; } }
        public string OSType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedDiskProperties> ProtectedDisks { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties> ProtectedNics { get { throw null; } }
        public int? ResyncProgressPercentage { get { throw null; } }
        public string RunAsAccountId { get { throw null; } set { } }
        public string SourceApplianceName { get { throw null; } }
        public int? SourceCpuCores { get { throw null; } }
        public string SourceFabricAgentName { get { throw null; } set { } }
        public double? SourceMemoryInMegaBytes { get { throw null; } }
        public string SourceVmName { get { throw null; } }
        public string StorageContainerId { get { throw null; } set { } }
        public string TargetApplianceName { get { throw null; } }
        public string TargetArcClusterCustomLocationId { get { throw null; } set { } }
        public string TargetAzStackHciClusterName { get { throw null; } }
        public int? TargetCpuCores { get { throw null; } set { } }
        public string TargetFabricAgentName { get { throw null; } set { } }
        public string TargetHciClusterId { get { throw null; } set { } }
        public string TargetLocation { get { throw null; } }
        public int? TargetMemoryInMegaBytes { get { throw null; } set { } }
        public string TargetNetworkId { get { throw null; } set { } }
        public string TargetResourceGroupId { get { throw null; } set { } }
        public string TargetVmBiosId { get { throw null; } }
        public string TargetVmName { get { throw null; } set { } }
        public string TestNetworkId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate : Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>
    {
        public HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get { throw null; } set { } }
        public bool? IsDynamicRam { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciNicInput> NicsToInclude { get { throw null; } }
        public string OSType { get { throw null; } set { } }
        public int? TargetCpuCores { get { throw null; } set { } }
        public int? TargetMemoryInMegaBytes { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciProtectedNicProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>
    {
        internal HyperVToAzStackHciProtectedNicProperties() { }
        public string MacAddress { get { throw null; } }
        public string NetworkName { get { throw null; } }
        public string NicId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection? SelectionTypeForFailover { get { throw null; } }
        public string TargetNetworkId { get { throw null; } }
        public string TestNetworkId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciProtectedNicProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciRecoveryPointModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>
    {
        internal HyperVToAzStackHciRecoveryPointModelCustomProperties() { }
        public System.Collections.Generic.IReadOnlyList<string> DiskIds { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciRecoveryPointModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HyperVToAzStackHciReplicationExtensionModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>
    {
        public HyperVToAzStackHciReplicationExtensionModelCustomProperties(string hyperVFabricArmId, string azStackHciFabricArmId) { }
        public string AsrServiceUri { get { throw null; } }
        public string AzStackHciFabricArmId { get { throw null; } set { } }
        public string AzStackHciSiteId { get { throw null; } }
        public string GatewayServiceUri { get { throw null; } }
        public string HyperVFabricArmId { get { throw null; } set { } }
        public string HyperVSiteId { get { throw null; } }
        public string RcmServiceUri { get { throw null; } }
        public string ResourceGroup { get { throw null; } }
        public string ResourceLocation { get { throw null; } }
        public string SourceGatewayServiceId { get { throw null; } }
        public string SourceStorageContainerName { get { throw null; } }
        public string StorageAccountId { get { throw null; } set { } }
        public string StorageAccountSasSecretName { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } }
        public string TargetGatewayServiceId { get { throw null; } }
        public string TargetStorageContainerName { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class IdentityModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>
    {
        public IdentityModel(string tenantId, string applicationId, string objectId, string audience, string aadAuthority) { }
        public string AadAuthority { get { throw null; } set { } }
        public string ApplicationId { get { throw null; } set { } }
        public string Audience { get { throw null; } set { } }
        public string ObjectId { get { throw null; } set { } }
        public string TenantId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class InnerHealthErrorModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>
    {
        internal InnerHealthErrorModel() { }
        public string Category { get { throw null; } }
        public string Causes { get { throw null; } }
        public string Code { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string HealthCategory { get { throw null; } }
        public bool? IsCustomerResolvable { get { throw null; } }
        public string Message { get { throw null; } }
        public string Recommendation { get { throw null; } }
        public string Severity { get { throw null; } }
        public string Source { get { throw null; } }
        public string Summary { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.InnerHealthErrorModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class JobModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>
    {
        protected JobModelCustomProperties() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails AffectedObjectDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class JobModelCustomPropertiesAffectedObjectDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>
    {
        internal JobModelCustomPropertiesAffectedObjectDetails() { }
        public string Description { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType? Type { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JobModelCustomPropertiesAffectedObjectDetailsType : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JobModelCustomPropertiesAffectedObjectDetailsType(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType Object { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomPropertiesAffectedObjectDetailsType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class JobModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>
    {
        internal JobModelProperties() { }
        public string ActivityId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> AllowedActions { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties CustomProperties { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ErrorModel> Errors { get { throw null; } }
        public string ObjectId { get { throw null; } }
        public string ObjectInternalId { get { throw null; } }
        public string ObjectInternalName { get { throw null; } }
        public string ObjectName { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType? ObjectType { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ReplicationProviderId { get { throw null; } }
        public string SourceFabricProviderId { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState? State { get { throw null; } }
        public string TargetFabricProviderId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel> Tasks { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JobObjectType : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JobObjectType(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType AvsDiskPool { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType Fabric { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType FabricAgent { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType Policy { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType ProtectedItem { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType RecoveryPlan { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType ReplicationExtension { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType Vault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobObjectType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JobState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JobState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState Cancelled { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState Cancelling { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState CompletedWithErrors { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState CompletedWithInformation { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState CompletedWithWarnings { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState Failed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState Pending { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState Started { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OperationStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>
    {
        internal OperationStatus() { }
        public string EndTime { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public string StartTime { get { throw null; } }
        public string Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.OperationStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PlannedFailoverModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>
    {
        public PlannedFailoverModel(Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties properties) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties PlannedFailoverModelCustomProperties { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class PlannedFailoverModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>
    {
        protected PlannedFailoverModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PlannedFailoverModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>
    {
        public PlannedFailoverModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties customProperties) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties CustomProperties { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class PolicyModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>
    {
        protected PolicyModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>
    {
        public PolicyModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties customProperties) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties CustomProperties { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateEndpointConnectionProxyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>
    {
        public PrivateEndpointConnectionProxyProperties() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint RemotePrivateEndpoint { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionProxyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateEndpointConnectionResponseProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>
    {
        public PrivateEndpointConnectionResponseProperties() { }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrivateEndpointConnectionStatus : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrivateEndpointConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrivateLinkServiceConnection : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>
    {
        public PrivateLinkServiceConnection() { }
        public System.Collections.Generic.IList<string> GroupIds { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string RequestMessage { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateLinkServiceProxy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>
    {
        public PrivateLinkServiceProxy() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.GroupConnectivityInformation> GroupConnectivityInformation { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier RemotePrivateEndpointConnectionId { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProtectedItemActiveLocation : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProtectedItemActiveLocation(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation Primary { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation Recovery { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProtectedItemDynamicMemoryConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>
    {
        public ProtectedItemDynamicMemoryConfig(long maximumMemoryInMegaBytes, long minimumMemoryInMegaBytes, int targetMemoryBufferPercentage) { }
        public long MaximumMemoryInMegaBytes { get { throw null; } set { } }
        public long MinimumMemoryInMegaBytes { get { throw null; } set { } }
        public int TargetMemoryBufferPercentage { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProtectedItemJobProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>
    {
        internal ProtectedItemJobProperties() { }
        public string DisplayName { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public string ScenarioName { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public string State { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ProtectedItemModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>
    {
        protected ProtectedItemModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ProtectedItemModelCustomPropertiesUpdate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>
    {
        protected ProtectedItemModelCustomPropertiesUpdate() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProtectedItemModelPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>
    {
        public ProtectedItemModelPatch() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate CustomProperties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProtectedItemModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>
    {
        public ProtectedItemModelProperties(string policyName, string replicationExtensionName, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties customProperties) { }
        public System.Collections.Generic.IReadOnlyList<string> AllowedJobs { get { throw null; } }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties CurrentJob { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties CustomProperties { get { throw null; } set { } }
        public string FabricAgentId { get { throw null; } }
        public string FabricId { get { throw null; } }
        public string FabricObjectId { get { throw null; } }
        public string FabricObjectName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthErrorModel> HealthErrors { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties LastFailedEnableProtectionJob { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties LastFailedPlannedFailoverJob { get { throw null; } }
        public System.DateTimeOffset? LastSuccessfulPlannedFailoverOn { get { throw null; } }
        public System.DateTimeOffset? LastSuccessfulTestFailoverOn { get { throw null; } }
        public System.DateTimeOffset? LastSuccessfulUnplannedFailoverOn { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties LastTestFailoverJob { get { throw null; } }
        public string PolicyName { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState? ProtectionState { get { throw null; } }
        public string ProtectionStateDescription { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ReplicationExtensionName { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.HealthStatus? ReplicationHealth { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState? ResynchronizationState { get { throw null; } }
        public bool? ResyncRequired { get { throw null; } }
        public string SourceFabricProviderId { get { throw null; } }
        public string TargetFabricAgentId { get { throw null; } }
        public string TargetFabricId { get { throw null; } }
        public string TargetFabricProviderId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState? TestFailoverState { get { throw null; } }
        public string TestFailoverStateDescription { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProtectionState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProtectionState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CancelFailoverFailedOnPrimary { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CancelFailoverFailedOnRecovery { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CancelFailoverInProgressOnPrimary { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CancelFailoverInProgressOnRecovery { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CancelFailoverStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CancelFailoverStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ChangeRecoveryPointCompleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ChangeRecoveryPointFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ChangeRecoveryPointInitiated { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ChangeRecoveryPointStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ChangeRecoveryPointStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverCompleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverFailedOnPrimary { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverFailedOnRecovery { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverInProgressOnPrimary { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverInProgressOnRecovery { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState CommitFailoverStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState DisablingFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState DisablingProtection { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState EnablingFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState EnablingProtection { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState InitialReplicationCompletedOnPrimary { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState InitialReplicationCompletedOnRecovery { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState InitialReplicationFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState InitialReplicationInProgress { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState InitialReplicationStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState InitialReplicationStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState MarkedForDeletion { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverCompleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverCompleting { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverCompletionFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverInitiated { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverTransitionStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState PlannedFailoverTransitionStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState Protected { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ProtectedStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ProtectedStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ReprotectFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ReprotectInitiated { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ReprotectStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState ReprotectStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverCompleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverCompleting { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverCompletionFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverInitiated { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverTransitionStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnplannedFailoverTransitionStatesEnd { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnprotectedStatesBegin { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState UnprotectedStatesEnd { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectionState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Deleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class RecoveryPointModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>
    {
        protected RecoveryPointModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecoveryPointModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>
    {
        internal RecoveryPointModelProperties() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties CustomProperties { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.DateTimeOffset RecoveryPointOn { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType RecoveryPointType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecoveryPointType : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecoveryPointType(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType ApplicationConsistent { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType CrashConsistent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateLinkResourceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>
    {
        internal RecoveryServicesDataReplicationPrivateLinkResourceProperties() { }
        public string GroupId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkResourceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecoveryServicesDataReplicationPrivateLinkServiceConnectionState : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>
    {
        public RecoveryServicesDataReplicationPrivateLinkServiceConnectionState() { }
        public string ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionStatus? Status { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationPrivateLinkServiceConnectionState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RemotePrivateEndpoint : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>
    {
        public RemotePrivateEndpoint(string id) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ConnectionDetails> ConnectionDetails { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnection> PrivateLinkServiceConnections { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.PrivateLinkServiceProxy> PrivateLinkServiceProxies { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ReplicationExtensionModelCustomProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>
    {
        protected ReplicationExtensionModelCustomProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReplicationExtensionModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>
    {
        public ReplicationExtensionModelProperties(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties customProperties) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties CustomProperties { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReplicationVaultType : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReplicationVaultType(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType DisasterRecovery { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType Migrate { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResynchronizationState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResynchronizationState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState None { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState ResynchronizationCompleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState ResynchronizationFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState ResynchronizationInitiated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.ResynchronizationState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class StorageContainerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>
    {
        public StorageContainerProperties(string name, string clusterSharedVolumePath) { }
        public string ClusterSharedVolumePath { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.StorageContainerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TaskModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>
    {
        internal TaskModel() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.JobModelData> ChildrenJobs { get { throw null; } }
        public string CustomInstanceType { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState? State { get { throw null; } }
        public string TaskName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TaskState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TaskState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState Cancelled { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState Failed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState Pending { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState Skipped { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState Started { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.TaskState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TestFailoverCleanupJobModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>
    {
        internal TestFailoverCleanupJobModelCustomProperties() { }
        public string Comments { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverCleanupJobModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestFailoverJobModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.JobModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>
    {
        internal TestFailoverJobModelCustomProperties() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.FailoverProtectedItemProperties> ProtectedItemDetails { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverJobModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TestFailoverState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TestFailoverState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState MarkedForDeletion { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState None { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverCleanupCompleting { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverCleanupInitiated { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverCompleted { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverCompleting { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverCompletionFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverFailed { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState TestFailoverInitiated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.TestFailoverState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VaultModelPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>
    {
        public VaultModelPatch() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VaultModelProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>
    {
        public VaultModelProperties() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ServiceResourceId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationVaultType? VaultType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VaultModelProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VmNicSelection : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VmNicSelection(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection NotSelected { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection SelectedByDefault { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection SelectedByUser { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection SelectedByUserOverride { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VMwareFabricAgentModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>
    {
        public VMwareFabricAgentModelCustomProperties(string biosId, Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel marsAuthenticationIdentity) { }
        public string BiosId { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.IdentityModel MarsAuthenticationIdentity { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareFabricAgentModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareMigrateFabricModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.FabricModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>
    {
        public VMwareMigrateFabricModelCustomProperties(string vmwareSiteId, string migrationSolutionId) { }
        public string MigrationSolutionId { get { throw null; } set { } }
        public string VmwareSiteId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareMigrateFabricModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciDiskInput : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>
    {
        public VMwareToAzStackHciDiskInput(string diskId, long diskSizeGB, string diskFileFormat, bool isOSDisk) { }
        public long? DiskBlockSize { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.DiskControllerInputs DiskController { get { throw null; } set { } }
        public string DiskFileFormat { get { throw null; } set { } }
        public string DiskId { get { throw null; } set { } }
        public string DiskIdentifier { get { throw null; } set { } }
        public long? DiskLogicalSectorSize { get { throw null; } set { } }
        public long? DiskPhysicalSectorSize { get { throw null; } set { } }
        public long DiskSizeGB { get { throw null; } set { } }
        public bool? IsDynamic { get { throw null; } set { } }
        public bool IsOSDisk { get { throw null; } set { } }
        public string StorageContainerId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciEventModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.EventModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>
    {
        internal VMwareToAzStackHciEventModelCustomProperties() { }
        public string EventSourceFriendlyName { get { throw null; } }
        public string ProtectedItemFriendlyName { get { throw null; } }
        public string ServerType { get { throw null; } }
        public string SourceApplianceName { get { throw null; } }
        public string TargetApplianceName { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciEventModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciNicInput : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>
    {
        public VMwareToAzStackHciNicInput(string nicId, string label, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection selectionTypeForFailover) { }
        public bool? IsMacMigrationEnabled { get { throw null; } set { } }
        public bool? IsStaticIPMigrationEnabled { get { throw null; } set { } }
        public string Label { get { throw null; } set { } }
        public string NetworkName { get { throw null; } }
        public string NicId { get { throw null; } set { } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection SelectionTypeForFailover { get { throw null; } set { } }
        public string TargetNetworkId { get { throw null; } set { } }
        public string TestNetworkId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciPlannedFailoverModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>
    {
        public VMwareToAzStackHciPlannedFailoverModelCustomProperties(bool shutdownSourceVm) { }
        public bool ShutdownSourceVm { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciPolicyModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.PolicyModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>
    {
        public VMwareToAzStackHciPolicyModelCustomProperties(int recoveryPointHistoryInMinutes, int crashConsistentFrequencyInMinutes, int appConsistentFrequencyInMinutes) { }
        public int AppConsistentFrequencyInMinutes { get { throw null; } set { } }
        public int CrashConsistentFrequencyInMinutes { get { throw null; } set { } }
        public int RecoveryPointHistoryInMinutes { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciPolicyModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciProtectedDiskProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>
    {
        internal VMwareToAzStackHciProtectedDiskProperties() { }
        public long? CapacityInBytes { get { throw null; } }
        public long? DiskBlockSize { get { throw null; } }
        public long? DiskLogicalSectorSize { get { throw null; } }
        public long? DiskPhysicalSectorSize { get { throw null; } }
        public string DiskType { get { throw null; } }
        public bool? IsDynamic { get { throw null; } }
        public bool? IsOSDisk { get { throw null; } }
        public string MigrateDiskName { get { throw null; } }
        public string SeedDiskName { get { throw null; } }
        public string SourceDiskId { get { throw null; } }
        public string SourceDiskName { get { throw null; } }
        public string StorageContainerId { get { throw null; } }
        public string StorageContainerLocalPath { get { throw null; } }
        public string TestMigrateDiskName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciProtectedItemModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>
    {
        public VMwareToAzStackHciProtectedItemModelCustomProperties(string targetHciClusterId, string targetArcClusterCustomLocationId, string storageContainerId, string targetResourceGroupId, string customLocationRegion, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput> disksToInclude, System.Collections.Generic.IEnumerable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput> nicsToInclude, string hyperVGeneration, string fabricDiscoveryMachineId, string runAsAccountId, string sourceFabricAgentName, string targetFabricAgentName) { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemActiveLocation? ActiveLocation { get { throw null; } }
        public string CustomLocationRegion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciDiskInput> DisksToInclude { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get { throw null; } set { } }
        public string FabricDiscoveryMachineId { get { throw null; } set { } }
        public string FailoverRecoveryPointId { get { throw null; } }
        public string FirmwareType { get { throw null; } }
        public string HyperVGeneration { get { throw null; } set { } }
        public int? InitialReplicationProgressPercentage { get { throw null; } }
        public bool? IsDynamicRam { get { throw null; } set { } }
        public string LastRecoveryPointId { get { throw null; } }
        public System.DateTimeOffset? LastRecoveryPointReceived { get { throw null; } }
        public System.DateTimeOffset? LastReplicationUpdateOn { get { throw null; } }
        public int? MigrationProgressPercentage { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput> NicsToInclude { get { throw null; } }
        public string OSName { get { throw null; } }
        public string OSType { get { throw null; } }
        public bool? PerformAutoResync { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedDiskProperties> ProtectedDisks { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties> ProtectedNics { get { throw null; } }
        public int? ResumeProgressPercentage { get { throw null; } }
        public long? ResumeRetryCount { get { throw null; } }
        public int? ResyncProgressPercentage { get { throw null; } }
        public bool? ResyncRequired { get { throw null; } }
        public long? ResyncRetryCount { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState? ResyncState { get { throw null; } }
        public string RunAsAccountId { get { throw null; } set { } }
        public string SourceApplianceName { get { throw null; } }
        public int? SourceCpuCores { get { throw null; } }
        public string SourceFabricAgentName { get { throw null; } set { } }
        public double? SourceMemoryInMegaBytes { get { throw null; } }
        public string SourceVmName { get { throw null; } }
        public string StorageContainerId { get { throw null; } set { } }
        public string TargetApplianceName { get { throw null; } }
        public string TargetArcClusterCustomLocationId { get { throw null; } set { } }
        public string TargetAzStackHciClusterName { get { throw null; } }
        public int? TargetCpuCores { get { throw null; } set { } }
        public string TargetFabricAgentName { get { throw null; } set { } }
        public string TargetHciClusterId { get { throw null; } set { } }
        public string TargetLocation { get { throw null; } }
        public int? TargetMemoryInMegaBytes { get { throw null; } set { } }
        public string TargetNetworkId { get { throw null; } set { } }
        public string TargetResourceGroupId { get { throw null; } set { } }
        public string TargetVmBiosId { get { throw null; } }
        public string TargetVmName { get { throw null; } set { } }
        public string TestNetworkId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate : Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>
    {
        public VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate() { }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get { throw null; } set { } }
        public bool? IsDynamicRam { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciNicInput> NicsToInclude { get { throw null; } }
        public string OSType { get { throw null; } set { } }
        public int? TargetCpuCores { get { throw null; } set { } }
        public int? TargetMemoryInMegaBytes { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedItemModelCustomPropertiesUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciProtectedNicProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>
    {
        internal VMwareToAzStackHciProtectedNicProperties() { }
        public bool? IsPrimaryNic { get { throw null; } }
        public string Label { get { throw null; } }
        public string MacAddress { get { throw null; } }
        public string NetworkName { get { throw null; } }
        public string NicId { get { throw null; } }
        public Azure.ResourceManager.RecoveryServicesDataReplication.Models.VmNicSelection? SelectionTypeForFailover { get { throw null; } }
        public string TargetNetworkId { get { throw null; } }
        public string TestNetworkId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciProtectedNicProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciRecoveryPointModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>
    {
        internal VMwareToAzStackHciRecoveryPointModelCustomProperties() { }
        public System.Collections.Generic.IReadOnlyList<string> DiskIds { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciRecoveryPointModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMwareToAzStackHciReplicationExtensionModelCustomProperties : Azure.ResourceManager.RecoveryServicesDataReplication.Models.ReplicationExtensionModelCustomProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>
    {
        public VMwareToAzStackHciReplicationExtensionModelCustomProperties(string vmwareFabricArmId, string azStackHciFabricArmId) { }
        public string AsrServiceUri { get { throw null; } }
        public string AzStackHciFabricArmId { get { throw null; } set { } }
        public string AzStackHciSiteId { get { throw null; } }
        public string GatewayServiceUri { get { throw null; } }
        public string RcmServiceUri { get { throw null; } }
        public string ResourceGroup { get { throw null; } }
        public string ResourceLocation { get { throw null; } }
        public string SourceGatewayServiceId { get { throw null; } }
        public string SourceStorageContainerName { get { throw null; } }
        public string StorageAccountId { get { throw null; } set { } }
        public string StorageAccountSasSecretName { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } }
        public string TargetGatewayServiceId { get { throw null; } }
        public string TargetStorageContainerName { get { throw null; } }
        public string VmwareFabricArmId { get { throw null; } set { } }
        public string VmwareSiteId { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VMwareToAzureMigrateResyncState : System.IEquatable<Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VMwareToAzureMigrateResyncState(string value) { throw null; }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState None { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState PreparedForResynchronization { get { throw null; } }
        public static Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState StartedResynchronization { get { throw null; } }
        public bool Equals(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState right) { throw null; }
        public static implicit operator Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState left, Azure.ResourceManager.RecoveryServicesDataReplication.Models.VMwareToAzureMigrateResyncState right) { throw null; }
        public override string ToString() { throw null; }
    }
}
