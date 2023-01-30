namespace Azure.ResourceManager.ExtendedLocations
{
    public partial class CustomLocationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>, System.Collections.IEnumerable
    {
        protected CustomLocationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ExtendedLocations.CustomLocationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ExtendedLocations.CustomLocationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> Get(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> GetAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CustomLocationData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public CustomLocationData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string AccountId { get { throw null; } set { } }
        public Azure.ResourceManager.ExtendedLocations.Models.CustomLocationAuthentication Authentication { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ClusterExtensionIds { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ExcludedAccounts { get { throw null; } }
        public System.Collections.Generic.IList<string> ExcludedFolderIds { get { throw null; } }
        public System.Collections.Generic.IList<string> ExcludedProjectNumbers { get { throw null; } }
        public Azure.Core.ResourceIdentifier HostResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType? HostType { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public string OrganizationId { get { throw null; } set { } }
        public string ProjectId { get { throw null; } set { } }
        public string ProjectNumber { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } set { } }
    }
    public partial class CustomLocationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CustomLocationResource() { }
        public virtual Azure.ResourceManager.ExtendedLocations.CustomLocationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.Models.CustomLocationFindTargetResourceGroupResult> FindTargetResourceGroup(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationFindTargetResourceGroupProperties customLocationFindTargetResourceGroupProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.Models.CustomLocationFindTargetResourceGroupResult>> FindTargetResourceGroupAsync(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationFindTargetResourceGroupProperties customLocationFindTargetResourceGroupProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ExtendedLocations.Models.CustomLocationEnabledResourceType> GetEnabledResourceTypes(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ExtendedLocations.Models.CustomLocationEnabledResourceType> GetEnabledResourceTypesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> GetResourceSyncRule(string childResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> GetResourceSyncRuleAsync(string childResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleCollection GetResourceSyncRules() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> Update(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> UpdateAsync(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ExtendedLocationsExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> GetCustomLocation(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.CustomLocationResource>> GetCustomLocationAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ExtendedLocations.CustomLocationResource GetCustomLocationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ExtendedLocations.CustomLocationCollection GetCustomLocations(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> GetCustomLocations(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ExtendedLocations.CustomLocationResource> GetCustomLocationsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource GetResourceSyncRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class ResourceSyncRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>, System.Collections.IEnumerable
    {
        protected ResourceSyncRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string childResourceName, Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string childResourceName, Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string childResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string childResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> Get(string childResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> GetAsync(string childResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ResourceSyncRuleData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ResourceSyncRuleData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public int? Priority { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ExtendedLocations.Models.ResourceSyncRulePropertiesSelector Selector { get { throw null; } set { } }
        public string TargetResourceGroup { get { throw null; } set { } }
    }
    public partial class ResourceSyncRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ResourceSyncRuleResource() { }
        public virtual Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string childResourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ExtendedLocations.Models.ResourceSyncRulePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ExtendedLocations.ResourceSyncRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ExtendedLocations.Models.ResourceSyncRulePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationAuthentication
    {
        public CustomLocationAuthentication() { }
        public string CustomLocationPropertiesAuthenticationType { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class CustomLocationEnabledResourceType : Azure.ResourceManager.Models.ResourceData
    {
        public CustomLocationEnabledResourceType() { }
        public Azure.Core.ResourceIdentifier ClusterExtensionId { get { throw null; } set { } }
        public string ExtensionType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ExtendedLocations.Models.CustomLocationEnabledResourceTypeMetadata> TypesMetadata { get { throw null; } }
    }
    public partial class CustomLocationEnabledResourceTypeMetadata
    {
        public CustomLocationEnabledResourceTypeMetadata() { }
        public string ApiVersion { get { throw null; } set { } }
        public string ResourceProviderNamespace { get { throw null; } set { } }
        public string ResourceType { get { throw null; } set { } }
    }
    public partial class CustomLocationFindTargetResourceGroupProperties
    {
        public CustomLocationFindTargetResourceGroupProperties() { }
        public System.Collections.Generic.IDictionary<string, string> Labels { get { throw null; } }
    }
    public partial class CustomLocationFindTargetResourceGroupResult
    {
        internal CustomLocationFindTargetResourceGroupResult() { }
        public string MatchedResourceSyncRule { get { throw null; } }
        public string TargetResourceGroup { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomLocationHostType : System.IEquatable<Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomLocationHostType(string value) { throw null; }
        public static Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType AWS { get { throw null; } }
        public static Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType GCP { get { throw null; } }
        public static Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType Kubernetes { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType left, Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType left, Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CustomLocationPatch
    {
        public CustomLocationPatch() { }
        public string AccountId { get { throw null; } set { } }
        public Azure.ResourceManager.ExtendedLocations.Models.CustomLocationAuthentication Authentication { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ClusterExtensionIds { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ExcludedAccounts { get { throw null; } }
        public System.Collections.Generic.IList<string> ExcludedFolderIds { get { throw null; } }
        public System.Collections.Generic.IList<string> ExcludedProjectNumbers { get { throw null; } }
        public Azure.Core.ResourceIdentifier HostResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.ExtendedLocations.Models.CustomLocationHostType? HostType { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public string OrganizationId { get { throw null; } set { } }
        public string ProjectId { get { throw null; } set { } }
        public string ProjectNumber { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class MatchExpressionsProperties
    {
        public MatchExpressionsProperties() { }
        public string Key { get { throw null; } set { } }
        public string Operator { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Values { get { throw null; } }
    }
    public partial class ResourceSyncRulePatch
    {
        public ResourceSyncRulePatch() { }
        public int? Priority { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ExtendedLocations.Models.ResourceSyncRulePropertiesSelector Selector { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public string TargetResourceGroup { get { throw null; } set { } }
    }
    public partial class ResourceSyncRulePropertiesSelector
    {
        public ResourceSyncRulePropertiesSelector() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ExtendedLocations.Models.MatchExpressionsProperties> MatchExpressions { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> MatchLabels { get { throw null; } }
    }
}
