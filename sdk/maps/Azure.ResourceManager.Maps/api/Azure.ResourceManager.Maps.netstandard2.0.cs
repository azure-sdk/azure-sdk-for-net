namespace Azure.ResourceManager.Maps
{
    public partial class MapsCreatorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Maps.MapsCreatorResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Maps.MapsCreatorResource>, System.Collections.IEnumerable
    {
        protected MapsCreatorCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Maps.MapsCreatorResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string creatorName, Azure.ResourceManager.Maps.MapsCreatorData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Maps.MapsCreatorResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string creatorName, Azure.ResourceManager.Maps.MapsCreatorData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string creatorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string creatorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> Get(string creatorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Maps.MapsCreatorResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Maps.MapsCreatorResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> GetAsync(string creatorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Maps.MapsCreatorResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Maps.MapsCreatorResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Maps.MapsCreatorResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Maps.MapsCreatorResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MapsCreatorData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public MapsCreatorData(Azure.Core.AzureLocation location, Azure.ResourceManager.Maps.Models.MapsCreatorProperties properties) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.Maps.Models.MapsCreatorProperties Properties { get { throw null; } set { } }
    }
    public partial class MapsCreatorResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected MapsCreatorResource() { }
        public virtual Azure.ResourceManager.Maps.MapsCreatorData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string creatorName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> Update(Azure.ResourceManager.Maps.Models.MapsCreatorPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> UpdateAsync(Azure.ResourceManager.Maps.Models.MapsCreatorPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class MapsExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource> GetMapsCreator(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName, string creatorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Maps.MapsCreatorResource>> GetMapsCreatorAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName, string creatorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Maps.MapsCreatorResource GetMapsCreatorResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Maps.MapsCreatorCollection GetMapsCreators(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName) { throw null; }
    }
}
namespace Azure.ResourceManager.Maps.Models
{
    public static partial class ArmMapsModelFactory
    {
        public static Azure.ResourceManager.Maps.MapsCreatorData MapsCreatorData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Maps.Models.MapsCreatorProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Maps.Models.MapsCreatorProperties MapsCreatorProperties(string provisioningState = null, int storageUnits = 0, int? totalStorageUnitSizeInBytes = default(int?), int? consumedStorageUnitSizeInBytes = default(int?)) { throw null; }
    }
    public partial class MapsCreatorPatch
    {
        public MapsCreatorPatch() { }
        public int? ConsumedStorageUnitSizeInBytes { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public int? StorageUnits { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public int? TotalStorageUnitSizeInBytes { get { throw null; } set { } }
    }
    public partial class MapsCreatorProperties
    {
        public MapsCreatorProperties(int storageUnits) { }
        public int? ConsumedStorageUnitSizeInBytes { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public int StorageUnits { get { throw null; } set { } }
        public int? TotalStorageUnitSizeInBytes { get { throw null; } set { } }
    }
}
