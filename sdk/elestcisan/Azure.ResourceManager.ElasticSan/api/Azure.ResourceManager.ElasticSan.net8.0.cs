namespace Azure.ResourceManager.ElasticSan
{
    public partial class AzureResourceManagerElasticSanContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerElasticSanContext() { }
        public static Azure.ResourceManager.ElasticSan.AzureResourceManagerElasticSanContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class ElasticSanCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanResource>, System.Collections.IEnumerable
    {
        protected ElasticSanCollection() { }
        public virtual Azure.ResourceManager.ArmOperation CreateOrUpdate(Azure.WaitUntil waitUntil, string elasticSanName, Azure.ResourceManager.ElasticSan.ElasticSanData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string elasticSanName, Azure.ResourceManager.ElasticSan.ElasticSanData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> Get(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> GetAsync(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetIfExists(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ElasticSan.ElasticSanResource>> GetIfExistsAsync(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ElasticSan.ElasticSanResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ElasticSan.ElasticSanResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ElasticSanData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>
    {
        public ElasticSanData(Azure.Core.AzureLocation location, Azure.ResourceManager.ElasticSan.Models.ElasticSanSku sku, long baseSizeTiB, long extendedCapacitySizeTiB) { }
        public System.Collections.Generic.IList<string> AvailabilityZones { get { throw null; } }
        public long BaseSizeTiB { get { throw null; } set { } }
        public long ExtendedCapacitySizeTiB { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties ScaleUpProperties { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanSku Sku { get { throw null; } set { } }
        public long? TotalIops { get { throw null; } }
        public long? TotalMBps { get { throw null; } }
        public long? TotalSizeTiB { get { throw null; } }
        public long? TotalVolumeSizeGiB { get { throw null; } }
        public long? VolumeGroupCount { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.ElasticSanData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.ElasticSanData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ElasticSanExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetElasticSan(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> GetElasticSanAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource GetElasticSanPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ElasticSan.ElasticSanResource GetElasticSanResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ElasticSan.ElasticSanCollection GetElasticSans(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetElasticSans(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetElasticSansAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation> GetSkusOperationGroups(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation> GetSkusOperationGroupsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ElasticSan.SnapshotResource GetSnapshotResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ElasticSan.VolumeGroupResource GetVolumeGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ElasticSan.VolumeResource GetVolumeResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class ElasticSanPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected ElasticSanPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ElasticSanPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>
    {
        public ElasticSanPrivateEndpointConnectionData(Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState privateLinkServiceConnectionState) { }
        public System.Collections.Generic.IList<string> GroupIds { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ElasticSanPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ElasticSanPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string elasticSanName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ElasticSanResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ElasticSanResource() { }
        public virtual Azure.ResourceManager.ElasticSan.ElasticSanData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string elasticSanName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData> GetByElasticSan(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData> GetByElasticSanAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource> GetElasticSanPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource>> GetElasticSanPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionCollection GetElasticSanPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.VolumeGroupResource> GetVolumeGroup(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.VolumeGroupResource>> GetVolumeGroupAsync(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.VolumeGroupCollection GetVolumeGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ElasticSan.ElasticSanData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.ElasticSanData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.ElasticSanData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.ElasticSanResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.ElasticSanResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SnapshotCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.SnapshotResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.SnapshotResource>, System.Collections.IEnumerable
    {
        protected SnapshotCollection() { }
        public virtual Azure.ResourceManager.ArmOperation CreateOrUpdate(Azure.WaitUntil waitUntil, string snapshotName, Azure.ResourceManager.ElasticSan.SnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string snapshotName, Azure.ResourceManager.ElasticSan.SnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.SnapshotResource> Get(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.SnapshotResource> GetAll(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.SnapshotResource> GetAllAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.SnapshotResource>> GetAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ElasticSan.SnapshotResource> GetIfExists(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ElasticSan.SnapshotResource>> GetIfExistsAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ElasticSan.SnapshotResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.SnapshotResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ElasticSan.SnapshotResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.SnapshotResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SnapshotData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.SnapshotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>
    {
        public SnapshotData(Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent creationData) { }
        public string CreationDataSourceId { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public long? SourceVolumeSizeGiB { get { throw null; } }
        public string VolumeName { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.SnapshotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.SnapshotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SnapshotResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.SnapshotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SnapshotResource() { }
        public virtual Azure.ResourceManager.ElasticSan.SnapshotData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.SnapshotResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.SnapshotResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ElasticSan.SnapshotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.SnapshotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.SnapshotData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.SnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.SnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VolumeCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.VolumeResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.VolumeResource>, System.Collections.IEnumerable
    {
        protected VolumeCollection() { }
        public virtual Azure.ResourceManager.ArmOperation CreateOrUpdate(Azure.WaitUntil waitUntil, string volumeName, Azure.ResourceManager.ElasticSan.VolumeData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string volumeName, Azure.ResourceManager.ElasticSan.VolumeData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.VolumeResource> Get(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.VolumeResource> GetAll(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource? xMsAccessSoftDeletedResources = default(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.VolumeResource> GetAllAsync(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource? xMsAccessSoftDeletedResources = default(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.VolumeResource>> GetAsync(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ElasticSan.VolumeResource> GetIfExists(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ElasticSan.VolumeResource>> GetIfExistsAsync(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ElasticSan.VolumeResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.VolumeResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ElasticSan.VolumeResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.VolumeResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VolumeData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>
    {
        public VolumeData(long sizeGiB) { }
        public Azure.ResourceManager.ElasticSan.Models.SourceCreationContent CreationData { get { throw null; } set { } }
        public string ManagedByResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public long SizeGiB { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo StorageTarget { get { throw null; } set { } }
        public string VolumeId { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.VolumeData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.VolumeData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VolumeGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.VolumeGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.VolumeGroupResource>, System.Collections.IEnumerable
    {
        protected VolumeGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation CreateOrUpdate(Azure.WaitUntil waitUntil, string volumeGroupName, Azure.ResourceManager.ElasticSan.VolumeGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string volumeGroupName, Azure.ResourceManager.ElasticSan.VolumeGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.VolumeGroupResource> Get(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.VolumeGroupResource> GetAll(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource? xMsAccessSoftDeletedResources = default(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.VolumeGroupResource> GetAllAsync(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource? xMsAccessSoftDeletedResources = default(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.VolumeGroupResource>> GetAsync(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ElasticSan.VolumeGroupResource> GetIfExists(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ElasticSan.VolumeGroupResource>> GetIfExistsAsync(string volumeGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ElasticSan.VolumeGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ElasticSan.VolumeGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ElasticSan.VolumeGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.VolumeGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VolumeGroupData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>
    {
        public VolumeGroupData() { }
        public Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy DeleteRetentionPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.EncryptionType? Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.EncryptionProperties EncryptionProperties { get { throw null; } set { } }
        public bool? EnforceDataIntegrityCheckForIscsi { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.StorageTargetType? ProtocolType { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule> VirtualNetworkRules { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.VolumeGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.VolumeGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VolumeGroupResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VolumeGroupResource() { }
        public virtual Azure.ResourceManager.ElasticSan.VolumeGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.VolumeGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.VolumeGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.SnapshotResource> GetSnapshot(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.SnapshotResource>> GetSnapshotAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.SnapshotCollection GetSnapshots() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.VolumeResource> GetVolume(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.VolumeResource>> GetVolumeAsync(string volumeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.VolumeCollection GetVolumes() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.Models.PreValidationResult> PreBackup(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.VolumeNameList volumeNameList, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>> PreBackupAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.VolumeNameList volumeNameList, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.Models.PreValidationResult> PreRestore(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList diskSnapshotList, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>> PreRestoreAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList diskSnapshotList, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ElasticSan.VolumeGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.VolumeGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.VolumeGroupResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.VolumeGroupResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VolumeResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VolumeResource() { }
        public virtual Azure.ResourceManager.ElasticSan.VolumeData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string volumeName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot? xMsDeleteSnapshots = default(Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot?), Azure.ResourceManager.ElasticSan.Models.XMsForceDelete? xMsForceDelete = default(Azure.ResourceManager.ElasticSan.Models.XMsForceDelete?), Azure.ResourceManager.ElasticSan.Models.DeleteType? deleteType = default(Azure.ResourceManager.ElasticSan.Models.DeleteType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot? xMsDeleteSnapshots = default(Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot?), Azure.ResourceManager.ElasticSan.Models.XMsForceDelete? xMsForceDelete = default(Azure.ResourceManager.ElasticSan.Models.XMsForceDelete?), Azure.ResourceManager.ElasticSan.Models.DeleteType? deleteType = default(Azure.ResourceManager.ElasticSan.Models.DeleteType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.VolumeResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.VolumeResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.VolumeResource> RestoreVolume(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.VolumeResource>> RestoreVolumeAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ElasticSan.VolumeData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.VolumeData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.VolumeData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.VolumeData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.VolumeResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.VolumePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ElasticSan.VolumeResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ElasticSan.Models.VolumePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ElasticSan.Mocking
{
    public partial class MockableElasticSanArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableElasticSanArmClient() { }
        public virtual Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionResource GetElasticSanPrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.ElasticSanResource GetElasticSanResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.SnapshotResource GetSnapshotResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.VolumeGroupResource GetVolumeGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.VolumeResource GetVolumeResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableElasticSanResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableElasticSanResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetElasticSan(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ElasticSan.ElasticSanResource>> GetElasticSanAsync(string elasticSanName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ElasticSan.ElasticSanCollection GetElasticSans() { throw null; }
    }
    public partial class MockableElasticSanSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableElasticSanSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetElasticSans(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.ElasticSanResource> GetElasticSansAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation> GetSkusOperationGroups(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation> GetSkusOperationGroupsAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ElasticSan.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Action : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.Action>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Action(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.Action Allow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.Action other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.Action left, Azure.ResourceManager.ElasticSan.Models.Action right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.Action (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.Action left, Azure.ResourceManager.ElasticSan.Models.Action right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmElasticSanModelFactory
    {
        public static Azure.ResourceManager.ElasticSan.ElasticSanData ElasticSanData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.ElasticSan.Models.ElasticSanSku sku = null, System.Collections.Generic.IEnumerable<string> availabilityZones = null, Azure.ResourceManager.ElasticSan.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ElasticSan.Models.ProvisioningState?), long baseSizeTiB = (long)0, long extendedCapacitySizeTiB = (long)0, long? totalVolumeSizeGiB = default(long?), long? volumeGroupCount = default(long?), long? totalIops = default(long?), long? totalMBps = default(long?), long? totalSizeTiB = default(long?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData> privateEndpointConnections = null, Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess?), Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties scaleUpProperties = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData ElasticSanPrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ElasticSan.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ElasticSan.Models.ProvisioningState?), Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, System.Collections.Generic.IEnumerable<string> groupIds = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData ElasticSanPrivateLinkResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, System.Collections.Generic.IEnumerable<string> requiredZoneNames = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation ElasticSanSkuInformation(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName name = default(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName), Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier? tier = default(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier?), string resourceType = null, System.Collections.Generic.IEnumerable<string> locations = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo> locationInfo = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.Models.SKUCapability> capabilities = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo IscsiTargetInfo(string targetIqn = null, string targetPortalHostname = null, int? targetPortalPort = default(int?), Azure.ResourceManager.ElasticSan.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ElasticSan.Models.ProvisioningState?), Azure.ResourceManager.ElasticSan.Models.OperationalStatus? status = default(Azure.ResourceManager.ElasticSan.Models.OperationalStatus?)) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties KeyVaultProperties(string keyName = null, string keyVersion = null, System.Uri keyVaultUri = null, string currentVersionedKeyIdentifier = null, System.DateTimeOffset? lastKeyRotationTimestamp = default(System.DateTimeOffset?), System.DateTimeOffset? currentVersionedKeyExpirationTimestamp = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.PreValidationResult PreValidationResult(string validationStatus = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.SKUCapability SKUCapability(string name = null, string value = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo SkuLocationInfo(string location = null, System.Collections.Generic.IEnumerable<string> zones = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.SnapshotData SnapshotData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string creationDataSourceId = null, Azure.ResourceManager.ElasticSan.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ElasticSan.Models.ProvisioningState?), long? sourceVolumeSizeGiB = default(long?), string volumeName = null) { throw null; }
        public static Azure.ResourceManager.ElasticSan.VolumeData VolumeData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string volumeId = null, Azure.ResourceManager.ElasticSan.Models.SourceCreationContent creationData = null, long sizeGiB = (long)0, Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo storageTarget = null, string managedByResourceId = null, Azure.ResourceManager.ElasticSan.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ElasticSan.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.ElasticSan.VolumeGroupData VolumeGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.ElasticSan.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ElasticSan.Models.ProvisioningState?), Azure.ResourceManager.ElasticSan.Models.StorageTargetType? protocolType = default(Azure.ResourceManager.ElasticSan.Models.StorageTargetType?), Azure.ResourceManager.ElasticSan.Models.EncryptionType? encryption = default(Azure.ResourceManager.ElasticSan.Models.EncryptionType?), Azure.ResourceManager.ElasticSan.Models.EncryptionProperties encryptionProperties = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule> virtualNetworkRules = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ElasticSan.ElasticSanPrivateEndpointConnectionData> privateEndpointConnections = null, bool? enforceDataIntegrityCheckForIscsi = default(bool?), Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy deleteRetentionPolicy = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoScalePolicyEnforcement : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoScalePolicyEnforcement(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement Disabled { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement Enabled { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement left, Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement left, Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeleteRetentionPolicy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>
    {
        public DeleteRetentionPolicy() { }
        public Azure.ResourceManager.ElasticSan.Models.PolicyState? PolicyState { get { throw null; } set { } }
        public int? RetentionPeriodDays { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteType : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.DeleteType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteType(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.DeleteType Permanent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.DeleteType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.DeleteType left, Azure.ResourceManager.ElasticSan.Models.DeleteType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.DeleteType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.DeleteType left, Azure.ResourceManager.ElasticSan.Models.DeleteType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiskSnapshotList : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>
    {
        public DiskSnapshotList(System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> diskSnapshotIds) { }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> DiskSnapshotIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.DiskSnapshotList>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ElasticSanPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>
    {
        public ElasticSanPatch() { }
        public long? BaseSizeTiB { get { throw null; } set { } }
        public long? ExtendedCapacitySizeTiB { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties ScaleUpProperties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ElasticSanPrivateEndpointServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ElasticSanPrivateEndpointServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ElasticSanPrivateLinkResourceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>
    {
        internal ElasticSanPrivateLinkResourceData() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ElasticSanPrivateLinkServiceConnectionState : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>
    {
        public ElasticSanPrivateLinkServiceConnectionState() { }
        public string ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateEndpointServiceConnectionStatus? Status { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanPrivateLinkServiceConnectionState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ElasticSanSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>
    {
        public ElasticSanSku(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName name) { }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName Name { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier? Tier { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ElasticSanSkuInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>
    {
        internal ElasticSanSkuInformation() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ElasticSan.Models.SKUCapability> Capabilities { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo> LocationInfo { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Locations { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier? Tier { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ElasticSanSkuName : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ElasticSanSkuName(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName PremiumLRS { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName PremiumZRS { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName left, Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName left, Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ElasticSanSkuTier : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ElasticSanSkuTier(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier Premium { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier left, Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier left, Azure.ResourceManager.ElasticSan.Models.ElasticSanSkuTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EncryptionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>
    {
        public EncryptionProperties() { }
        public string EncryptionUserAssignedIdentity { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties KeyVaultProperties { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.EncryptionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.EncryptionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.EncryptionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EncryptionType : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.EncryptionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EncryptionType(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.EncryptionType EncryptionAtRestWithCustomerManagedKey { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.EncryptionType EncryptionAtRestWithPlatformKey { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.EncryptionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.EncryptionType left, Azure.ResourceManager.ElasticSan.Models.EncryptionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.EncryptionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.EncryptionType left, Azure.ResourceManager.ElasticSan.Models.EncryptionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IscsiTargetInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>
    {
        public IscsiTargetInfo() { }
        public Azure.ResourceManager.ElasticSan.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ElasticSan.Models.OperationalStatus? Status { get { throw null; } set { } }
        public string TargetIqn { get { throw null; } }
        public string TargetPortalHostname { get { throw null; } }
        public int? TargetPortalPort { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.IscsiTargetInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>
    {
        public KeyVaultProperties() { }
        public System.DateTimeOffset? CurrentVersionedKeyExpirationTimestamp { get { throw null; } }
        public string CurrentVersionedKeyIdentifier { get { throw null; } }
        public string KeyName { get { throw null; } set { } }
        public System.Uri KeyVaultUri { get { throw null; } set { } }
        public string KeyVersion { get { throw null; } set { } }
        public System.DateTimeOffset? LastKeyRotationTimestamp { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.KeyVaultProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OperationalStatus : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.OperationalStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OperationalStatus(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Healthy { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Invalid { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Running { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Stopped { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus StoppedDeallocated { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Unhealthy { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Unknown { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.OperationalStatus Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.OperationalStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.OperationalStatus left, Azure.ResourceManager.ElasticSan.Models.OperationalStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.OperationalStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.OperationalStatus left, Azure.ResourceManager.ElasticSan.Models.OperationalStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyState : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.PolicyState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyState(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.PolicyState Disabled { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.PolicyState Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.PolicyState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.PolicyState left, Azure.ResourceManager.ElasticSan.Models.PolicyState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.PolicyState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.PolicyState left, Azure.ResourceManager.ElasticSan.Models.PolicyState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PreValidationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>
    {
        internal PreValidationResult() { }
        public string ValidationStatus { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.PreValidationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.PreValidationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.PreValidationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Deleted { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Invalid { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Pending { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Restoring { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState SoftDeleting { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.ProvisioningState left, Azure.ResourceManager.ElasticSan.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.ProvisioningState left, Azure.ResourceManager.ElasticSan.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccess : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess left, Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess left, Azure.ResourceManager.ElasticSan.Models.PublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ScaleUpProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>
    {
        public ScaleUpProperties() { }
        public Azure.ResourceManager.ElasticSan.Models.AutoScalePolicyEnforcement? AutoScalePolicyEnforcement { get { throw null; } set { } }
        public long? CapacityUnitScaleUpLimitTiB { get { throw null; } set { } }
        public long? IncreaseCapacityUnitByTiB { get { throw null; } set { } }
        public long? UnusedSizeTiB { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.ScaleUpProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SKUCapability : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>
    {
        internal SKUCapability() { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SKUCapability System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SKUCapability System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SKUCapability>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SkuLocationInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>
    {
        internal SkuLocationInfo() { }
        public string Location { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Zones { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SkuLocationInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SnapshotCreationContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>
    {
        public SnapshotCreationContent(string sourceId) { }
        public string SourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SnapshotCreationContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SourceCreationContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>
    {
        public SourceCreationContent() { }
        public Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption? CreateSource { get { throw null; } set { } }
        public string SourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SourceCreationContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.SourceCreationContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.SourceCreationContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StorageTargetType : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.StorageTargetType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StorageTargetType(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.StorageTargetType Iscsi { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.StorageTargetType None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.StorageTargetType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.StorageTargetType left, Azure.ResourceManager.ElasticSan.Models.StorageTargetType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.StorageTargetType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.StorageTargetType left, Azure.ResourceManager.ElasticSan.Models.StorageTargetType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VirtualNetworkRule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>
    {
        public VirtualNetworkRule(string virtualNetworkResourceId) { }
        public Azure.ResourceManager.ElasticSan.Models.Action? Action { get { throw null; } set { } }
        public string VirtualNetworkResourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VolumeCreateOption : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VolumeCreateOption(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption Disk { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption DiskRestorePoint { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption DiskSnapshot { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption None { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption VolumeSnapshot { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption left, Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption left, Azure.ResourceManager.ElasticSan.Models.VolumeCreateOption right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VolumeGroupPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>
    {
        public VolumeGroupPatch() { }
        public Azure.ResourceManager.ElasticSan.Models.DeleteRetentionPolicy DeleteRetentionPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.EncryptionType? Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.EncryptionProperties EncryptionProperties { get { throw null; } set { } }
        public bool? EnforceDataIntegrityCheckForIscsi { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.ElasticSan.Models.StorageTargetType? ProtocolType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ElasticSan.Models.VirtualNetworkRule> VirtualNetworkRules { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeGroupPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VolumeNameList : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>
    {
        public VolumeNameList(System.Collections.Generic.IEnumerable<string> volumeNames) { }
        public System.Collections.Generic.IList<string> VolumeNames { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VolumeNameList System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VolumeNameList System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumeNameList>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VolumePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>
    {
        public VolumePatch() { }
        public string ManagedByResourceId { get { throw null; } set { } }
        public long? SizeGiB { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VolumePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ElasticSan.Models.VolumePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ElasticSan.Models.VolumePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct XMsAccessSoftDeletedResource : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public XMsAccessSoftDeletedResource(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource False { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource left, Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource left, Azure.ResourceManager.ElasticSan.Models.XMsAccessSoftDeletedResource right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct XMsDeleteSnapshot : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public XMsDeleteSnapshot(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot False { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot left, Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot left, Azure.ResourceManager.ElasticSan.Models.XMsDeleteSnapshot right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct XMsForceDelete : System.IEquatable<Azure.ResourceManager.ElasticSan.Models.XMsForceDelete>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public XMsForceDelete(string value) { throw null; }
        public static Azure.ResourceManager.ElasticSan.Models.XMsForceDelete False { get { throw null; } }
        public static Azure.ResourceManager.ElasticSan.Models.XMsForceDelete True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ElasticSan.Models.XMsForceDelete other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ElasticSan.Models.XMsForceDelete left, Azure.ResourceManager.ElasticSan.Models.XMsForceDelete right) { throw null; }
        public static implicit operator Azure.ResourceManager.ElasticSan.Models.XMsForceDelete (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ElasticSan.Models.XMsForceDelete left, Azure.ResourceManager.ElasticSan.Models.XMsForceDelete right) { throw null; }
        public override string ToString() { throw null; }
    }
}
