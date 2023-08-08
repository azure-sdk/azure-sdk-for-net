namespace Azure.ResourceManager.HDInsight
{
    public partial class ClusterPoolCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HDInsight.ClusterPoolResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.ClusterPoolResource>, System.Collections.IEnumerable
    {
        protected ClusterPoolCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.ClusterPoolResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string clusterPoolName, Azure.ResourceManager.HDInsight.ClusterPoolData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.ClusterPoolResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string clusterPoolName, Azure.ResourceManager.HDInsight.ClusterPoolData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string clusterPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string clusterPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource> Get(string clusterPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HDInsight.ClusterPoolResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HDInsight.ClusterPoolResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource>> GetAsync(string clusterPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HDInsight.ClusterPoolResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HDInsight.ClusterPoolResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HDInsight.ClusterPoolResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.ClusterPoolResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ClusterPoolData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ClusterPoolData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesAksClusterProfile AksClusterProfile { get { throw null; } }
        public string AksManagedResourceGroupName { get { throw null; } }
        public string ClusterPoolVersion { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesComputeProfile ComputeProfile { get { throw null; } set { } }
        public string DeploymentId { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesLogAnalyticsProfile LogAnalyticsProfile { get { throw null; } set { } }
        public string ManagedResourceGroupName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier NetworkSubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ProvisioningStatus? ProvisioningState { get { throw null; } }
        public string Status { get { throw null; } }
    }
    public partial class ClusterPoolResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ClusterPoolResource() { }
        public virtual Azure.ResourceManager.HDInsight.ClusterPoolData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterPoolName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource> GetHDInsightCluster(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> GetHDInsightClusterAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HDInsight.HDInsightClusterCollection GetHDInsightClusters() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.ClusterPoolResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.ClusterPoolPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.ClusterPoolResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.ClusterPoolPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HDInsightClusterCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HDInsight.HDInsightClusterResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.HDInsightClusterResource>, System.Collections.IEnumerable
    {
        protected HDInsightClusterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.HDInsightClusterResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.HDInsight.HDInsightClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.HDInsight.HDInsightClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource> Get(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HDInsight.HDInsightClusterResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HDInsight.HDInsightClusterResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> GetAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HDInsight.HDInsightClusterResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HDInsight.HDInsightClusterResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HDInsight.HDInsightClusterResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.HDInsightClusterResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HDInsightClusterData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public HDInsightClusterData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.HDInsight.Models.ClusterProfile ClusterProfile { get { throw null; } set { } }
        public string ClusterType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.NodeProfile> ComputeNodes { get { throw null; } set { } }
        public string DeploymentId { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.ProvisioningStatus? ProvisioningState { get { throw null; } }
        public string Status { get { throw null; } }
    }
    public partial class HDInsightClusterResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HDInsightClusterResource() { }
        public virtual Azure.ResourceManager.HDInsight.HDInsightClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterPoolName, string clusterName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HDInsight.Models.ClusterJob> GetClusterJobs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HDInsight.Models.ClusterJob> GetClusterJobsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewResult> GetInstanceView(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewResult>> GetInstanceViewAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewResult> GetInstanceViews(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewResult> GetInstanceViewsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HDInsight.Models.ServiceConfigResult> GetServiceConfigs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HDInsight.Models.ServiceConfigResult> GetServiceConfigsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.HDInsightClusterResource> Resize(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.ClusterResizeData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> ResizeAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.ClusterResizeData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.Models.ClusterJob> RunJobClusterJob(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.ClusterJob clusterJob, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.Models.ClusterJob>> RunJobClusterJobAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.ClusterJob clusterJob, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.HDInsightClusterResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.HDInsightClusterPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HDInsight.HDInsightClusterResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HDInsight.Models.HDInsightClusterPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HDInsightExtensions
    {
        public static Azure.Response<Azure.ResourceManager.HDInsight.Models.NameAvailabilityResult> CheckHDInsightNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.HDInsight.Models.NameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.Models.NameAvailabilityResult>> CheckHDInsightNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.HDInsight.Models.NameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HDInsight.Models.ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocation(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HDInsight.Models.ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocationAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HDInsight.Models.ClusterVersion> GetAvailableClusterVersionsByLocation(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HDInsight.Models.ClusterVersion> GetAvailableClusterVersionsByLocationAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource> GetClusterPool(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string clusterPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HDInsight.ClusterPoolResource>> GetClusterPoolAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string clusterPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HDInsight.ClusterPoolResource GetClusterPoolResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HDInsight.ClusterPoolCollection GetClusterPools(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HDInsight.ClusterPoolResource> GetClusterPools(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HDInsight.ClusterPoolResource> GetClusterPoolsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HDInsight.HDInsightClusterResource GetHDInsightClusterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
}
namespace Azure.ResourceManager.HDInsight.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Action : System.IEquatable<Azure.ResourceManager.HDInsight.Models.Action>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Action(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.Action Cancel { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action Delete { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action ListSavepoint { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action NEW { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action Savepoint { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action Start { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action StatelessUpdate { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action Stop { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.Action Update { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.Action other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.Action left, Azure.ResourceManager.HDInsight.Models.Action right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.Action (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.Action left, Azure.ResourceManager.HDInsight.Models.Action right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AksClusterProfile
    {
        internal AksClusterProfile() { }
        public Azure.ResourceManager.HDInsight.Models.AksClusterProfileAksClusterAgentPoolIdentityProfile AksClusterAgentPoolIdentityProfile { get { throw null; } }
        public Azure.Core.ResourceIdentifier AksClusterResourceId { get { throw null; } }
        public string AksVersion { get { throw null; } }
    }
    public partial class AksClusterProfileAksClusterAgentPoolIdentityProfile : Azure.ResourceManager.HDInsight.Models.IdentityProfile
    {
        public AksClusterProfileAksClusterAgentPoolIdentityProfile(Azure.Core.ResourceIdentifier msiResourceId, string msiClientId, string msiObjectId) : base (default(Azure.Core.ResourceIdentifier), default(string), default(string)) { }
    }
    public static partial class ArmHDInsightModelFactory
    {
        public static Azure.ResourceManager.HDInsight.Models.AksClusterProfile AksClusterProfile(Azure.Core.ResourceIdentifier aksClusterResourceId = null, Azure.ResourceManager.HDInsight.Models.AksClusterProfileAksClusterAgentPoolIdentityProfile aksClusterAgentPoolIdentityProfile = null, string aksVersion = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterComponentsItem ClusterComponentsItem(string name = null, string version = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewPropertiesStatus ClusterInstanceViewPropertiesStatus(string ready = null, string reason = null, string message = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewResult ClusterInstanceViewResult(string name = null, Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewPropertiesStatus status = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ServiceStatus> serviceStatuses = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewStatus ClusterInstanceViewStatus(string ready = null, string reason = null, string message = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterJob ClusterJob(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.HDInsight.Models.ClusterJobProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterPoolComputeProfile ClusterPoolComputeProfile(string vmSize = null, int? count = default(int?)) { throw null; }
        public static Azure.ResourceManager.HDInsight.ClusterPoolData ClusterPoolData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HDInsight.Models.ProvisioningStatus? provisioningState = default(Azure.ResourceManager.HDInsight.Models.ProvisioningStatus?), string deploymentId = null, string managedResourceGroupName = null, string aksManagedResourceGroupName = null, string clusterPoolVersion = null, Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesComputeProfile computeProfile = null, Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesAksClusterProfile aksClusterProfile = null, Azure.Core.ResourceIdentifier networkSubnetId = null, Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesLogAnalyticsProfile logAnalyticsProfile = null, string status = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesAksClusterProfile ClusterPoolResourcePropertiesAksClusterProfile(Azure.Core.ResourceIdentifier aksClusterResourceId = null, Azure.ResourceManager.HDInsight.Models.AksClusterProfileAksClusterAgentPoolIdentityProfile aksClusterAgentPoolIdentityProfile = null, string aksVersion = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterPoolResourcePropertiesComputeProfile ClusterPoolResourcePropertiesComputeProfile(string vmSize = null, int? count = default(int?)) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterPoolVersion ClusterPoolVersion(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string clusterPoolVersionValue = null, string aksVersion = null, bool? isPreview = default(bool?)) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterProfile ClusterProfile(string clusterVersion = null, string ossVersion = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ClusterComponentsItem> components = null, Azure.ResourceManager.HDInsight.Models.IdentityProfile identityProfile = null, Azure.ResourceManager.HDInsight.Models.AuthorizationProfile authorizationProfile = null, Azure.ResourceManager.HDInsight.Models.SecretsProfile secretsProfile = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ClusterServiceConfigsProfile> serviceConfigsProfiles = null, Azure.ResourceManager.HDInsight.Models.ConnectivityProfile connectivityProfile = null, Azure.ResourceManager.HDInsight.Models.ClusterLogAnalyticsProfile logAnalyticsProfile = null, bool? prometheusProfileEnabled = default(bool?), Azure.ResourceManager.HDInsight.Models.SshProfile sshProfile = null, Azure.ResourceManager.HDInsight.Models.AutoScaleProfile autoScaleProfile = null, System.Collections.Generic.IDictionary<string, System.BinaryData> kafkaProfile = null, Azure.ResourceManager.HDInsight.Models.TrinoProfile trinoProfile = null, System.Collections.Generic.IDictionary<string, System.BinaryData> llapProfile = null, Azure.ResourceManager.HDInsight.Models.FlinkProfile flinkProfile = null, Azure.ResourceManager.HDInsight.Models.SparkProfile sparkProfile = null, System.Collections.Generic.IDictionary<string, System.BinaryData> stubProfile = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ScriptActionProfile> scriptActionProfiles = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterResizeData ClusterResizeData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), int? targetWorkerNodeCount = default(int?)) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ClusterVersion ClusterVersion(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string clusterType = null, string clusterVersionValue = null, string ossVersion = null, string clusterPoolVersion = null, bool? isPreview = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ClusterComponentsItem> components = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ConnectivityProfile ConnectivityProfile(string webFqdn = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.SshConnectivityEndpoint> ssh = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.FlinkJobProperties FlinkJobProperties(string jobName = null, string jobJarDirectory = null, string jarName = null, string entryClass = null, string args = null, string savePointName = null, Azure.ResourceManager.HDInsight.Models.Action? action = default(Azure.ResourceManager.HDInsight.Models.Action?), System.Collections.Generic.IDictionary<string, string> flinkConfiguration = null, string jobId = null, string status = null, string jobOutput = null, string actionResult = null, string lastSavePoint = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.HDInsightClusterData HDInsightClusterData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HDInsight.Models.ProvisioningStatus? provisioningState = default(Azure.ResourceManager.HDInsight.Models.ProvisioningStatus?), string clusterType = null, string deploymentId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.NodeProfile> computeNodes = null, Azure.ResourceManager.HDInsight.Models.ClusterProfile clusterProfile = null, string status = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.HDInsightClusterPatch HDInsightClusterPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HDInsight.Models.UpdatableClusterProfile clusterProfile = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.NameAvailabilityResult NameAvailabilityResult(bool? nameAvailable = default(bool?), string reason = null, string message = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ServiceConfigListResultValueEntity ServiceConfigListResultValueEntity(string value = null, string description = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ServiceConfigResult ServiceConfigResult(string serviceName = null, string fileName = null, string content = null, string componentName = null, string serviceConfigListResultPropertiesType = null, string path = null, System.Collections.Generic.IReadOnlyDictionary<string, string> customKeys = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.HDInsight.Models.ServiceConfigListResultValueEntity> defaultKeys = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ServiceStatus ServiceStatus(string kind = null, string ready = null, string message = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.SshConnectivityEndpoint SshConnectivityEndpoint(string endpoint = null) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.SshProfile SshProfile(int count = 0, string podPrefix = null) { throw null; }
    }
    public partial class AuthorizationProfile
    {
        public AuthorizationProfile() { }
        public System.Collections.Generic.IList<string> GroupIds { get { throw null; } }
        public System.Collections.Generic.IList<string> UserIds { get { throw null; } }
    }
    public partial class AutoScaleProfile
    {
        public AutoScaleProfile(bool enabled) { }
        public Azure.ResourceManager.HDInsight.Models.AutoScaleType? AutoScaleType { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public int? GracefulDecommissionTimeout { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.LoadBasedConfig LoadBasedConfig { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ScheduleBasedConfig ScheduleBasedConfig { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoScaleType : System.IEquatable<Azure.ResourceManager.HDInsight.Models.AutoScaleType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoScaleType(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.AutoScaleType LoadBased { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.AutoScaleType ScheduleBased { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.AutoScaleType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.AutoScaleType left, Azure.ResourceManager.HDInsight.Models.AutoScaleType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.AutoScaleType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.AutoScaleType left, Azure.ResourceManager.HDInsight.Models.AutoScaleType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ClusterComponentsItem
    {
        internal ClusterComponentsItem() { }
        public string Name { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class ClusterConfigFile
    {
        public ClusterConfigFile(string fileName) { }
        public string Content { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ContentEncoding? Encoding { get { throw null; } set { } }
        public string FileName { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Values { get { throw null; } }
    }
    public partial class ClusterInstanceViewPropertiesStatus : Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewStatus
    {
        internal ClusterInstanceViewPropertiesStatus() { }
    }
    public partial class ClusterInstanceViewResult
    {
        internal ClusterInstanceViewResult() { }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HDInsight.Models.ServiceStatus> ServiceStatuses { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.ClusterInstanceViewPropertiesStatus Status { get { throw null; } }
    }
    public partial class ClusterInstanceViewStatus
    {
        internal ClusterInstanceViewStatus() { }
        public string Message { get { throw null; } }
        public string Ready { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    public partial class ClusterJob : Azure.ResourceManager.Models.ResourceData
    {
        public ClusterJob(Azure.ResourceManager.HDInsight.Models.ClusterJobProperties properties) { }
        public Azure.ResourceManager.HDInsight.Models.ClusterJobProperties Properties { get { throw null; } set { } }
    }
    public abstract partial class ClusterJobProperties
    {
        protected ClusterJobProperties() { }
    }
    public partial class ClusterLogAnalyticsApplicationLogs
    {
        public ClusterLogAnalyticsApplicationLogs() { }
        public bool? StdErrorEnabled { get { throw null; } set { } }
        public bool? StdOutEnabled { get { throw null; } set { } }
    }
    public partial class ClusterLogAnalyticsProfile
    {
        public ClusterLogAnalyticsProfile(bool enabled) { }
        public Azure.ResourceManager.HDInsight.Models.ClusterLogAnalyticsApplicationLogs ApplicationLogs { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public bool? MetricsEnabled { get { throw null; } set { } }
    }
    public partial class ClusterPoolComputeProfile
    {
        public ClusterPoolComputeProfile(string vmSize) { }
        public int? Count { get { throw null; } }
        public string VmSize { get { throw null; } set { } }
    }
    public partial class ClusterPoolLogAnalyticsProfile
    {
        public ClusterPoolLogAnalyticsProfile(bool enabled) { }
        public bool Enabled { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier WorkspaceId { get { throw null; } set { } }
    }
    public partial class ClusterPoolPatch
    {
        public ClusterPoolPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class ClusterPoolResourcePropertiesAksClusterProfile : Azure.ResourceManager.HDInsight.Models.AksClusterProfile
    {
        internal ClusterPoolResourcePropertiesAksClusterProfile() { }
    }
    public partial class ClusterPoolResourcePropertiesComputeProfile : Azure.ResourceManager.HDInsight.Models.ClusterPoolComputeProfile
    {
        public ClusterPoolResourcePropertiesComputeProfile(string vmSize) : base (default(string)) { }
    }
    public partial class ClusterPoolResourcePropertiesLogAnalyticsProfile : Azure.ResourceManager.HDInsight.Models.ClusterPoolLogAnalyticsProfile
    {
        public ClusterPoolResourcePropertiesLogAnalyticsProfile(bool enabled) : base (default(bool)) { }
    }
    public partial class ClusterPoolVersion : Azure.ResourceManager.Models.ResourceData
    {
        public ClusterPoolVersion() { }
        public string AksVersion { get { throw null; } set { } }
        public string ClusterPoolVersionValue { get { throw null; } set { } }
        public bool? IsPreview { get { throw null; } set { } }
    }
    public partial class ClusterProfile
    {
        public ClusterProfile(string clusterVersion, string ossVersion, Azure.ResourceManager.HDInsight.Models.IdentityProfile identityProfile, Azure.ResourceManager.HDInsight.Models.AuthorizationProfile authorizationProfile) { }
        public Azure.ResourceManager.HDInsight.Models.AuthorizationProfile AuthorizationProfile { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.AutoScaleProfile AutoScaleProfile { get { throw null; } set { } }
        public string ClusterVersion { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HDInsight.Models.ClusterComponentsItem> Components { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.ConnectivityProfile ConnectivityProfile { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.FlinkProfile FlinkProfile { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.IdentityProfile IdentityProfile { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> KafkaProfile { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> LlapProfile { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.ClusterLogAnalyticsProfile LogAnalyticsProfile { get { throw null; } set { } }
        public string OssVersion { get { throw null; } set { } }
        public bool? PrometheusProfileEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ScriptActionProfile> ScriptActionProfiles { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.SecretsProfile SecretsProfile { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ClusterServiceConfigsProfile> ServiceConfigsProfiles { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.SparkProfile SparkProfile { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.SshProfile SshProfile { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> StubProfile { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.TrinoProfile TrinoProfile { get { throw null; } set { } }
    }
    public partial class ClusterResizeData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ClusterResizeData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public int? TargetWorkerNodeCount { get { throw null; } set { } }
    }
    public partial class ClusterServiceConfig
    {
        public ClusterServiceConfig(string component, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ClusterConfigFile> files) { }
        public string Component { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ClusterConfigFile> Files { get { throw null; } }
    }
    public partial class ClusterServiceConfigsProfile
    {
        public ClusterServiceConfigsProfile(string serviceName, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ClusterServiceConfig> configs) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ClusterServiceConfig> Configs { get { throw null; } }
        public string ServiceName { get { throw null; } set { } }
    }
    public partial class ClusterVersion : Azure.ResourceManager.Models.ResourceData
    {
        public ClusterVersion() { }
        public string ClusterPoolVersion { get { throw null; } set { } }
        public string ClusterType { get { throw null; } set { } }
        public string ClusterVersionValue { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HDInsight.Models.ClusterComponentsItem> Components { get { throw null; } }
        public bool? IsPreview { get { throw null; } set { } }
        public string OssVersion { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ComparisonOperator : System.IEquatable<Azure.ResourceManager.HDInsight.Models.ComparisonOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ComparisonOperator(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ComparisonOperator GreaterThan { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ComparisonOperator GreaterThanOrEqual { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ComparisonOperator LessThan { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ComparisonOperator LessThanOrEqual { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.ComparisonOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.ComparisonOperator left, Azure.ResourceManager.HDInsight.Models.ComparisonOperator right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.ComparisonOperator (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.ComparisonOperator left, Azure.ResourceManager.HDInsight.Models.ComparisonOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ComparisonRule
    {
        public ComparisonRule(Azure.ResourceManager.HDInsight.Models.ComparisonOperator @operator, float threshold) { }
        public Azure.ResourceManager.HDInsight.Models.ComparisonOperator Operator { get { throw null; } set { } }
        public float Threshold { get { throw null; } set { } }
    }
    public partial class ComputeResourceDefinition
    {
        public ComputeResourceDefinition(float cpu, long memory) { }
        public float Cpu { get { throw null; } set { } }
        public long Memory { get { throw null; } set { } }
    }
    public partial class ConnectivityProfile
    {
        internal ConnectivityProfile() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HDInsight.Models.SshConnectivityEndpoint> Ssh { get { throw null; } }
        public string WebFqdn { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContentEncoding : System.IEquatable<Azure.ResourceManager.HDInsight.Models.ContentEncoding>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContentEncoding(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ContentEncoding Base64 { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ContentEncoding None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.ContentEncoding other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.ContentEncoding left, Azure.ResourceManager.HDInsight.Models.ContentEncoding right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.ContentEncoding (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.ContentEncoding left, Azure.ResourceManager.HDInsight.Models.ContentEncoding right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FlinkHiveCatalogOption
    {
        public FlinkHiveCatalogOption(string metastoreDbConnectionPasswordSecret, string metastoreDbConnectionURL, string metastoreDbConnectionUserName) { }
        public string MetastoreDbConnectionPasswordSecret { get { throw null; } set { } }
        public string MetastoreDbConnectionURL { get { throw null; } set { } }
        public string MetastoreDbConnectionUserName { get { throw null; } set { } }
    }
    public partial class FlinkJobProperties : Azure.ResourceManager.HDInsight.Models.ClusterJobProperties
    {
        public FlinkJobProperties(string jobName) { }
        public Azure.ResourceManager.HDInsight.Models.Action? Action { get { throw null; } set { } }
        public string ActionResult { get { throw null; } }
        public string Args { get { throw null; } set { } }
        public string EntryClass { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> FlinkConfiguration { get { throw null; } }
        public string JarName { get { throw null; } set { } }
        public string JobId { get { throw null; } }
        public string JobJarDirectory { get { throw null; } set { } }
        public string JobName { get { throw null; } set { } }
        public string JobOutput { get { throw null; } }
        public string LastSavePoint { get { throw null; } }
        public string SavePointName { get { throw null; } set { } }
        public string Status { get { throw null; } }
    }
    public partial class FlinkProfile
    {
        public FlinkProfile(Azure.ResourceManager.HDInsight.Models.FlinkStorageProfile storage, Azure.ResourceManager.HDInsight.Models.ComputeResourceDefinition jobManager, Azure.ResourceManager.HDInsight.Models.ComputeResourceDefinition taskManager) { }
        public Azure.ResourceManager.HDInsight.Models.FlinkHiveCatalogOption CatalogOptionsHive { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ComputeResourceDefinition HistoryServer { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ComputeResourceDefinition JobManager { get { throw null; } set { } }
        public int? NumReplicas { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.FlinkStorageProfile Storage { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ComputeResourceDefinition TaskManager { get { throw null; } set { } }
    }
    public partial class FlinkStorageProfile
    {
        public FlinkStorageProfile(System.Uri storageUri) { }
        public string Storagekey { get { throw null; } set { } }
        public System.Uri StorageUri { get { throw null; } set { } }
    }
    public partial class HDInsightClusterGatewaySettings
    {
        internal HDInsightClusterGatewaySettings() { }
        public bool? IsCredentialEnabled { get { throw null; } }
        public string Password { get { throw null; } }
        public string UserName { get { throw null; } }
    }
    public partial class HDInsightClusterPatch : Azure.ResourceManager.Models.TrackedResourceData
    {
        public HDInsightClusterPatch(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.HDInsight.Models.UpdatableClusterProfile ClusterProfile { get { throw null; } set { } }
    }
    public partial class HiveCatalogOption
    {
        public HiveCatalogOption(string catalogName, string metastoreDbConnectionPasswordSecret, string metastoreDbConnectionURL, string metastoreDbConnectionUserName, string metastoreWarehouseDir) { }
        public string CatalogName { get { throw null; } set { } }
        public string MetastoreDbConnectionPasswordSecret { get { throw null; } set { } }
        public string MetastoreDbConnectionURL { get { throw null; } set { } }
        public string MetastoreDbConnectionUserName { get { throw null; } set { } }
        public string MetastoreWarehouseDir { get { throw null; } set { } }
    }
    public partial class IdentityProfile
    {
        public IdentityProfile(Azure.Core.ResourceIdentifier msiResourceId, string msiClientId, string msiObjectId) { }
        public string MsiClientId { get { throw null; } set { } }
        public string MsiObjectId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier MsiResourceId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct KeyVaultObjectType : System.IEquatable<Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public KeyVaultObjectType(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType Certificate { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType Key { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType Secret { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType left, Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType left, Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LoadBasedConfig
    {
        public LoadBasedConfig(int minNodes, int maxNodes, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ScalingRule> scalingRules) { }
        public int? CooldownPeriod { get { throw null; } set { } }
        public int MaxNodes { get { throw null; } set { } }
        public int MinNodes { get { throw null; } set { } }
        public int? PollInterval { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ScalingRule> ScalingRules { get { throw null; } }
    }
    public partial class NameAvailabilityContent
    {
        public NameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public string ResourceType { get { throw null; } set { } }
    }
    public partial class NameAvailabilityResult
    {
        internal NameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    public partial class NodeProfile
    {
        public NodeProfile(string nodeProfileType, string vmSize, int count) { }
        public int Count { get { throw null; } set { } }
        public string NodeProfileType { get { throw null; } set { } }
        public string VmSize { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningStatus : System.IEquatable<Azure.ResourceManager.HDInsight.Models.ProvisioningStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningStatus(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ProvisioningStatus Accepted { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ProvisioningStatus Canceled { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ProvisioningStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ProvisioningStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.ProvisioningStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.ProvisioningStatus left, Azure.ResourceManager.HDInsight.Models.ProvisioningStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.ProvisioningStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.ProvisioningStatus left, Azure.ResourceManager.HDInsight.Models.ProvisioningStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScaleActionType : System.IEquatable<Azure.ResourceManager.HDInsight.Models.ScaleActionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScaleActionType(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ScaleActionType Scaledown { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScaleActionType Scaleup { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.ScaleActionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.ScaleActionType left, Azure.ResourceManager.HDInsight.Models.ScaleActionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.ScaleActionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.ScaleActionType left, Azure.ResourceManager.HDInsight.Models.ScaleActionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ScalingRule
    {
        public ScalingRule(Azure.ResourceManager.HDInsight.Models.ScaleActionType actionType, int evaluationCount, string scalingMetric, Azure.ResourceManager.HDInsight.Models.ComparisonRule comparisonRule) { }
        public Azure.ResourceManager.HDInsight.Models.ScaleActionType ActionType { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ComparisonRule ComparisonRule { get { throw null; } set { } }
        public int EvaluationCount { get { throw null; } set { } }
        public string ScalingMetric { get { throw null; } set { } }
    }
    public partial class Schedule
    {
        public Schedule(string startTime, string endTime, int count, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.ScheduleDay> days) { }
        public int Count { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ScheduleDay> Days { get { throw null; } }
        public string EndTime { get { throw null; } set { } }
        public string StartTime { get { throw null; } set { } }
    }
    public partial class ScheduleBasedConfig
    {
        public ScheduleBasedConfig(string timeZone, int defaultCount, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HDInsight.Models.Schedule> schedules) { }
        public int DefaultCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.Schedule> Schedules { get { throw null; } }
        public string TimeZone { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScheduleDay : System.IEquatable<Azure.ResourceManager.HDInsight.Models.ScheduleDay>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScheduleDay(string value) { throw null; }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Friday { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Monday { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Saturday { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Sunday { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Thursday { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Tuesday { get { throw null; } }
        public static Azure.ResourceManager.HDInsight.Models.ScheduleDay Wednesday { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HDInsight.Models.ScheduleDay other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HDInsight.Models.ScheduleDay left, Azure.ResourceManager.HDInsight.Models.ScheduleDay right) { throw null; }
        public static implicit operator Azure.ResourceManager.HDInsight.Models.ScheduleDay (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HDInsight.Models.ScheduleDay left, Azure.ResourceManager.HDInsight.Models.ScheduleDay right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ScriptActionProfile
    {
        public ScriptActionProfile(string scriptActionProfileType, string name, System.Uri uri, System.Collections.Generic.IEnumerable<string> services) { }
        public string Name { get { throw null; } set { } }
        public string Parameters { get { throw null; } set { } }
        public string ScriptActionProfileType { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Services { get { throw null; } }
        public bool? ShouldPersist { get { throw null; } set { } }
        public int? TimeoutInMinutes { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
    }
    public partial class SecretReference
    {
        public SecretReference(string referenceName, Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType keyVaultObjectType, string keyVaultObjectName) { }
        public string KeyVaultObjectName { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.KeyVaultObjectType KeyVaultObjectType { get { throw null; } set { } }
        public string ReferenceName { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    public partial class SecretsProfile
    {
        public SecretsProfile(Azure.Core.ResourceIdentifier keyVaultResourceId) { }
        public Azure.Core.ResourceIdentifier KeyVaultResourceId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.SecretReference> Secrets { get { throw null; } }
    }
    public partial class ServiceConfigListResultValueEntity
    {
        internal ServiceConfigListResultValueEntity() { }
        public string Description { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class ServiceConfigResult
    {
        internal ServiceConfigResult() { }
        public string ComponentName { get { throw null; } }
        public string Content { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> CustomKeys { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.HDInsight.Models.ServiceConfigListResultValueEntity> DefaultKeys { get { throw null; } }
        public string FileName { get { throw null; } }
        public string Path { get { throw null; } }
        public string ServiceConfigListResultPropertiesType { get { throw null; } }
        public string ServiceName { get { throw null; } }
    }
    public partial class ServiceStatus
    {
        internal ServiceStatus() { }
        public string Kind { get { throw null; } }
        public string Message { get { throw null; } }
        public string Ready { get { throw null; } }
    }
    public partial class SparkMetastoreSpec
    {
        public SparkMetastoreSpec(string dbServerHost, string dbUserName, string dbPasswordSecretName, string keyVaultId) { }
        public string DbName { get { throw null; } set { } }
        public string DbPasswordSecretName { get { throw null; } set { } }
        public string DbServerHost { get { throw null; } set { } }
        public string DbUserName { get { throw null; } set { } }
        public string KeyVaultId { get { throw null; } set { } }
        public System.Uri ThriftUri { get { throw null; } set { } }
    }
    public partial class SparkProfile
    {
        public SparkProfile() { }
        public System.Uri DefaultStorageUri { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.SparkMetastoreSpec MetastoreSpec { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.SparkUserPlugin> Plugins { get { throw null; } }
    }
    public partial class SparkUserPlugin
    {
        public SparkUserPlugin(string path) { }
        public string Path { get { throw null; } set { } }
    }
    public partial class SshConnectivityEndpoint
    {
        internal SshConnectivityEndpoint() { }
        public string Endpoint { get { throw null; } }
    }
    public partial class SshProfile
    {
        public SshProfile(int count) { }
        public int Count { get { throw null; } set { } }
        public string PodPrefix { get { throw null; } }
    }
    public partial class TrinoCoordinator
    {
        public TrinoCoordinator() { }
        public bool? Enable { get { throw null; } set { } }
        public bool? HighAvailabilityEnabled { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public bool? Suspend { get { throw null; } set { } }
    }
    public partial class TrinoProfile
    {
        public TrinoProfile() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.HiveCatalogOption> CatalogOptionsHive { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.TrinoCoordinator Coordinator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.TrinoUserPlugin> Plugins { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.TrinoTelemetryConfig UserTelemetrySpecStorage { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.TrinoWorker Worker { get { throw null; } set { } }
    }
    public partial class TrinoTelemetryConfig
    {
        public TrinoTelemetryConfig() { }
        public string HivecatalogName { get { throw null; } set { } }
        public string HivecatalogSchema { get { throw null; } set { } }
        public int? PartitionRetentionInDays { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
    }
    public partial class TrinoUserPlugin
    {
        public TrinoUserPlugin() { }
        public bool? Enabled { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
    }
    public partial class TrinoWorker
    {
        public TrinoWorker() { }
        public bool? Enable { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public bool? Suspend { get { throw null; } set { } }
    }
    public partial class UpdatableClusterProfile
    {
        public UpdatableClusterProfile() { }
        public Azure.ResourceManager.HDInsight.Models.AuthorizationProfile AuthorizationProfile { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.AutoScaleProfile AutoScaleProfile { get { throw null; } set { } }
        public Azure.ResourceManager.HDInsight.Models.ClusterLogAnalyticsProfile LogAnalyticsProfile { get { throw null; } set { } }
        public bool? PrometheusProfileEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ScriptActionProfile> ScriptActionProfiles { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HDInsight.Models.ClusterServiceConfigsProfile> ServiceConfigsProfiles { get { throw null; } }
        public Azure.ResourceManager.HDInsight.Models.SshProfile SshProfile { get { throw null; } set { } }
    }
}
