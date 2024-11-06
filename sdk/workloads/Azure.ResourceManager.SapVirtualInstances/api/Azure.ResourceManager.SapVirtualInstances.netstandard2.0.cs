namespace Azure.ResourceManager.SapVirtualInstances
{
    public partial class SAPApplicationServerInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>, System.Collections.IEnumerable
    {
        protected SAPApplicationServerInstanceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string applicationInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string applicationInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> Get(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> GetAsync(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> GetIfExists(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> GetIfExistsAsync(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SAPApplicationServerInstanceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>
    {
        public SAPApplicationServerInstanceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPApplicationServerInstanceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SAPApplicationServerInstanceResource() { }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string applicationInstanceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Start(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StartAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Stop(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StopAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> Update(Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> UpdateAsync(Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SAPCentralServerInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>, System.Collections.IEnumerable
    {
        protected SAPCentralServerInstanceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string centralInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string centralInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> Get(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> GetAsync(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> GetIfExists(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> GetIfExistsAsync(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SAPCentralServerInstanceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>
    {
        public SAPCentralServerInstanceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPCentralServerInstanceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SAPCentralServerInstanceResource() { }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Start(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StartAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Stop(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StopAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> Update(Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> UpdateAsync(Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SAPDatabaseInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>, System.Collections.IEnumerable
    {
        protected SAPDatabaseInstanceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string databaseInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string databaseInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> Get(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> GetAsync(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> GetIfExists(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> GetIfExistsAsync(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SAPDatabaseInstanceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>
    {
        public SAPDatabaseInstanceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPDatabaseInstanceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SAPDatabaseInstanceResource() { }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string databaseInstanceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Start(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StartAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Stop(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StopAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> Update(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> UpdateAsync(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SAPVirtualInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>, System.Collections.IEnumerable
    {
        protected SAPVirtualInstanceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string sapVirtualInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string sapVirtualInstanceName, Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> Get(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> GetAsync(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetIfExists(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> GetIfExistsAsync(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SAPVirtualInstanceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>
    {
        public SAPVirtualInstanceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPVirtualInstanceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SAPVirtualInstanceResource() { }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource> GetSAPApplicationServerInstance(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource>> GetSAPApplicationServerInstanceAsync(string applicationInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceCollection GetSAPApplicationServerInstances() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource> GetSAPCentralServerInstance(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource>> GetSAPCentralServerInstanceAsync(string centralInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceCollection GetSAPCentralServerInstances() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource> GetSAPDatabaseInstance(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource>> GetSAPDatabaseInstanceAsync(string databaseInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceCollection GetSAPDatabaseInstances() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Start(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StartAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StartContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Stop(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>> StopAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.StopContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class SapVirtualInstancesExtensions
    {
        public static Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult> GetAvailabilityZoneDetailsSAPVirtualInstance(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>> GetAvailabilityZoneDetailsSAPVirtualInstanceAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult> GetDiskConfigurationsSAPVirtualInstance(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>> GetDiskConfigurationsSAPVirtualInstanceAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource GetSAPApplicationServerInstanceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource GetSAPCentralServerInstanceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource GetSAPDatabaseInstanceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult> GetSapSupportedSkuSAPVirtualInstance(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>> GetSapSupportedSkuSAPVirtualInstanceAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetSAPVirtualInstance(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> GetSAPVirtualInstanceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource GetSAPVirtualInstanceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceCollection GetSAPVirtualInstances(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetSAPVirtualInstances(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetSAPVirtualInstancesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult> GetSizingRecommendationsSAPVirtualInstance(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>> GetSizingRecommendationsSAPVirtualInstanceAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SapVirtualInstances.Mocking
{
    public partial class MockableSapVirtualInstancesArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableSapVirtualInstancesArmClient() { }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceResource GetSAPApplicationServerInstanceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceResource GetSAPCentralServerInstanceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceResource GetSAPDatabaseInstanceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource GetSAPVirtualInstanceResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableSapVirtualInstancesResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSapVirtualInstancesResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetSAPVirtualInstance(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource>> GetSAPVirtualInstanceAsync(string sapVirtualInstanceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceCollection GetSAPVirtualInstances() { throw null; }
    }
    public partial class MockableSapVirtualInstancesSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSapVirtualInstancesSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult> GetAvailabilityZoneDetailsSAPVirtualInstance(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>> GetAvailabilityZoneDetailsSAPVirtualInstanceAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult> GetDiskConfigurationsSAPVirtualInstance(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>> GetDiskConfigurationsSAPVirtualInstanceAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult> GetSapSupportedSkuSAPVirtualInstance(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>> GetSapSupportedSkuSAPVirtualInstanceAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetSAPVirtualInstances(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceResource> GetSAPVirtualInstancesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult> GetSizingRecommendationsSAPVirtualInstance(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>> GetSizingRecommendationsSAPVirtualInstanceAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SapVirtualInstances.Models
{
    public partial class ApplicationServerConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>
    {
        public ApplicationServerConfiguration(string subnetId, Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration virtualMachineConfiguration, long instanceCount) { }
        public long InstanceCount { get { throw null; } set { } }
        public string SubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration VirtualMachineConfiguration { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApplicationServerFullResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>
    {
        public ApplicationServerFullResourceNames() { }
        public string AvailabilitySetName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames> VirtualMachines { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApplicationServerVirtualMachineType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApplicationServerVirtualMachineType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType Active { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType Standby { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType left, Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType left, Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApplicationServerVmDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>
    {
        internal ApplicationServerVmDetails() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> StorageDetails { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType? Type { get { throw null; } }
        public string VirtualMachineId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmSapVirtualInstancesModelFactory
    {
        public static Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails ApplicationServerVmDetails(Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType? type = default(Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVirtualMachineType?), string virtualMachineId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> storageDetails = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails CentralServerVmDetails(Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType? type = default(Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType?), string virtualMachineId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> storageDetails = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails DatabaseVmDetails(string virtualMachineId = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? status = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> storageDetails = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration DiscoveryConfiguration(string centralServerVmId = null, string managedRgStorageAccountName = null, string appLocation = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails DiskDetails(Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName? skuName = default(Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName?), long? sizeGB = default(long?), long? minimumSupportedDiskCount = default(long?), long? maximumSupportedDiskCount = default(long?), long? iopsReadWrite = default(long?), long? mbpsReadWrite = default(long?), string diskTier = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties EnqueueReplicationServerProperties(Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType? ersVersion = default(Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType?), string instanceNo = null, string hostname = null, string kernelVersion = null, string kernelPatch = null, string ipAddress = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties EnqueueServerProperties(string hostname = null, string ipAddress = null, long? port = default(long?), Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation ErrorInformation(string code = null, string message = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation> details = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties GatewayServerProperties(long? port = default(long?), Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties MessageServerProperties(long? msPort = default(long?), long? internalMsPort = default(long?), long? httpPort = default(long?), long? httpsPort = default(long?), string hostname = null, string ipAddress = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult OperationStatusResult(string id = null, string name = null, string status = null, double? percentComplete = default(double?), System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> operations = null, Azure.ResponseError error = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPApplicationServerInstanceData SAPApplicationServerInstanceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties properties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties SAPApplicationServerProperties(string instanceNo = null, string subnet = null, string hostname = null, string kernelVersion = null, string kernelPatch = null, string ipAddress = null, long? gatewayPort = default(long?), long? icmHttpPort = default(long?), long? icmHttpsPort = default(long?), string dispatcherStatus = null, Azure.Core.ResourceIdentifier loadBalancerDetailsId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails> vmDetails = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? status = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus?), Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?), Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? provisioningState = default(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState?), Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation errorsProperties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult SAPAvailabilityZoneDetailsResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair> availabilityZonePairs = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair SAPAvailabilityZonePair(long? zoneA = default(long?), long? zoneB = default(long?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPCentralServerInstanceData SAPCentralServerInstanceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties properties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties SAPCentralServerProperties(string instanceNo = null, string subnet = null, Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties messageServerProperties = null, Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties enqueueServerProperties = null, Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties gatewayServerProperties = null, Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties enqueueReplicationServerProperties = null, string kernelVersion = null, string kernelPatch = null, Azure.Core.ResourceIdentifier loadBalancerDetailsId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails> vmDetails = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? status = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus?), Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?), Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? provisioningState = default(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState?), Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation errorsProperties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPDatabaseInstanceData SAPDatabaseInstanceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties properties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties SAPDatabaseProperties(string subnet = null, string databaseSid = null, string databaseType = null, string ipAddress = null, Azure.Core.ResourceIdentifier loadBalancerDetailsId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails> vmDetails = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? status = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus?), Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? provisioningState = default(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState?), Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation errorsProperties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration SAPDiskConfiguration(Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration recommendedConfiguration = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails> supportedConfigurations = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult SAPDiskConfigurationsResult(System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration> volumeConfigurations = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent SAPSizingRecommendationContent(string appLocation = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType), Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType), Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType deploymentType = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType), long saps = (long)0, long dbMemory = (long)0, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType databaseType = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType), Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod? dbScaleMethod = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod?), Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType? highAvailabilityType = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult SAPSupportedResourceSkusResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku> supportedSkus = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku SAPSupportedSku(string vmSku = null, bool? isAppServerCertified = default(bool?), bool? isDatabaseCertified = default(bool?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent SAPSupportedSkusContent(string appLocation = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType), Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType), Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType deploymentType = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType), Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType databaseType = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType), Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType? highAvailabilityType = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType?)) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.SAPVirtualInstanceData SAPVirtualInstanceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties properties = null, Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity identity = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties SAPVirtualInstanceProperties(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType), Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType), Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType? managedResourcesNetworkAccessType = default(Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType?), Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration configuration = null, string managedResourceGroupName = null, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? status = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus?), Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? health = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState?), Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState? state = default(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState?), Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? provisioningState = default(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState?), Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation errorsProperties = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult SingleServerRecommendationResult(string vmSku = null) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult ThreeTierRecommendationResult(string dbVmSku = null, long? databaseInstanceCount = default(long?), string centralServerVmSku = null, long? centralServerInstanceCount = default(long?), string applicationServerVmSku = null, long? applicationServerInstanceCount = default(long?)) { throw null; }
    }
    public partial class CentralServerConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>
    {
        public CentralServerConfiguration(string subnetId, Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration virtualMachineConfiguration, long instanceCount) { }
        public long InstanceCount { get { throw null; } set { } }
        public string SubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration VirtualMachineConfiguration { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CentralServerFullResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>
    {
        public CentralServerFullResourceNames() { }
        public string AvailabilitySetName { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames LoadBalancer { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames> VirtualMachines { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CentralServerVirtualMachineType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CentralServerVirtualMachineType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType ASCS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType ERS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType ERSInactive { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType Primary { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType Secondary { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType Standby { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType left, Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType left, Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CentralServerVmDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>
    {
        internal CentralServerVmDetails() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> StorageDetails { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVirtualMachineType? Type { get { throw null; } }
        public string VirtualMachineId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreateAndMountFileShareConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>
    {
        public CreateAndMountFileShareConfiguration() { }
        public string ResourceGroup { get { throw null; } set { } }
        public string StorageAccountName { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.CreateAndMountFileShareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DatabaseConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>
    {
        public DatabaseConfiguration(string subnetId, Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration virtualMachineConfiguration, long instanceCount) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType? DatabaseType { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration> DiskVolumeConfigurations { get { throw null; } }
        public long InstanceCount { get { throw null; } set { } }
        public string SubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration VirtualMachineConfiguration { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DatabaseServerFullResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>
    {
        public DatabaseServerFullResourceNames() { }
        public string AvailabilitySetName { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames LoadBalancer { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames> VirtualMachines { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DatabaseVmDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>
    {
        internal DatabaseVmDetails() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> StorageDetails { get { throw null; } }
        public string VirtualMachineId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeployerVmPackages : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>
    {
        public DeployerVmPackages() { }
        public string StorageAccountId { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>
    {
        public DeploymentConfiguration() { }
        public string AppLocation { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration InfrastructureConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration SoftwareConfiguration { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentWithOSConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>
    {
        public DeploymentWithOSConfiguration() { }
        public string AppLocation { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration InfrastructureConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration OSSapConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration SoftwareConfiguration { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DeploymentWithOSConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DiscoveryConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>
    {
        public DiscoveryConfiguration() { }
        public string AppLocation { get { throw null; } }
        public string CentralServerVmId { get { throw null; } set { } }
        public string ManagedRgStorageAccountName { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiscoveryConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DiskDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>
    {
        internal DiskDetails() { }
        public string DiskTier { get { throw null; } }
        public long? IopsReadWrite { get { throw null; } }
        public long? MaximumSupportedDiskCount { get { throw null; } }
        public long? MbpsReadWrite { get { throw null; } }
        public long? MinimumSupportedDiskCount { get { throw null; } }
        public long? SizeGB { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName? SkuName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskSkuName : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskSkuName(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName PremiumLRS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName PremiumV2LRS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName PremiumZRS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName StandardLRS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName StandardSSDLRS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName StandardSSDZRS { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName UltraSSDLRS { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName left, Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName left, Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiskVolumeConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>
    {
        public DiskVolumeConfiguration() { }
        public long? Count { get { throw null; } set { } }
        public long? SizeGB { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.DiskSkuName? SkuName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EnqueueReplicationServerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>
    {
        public EnqueueReplicationServerProperties() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType? ErsVersion { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public string Hostname { get { throw null; } }
        public string InstanceNo { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public string KernelPatch { get { throw null; } }
        public string KernelVersion { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnqueueReplicationServerType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnqueueReplicationServerType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType EnqueueReplicator1 { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType EnqueueReplicator2 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType left, Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType left, Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EnqueueServerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>
    {
        public EnqueueServerProperties() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public string Hostname { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public long? Port { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>
    {
        internal ErrorInformation() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation> Details { get { throw null; } }
        public string Message { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExternalInstallationSoftwareConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>
    {
        public ExternalInstallationSoftwareConfiguration() { }
        public string CentralServerVmId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ExternalInstallationSoftwareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class FileShareConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>
    {
        protected FileShareConfiguration() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GatewayServerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>
    {
        public GatewayServerProperties() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public long? Port { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HighAvailabilitySoftwareConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>
    {
        public HighAvailabilitySoftwareConfiguration(string fencingClientId, string fencingClientPassword) { }
        public string FencingClientId { get { throw null; } set { } }
        public string FencingClientPassword { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ImageReference : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>
    {
        public ImageReference() { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } set { } }
        public string Offer { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public string Sku { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ImageReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ImageReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ImageReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class InfrastructureConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>
    {
        protected InfrastructureConfiguration(string appResourceGroup) { }
        public string AppResourceGroup { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LinuxConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>
    {
        public LinuxConfiguration() { }
        public bool? DisablePasswordAuthentication { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair SshKeyPair { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey> SshPublicKeys { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LinuxConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LoadBalancerResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>
    {
        public LoadBalancerResourceNames() { }
        public System.Collections.Generic.IList<string> BackendPoolNames { get { throw null; } }
        public System.Collections.Generic.IList<string> FrontendIPConfigurationNames { get { throw null; } }
        public System.Collections.Generic.IList<string> HealthProbeNames { get { throw null; } }
        public string LoadBalancerName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.LoadBalancerResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedResourcesNetworkAccessType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedResourcesNetworkAccessType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType Private { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType Public { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType left, Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType left, Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MessageServerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>
    {
        public MessageServerProperties() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public string Hostname { get { throw null; } }
        public long? HttpPort { get { throw null; } }
        public long? HttpsPort { get { throw null; } }
        public long? InternalMsPort { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public long? MsPort { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MountFileShareConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>
    {
        public MountFileShareConfiguration(string id, string privateEndpointId) { }
        public string Id { get { throw null; } set { } }
        public string PrivateEndpointId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.MountFileShareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkInterfaceResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>
    {
        public NetworkInterfaceResourceNames() { }
        public string NetworkInterfaceName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OperationStatusResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>
    {
        internal OperationStatusResult() { }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public Azure.ResponseError Error { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult> Operations { get { throw null; } }
        public double? PercentComplete { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public string Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OperationStatusResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class OSConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>
    {
        protected OSConfiguration() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>
    {
        public OSProfile() { }
        public string AdminPassword { get { throw null; } set { } }
        public string AdminUsername { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration OSConfiguration { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OSProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OSProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSSapConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>
    {
        public OSSapConfiguration() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.DeployerVmPackages DeployerVmPackages { get { throw null; } set { } }
        public string SapFqdn { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.OSSapConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPApplicationServerInstancePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>
    {
        public SAPApplicationServerInstancePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerInstancePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPApplicationServerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>
    {
        public SAPApplicationServerProperties() { }
        public string DispatcherStatus { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation ErrorsProperties { get { throw null; } }
        public long? GatewayPort { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public string Hostname { get { throw null; } }
        public long? IcmHttpPort { get { throw null; } }
        public long? IcmHttpsPort { get { throw null; } }
        public string InstanceNo { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public string KernelPatch { get { throw null; } }
        public string KernelVersion { get { throw null; } }
        public Azure.Core.ResourceIdentifier LoadBalancerDetailsId { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? Status { get { throw null; } }
        public string Subnet { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerVmDetails> VmDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPApplicationServerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPAvailabilityZoneDetailsContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>
    {
        public SAPAvailabilityZoneDetailsContent(string appLocation, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType databaseType) { }
        public string AppLocation { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType DatabaseType { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType SapProduct { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPAvailabilityZoneDetailsResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>
    {
        internal SAPAvailabilityZoneDetailsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair> AvailabilityZonePairs { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZoneDetailsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPAvailabilityZonePair : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>
    {
        internal SAPAvailabilityZonePair() { }
        public long? ZoneA { get { throw null; } }
        public long? ZoneB { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPAvailabilityZonePair>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPCentralServerInstancePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>
    {
        public SAPCentralServerInstancePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerInstancePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPCentralServerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>
    {
        public SAPCentralServerProperties() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.EnqueueReplicationServerProperties EnqueueReplicationServerProperties { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.EnqueueServerProperties EnqueueServerProperties { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation ErrorsProperties { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.GatewayServerProperties GatewayServerProperties { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public string InstanceNo { get { throw null; } }
        public string KernelPatch { get { throw null; } }
        public string KernelVersion { get { throw null; } }
        public Azure.Core.ResourceIdentifier LoadBalancerDetailsId { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.MessageServerProperties MessageServerProperties { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? Status { get { throw null; } }
        public string Subnet { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.CentralServerVmDetails> VmDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPCentralServerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class SAPConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>
    {
        protected SAPConfiguration() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPDatabaseInstancePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>
    {
        public SAPDatabaseInstancePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseInstancePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPDatabaseProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>
    {
        public SAPDatabaseProperties() { }
        public string DatabaseSid { get { throw null; } }
        public string DatabaseType { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation ErrorsProperties { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public Azure.Core.ResourceIdentifier LoadBalancerDetailsId { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? Status { get { throw null; } }
        public string Subnet { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.DatabaseVmDetails> VmDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPDatabaseScaleMethod : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPDatabaseScaleMethod(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod ScaleUp { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod left, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod left, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPDatabaseType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPDatabaseType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType DB2 { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType HANA { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPDeploymentType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPDeploymentType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType SingleServer { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType ThreeTier { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SAPDiskConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>
    {
        internal SAPDiskConfiguration() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration RecommendedConfiguration { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.DiskDetails> SupportedConfigurations { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPDiskConfigurationsContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>
    {
        public SAPDiskConfigurationsContent(string appLocation, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType databaseType, Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType deploymentType, string dbVmSku) { }
        public string AppLocation { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType DatabaseType { get { throw null; } }
        public string DbVmSku { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType DeploymentType { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType Environment { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType SapProduct { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPDiskConfigurationsResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>
    {
        internal SAPDiskConfigurationsResult() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfiguration> VolumeConfigurations { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPDiskConfigurationsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPEnvironmentType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPEnvironmentType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType NonProd { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType Prod { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPHealthState : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPHealthState(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState Degraded { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState Healthy { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState Unhealthy { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState left, Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState left, Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPHighAvailabilityType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPHighAvailabilityType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType AvailabilitySet { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType AvailabilityZone { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SAPInstallWithoutOSConfigSoftwareConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>
    {
        public SAPInstallWithoutOSConfigSoftwareConfiguration(string bomUri, string sapBitsStorageAccountId, string softwareVersion) { }
        public string BomUri { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration HighAvailabilitySoftwareConfiguration { get { throw null; } set { } }
        public string SapBitsStorageAccountId { get { throw null; } set { } }
        public string SoftwareVersion { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPInstallWithoutOSConfigSoftwareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPProductType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPProductType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType ECC { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType Other { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType S4HANA { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType left, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SAPSizingRecommendationContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>
    {
        public SAPSizingRecommendationContent(string appLocation, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct, Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType deploymentType, long saps, long dbMemory, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType databaseType) { }
        public string AppLocation { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType DatabaseType { get { throw null; } }
        public long DbMemory { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseScaleMethod? DbScaleMethod { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType DeploymentType { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType Environment { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType? HighAvailabilityType { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType SapProduct { get { throw null; } }
        public long Saps { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class SAPSizingRecommendationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>
    {
        protected SAPSizingRecommendationResult() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPSupportedResourceSkusResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>
    {
        internal SAPSupportedResourceSkusResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku> SupportedSkus { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedResourceSkusResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPSupportedSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>
    {
        internal SAPSupportedSku() { }
        public bool? IsAppServerCertified { get { throw null; } }
        public bool? IsDatabaseCertified { get { throw null; } }
        public string VmSku { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPSupportedSkusContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>
    {
        public SAPSupportedSkusContent(string appLocation, Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct, Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType deploymentType, Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType databaseType) { }
        public string AppLocation { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType DatabaseType { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDeploymentType DeploymentType { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType Environment { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType? HighAvailabilityType { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType SapProduct { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPSupportedSkusContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SapVirtualInstanceIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>
    {
        public SapVirtualInstanceIdentity(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType type) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType Type { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Models.UserAssignedIdentity> UserAssignedIdentities { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SapVirtualInstanceIdentityType : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SapVirtualInstanceIdentityType(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType None { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType UserAssigned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType left, Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType left, Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SAPVirtualInstancePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>
    {
        public SAPVirtualInstancePatch() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType? UpdateSAPVirtualInstanceManagedResourcesNetworkAccessType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstancePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SAPVirtualInstanceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>
    {
        public SAPVirtualInstanceProperties(Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType environment, Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType sapProduct, Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration configuration) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPConfiguration Configuration { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPEnvironmentType Environment { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ErrorInformation ErrorsProperties { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHealthState? Health { get { throw null; } }
        public string ManagedResourceGroupName { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ManagedResourcesNetworkAccessType? ManagedResourcesNetworkAccessType { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPProductType SapProduct { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState? State { get { throw null; } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus? Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SapVirtualInstanceProvisioningState : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SapVirtualInstanceProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState left, Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState left, Azure.ResourceManager.SapVirtualInstances.Models.SapVirtualInstanceProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPVirtualInstanceState : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPVirtualInstanceState(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState ACSSInstallationBlocked { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState DiscoveryFailed { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState DiscoveryInProgress { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState DiscoveryPending { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState InfrastructureDeploymentFailed { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState InfrastructureDeploymentInProgress { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState InfrastructureDeploymentPending { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState RegistrationComplete { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState SoftwareDetectionFailed { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState SoftwareDetectionInProgress { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState SoftwareInstallationFailed { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState SoftwareInstallationInProgress { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState SoftwareInstallationPending { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState left, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState left, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SAPVirtualInstanceStatus : System.IEquatable<Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SAPVirtualInstanceStatus(string value) { throw null; }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus Offline { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus PartiallyRunning { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus Running { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus SoftShutdown { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus Starting { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus Stopping { get { throw null; } }
        public static Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus Unavailable { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus left, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus left, Azure.ResourceManager.SapVirtualInstances.Models.SAPVirtualInstanceStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceInitiatedSoftwareConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>
    {
        public ServiceInitiatedSoftwareConfiguration(string bomUri, string softwareVersion, string sapBitsStorageAccountId, string sapFqdn, string sshPrivateKey) { }
        public string BomUri { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.HighAvailabilitySoftwareConfiguration HighAvailabilitySoftwareConfiguration { get { throw null; } set { } }
        public string SapBitsStorageAccountId { get { throw null; } set { } }
        public string SapFqdn { get { throw null; } set { } }
        public string SoftwareVersion { get { throw null; } set { } }
        public string SshPrivateKey { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ServiceInitiatedSoftwareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SharedStorageResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>
    {
        public SharedStorageResourceNames() { }
        public string SharedStorageAccountName { get { throw null; } set { } }
        public string SharedStorageAccountPrivateEndPointName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleServerConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>
    {
        public SingleServerConfiguration(string appResourceGroup, string subnetId, Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration virtualMachineConfiguration) : base (default(string)) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames CustomResourceNames { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPDatabaseType? DatabaseType { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.SapVirtualInstances.Models.DiskVolumeConfiguration> DiskVolumeConfigurations { get { throw null; } }
        public bool? IsSecondaryIPEnabled { get { throw null; } set { } }
        public string SubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration VirtualMachineConfiguration { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class SingleServerCustomResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>
    {
        protected SingleServerCustomResourceNames() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleServerFullResourceNames : Azure.ResourceManager.SapVirtualInstances.Models.SingleServerCustomResourceNames, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>
    {
        public SingleServerFullResourceNames() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames VirtualMachine { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerFullResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleServerRecommendationResult : Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>
    {
        internal SingleServerRecommendationResult() { }
        public string VmSku { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SingleServerRecommendationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SkipFileShareConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>
    {
        public SkipFileShareConfiguration() { }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SkipFileShareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class SoftwareConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>
    {
        protected SoftwareConfiguration() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SoftwareConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SshKeyPair : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>
    {
        public SshKeyPair() { }
        public string PrivateKey { get { throw null; } set { } }
        public string PublicKey { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshKeyPair>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SshPublicKey : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>
    {
        public SshPublicKey() { }
        public string KeyData { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.SshPublicKey>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StartContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>
    {
        public StartContent() { }
        public bool? StartVm { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.StartContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.StartContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StartContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StopContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>
    {
        public StopContent() { }
        public bool? DeallocateVm { get { throw null; } set { } }
        public long? SoftStopTimeoutSeconds { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.StopContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.StopContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.StopContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ThreeTierConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.InfrastructureConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>
    {
        public ThreeTierConfiguration(string appResourceGroup, Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration centralServer, Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration applicationServer, Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration databaseServer) : base (default(string)) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerConfiguration ApplicationServer { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.CentralServerConfiguration CentralServer { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames CustomResourceNames { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.DatabaseConfiguration DatabaseServer { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SAPHighAvailabilityType? HighAvailabilityType { get { throw null; } set { } }
        public bool? IsSecondaryIPEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.FileShareConfiguration StorageTransportFileShareConfiguration { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ThreeTierCustomResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>
    {
        protected ThreeTierCustomResourceNames() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ThreeTierFullResourceNames : Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierCustomResourceNames, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>
    {
        public ThreeTierFullResourceNames() { }
        public Azure.ResourceManager.SapVirtualInstances.Models.ApplicationServerFullResourceNames ApplicationServer { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.CentralServerFullResourceNames CentralServer { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.DatabaseServerFullResourceNames DatabaseServer { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.SharedStorageResourceNames SharedStorage { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierFullResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ThreeTierRecommendationResult : Azure.ResourceManager.SapVirtualInstances.Models.SAPSizingRecommendationResult, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>
    {
        internal ThreeTierRecommendationResult() { }
        public long? ApplicationServerInstanceCount { get { throw null; } }
        public string ApplicationServerVmSku { get { throw null; } }
        public long? CentralServerInstanceCount { get { throw null; } }
        public string CentralServerVmSku { get { throw null; } }
        public long? DatabaseInstanceCount { get { throw null; } }
        public string DbVmSku { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.ThreeTierRecommendationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>
    {
        public VirtualMachineConfiguration(string vmSize, Azure.ResourceManager.SapVirtualInstances.Models.ImageReference imageReference, Azure.ResourceManager.SapVirtualInstances.Models.OSProfile osProfile) { }
        public Azure.ResourceManager.SapVirtualInstances.Models.ImageReference ImageReference { get { throw null; } set { } }
        public Azure.ResourceManager.SapVirtualInstances.Models.OSProfile OSProfile { get { throw null; } set { } }
        public string VmSize { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineResourceNames : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>
    {
        public VirtualMachineResourceNames() { }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> DataDiskNames { get { throw null; } }
        public string HostName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SapVirtualInstances.Models.NetworkInterfaceResourceNames> NetworkInterfaces { get { throw null; } }
        public string OSDiskName { get { throw null; } set { } }
        public string VmName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.VirtualMachineResourceNames>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WindowsConfiguration : Azure.ResourceManager.SapVirtualInstances.Models.OSConfiguration, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>
    {
        public WindowsConfiguration() { }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SapVirtualInstances.Models.WindowsConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
