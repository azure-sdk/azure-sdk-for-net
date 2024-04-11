namespace Azure.ResourceManager.EventHubs
{
    public partial class ClusterCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.ClusterResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.ClusterResource>, System.Collections.IEnumerable
    {
        protected ClusterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.ClusterResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.EventHubs.ClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.ClusterResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.EventHubs.ClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> Get(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.ClusterResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.ClusterResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> GetAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.ClusterResource> GetIfExists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.ClusterResource>> GetIfExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.ClusterResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.ClusterResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.ClusterResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.ClusterResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ClusterData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.ClusterData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.ClusterData>
    {
        public ClusterData(Azure.Core.AzureLocation location) { }
        public string CreatedAt { get { throw null; } }
        public string MetricId { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.ClusterSku Sku { get { throw null; } set { } }
        public string Status { get { throw null; } }
        public bool? SupportsScaling { get { throw null; } set { } }
        public string UpdatedAt { get { throw null; } }
        Azure.ResourceManager.EventHubs.ClusterData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.ClusterData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.ClusterData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.ClusterData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.ClusterData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.ClusterData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.ClusterData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClusterResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ClusterResource() { }
        public virtual Azure.ResourceManager.EventHubs.ClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties> GetConfiguration(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>> GetConfigurationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.SubResource> GetNamespaces(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.SubResource> GetNamespacesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties> PatchConfiguration(Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties clusterQuotaConfigurationProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>> PatchConfigurationAsync(Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties clusterQuotaConfigurationProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.ClusterResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.ClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.ClusterResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.ClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EHNamespaceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EHNamespaceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EHNamespaceResource>, System.Collections.IEnumerable
    {
        protected EHNamespaceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EHNamespaceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string namespaceName, Azure.ResourceManager.EventHubs.EHNamespaceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EHNamespaceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string namespaceName, Azure.ResourceManager.EventHubs.EHNamespaceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> Get(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> GetAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetIfExists(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EHNamespaceResource>> GetIfExistsAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EHNamespaceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EHNamespaceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EHNamespaceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EHNamespaceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EHNamespaceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EHNamespaceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EHNamespaceData>
    {
        public EHNamespaceData(Azure.Core.AzureLocation location) { }
        public string AlternateName { get { throw null; } set { } }
        public string ClusterArmId { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public bool? DisableLocalAuth { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.Encryption Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public bool? IsAutoInflateEnabled { get { throw null; } set { } }
        public bool? KafkaEnabled { get { throw null; } set { } }
        public int? MaximumThroughputUnits { get { throw null; } set { } }
        public string MetricId { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion? MinimumTlsVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public string ServiceBusEndpoint { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsSku Sku { get { throw null; } set { } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        public bool? ZoneRedundant { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.EHNamespaceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EHNamespaceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EHNamespaceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EHNamespaceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EHNamespaceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EHNamespaceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EHNamespaceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EHNamespaceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EHNamespaceResource() { }
        public virtual Azure.ResourceManager.EventHubs.EHNamespaceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult> CheckEventHubsDisasterRecoveryNameAvailability(Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>> CheckEventHubsDisasterRecoveryNameAvailabilityAsync(Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation CreateOrUpdateNetworkSecurityPerimeterConfiguration(Azure.WaitUntil waitUntil, string resourceAssociationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateOrUpdateNetworkSecurityPerimeterConfigurationAsync(Azure.WaitUntil waitUntil, string resourceAssociationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubResource> GetEventHub(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubResource>> GetEventHubAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubCollection GetEventHubs() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> GetEventHubsApplicationGroup(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>> GetEventHubsApplicationGroupAsync(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsApplicationGroupCollection GetEventHubsApplicationGroups() { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryCollection GetEventHubsDisasterRecoveries() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> GetEventHubsDisasterRecovery(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>> GetEventHubsDisasterRecoveryAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> GetEventHubsNamespaceAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>> GetEventHubsNamespaceAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleCollection GetEventHubsNamespaceAuthorizationRules() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> GetEventHubsPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>> GetEventHubsPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionCollection GetEventHubsPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> GetEventHubsSchemaGroup(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>> GetEventHubsSchemaGroupAsync(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsSchemaGroupCollection GetEventHubsSchemaGroups() { throw null; }
        public virtual Azure.ResourceManager.EventHubs.NetworkRuleSetResource GetNetworkRuleSet() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration> GetNetworkSecurityPerimeterConfigurations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration> GetNetworkSecurityPerimeterConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> Update(Azure.ResourceManager.EventHubs.EHNamespaceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> UpdateAsync(Azure.ResourceManager.EventHubs.EHNamespaceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected EventHubAuthorizationRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> GetIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys> RegenerateKeys(Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubResource>, System.Collections.IEnumerable
    {
        protected EventHubCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string eventHubName, Azure.ResourceManager.EventHubs.EventHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string eventHubName, Azure.ResourceManager.EventHubs.EventHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubResource> Get(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubResource>> GetAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubResource> GetIfExists(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubResource>> GetIfExistsAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubData>
    {
        public EventHubData() { }
        public Azure.ResourceManager.EventHubs.Models.CaptureDescription CaptureDescription { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future release", false)]
        public long? MessageRetentionInDays { get { throw null; } set { } }
        public long? PartitionCount { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> PartitionIds { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.RetentionDescription RetentionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubEntityStatus? Status { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        public string UserMetadata { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.EventHubData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string eventHubName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource> GetEventHubAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource>> GetEventHubAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleCollection GetEventHubAuthorizationRules() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> GetEventHubsConsumerGroup(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>> GetEventHubsConsumerGroupAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsConsumerGroupCollection GetEventHubsConsumerGroups() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubsApplicationGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>, System.Collections.IEnumerable
    {
        protected EventHubsApplicationGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string applicationGroupName, Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string applicationGroupName, Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> Get(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>> GetAsync(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> GetIfExists(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>> GetIfExistsAsync(string applicationGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsApplicationGroupData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>
    {
        public EventHubsApplicationGroupData() { }
        public string ClientAppGroupIdentifier { get { throw null; } set { } }
        public bool? IsEnabled { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy> Policies { get { throw null; } }
        Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsApplicationGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsApplicationGroupResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string applicationGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubsAuthorizationRuleData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>
    {
        public EventHubsAuthorizationRuleData() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight> Rights { get { throw null; } }
        Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsConsumerGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>, System.Collections.IEnumerable
    {
        protected EventHubsConsumerGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string consumerGroupName, Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string consumerGroupName, Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> Get(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>> GetAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> GetIfExists(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>> GetIfExistsAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsConsumerGroupData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>
    {
        public EventHubsConsumerGroupData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        public string UserMetadata { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsConsumerGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsConsumerGroupResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubsDisasterRecoveryAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected EventHubsDisasterRecoveryAuthorizationRuleCollection() { }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> GetIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsDisasterRecoveryAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsDisasterRecoveryAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string alias, string authorizationRuleName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubsDisasterRecoveryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>, System.Collections.IEnumerable
    {
        protected EventHubsDisasterRecoveryCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string alias, Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string alias, Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> Get(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>> GetAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> GetIfExists(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>> GetIfExistsAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsDisasterRecoveryData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>
    {
        public EventHubsDisasterRecoveryData() { }
        public string AlternateName { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public string PartnerNamespace { get { throw null; } set { } }
        public long? PendingReplicationOperationsCount { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsDisasterRecoveryProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsDisasterRecoveryRole? Role { get { throw null; } }
        Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsDisasterRecoveryResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsDisasterRecoveryResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response BreakPairing(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> BreakPairingAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string alias) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response FailOver(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> FailOverAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource> GetEventHubsDisasterRecoveryAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource>> GetEventHubsDisasterRecoveryAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleCollection GetEventHubsDisasterRecoveryAuthorizationRules() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class EventHubsExtensions
    {
        public static Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult> CheckEventHubsNamespaceNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>> CheckEventHubsNamespaceNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.EventHubs.Models.AvailableCluster> GetAvailableClusterRegionClusters(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Models.AvailableCluster> GetAvailableClusterRegionClustersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> GetCluster(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> GetClusterAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.EventHubs.ClusterResource GetClusterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.ClusterCollection GetClusters(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.EventHubs.ClusterResource> GetClusters(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.EventHubs.ClusterResource> GetClustersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetEHNamespace(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> GetEHNamespaceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.EventHubs.EHNamespaceResource GetEHNamespaceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EHNamespaceCollection GetEHNamespaces(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetEHNamespaces(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetEHNamespacesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource GetEventHubAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubResource GetEventHubResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource GetEventHubsApplicationGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource GetEventHubsConsumerGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource GetEventHubsDisasterRecoveryAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource GetEventHubsDisasterRecoveryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource GetEventHubsNamespaceAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource GetEventHubsPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource GetEventHubsSchemaGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.NetworkRuleSetResource GetNetworkRuleSetResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class EventHubsNamespaceAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected EventHubsNamespaceAuthorizationRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> GetIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsNamespaceAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsNamespaceAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string authorizationRuleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys> RegenerateKeys(Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubsPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected EventHubsPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>
    {
        public EventHubsPrivateEndpointConnectionData() { }
        public Azure.ResourceManager.EventHubs.Models.ConnectionState ConnectionState { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState? ProvisioningState { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubsSchemaGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>, System.Collections.IEnumerable
    {
        protected EventHubsSchemaGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string schemaGroupName, Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string schemaGroupName, Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> Get(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>> GetAsync(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> GetIfExists(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>> GetIfExistsAsync(string schemaGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubsSchemaGroupData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>
    {
        public EventHubsSchemaGroupData() { }
        public System.DateTimeOffset? CreatedAtUtc { get { throw null; } }
        public Azure.ETag? ETag { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> GroupProperties { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility? SchemaCompatibility { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType? SchemaType { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedAtUtc { get { throw null; } }
        Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsSchemaGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubsSchemaGroupResource() { }
        public virtual Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string schemaGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkRuleSetData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>
    {
        public NetworkRuleSetData() { }
        public Azure.ResourceManager.EventHubs.Models.DefaultAction? DefaultAction { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules> IPRules { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag? PublicNetworkAccess { get { throw null; } set { } }
        public bool? TrustedServiceAccessEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules> VirtualNetworkRules { get { throw null; } }
        Azure.ResourceManager.EventHubs.NetworkRuleSetData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.NetworkRuleSetData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.NetworkRuleSetData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkRuleSetResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkRuleSetResource() { }
        public virtual Azure.ResourceManager.EventHubs.NetworkRuleSetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.NetworkRuleSetResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.NetworkRuleSetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.EventHubs.NetworkRuleSetResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.EventHubs.NetworkRuleSetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.NetworkRuleSetResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.NetworkRuleSetResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.EventHubs.Mocking
{
    public partial class MockableEventHubsArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableEventHubsArmClient() { }
        public virtual Azure.ResourceManager.EventHubs.ClusterResource GetClusterResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EHNamespaceResource GetEHNamespaceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubAuthorizationRuleResource GetEventHubAuthorizationRuleResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubResource GetEventHubResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsApplicationGroupResource GetEventHubsApplicationGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsConsumerGroupResource GetEventHubsConsumerGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryAuthorizationRuleResource GetEventHubsDisasterRecoveryAuthorizationRuleResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryResource GetEventHubsDisasterRecoveryResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsNamespaceAuthorizationRuleResource GetEventHubsNamespaceAuthorizationRuleResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionResource GetEventHubsPrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EventHubsSchemaGroupResource GetEventHubsSchemaGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.NetworkRuleSetResource GetNetworkRuleSetResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableEventHubsResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableEventHubsResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource> GetCluster(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterResource>> GetClusterAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.ClusterCollection GetClusters() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetEHNamespace(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespaceResource>> GetEHNamespaceAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.EHNamespaceCollection GetEHNamespaces() { throw null; }
    }
    public partial class MockableEventHubsSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableEventHubsSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult> CheckEventHubsNamespaceNameAvailability(Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>> CheckEventHubsNamespaceNameAvailabilityAsync(Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.Models.AvailableCluster> GetAvailableClusterRegionClusters(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Models.AvailableCluster> GetAvailableClusterRegionClustersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.ClusterResource> GetClusters(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.ClusterResource> GetClustersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetEHNamespaces(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EHNamespaceResource> GetEHNamespacesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.EventHubs.Models
{
    public static partial class ArmEventHubsModelFactory
    {
        public static Azure.ResourceManager.EventHubs.Models.AvailableCluster AvailableCluster(Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.ClusterData ClusterData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.EventHubs.Models.ClusterSku sku = null, string createdAt = null, Azure.ResourceManager.EventHubs.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.EventHubs.Models.ProvisioningState?), string updatedAt = null, string metricId = null, string status = null, bool? supportsScaling = default(bool?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.EHNamespaceData EHNamespaceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.EventHubs.Models.EventHubsSku sku = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion? minimumTlsVersion = default(Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion?), string provisioningState = null, string status = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string serviceBusEndpoint = null, string clusterArmId = null, string metricId = null, bool? isAutoInflateEnabled = default(bool?), Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess?), int? maximumThroughputUnits = default(int?), bool? kafkaEnabled = default(bool?), bool? zoneRedundant = default(bool?), Azure.ResourceManager.EventHubs.Models.Encryption encryption = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData> privateEndpointConnections = null, bool? disableLocalAuth = default(bool?), string alternateName = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubData EventHubData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<string> partitionIds = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), long? partitionCount = default(long?), Azure.ResourceManager.EventHubs.Models.EventHubEntityStatus? status = default(Azure.ResourceManager.EventHubs.Models.EventHubEntityStatus?), string userMetadata = null, Azure.ResourceManager.EventHubs.Models.CaptureDescription captureDescription = null, Azure.ResourceManager.EventHubs.Models.RetentionDescription retentionDescription = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys EventHubsAccessKeys(string primaryConnectionString = null, string secondaryConnectionString = null, string aliasPrimaryConnectionString = null, string aliasSecondaryConnectionString = null, string primaryKey = null, string secondaryKey = null, string keyName = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsApplicationGroupData EventHubsApplicationGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, bool? isEnabled = default(bool?), string clientAppGroupIdentifier = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy> policies = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsAuthorizationRuleData EventHubsAuthorizationRuleData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight> rights = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsConsumerGroupData EventHubsConsumerGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string userMetadata = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsDisasterRecoveryData EventHubsDisasterRecoveryData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.EventHubs.Models.EventHubsDisasterRecoveryProvisioningState? provisioningState = default(Azure.ResourceManager.EventHubs.Models.EventHubsDisasterRecoveryProvisioningState?), string partnerNamespace = null, string alternateName = null, Azure.ResourceManager.EventHubs.Models.EventHubsDisasterRecoveryRole? role = default(Azure.ResourceManager.EventHubs.Models.EventHubsDisasterRecoveryRole?), long? pendingReplicationOperationsCount = default(long?), Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult EventHubsNameAvailabilityResult(string message = null, bool? nameAvailable = default(bool?), Azure.ResourceManager.EventHubs.Models.EventHubsNameUnavailableReason? reason = default(Azure.ResourceManager.EventHubs.Models.EventHubsNameUnavailableReason?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter EventHubsNetworkSecurityPerimeter(string id = null, string perimeterGuid = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration EventHubsNetworkSecurityPerimeterConfiguration(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState? provisioningState = default(Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue> provisioningIssues = null, Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter networkSecurityPerimeter = null, Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation resourceAssociation = null, Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile profile = null, bool? isBackingResource = default(bool?), System.Collections.Generic.IEnumerable<string> applicableFeatures = null, string parentAssociationName = null, string sourceResourceId = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(string name = null, string accessRulesVersion = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule> accessRules = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(string name = null, Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode? accessMode = default(Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule EventHubsNspAccessRule(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties properties = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties EventHubsNspAccessRuleProperties(Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection? direction = default(Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection?), System.Collections.Generic.IEnumerable<string> addressPrefixes = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> subscriptions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter> networkSecurityPerimeters = null, System.Collections.Generic.IEnumerable<string> fullyQualifiedDomainNames = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsPrivateEndpointConnectionData EventHubsPrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.EventHubs.Models.ConnectionState connectionState = null, Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState? provisioningState = default(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState?), Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource EventHubsPrivateLinkResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, System.Collections.Generic.IEnumerable<string> requiredZoneNames = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue EventHubsProvisioningIssue(string name = null, Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties properties = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties EventHubsProvisioningIssueProperties(string issueType = null, string description = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent EventHubsRegenerateAccessKeyContent(Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType keyType = default(Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType), string key = null) { throw null; }
        public static Azure.ResourceManager.EventHubs.EventHubsSchemaGroupData EventHubsSchemaGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.DateTimeOffset? updatedAtUtc = default(System.DateTimeOffset?), System.DateTimeOffset? createdAtUtc = default(System.DateTimeOffset?), Azure.ETag? eTag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> groupProperties = null, Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility? schemaCompatibility = default(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility?), Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType? schemaType = default(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType?), Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
        public static Azure.ResourceManager.EventHubs.NetworkRuleSetData NetworkRuleSetData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, bool? trustedServiceAccessEnabled = default(bool?), Azure.ResourceManager.EventHubs.Models.DefaultAction? defaultAction = default(Azure.ResourceManager.EventHubs.Models.DefaultAction?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules> virtualNetworkRules = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules> ipRules = null, Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag? publicNetworkAccess = default(Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag?), Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?)) { throw null; }
    }
    public partial class AvailableCluster : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>
    {
        internal AvailableCluster() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.AvailableCluster System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.AvailableCluster System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.AvailableCluster>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CaptureDescription : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>
    {
        public CaptureDescription() { }
        public Azure.ResourceManager.EventHubs.Models.EventHubDestination Destination { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EncodingCaptureDescription? Encoding { get { throw null; } set { } }
        public int? IntervalInSeconds { get { throw null; } set { } }
        public int? SizeLimitInBytes { get { throw null; } set { } }
        public bool? SkipEmptyArchives { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.CaptureDescription System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.CaptureDescription System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureDescription>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CaptureIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>
    {
        public CaptureIdentity() { }
        public Azure.ResourceManager.EventHubs.Models.CaptureIdentityType? IdentityType { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.CaptureIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.CaptureIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.CaptureIdentity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum CaptureIdentityType
    {
        SystemAssigned = 0,
        UserAssigned = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CleanupPolicyRetentionDescription : System.IEquatable<Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CleanupPolicyRetentionDescription(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription Compact { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription Delete { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription left, Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription left, Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ClusterQuotaConfigurationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>
    {
        public ClusterQuotaConfigurationProperties() { }
        public System.Collections.Generic.IDictionary<string, string> Settings { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterQuotaConfigurationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClusterSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>
    {
        public ClusterSku(Azure.ResourceManager.EventHubs.Models.ClusterSkuName name) { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.ClusterSkuName Name { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.ClusterSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.ClusterSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ClusterSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClusterSkuName : System.IEquatable<Azure.ResourceManager.EventHubs.Models.ClusterSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClusterSkuName(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.ClusterSkuName Dedicated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.ClusterSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.ClusterSkuName left, Azure.ResourceManager.EventHubs.Models.ClusterSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.ClusterSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.ClusterSkuName left, Azure.ResourceManager.EventHubs.Models.ClusterSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConnectionState : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>
    {
        public ConnectionState() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.ConnectionState System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.ConnectionState System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.ConnectionState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DefaultAction : System.IEquatable<Azure.ResourceManager.EventHubs.Models.DefaultAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DefaultAction(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.DefaultAction Allow { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.DefaultAction Deny { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.DefaultAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.DefaultAction left, Azure.ResourceManager.EventHubs.Models.DefaultAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.DefaultAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.DefaultAction left, Azure.ResourceManager.EventHubs.Models.DefaultAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum EncodingCaptureDescription
    {
        Avro = 0,
        AvroDeflate = 1,
    }
    public partial class Encryption : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.Encryption>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.Encryption>
    {
        public Encryption() { }
        public Azure.ResourceManager.EventHubs.Models.EventHubsKeySource? KeySource { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties> KeyVaultProperties { get { throw null; } }
        public bool? RequireInfrastructureEncryption { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.Encryption System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.Encryption>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.Encryption>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.Encryption System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.Encryption>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.Encryption>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.Encryption>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EndPointProvisioningState : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EndPointProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState left, Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState left, Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubDestination : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>
    {
        public EventHubDestination() { }
        public string ArchiveNameFormat { get { throw null; } set { } }
        public string BlobContainer { get { throw null; } set { } }
        public string DataLakeAccountName { get { throw null; } set { } }
        public string DataLakeFolderPath { get { throw null; } set { } }
        public System.Guid? DataLakeSubscriptionId { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.CaptureIdentity Identity { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier StorageAccountResourceId { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.EventHubDestination System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubDestination System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubDestination>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum EventHubEntityStatus
    {
        Unknown = 0,
        Active = 1,
        Disabled = 2,
        Restoring = 3,
        SendDisabled = 4,
        ReceiveDisabled = 5,
        Creating = 6,
        Deleting = 7,
        Renaming = 8,
    }
    public partial class EventHubsAccessKeys : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>
    {
        internal EventHubsAccessKeys() { }
        public string AliasPrimaryConnectionString { get { throw null; } }
        public string AliasSecondaryConnectionString { get { throw null; } }
        public string KeyName { get { throw null; } }
        public string PrimaryConnectionString { get { throw null; } }
        public string PrimaryKey { get { throw null; } }
        public string SecondaryConnectionString { get { throw null; } }
        public string SecondaryKey { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeys>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsAccessKeyType : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsAccessKeyType(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType PrimaryKey { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType SecondaryKey { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType left, Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType left, Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsAccessRight : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsAccessRight(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight Listen { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight Manage { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight Send { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight left, Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight left, Azure.ResourceManager.EventHubs.Models.EventHubsAccessRight right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class EventHubsApplicationGroupPolicy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>
    {
        protected EventHubsApplicationGroupPolicy(string name) { }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum EventHubsDisasterRecoveryProvisioningState
    {
        Accepted = 0,
        Succeeded = 1,
        Failed = 2,
    }
    public enum EventHubsDisasterRecoveryRole
    {
        Primary = 0,
        PrimaryNotReplicating = 1,
        Secondary = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsKeySource : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsKeySource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsKeySource(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsKeySource MicrosoftKeyVault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsKeySource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsKeySource left, Azure.ResourceManager.EventHubs.Models.EventHubsKeySource right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsKeySource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsKeySource left, Azure.ResourceManager.EventHubs.Models.EventHubsKeySource right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsMetricId : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsMetricId>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsMetricId(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsMetricId IncomingBytes { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsMetricId IncomingMessages { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsMetricId OutgoingBytes { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsMetricId OutgoingMessages { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsMetricId other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsMetricId left, Azure.ResourceManager.EventHubs.Models.EventHubsMetricId right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsMetricId (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsMetricId left, Azure.ResourceManager.EventHubs.Models.EventHubsMetricId right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubsNameAvailabilityContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>
    {
        public EventHubsNameAvailabilityContent(string name) { }
        public string Name { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsNameAvailabilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>
    {
        internal EventHubsNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNameUnavailableReason? Reason { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNameAvailabilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum EventHubsNameUnavailableReason
    {
        None = 0,
        InvalidName = 1,
        SubscriptionIsDisabled = 2,
        NameInUse = 3,
        NameInLockdown = 4,
        TooManyNamespaceInCurrentSubscription = 5,
    }
    public partial class EventHubsNetworkSecurityPerimeter : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>
    {
        internal EventHubsNetworkSecurityPerimeter() { }
        public string Id { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public string PerimeterGuid { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsNetworkSecurityPerimeterConfiguration : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>
    {
        public EventHubsNetworkSecurityPerimeterConfiguration() { }
        public System.Collections.Generic.IReadOnlyList<string> ApplicableFeatures { get { throw null; } }
        public bool? IsBackingResource { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter NetworkSecurityPerimeter { get { throw null; } }
        public string ParentAssociationName { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile Profile { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue> ProvisioningIssues { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState? ProvisioningState { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation ResourceAssociation { get { throw null; } }
        public string SourceResourceId { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>
    {
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule> AccessRules { get { throw null; } }
        public string AccessRulesVersion { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>
    {
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation() { }
        public Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode? AccessMode { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsNetworkSecurityPerimeterConfigurationProvisioningState : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsNetworkSecurityPerimeterConfigurationProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Deleted { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState InvalidResponse { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState SucceededWithIssues { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Unknown { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState left, Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState left, Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeterConfigurationProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubsNspAccessRule : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>
    {
        internal EventHubsNspAccessRule() { }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties Properties { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRule>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsNspAccessRuleDirection : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsNspAccessRuleDirection(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection Inbound { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection Outbound { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection left, Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection left, Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubsNspAccessRuleProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>
    {
        internal EventHubsNspAccessRuleProperties() { }
        public System.Collections.Generic.IReadOnlyList<string> AddressPrefixes { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleDirection? Direction { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> FullyQualifiedDomainNames { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.EventHubsNetworkSecurityPerimeter> NetworkSecurityPerimeters { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> Subscriptions { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsNspAccessRuleProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsPrivateLinkResource : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>
    {
        internal EventHubsPrivateLinkResource() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsPrivateLinkResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsProvisioningIssue : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>
    {
        public EventHubsProvisioningIssue() { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties Properties { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssue>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EventHubsProvisioningIssueProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>
    {
        internal EventHubsProvisioningIssueProperties() { }
        public string Description { get { throw null; } }
        public string IssueType { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsProvisioningIssueProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsPublicNetworkAccess : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsPublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess Enabled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess SecuredByPerimeter { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess left, Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess left, Azure.ResourceManager.EventHubs.Models.EventHubsPublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubsRegenerateAccessKeyContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>
    {
        public EventHubsRegenerateAccessKeyContent(Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType keyType) { }
        public string Key { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsAccessKeyType KeyType { get { throw null; } }
        Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsRegenerateAccessKeyContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsResourceAssociationAccessMode : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsResourceAssociationAccessMode(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode AuditMode { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode EnforcedMode { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode LearningMode { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode NoAssociationMode { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode UnspecifiedMode { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode left, Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode left, Azure.ResourceManager.EventHubs.Models.EventHubsResourceAssociationAccessMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsSchemaCompatibility : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsSchemaCompatibility(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility Backward { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility Forward { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility left, Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility left, Azure.ResourceManager.EventHubs.Models.EventHubsSchemaCompatibility right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsSchemaType : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsSchemaType(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType Avro { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType left, Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType left, Azure.ResourceManager.EventHubs.Models.EventHubsSchemaType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubsSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>
    {
        public EventHubsSku(Azure.ResourceManager.EventHubs.Models.EventHubsSkuName name) { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsSkuName Name { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier? Tier { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.EventHubsSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsSkuName : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsSkuName(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSkuName Basic { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSkuName Premium { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSkuName Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsSkuName left, Azure.ResourceManager.EventHubs.Models.EventHubsSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsSkuName left, Azure.ResourceManager.EventHubs.Models.EventHubsSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsSkuTier : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsSkuTier(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier Basic { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier Premium { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier left, Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier left, Azure.ResourceManager.EventHubs.Models.EventHubsSkuTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventHubsThrottlingPolicy : Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>
    {
        public EventHubsThrottlingPolicy(string name, long rateLimitThreshold, Azure.ResourceManager.EventHubs.Models.EventHubsMetricId metricId) : base (default(string)) { }
        public Azure.ResourceManager.EventHubs.Models.EventHubsMetricId MetricId { get { throw null; } set { } }
        public long RateLimitThreshold { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventHubsTlsVersion : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventHubsTlsVersion(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion Tls1_0 { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion Tls1_1 { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion Tls1_2 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion left, Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion left, Azure.ResourceManager.EventHubs.Models.EventHubsTlsVersion right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KeyVaultProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>
    {
        public KeyVaultProperties() { }
        public string KeyName { get { throw null; } set { } }
        public System.Uri KeyVaultUri { get { throw null; } set { } }
        public string KeyVersion { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.KeyVaultProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.KeyVaultProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkRuleIPAction : System.IEquatable<Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkRuleIPAction(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction Allow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction left, Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction left, Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NWRuleSetIPRules : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>
    {
        public NWRuleSetIPRules() { }
        public Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction? Action { get { throw null; } set { } }
        public string IPMask { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetIPRules>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NWRuleSetVirtualNetworkRules : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>
    {
        public NWRuleSetVirtualNetworkRules() { }
        public bool? IgnoreMissingVnetServiceEndpoint { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrivateLinkConnectionStatus : System.IEquatable<Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrivateLinkConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus left, Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus left, Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.EventHubs.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Active { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Scaling { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.ProvisioningState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.ProvisioningState left, Azure.ResourceManager.EventHubs.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.ProvisioningState left, Azure.ResourceManager.EventHubs.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccessFlag : System.IEquatable<Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccessFlag(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag Disabled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag Enabled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag SecuredByPerimeter { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag left, Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag left, Azure.ResourceManager.EventHubs.Models.PublicNetworkAccessFlag right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RetentionDescription : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>
    {
        public RetentionDescription() { }
        public Azure.ResourceManager.EventHubs.Models.CleanupPolicyRetentionDescription? CleanupPolicy { get { throw null; } set { } }
        public long? RetentionTimeInHours { get { throw null; } set { } }
        public int? TombstoneRetentionTimeInHours { get { throw null; } set { } }
        Azure.ResourceManager.EventHubs.Models.RetentionDescription System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.EventHubs.Models.RetentionDescription System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.EventHubs.Models.RetentionDescription>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
