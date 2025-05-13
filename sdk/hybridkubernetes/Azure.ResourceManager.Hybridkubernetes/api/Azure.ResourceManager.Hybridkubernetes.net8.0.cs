namespace Azure.ResourceManager.Hybridkubernetes
{
    public partial class AzureResourceManagerHybridkubernetesContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerHybridkubernetesContext() { }
        public static Azure.ResourceManager.Hybridkubernetes.AzureResourceManagerHybridkubernetesContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class ConnectedClusterCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>, System.Collections.IEnumerable
    {
        protected ConnectedClusterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> Get(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> GetAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetIfExists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> GetIfExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConnectedClusterData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>
    {
        public ConnectedClusterData(Azure.Core.AzureLocation location, Azure.ResourceManager.Models.ManagedServiceIdentity identity, string agentPublicKeyCertificate) { }
        public Azure.ResourceManager.Hybridkubernetes.Models.AadProfile AadProfile { get { throw null; } set { } }
        public string AgentPublicKeyCertificate { get { throw null; } set { } }
        public string AgentVersion { get { throw null; } }
        public Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile ArcAgentProfile { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations> ArcAgentryConfigurations { get { throw null; } set { } }
        public Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit? AzureHybridBenefit { get { throw null; } set { } }
        public Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus? ConnectivityStatus { get { throw null; } }
        public string Distribution { get { throw null; } set { } }
        public string DistributionVersion { get { throw null; } set { } }
        public Azure.ResourceManager.Hybridkubernetes.Models.Gateway Gateway { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string Infrastructure { get { throw null; } set { } }
        public Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind? Kind { get { throw null; } set { } }
        public string KubernetesVersion { get { throw null; } }
        public System.DateTimeOffset? LastConnectivityOn { get { throw null; } }
        public System.DateTimeOffset? ManagedIdentityCertificateExpirationOn { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> MiscellaneousProperties { get { throw null; } }
        public string Offering { get { throw null; } }
        public Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile OidcIssuerProfile { get { throw null; } set { } }
        public string PrivateLinkScopeResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState? PrivateLinkState { get { throw null; } set { } }
        public Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        public int? TotalCoreCount { get { throw null; } }
        public int? TotalNodeCount { get { throw null; } }
        public bool? WorkloadIdentityEnabled { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectedClusterResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConnectedClusterResource() { }
        public virtual Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults> GetClusterUserCredential(Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>> GetClusterUserCredentialAsync(Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> Update(Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> UpdateAsync(Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HybridkubernetesExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetConnectedCluster(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> GetConnectedClusterAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource GetConnectedClusterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.ConnectedClusterCollection GetConnectedClusters(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetConnectedClusters(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetConnectedClustersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Hybridkubernetes.Mocking
{
    public partial class MockableHybridkubernetesArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableHybridkubernetesArmClient() { }
        public virtual Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource GetConnectedClusterResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableHybridkubernetesResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHybridkubernetesResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetConnectedCluster(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource>> GetConnectedClusterAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Hybridkubernetes.ConnectedClusterCollection GetConnectedClusters() { throw null; }
    }
    public partial class MockableHybridkubernetesSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHybridkubernetesSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetConnectedClusters(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Hybridkubernetes.ConnectedClusterResource> GetConnectedClustersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Hybridkubernetes.Models
{
    public partial class AadProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>
    {
        public AadProfile() { }
        public System.Collections.Generic.IList<string> AdminGroupObjectIds { get { throw null; } }
        public bool? EnableAzureRBAC { get { throw null; } set { } }
        public string TenantId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.AadProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.AadProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AadProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AgentError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>
    {
        public AgentError() { }
        public string Component { get { throw null; } }
        public string Message { get { throw null; } }
        public string Severity { get { throw null; } }
        public System.DateTimeOffset? Time { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.AgentError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.AgentError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.AgentError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ArcAgentProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>
    {
        public ArcAgentProfile() { }
        public Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption? AgentAutoUpgrade { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Hybridkubernetes.Models.AgentError> AgentErrors { get { throw null; } }
        public string AgentState { get { throw null; } }
        public string DesiredAgentVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent> SystemComponents { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ArcAgentryConfigurations : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>
    {
        public ArcAgentryConfigurations() { }
        public string Feature { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> ProtectedSettings { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Settings { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmHybridkubernetesModelFactory
    {
        public static Azure.ResourceManager.Hybridkubernetes.Models.AgentError AgentError(string message = null, string severity = null, string component = null, System.DateTimeOffset? time = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile ArcAgentProfile(string desiredAgentVersion = null, Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption? agentAutoUpgrade = default(Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent> systemComponents = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Hybridkubernetes.Models.AgentError> agentErrors = null, string agentState = null) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.ConnectedClusterData ConnectedClusterData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind? kind = default(Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind?), string agentPublicKeyCertificate = null, string kubernetesVersion = null, int? totalNodeCount = default(int?), int? totalCoreCount = default(int?), string agentVersion = null, Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState?), string distribution = null, string distributionVersion = null, string infrastructure = null, string offering = null, System.DateTimeOffset? managedIdentityCertificateExpirationOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastConnectivityOn = default(System.DateTimeOffset?), Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus? connectivityStatus = default(Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus?), Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState? privateLinkState = default(Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState?), string privateLinkScopeResourceId = null, Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit? azureHybridBenefit = default(Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit?), Azure.ResourceManager.Hybridkubernetes.Models.AadProfile aadProfile = null, Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentProfile arcAgentProfile = null, bool? workloadIdentityEnabled = default(bool?), Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile oidcIssuerProfile = null, Azure.ResourceManager.Hybridkubernetes.Models.Gateway gateway = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Hybridkubernetes.Models.ArcAgentryConfigurations> arcAgentryConfigurations = null, System.Collections.Generic.IReadOnlyDictionary<string, string> miscellaneousProperties = null) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult CredentialResult(string name = null, byte[] value = null) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults CredentialResults(Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig hybridConnectionConfig = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult> kubeconfigs = null) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig HybridConnectionConfig(long? expirationTime = default(long?), string hybridConnectionName = null, string relay = null, string token = null, string relayTid = null, string relayType = null) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile OidcIssuerProfile(bool? enabled = default(bool?), string issuerUri = null, string selfHostedIssuerUri = null) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent SystemComponent(string type = null, string userSpecifiedVersion = null, int? majorVersion = default(int?), string currentVersion = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AuthenticationMethod : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AuthenticationMethod(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod AAD { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod Token { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod left, Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod left, Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoUpgradeOption : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoUpgradeOption(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption Disabled { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption left, Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption left, Azure.ResourceManager.Hybridkubernetes.Models.AutoUpgradeOption right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AzureHybridBenefit : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AzureHybridBenefit(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit False { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit NotApplicable { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit left, Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit left, Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectedClusterKind : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectedClusterKind(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind AWS { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind ProvisionedCluster { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind left, Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind left, Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConnectedClusterPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>
    {
        public ConnectedClusterPatch() { }
        public Azure.ResourceManager.Hybridkubernetes.Models.AzureHybridBenefit? AzureHybridBenefit { get { throw null; } set { } }
        public string Distribution { get { throw null; } set { } }
        public string DistributionVersion { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ConnectedClusterPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectivityStatus : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectivityStatus(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus AgentNotInstalled { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus Connected { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus Connecting { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus Offline { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus left, Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus left, Azure.ResourceManager.Hybridkubernetes.Models.ConnectivityStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CredentialResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>
    {
        internal CredentialResult() { }
        public string Name { get { throw null; } }
        public byte[] Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CredentialResults : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>
    {
        internal CredentialResults() { }
        public Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig HybridConnectionConfig { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResult> Kubeconfigs { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.CredentialResults>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Gateway : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>
    {
        public Gateway() { }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.Gateway System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.Gateway System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.Gateway>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridConnectionConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>
    {
        internal HybridConnectionConfig() { }
        public long? ExpirationTime { get { throw null; } }
        public string HybridConnectionName { get { throw null; } }
        public string Relay { get { throw null; } }
        public string RelayTid { get { throw null; } }
        public string RelayType { get { throw null; } }
        public string Token { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.HybridConnectionConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ListClusterUserCredentialProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>
    {
        public ListClusterUserCredentialProperties(Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod authenticationMethod, bool clientProxy) { }
        public Azure.ResourceManager.Hybridkubernetes.Models.AuthenticationMethod AuthenticationMethod { get { throw null; } }
        public bool ClientProxy { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.ListClusterUserCredentialProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OidcIssuerProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>
    {
        public OidcIssuerProfile() { }
        public bool? Enabled { get { throw null; } set { } }
        public string IssuerUri { get { throw null; } }
        public string SelfHostedIssuerUri { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.OidcIssuerProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrivateLinkState : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrivateLinkState(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState left, Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState left, Azure.ResourceManager.Hybridkubernetes.Models.PrivateLinkState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState left, Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState left, Azure.ResourceManager.Hybridkubernetes.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SystemComponent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>
    {
        public SystemComponent() { }
        public string CurrentVersion { get { throw null; } }
        public int? MajorVersion { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public string UserSpecifiedVersion { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Hybridkubernetes.Models.SystemComponent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
