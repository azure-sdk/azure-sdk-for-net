namespace Azure.ResourceManager.Fileshares
{
    public partial class AzureResourceManagerFilesharesContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerFilesharesContext() { }
        public static Azure.ResourceManager.Fileshares.AzureResourceManagerFilesharesContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class FileShareCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Fileshares.FileShareResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Fileshares.FileShareResource>, System.Collections.IEnumerable
    {
        protected FileShareCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.Fileshares.FileShareData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.Fileshares.FileShareData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> Get(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Fileshares.FileShareResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Fileshares.FileShareResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> GetAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Fileshares.FileShareResource> GetIfExists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Fileshares.FileShareResource>> GetIfExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Fileshares.FileShareResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Fileshares.FileShareResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Fileshares.FileShareResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Fileshares.FileShareResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FileShareData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>
    {
        public FileShareData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Fileshares.Models.FileShareProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.FileShareData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.FileShareData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileShareResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FileShareResource() { }
        public virtual Azure.ResourceManager.Fileshares.FileShareData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> GetFileShareSnapshot(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>> GetFileShareSnapshotAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Fileshares.FileShareSnapshotCollection GetFileShareSnapshots() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Fileshares.FileShareData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.FileShareData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Fileshares.Models.FileSharePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Fileshares.Models.FileSharePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class FilesharesExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult> CheckNameAvailabilityFileShare(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>> CheckNameAvailabilityFileShareAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> GetFileShare(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> GetFileShareAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Fileshares.FileShareResource GetFileShareResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Fileshares.FileShareCollection GetFileShares(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Fileshares.FileShareResource> GetFileShares(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Fileshares.FileShareResource> GetFileSharesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Fileshares.FileShareSnapshotResource GetFileShareSnapshotResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Fileshares.Models.Info> GetOperations(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Fileshares.Models.Info> GetOperationsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FileShareSnapshotCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>, System.Collections.IEnumerable
    {
        protected FileShareSnapshotCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Fileshares.FileShareSnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Fileshares.FileShareSnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FileShareSnapshotData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>
    {
        public FileShareSnapshotData() { }
        public Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.FileShareSnapshotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.FileShareSnapshotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileShareSnapshotResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FileShareSnapshotResource() { }
        public virtual Azure.ResourceManager.Fileshares.FileShareSnapshotData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Fileshares.FileShareSnapshotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.FileShareSnapshotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.FileShareSnapshotData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareSnapshotResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Fileshares.FileShareSnapshotResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Fileshares.Mocking
{
    public partial class MockableFilesharesArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableFilesharesArmClient() { }
        public virtual Azure.ResourceManager.Fileshares.FileShareResource GetFileShareResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Fileshares.FileShareSnapshotResource GetFileShareSnapshotResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableFilesharesResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableFilesharesResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource> GetFileShare(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.FileShareResource>> GetFileShareAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Fileshares.FileShareCollection GetFileShares() { throw null; }
    }
    public partial class MockableFilesharesSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableFilesharesSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult> CheckNameAvailabilityFileShare(Azure.Core.AzureLocation location, Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>> CheckNameAvailabilityFileShareAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Fileshares.FileShareResource> GetFileShares(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Fileshares.FileShareResource> GetFileSharesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MockableFilesharesTenantResource : Azure.ResourceManager.ArmResource
    {
        protected MockableFilesharesTenantResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Fileshares.Models.Info> GetOperations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Fileshares.Models.Info> GetOperationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Fileshares.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionType : System.IEquatable<Azure.ResourceManager.Fileshares.Models.ActionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionType(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.ActionType Internal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.ActionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.ActionType left, Azure.ResourceManager.Fileshares.Models.ActionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.ActionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.ActionType left, Azure.ResourceManager.Fileshares.Models.ActionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmFilesharesModelFactory
    {
        public static Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult CheckNameAvailabilityResult(bool? nameAvailable = default(bool?), Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason? reason = default(Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason?), string message = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.FileShareData FileShareData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Fileshares.Models.FileShareProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProperties FileShareProperties(string mountName = null, string hostName = null, Azure.ResourceManager.Fileshares.Models.MediaTier? mediaTier = default(Azure.ResourceManager.Fileshares.Models.MediaTier?), Azure.ResourceManager.Fileshares.Models.Redundancy? redundancy = default(Azure.ResourceManager.Fileshares.Models.Redundancy?), Azure.ResourceManager.Fileshares.Models.Protocol? protocol = default(Azure.ResourceManager.Fileshares.Models.Protocol?), int? provisionedStorageGiB = default(int?), System.DateTimeOffset? provisionedStorageNextAllowedDowngrade = default(System.DateTimeOffset?), int? provisionedIOPerSec = default(int?), System.DateTimeOffset? provisionedIOPerSecNextAllowedDowngrade = default(System.DateTimeOffset?), int? provisionedThroughputMiBPerSec = default(int?), System.DateTimeOffset? provisionedThroughputNextAllowedDowngrade = default(System.DateTimeOffset?), int? includedBurstIOPerSec = default(int?), long? maxBurstIOPerSecCredits = default(long?), Azure.ResourceManager.Fileshares.Models.ShareRootSquash? nfsProtocolRootSquash = default(Azure.ResourceManager.Fileshares.Models.ShareRootSquash?), System.Collections.Generic.IEnumerable<string> publicAccessAllowedSubnets = null, Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState? provisioningState = default(Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState?), Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection> privateEndpointConnections = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.FileShareSnapshotData FileShareSnapshotData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties FileShareSnapshotProperties(string snapshotTime = null, string initiatorId = null, System.Collections.Generic.IDictionary<string, string> metadata = null, Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState? provisioningState = default(Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection FilesharesPrivateEndpointConnection(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState FilesharesPrivateLinkServiceConnectionState(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus? status = default(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus?), string description = null, string actionsRequired = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.Info Info(string name = null, bool? isDataAction = default(bool?), Azure.ResourceManager.Fileshares.Models.OperationDisplay display = null, Azure.ResourceManager.Fileshares.Models.Origin? origin = default(Azure.ResourceManager.Fileshares.Models.Origin?), Azure.ResourceManager.Fileshares.Models.ActionType? actionType = default(Azure.ResourceManager.Fileshares.Models.ActionType?)) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.OperationDisplay OperationDisplay(string provider = null, string resource = null, string operation = null, string description = null) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties PrivateEndpointConnectionProperties(System.Collections.Generic.IEnumerable<string> groupIds = null, Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState? provisioningState = default(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState?)) { throw null; }
    }
    public partial class CheckNameAvailabilityContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>
    {
        public CheckNameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CheckNameAvailabilityReason : System.IEquatable<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CheckNameAvailabilityReason(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason AlreadyExists { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason Invalid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CheckNameAvailabilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>
    {
        internal CheckNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityReason? Reason { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.CheckNameAvailabilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileSharePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>
    {
        public FileSharePatch() { }
        public Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileSharePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileSharePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileSharePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileShareProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>
    {
        public FileShareProperties() { }
        public string HostName { get { throw null; } }
        public int? IncludedBurstIOPerSec { get { throw null; } }
        public long? MaxBurstIOPerSecCredits { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.MediaTier? MediaTier { get { throw null; } set { } }
        public string MountName { get { throw null; } set { } }
        public Azure.ResourceManager.Fileshares.Models.ShareRootSquash? NfsProtocolRootSquash { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection> PrivateEndpointConnections { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.Protocol? Protocol { get { throw null; } set { } }
        public int? ProvisionedIOPerSec { get { throw null; } set { } }
        public System.DateTimeOffset? ProvisionedIOPerSecNextAllowedDowngrade { get { throw null; } }
        public int? ProvisionedStorageGiB { get { throw null; } set { } }
        public System.DateTimeOffset? ProvisionedStorageNextAllowedDowngrade { get { throw null; } }
        public int? ProvisionedThroughputMiBPerSec { get { throw null; } set { } }
        public System.DateTimeOffset? ProvisionedThroughputNextAllowedDowngrade { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<string> PublicAccessAllowedSubnets { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.Fileshares.Models.Redundancy? Redundancy { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FileShareProvisioningState : System.IEquatable<Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FileShareProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState left, Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState left, Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FileShareSnapshotPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>
    {
        public FileShareSnapshotPatch() { }
        public System.Collections.Generic.IDictionary<string, string> FileShareSnapshotUpdateMetadata { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileShareSnapshotProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>
    {
        public FileShareSnapshotProperties() { }
        public string InitiatorId { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Metadata { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.FileShareProvisioningState? ProvisioningState { get { throw null; } }
        public string SnapshotTime { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareSnapshotProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FilesharesPrivateEndpointConnection : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>
    {
        internal FilesharesPrivateEndpointConnection() { }
        public Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnection>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FilesharesPrivateEndpointConnectionProvisioningState : System.IEquatable<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FilesharesPrivateEndpointConnectionProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FilesharesPrivateEndpointServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FilesharesPrivateEndpointServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FilesharesPrivateLinkServiceConnectionState : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>
    {
        internal FilesharesPrivateLinkServiceConnectionState() { }
        public string ActionsRequired { get { throw null; } }
        public string Description { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointServiceConnectionStatus? Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileShareUpdateProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>
    {
        public FileShareUpdateProperties() { }
        public Azure.ResourceManager.Fileshares.Models.ShareRootSquash? NfsProtocolRootSquash { get { throw null; } set { } }
        public int? ProvisionedIOPerSec { get { throw null; } set { } }
        public int? ProvisionedStorageGiB { get { throw null; } set { } }
        public int? ProvisionedThroughputMiBPerSec { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> PublicAccessAllowedSubnets { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.FileShareUpdateProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Info : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.Info>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.Info>
    {
        internal Info() { }
        public Azure.ResourceManager.Fileshares.Models.ActionType? ActionType { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.OperationDisplay Display { get { throw null; } }
        public bool? IsDataAction { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.Origin? Origin { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.Info System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.Info>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.Info>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.Info System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.Info>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.Info>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.Info>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum MediaTier
    {
        SSD = 0,
    }
    public partial class OperationDisplay : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>
    {
        internal OperationDisplay() { }
        public string Description { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.OperationDisplay System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.OperationDisplay System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.OperationDisplay>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Origin : System.IEquatable<Azure.ResourceManager.Fileshares.Models.Origin>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Origin(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.Origin System { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.Origin User { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.Origin UserSystem { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.Origin other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.Origin left, Azure.ResourceManager.Fileshares.Models.Origin right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.Origin (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.Origin left, Azure.ResourceManager.Fileshares.Models.Origin right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrivateEndpointConnectionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>
    {
        internal PrivateEndpointConnectionProperties() { }
        public System.Collections.Generic.IReadOnlyList<string> GroupIds { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.FilesharesPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } }
        public Azure.ResourceManager.Fileshares.Models.FilesharesPrivateEndpointConnectionProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Fileshares.Models.PrivateEndpointConnectionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum Protocol
    {
        NFS = 0,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccess : System.IEquatable<Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess left, Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess left, Azure.ResourceManager.Fileshares.Models.PublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum Redundancy
    {
        Local = 0,
        Zone = 1,
    }
    public enum ShareRootSquash
    {
        NoRootSquash = 0,
        RootSquash = 1,
        AllSquash = 2,
    }
}
