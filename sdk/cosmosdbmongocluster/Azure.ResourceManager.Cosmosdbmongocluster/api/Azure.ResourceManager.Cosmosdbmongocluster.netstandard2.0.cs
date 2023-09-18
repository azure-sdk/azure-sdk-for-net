namespace Azure.ResourceManager.Cosmosdbmongocluster
{
    public static partial class CosmosdbmongoclusterExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityResponse> CheckNameAvailabilityMongoCluster(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityResponse>> CheckNameAvailabilityMongoClusterAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource GetFirewallRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> GetMongoCluster(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string mongoClusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> GetMongoClusterAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string mongoClusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource GetMongoClusterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterCollection GetMongoClusters(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> GetMongoClusters(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> GetMongoClustersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cosmosdbmongocluster.Models.Operation> GetOperations(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cosmosdbmongocluster.Models.Operation> GetOperationsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FirewallRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>, System.Collections.IEnumerable
    {
        protected FirewallRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string firewallRuleName, Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string firewallRuleName, Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> Get(string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>> GetAsync(string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FirewallRuleData : Azure.ResourceManager.Models.ResourceData
    {
        public FirewallRuleData(string startIPAddress, string endIPAddress) { }
        public string EndIPAddress { get { throw null; } set { } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string StartIPAddress { get { throw null; } set { } }
    }
    public partial class FirewallRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FirewallRuleResource() { }
        public virtual Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string mongoClusterName, string firewallRuleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MongoClusterCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>, System.Collections.IEnumerable
    {
        protected MongoClusterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string mongoClusterName, Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string mongoClusterName, Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string mongoClusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string mongoClusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> Get(string mongoClusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> GetAsync(string mongoClusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MongoClusterData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public MongoClusterData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string AdministratorLogin { get { throw null; } set { } }
        public string AdministratorLoginPassword { get { throw null; } set { } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus? ClusterStatus { get { throw null; } }
        public string ConnectionString { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode? CreateMode { get { throw null; } set { } }
        public string EarliestRestoreTime { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeGroupSpec> NodeGroupSpecs { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterRestoreParameters RestoreParameters { get { throw null; } set { } }
        public string ServerVersion { get { throw null; } set { } }
    }
    public partial class MongoClusterResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected MongoClusterResource() { }
        public virtual Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string mongoClusterName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.Models.ListConnectionStringsResult> GetConnectionStrings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.Models.ListConnectionStringsResult>> GetConnectionStringsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource> GetFirewallRule(string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleResource>> GetFirewallRuleAsync(string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleCollection GetFirewallRules() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Cosmosdbmongocluster.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionType : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionType(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType Internal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType left, Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType left, Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmCosmosdbmongoclusterModelFactory
    {
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityResponse CheckNameAvailabilityResponse(bool? nameAvailable = default(bool?), Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason? reason = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason?), string message = null) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ConnectionString ConnectionString(string connectionStringValue = null, string description = null) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.FirewallRuleData FirewallRuleData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState?), string startIPAddress = null, string endIPAddress = null) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ListConnectionStringsResult ListConnectionStringsResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.Models.ConnectionString> connectionStrings = null) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.MongoClusterData MongoClusterData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode? createMode = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode?), Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterRestoreParameters restoreParameters = null, string administratorLogin = null, string administratorLoginPassword = null, string serverVersion = null, string connectionString = null, string earliestRestoreTime = null, Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState?), Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus? clusterStatus = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeGroupSpec> nodeGroupSpecs = null) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.Operation Operation(string name = null, bool? isDataAction = default(bool?), Azure.ResourceManager.Cosmosdbmongocluster.Models.OperationDisplay display = null, Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin? origin = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin?), Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType? actionType = default(Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType?)) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.OperationDisplay OperationDisplay(string provider = null, string resource = null, string operation = null, string description = null) { throw null; }
    }
    public partial class CheckNameAvailabilityContent
    {
        public CheckNameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public string ResourceType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CheckNameAvailabilityReason : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CheckNameAvailabilityReason(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason AlreadyExists { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason Invalid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CheckNameAvailabilityResponse
    {
        internal CheckNameAvailabilityResponse() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.CheckNameAvailabilityReason? Reason { get { throw null; } }
    }
    public partial class ConnectionString
    {
        internal ConnectionString() { }
        public string ConnectionStringValue { get { throw null; } }
        public string Description { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CreateMode : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CreateMode(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode Default { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode PointInTimeRestore { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode left, Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode left, Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ListConnectionStringsResult
    {
        internal ListConnectionStringsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Cosmosdbmongocluster.Models.ConnectionString> ConnectionStrings { get { throw null; } }
    }
    public partial class MongoClusterPatch
    {
        public MongoClusterPatch() { }
        public string AdministratorLogin { get { throw null; } set { } }
        public string AdministratorLoginPassword { get { throw null; } set { } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus? ClusterStatus { get { throw null; } }
        public string ConnectionString { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.CreateMode? CreateMode { get { throw null; } set { } }
        public string EarliestRestoreTime { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeGroupSpec> NodeGroupSpecs { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterRestoreParameters RestoreParameters { get { throw null; } set { } }
        public string ServerVersion { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class MongoClusterRestoreParameters
    {
        public MongoClusterRestoreParameters() { }
        public System.DateTimeOffset? PointInTimeUTC { get { throw null; } set { } }
        public string SourceResourceId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MongoClusterStatus : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MongoClusterStatus(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Dropping { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Ready { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Starting { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Stopped { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Stopping { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus left, Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus left, Azure.ResourceManager.Cosmosdbmongocluster.Models.MongoClusterStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NodeGroupProperties
    {
        public NodeGroupProperties() { }
        public long? DiskSizeGB { get { throw null; } set { } }
        public bool? EnableHa { get { throw null; } set { } }
        public string Sku { get { throw null; } set { } }
    }
    public partial class NodeGroupSpec : Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeGroupProperties
    {
        public NodeGroupSpec() { }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind? Kind { get { throw null; } set { } }
        public int? NodeCount { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NodeKind : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NodeKind(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind Shard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind left, Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind left, Azure.ResourceManager.Cosmosdbmongocluster.Models.NodeKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Operation
    {
        internal Operation() { }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.ActionType? ActionType { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.OperationDisplay Display { get { throw null; } }
        public bool? IsDataAction { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin? Origin { get { throw null; } }
    }
    public partial class OperationDisplay
    {
        internal OperationDisplay() { }
        public string Description { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Origin : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Origin(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin System { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin User { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin UserSystem { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin left, Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin left, Azure.ResourceManager.Cosmosdbmongocluster.Models.Origin right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState Dropping { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState InProgress { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState left, Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState left, Azure.ResourceManager.Cosmosdbmongocluster.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
}
