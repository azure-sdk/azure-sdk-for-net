namespace Azure.ResourceManager.SqlVirtualMachine
{
    public partial class AvailabilityGroupListenerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>, System.Collections.IEnumerable
    {
        protected AvailabilityGroupListenerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string availabilityGroupListenerName, Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string availabilityGroupListenerName, Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> Get(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>> GetAsync(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> GetIfExists(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>> GetIfExistsAsync(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AvailabilityGroupListenerData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>
    {
        public AvailabilityGroupListenerData() { }
        public string AvailabilityGroupName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica> AvailabilityGroupReplicas { get { throw null; } }
        public bool? CreateDefaultAvailabilityGroupIfNotExist { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration> LoadBalancerConfigurations { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration> MultiSubnetIPConfigurations { get { throw null; } }
        public int? Port { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AvailabilityGroupListenerResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AvailabilityGroupListenerResource() { }
        public virtual Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AzureResourceManagerSqlVirtualMachineContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerSqlVirtualMachineContext() { }
        public static Azure.ResourceManager.SqlVirtualMachine.AzureResourceManagerSqlVirtualMachineContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class SqlVirtualMachineCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>, System.Collections.IEnumerable
    {
        protected SqlVirtualMachineCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string sqlVirtualMachineName, Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string sqlVirtualMachineName, Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> Get(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> GetAsync(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetIfExists(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> GetIfExistsAsync(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SqlVirtualMachineData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>
    {
        public SqlVirtualMachineData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch? AdditionalVmPatch { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings AssessmentSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings AutoBackupSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings AutoPatchingSettings { get { throw null; } set { } }
        public bool? EnableAutomaticUpgrade { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings KeyVaultCredentialSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode? LeastPrivilegeMode { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.OSType? OSType { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings ServerConfigurationsManagementSettings { get { throw null; } set { } }
        public string SqlImageOffer { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku? SqlImageSku { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode? SqlManagement { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType? SqlServerLicenseType { get { throw null; } set { } }
        public string SqlVirtualMachineGroupResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings StorageConfigurationSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus TroubleshootingStatus { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity VirtualMachineIdentitySettings { get { throw null; } set { } }
        public string VirtualMachineResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials WsfcDomainCredentials { get { throw null; } set { } }
        public string WsfcStaticIP { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class SqlVirtualMachineExtensions
    {
        public static Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource GetAvailabilityGroupListenerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.Models.Info> GetOperations(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.Models.Info> GetOperationsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetSqlVirtualMachine(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> GetSqlVirtualMachineAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroup(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> GetSqlVirtualMachineGroupAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource GetSqlVirtualMachineGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupCollection GetSqlVirtualMachineGroups(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroups(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroupsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource GetSqlVirtualMachineResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineCollection GetSqlVirtualMachines(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetSqlVirtualMachines(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetSqlVirtualMachinesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SqlVirtualMachineGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>, System.Collections.IEnumerable
    {
        protected SqlVirtualMachineGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string sqlVirtualMachineGroupName, Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string sqlVirtualMachineGroupName, Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> Get(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> GetAsync(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetIfExists(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> GetIfExistsAsync(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SqlVirtualMachineGroupData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>
    {
        public SqlVirtualMachineGroupData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration? ClusterConfiguration { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType? ClusterManagerType { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType? ScaleType { get { throw null; } }
        public string SqlImageOffer { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku? SqlImageSku { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile WsfcDomainProfile { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SqlVirtualMachineGroupResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SqlVirtualMachineGroupResource() { }
        public virtual Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sqlVirtualMachineGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource> GetAvailabilityGroupListener(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource>> GetAvailabilityGroupListenerAsync(string availabilityGroupListenerName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerCollection GetAvailabilityGroupListeners() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetBySqlVmGroup(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetBySqlVmGroupAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SqlVirtualMachineResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SqlVirtualMachineResource() { }
        public virtual Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string sqlVirtualMachineName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation FetchDCAssessment(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> FetchDCAssessmentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Redeploy(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RedeployAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation StartAssessment(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> StartAssessmentAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting> Troubleshoot(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting sqlVmTroubleshooting, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>> TroubleshootAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting sqlVmTroubleshooting, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SqlVirtualMachine.Mocking
{
    public partial class MockableSqlVirtualMachineArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableSqlVirtualMachineArmClient() { }
        public virtual Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerResource GetAvailabilityGroupListenerResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource GetSqlVirtualMachineGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource GetSqlVirtualMachineResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableSqlVirtualMachineResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSqlVirtualMachineResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetSqlVirtualMachine(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource>> GetSqlVirtualMachineAsync(string sqlVirtualMachineName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroup(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource>> GetSqlVirtualMachineGroupAsync(string sqlVirtualMachineGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupCollection GetSqlVirtualMachineGroups() { throw null; }
        public virtual Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineCollection GetSqlVirtualMachines() { throw null; }
    }
    public partial class MockableSqlVirtualMachineSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSqlVirtualMachineSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroups(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroupsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetSqlVirtualMachines(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineResource> GetSqlVirtualMachinesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MockableSqlVirtualMachineTenantResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSqlVirtualMachineTenantResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.SqlVirtualMachine.Models.Info> GetOperations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SqlVirtualMachine.Models.Info> GetOperationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AdditionalOSPatch : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AdditionalOSPatch(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch WSUS { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch WU { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch WUMU { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch left, Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch left, Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AdditionalVmPatch : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AdditionalVmPatch(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch MicrosoftUpdate { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch NotSet { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch left, Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch left, Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AgReplica : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>
    {
        public AgReplica() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.Commit? Commit { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.Failover? Failover { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary? ReadableSecondary { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.Role? Role { get { throw null; } set { } }
        public string SqlVirtualMachineInstanceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmSqlVirtualMachineModelFactory
    {
        public static Azure.ResourceManager.SqlVirtualMachine.AvailabilityGroupListenerData AvailabilityGroupListenerData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string provisioningState = null, string availabilityGroupName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration> loadBalancerConfigurations = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration> multiSubnetIPConfigurations = null, bool? createDefaultAvailabilityGroupIfNotExist = default(bool?), int? port = default(int?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.SqlVirtualMachine.Models.AgReplica> availabilityGroupReplicas = null) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Info Info(string name = null, Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay display = null, Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin? origin = default(Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin?), System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty> properties = null) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay OperationDisplay(string provider = null, string resource = null, string operation = null, string description = null) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineData SqlVirtualMachineData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, string virtualMachineResourceId = null, string provisioningState = null, string sqlImageOffer = null, Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType? sqlServerLicenseType = default(Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType?), Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode? sqlManagement = default(Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode?), Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode? leastPrivilegeMode = default(Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode?), Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku? sqlImageSku = default(Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku?), string sqlVirtualMachineGroupResourceId = null, Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials wsfcDomainCredentials = null, string wsfcStaticIP = null, Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings autoPatchingSettings = null, Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings autoBackupSettings = null, Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings keyVaultCredentialSettings = null, Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings serverConfigurationsManagementSettings = null, Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings storageConfigurationSettings = null, Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus troubleshootingStatus = null, Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings assessmentSettings = null, bool? enableAutomaticUpgrade = default(bool?), Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch? additionalVmPatch = default(Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalOSPatch?), Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity virtualMachineIdentitySettings = null, Azure.ResourceManager.SqlVirtualMachine.Models.OSType? osType = default(Azure.ResourceManager.SqlVirtualMachine.Models.OSType?)) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.SqlVirtualMachineGroupData SqlVirtualMachineGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), string provisioningState = null, string sqlImageOffer = null, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku? sqlImageSku = default(Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku?), Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType? scaleType = default(Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType?), Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType? clusterManagerType = default(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType?), Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration? clusterConfiguration = default(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration?), Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile wsfcDomainProfile = null) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting SqlVmTroubleshooting(System.DateTimeOffset? startTimeUtc = default(System.DateTimeOffset?), System.DateTimeOffset? endTimeUtc = default(System.DateTimeOffset?), Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario? troubleshootingScenario = default(Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario?), string unhealthyReplicaInfoAvailabilityGroupName = null, string virtualMachineResourceId = null) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus TroubleshootingStatus(string rootCause = null, System.DateTimeOffset? lastTriggerTimeUtc = default(System.DateTimeOffset?), System.DateTimeOffset? startTimeUtc = default(System.DateTimeOffset?), System.DateTimeOffset? endTimeUtc = default(System.DateTimeOffset?), Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario? troubleshootingScenario = default(Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario?), string unhealthyReplicaInfoAvailabilityGroupName = null) { throw null; }
    }
    public enum AssessmentDayOfWeek
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
    }
    public partial class AssessmentSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>
    {
        public AssessmentSettings() { }
        public bool? Enable { get { throw null; } set { } }
        public bool? RunImmediately { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.Schedule Schedule { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoBackupDaysOfWeek : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoBackupDaysOfWeek(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Friday { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Monday { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Saturday { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Sunday { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Thursday { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Tuesday { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek Wednesday { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek left, Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek left, Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AutoBackupSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>
    {
        public AutoBackupSettings() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType? BackupScheduleType { get { throw null; } set { } }
        public bool? BackupSystemDbs { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupDaysOfWeek> DaysOfWeek { get { throw null; } }
        public bool? Enable { get { throw null; } set { } }
        public bool? EnableEncryption { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType? FullBackupFrequency { get { throw null; } set { } }
        public int? FullBackupStartTime { get { throw null; } set { } }
        public int? FullBackupWindowHours { get { throw null; } set { } }
        public int? LogBackupFrequency { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public int? RetentionPeriod { get { throw null; } set { } }
        public string StorageAccessKey { get { throw null; } set { } }
        public string StorageAccountUri { get { throw null; } set { } }
        public string StorageContainerName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoBackupSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoPatchingSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>
    {
        public AutoPatchingSettings() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.AdditionalVmPatch? AdditionalVmPatch { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.DayOfWeek? DayOfWeek { get { throw null; } set { } }
        public bool? Enable { get { throw null; } set { } }
        public int? MaintenanceWindowDuration { get { throw null; } set { } }
        public int? MaintenanceWindowStartingHour { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.AutoPatchingSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BackupScheduleType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BackupScheduleType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType Automated { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType Manual { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType left, Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType left, Azure.ResourceManager.SqlVirtualMachine.Models.BackupScheduleType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClusterConfiguration : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClusterConfiguration(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration Domainful { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration left, Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration left, Azure.ResourceManager.SqlVirtualMachine.Models.ClusterConfiguration right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClusterManagerType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClusterManagerType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType WSFC { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType left, Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType left, Azure.ResourceManager.SqlVirtualMachine.Models.ClusterManagerType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClusterSubnetType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClusterSubnetType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType MultiSubnet { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType SingleSubnet { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType left, Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType left, Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Commit : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.Commit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Commit(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Commit AsynchronousCommit { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Commit SynchronousCommit { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.Commit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.Commit left, Azure.ResourceManager.SqlVirtualMachine.Models.Commit right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.Commit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.Commit left, Azure.ResourceManager.SqlVirtualMachine.Models.Commit right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectivityType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectivityType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType LOCAL { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType PRIVATE { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType PUBLIC { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType left, Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType left, Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum DayOfWeek
    {
        Everyday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    public partial class DiskConfigAssessmentContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>
    {
        public DiskConfigAssessmentContent() { }
        public bool? RunDiskConfigRules { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigAssessmentContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskConfigurationType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskConfigurationType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType ADD { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType EXTEND { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType NEW { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType left, Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType left, Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Failover : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.Failover>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Failover(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Failover Automatic { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Failover Manual { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.Failover other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.Failover left, Azure.ResourceManager.SqlVirtualMachine.Models.Failover right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.Failover (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.Failover left, Azure.ResourceManager.SqlVirtualMachine.Models.Failover right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FullBackupFrequencyType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FullBackupFrequencyType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType Daily { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType Weekly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType left, Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType left, Azure.ResourceManager.SqlVirtualMachine.Models.FullBackupFrequencyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Info : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>
    {
        internal Info() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay Display { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin? Origin { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty> Properties { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.Info System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.Info System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Info>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultCredentialSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>
    {
        public KeyVaultCredentialSettings() { }
        public string AzureKeyVaultUri { get { throw null; } set { } }
        public string CredentialName { get { throw null; } set { } }
        public bool? Enable { get { throw null; } set { } }
        public string ServicePrincipalName { get { throw null; } set { } }
        public string ServicePrincipalSecret { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.KeyVaultCredentialSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LeastPrivilegeMode : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LeastPrivilegeMode(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode Enabled { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode NotSet { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode left, Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode left, Azure.ResourceManager.SqlVirtualMachine.Models.LeastPrivilegeMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LoadBalancerConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>
    {
        public LoadBalancerConfiguration() { }
        public string LoadBalancerResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress PrivateIPAddress { get { throw null; } set { } }
        public int? ProbePort { get { throw null; } set { } }
        public string PublicIPAddressResourceId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> SqlVirtualMachineInstances { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.LoadBalancerConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiSubnetIPConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>
    {
        public MultiSubnetIPConfiguration(Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress privateIPAddress, string sqlVirtualMachineInstance) { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress PrivateIPAddress { get { throw null; } set { } }
        public string SqlVirtualMachineInstance { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.MultiSubnetIPConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OperationDisplay : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>
    {
        internal OperationDisplay() { }
        public string Description { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationDisplay>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OperationOrigin : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OperationOrigin(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin System { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin User { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin left, Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin left, Azure.ResourceManager.SqlVirtualMachine.Models.OperationOrigin right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OperationProperty : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>
    {
        internal OperationProperty() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.OperationProperty>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum OSType
    {
        Windows = 0,
        Linux = 1,
    }
    public partial class PrivateIPAddress : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>
    {
        public PrivateIPAddress() { }
        public string IPAddress { get { throw null; } set { } }
        public string SubnetResourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.PrivateIPAddress>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReadableSecondary : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReadableSecondary(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary All { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary No { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary ReadOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary left, Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary left, Azure.ResourceManager.SqlVirtualMachine.Models.ReadableSecondary right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Role : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.Role>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Role(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Role Primary { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.Role Secondary { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.Role other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.Role left, Azure.ResourceManager.SqlVirtualMachine.Models.Role right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.Role (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.Role left, Azure.ResourceManager.SqlVirtualMachine.Models.Role right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScaleType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScaleType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType HA { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType left, Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType left, Azure.ResourceManager.SqlVirtualMachine.Models.ScaleType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Schedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>
    {
        public Schedule() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.AssessmentDayOfWeek? DayOfWeek { get { throw null; } set { } }
        public bool? Enable { get { throw null; } set { } }
        public int? MonthlyOccurrence { get { throw null; } set { } }
        public string StartTime { get { throw null; } set { } }
        public int? WeeklyInterval { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.Schedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.Schedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.Schedule>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ServerConfigurationsManagementSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>
    {
        public ServerConfigurationsManagementSettings() { }
        public string AzureAdAuthenticationClientId { get { throw null; } set { } }
        public bool? IsRServicesEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings SqlConnectivityUpdateSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings SqlInstanceSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings SqlStorageUpdateSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType? SqlWorkloadType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.ServerConfigurationsManagementSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SqlConnectivityUpdateSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>
    {
        public SqlConnectivityUpdateSettings() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ConnectivityType? ConnectivityType { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public string SqlAuthUpdatePassword { get { throw null; } set { } }
        public string SqlAuthUpdateUserName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlConnectivityUpdateSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SqlImageSku : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SqlImageSku(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku Developer { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku Enterprise { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku Express { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku Standard { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku Web { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlImageSku right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SQLInstanceSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>
    {
        public SQLInstanceSettings() { }
        public string Collation { get { throw null; } set { } }
        public bool? IsIfiEnabled { get { throw null; } set { } }
        public bool? IsLpimEnabled { get { throw null; } set { } }
        public bool? IsOptimizeForAdHocWorkloadsEnabled { get { throw null; } set { } }
        public int? MaxDop { get { throw null; } set { } }
        public int? MaxServerMemoryMB { get { throw null; } set { } }
        public int? MinServerMemoryMB { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLInstanceSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SqlManagementMode : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SqlManagementMode(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode Full { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode LightWeight { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode NoAgent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlManagementMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SqlServerLicenseType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SqlServerLicenseType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType AHUB { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType DR { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType PAYG { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlServerLicenseType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SQLStorageSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>
    {
        public SQLStorageSettings() { }
        public string DefaultFilePath { get { throw null; } set { } }
        public System.Collections.Generic.IList<int> Luns { get { throw null; } }
        public bool? UseStoragePool { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SqlStorageUpdateSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>
    {
        public SqlStorageUpdateSettings() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType? DiskConfigurationType { get { throw null; } set { } }
        public int? DiskCount { get { throw null; } set { } }
        public int? StartingDeviceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlStorageUpdateSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SQLTempDbSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>
    {
        public SQLTempDbSettings() { }
        public int? DataFileCount { get { throw null; } set { } }
        public int? DataFileSize { get { throw null; } set { } }
        public int? DataGrowth { get { throw null; } set { } }
        public string DefaultFilePath { get { throw null; } set { } }
        public int? LogFileSize { get { throw null; } set { } }
        public int? LogGrowth { get { throw null; } set { } }
        public System.Collections.Generic.IList<int> Luns { get { throw null; } }
        public bool? PersistFolder { get { throw null; } set { } }
        public string PersistFolderPath { get { throw null; } set { } }
        public bool? UseStoragePool { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SqlVirtualMachineGroupPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>
    {
        public SqlVirtualMachineGroupPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachineGroupPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SqlVirtualMachinePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>
    {
        public SqlVirtualMachinePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVirtualMachinePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SqlVmGroupImageSku : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SqlVmGroupImageSku(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku Developer { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku Enterprise { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmGroupImageSku right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SqlVmTroubleshooting : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>
    {
        public SqlVmTroubleshooting() { }
        public System.DateTimeOffset? EndTimeUtc { get { throw null; } set { } }
        public System.DateTimeOffset? StartTimeUtc { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario? TroubleshootingScenario { get { throw null; } set { } }
        public string UnhealthyReplicaInfoAvailabilityGroupName { get { throw null; } set { } }
        public string VirtualMachineResourceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.SqlVmTroubleshooting>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SqlWorkloadType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SqlWorkloadType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType DW { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType GENERAL { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType OLTP { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType left, Azure.ResourceManager.SqlVirtualMachine.Models.SqlWorkloadType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class StorageConfigurationSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>
    {
        public StorageConfigurationSettings() { }
        public Azure.ResourceManager.SqlVirtualMachine.Models.DiskConfigurationType? DiskConfigurationType { get { throw null; } set { } }
        public bool? EnableStorageConfigBlade { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings SqlDataSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SQLStorageSettings SqlLogSettings { get { throw null; } set { } }
        public bool? SqlSystemDbOnDataDisk { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.SQLTempDbSettings SqlTempDbSettings { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType? StorageWorkloadType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.StorageConfigurationSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StorageWorkloadType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StorageWorkloadType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType DW { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType GENERAL { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType OLTP { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType left, Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType left, Azure.ResourceManager.SqlVirtualMachine.Models.StorageWorkloadType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TroubleshootingScenario : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TroubleshootingScenario(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario UnhealthyReplica { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario left, Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario left, Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TroubleshootingStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>
    {
        internal TroubleshootingStatus() { }
        public System.DateTimeOffset? EndTimeUtc { get { throw null; } }
        public System.DateTimeOffset? LastTriggerTimeUtc { get { throw null; } }
        public string RootCause { get { throw null; } }
        public System.DateTimeOffset? StartTimeUtc { get { throw null; } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingScenario? TroubleshootingScenario { get { throw null; } }
        public string UnhealthyReplicaInfoAvailabilityGroupName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.TroubleshootingStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>
    {
        public VirtualMachineIdentity() { }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType? Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.VirtualMachineIdentity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VmIdentityType : System.IEquatable<Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VmIdentityType(string value) { throw null; }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType None { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType SystemAssigned { get { throw null; } }
        public static Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType UserAssigned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType left, Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType left, Azure.ResourceManager.SqlVirtualMachine.Models.VmIdentityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WsfcDomainCredentials : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>
    {
        public WsfcDomainCredentials() { }
        public string ClusterBootstrapAccountPassword { get { throw null; } set { } }
        public string ClusterOperatorAccountPassword { get { throw null; } set { } }
        public string SqlServiceAccountPassword { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainCredentials>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WsfcDomainProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>
    {
        public WsfcDomainProfile() { }
        public string ClusterBootstrapAccount { get { throw null; } set { } }
        public string ClusterOperatorAccount { get { throw null; } set { } }
        public Azure.ResourceManager.SqlVirtualMachine.Models.ClusterSubnetType? ClusterSubnetType { get { throw null; } set { } }
        public string DomainFqdn { get { throw null; } set { } }
        public string FileShareWitnessPath { get { throw null; } set { } }
        public bool? IsSqlServiceAccountGmsa { get { throw null; } set { } }
        public string OuPath { get { throw null; } set { } }
        public string SqlServiceAccount { get { throw null; } set { } }
        public string StorageAccountPrimaryKey { get { throw null; } set { } }
        public string StorageAccountUri { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SqlVirtualMachine.Models.WsfcDomainProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
