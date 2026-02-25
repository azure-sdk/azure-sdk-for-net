namespace Azure.ResourceManager.ManagedOps
{
    public partial class AzureResourceManagerManagedOpsContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerManagedOpsContext() { }
        public static Azure.ResourceManager.ManagedOps.AzureResourceManagerManagedOpsContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class ManagedOpCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ManagedOps.ManagedOpResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagedOps.ManagedOpResource>, System.Collections.IEnumerable
    {
        protected ManagedOpCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ManagedOps.ManagedOpResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string managedOpsName, Azure.ResourceManager.ManagedOps.ManagedOpData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ManagedOps.ManagedOpResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string managedOpsName, Azure.ResourceManager.ManagedOps.ManagedOpData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource> Get(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ManagedOps.ManagedOpResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ManagedOps.ManagedOpResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource>> GetAsync(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ManagedOps.ManagedOpResource> GetIfExists(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ManagedOps.ManagedOpResource>> GetIfExistsAsync(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ManagedOps.ManagedOpResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ManagedOps.ManagedOpResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ManagedOps.ManagedOpResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagedOps.ManagedOpResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ManagedOpData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.ManagedOpData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>
    {
        public ManagedOpData() { }
        public Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.ManagedOpData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.ManagedOpData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedOpResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.ManagedOpData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagedOpResource() { }
        public virtual Azure.ResourceManager.ManagedOps.ManagedOpData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string managedOpsName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ManagedOps.ManagedOpData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.ManagedOpData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.ManagedOpData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ManagedOps.ManagedOpResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ManagedOps.ManagedOpResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ManagedOpsExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource> GetManagedOp(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource>> GetManagedOpAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ManagedOps.ManagedOpResource GetManagedOpResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ManagedOps.ManagedOpCollection GetManagedOps(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
    }
}
namespace Azure.ResourceManager.ManagedOps.Mocking
{
    public partial class MockableManagedOpsArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableManagedOpsArmClient() { }
        public virtual Azure.ResourceManager.ManagedOps.ManagedOpResource GetManagedOpResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableManagedOpsSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableManagedOpsSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource> GetManagedOp(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagedOps.ManagedOpResource>> GetManagedOpAsync(string managedOpsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ManagedOps.ManagedOpCollection GetManagedOps() { throw null; }
    }
}
namespace Azure.ResourceManager.ManagedOps.Models
{
    public static partial class ArmManagedOpsModelFactory
    {
        public static Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation AzureMonitorInformation(Azure.Core.ResourceIdentifier dcrId = null, Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus enablementStatus = default(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus)) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation ChangeTrackingInformation(Azure.Core.ResourceIdentifier dcrId = null, Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus enablementStatus = default(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus)) { throw null; }
        public static Azure.ResourceManager.ManagedOps.ManagedOpData ManagedOpData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties properties = null) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties ManagedOpsProperties(Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku sku = null, Azure.ResourceManager.ManagedOps.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ManagedOps.Models.ProvisioningState?), Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration desiredConfiguration = null, Azure.ResourceManager.ManagedOps.Models.ServiceInformation services = null, Azure.Core.ResourceIdentifier policyInitiativeAssignmentId = null) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku ManagedOpsSku(string name = null, string tier = null) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.ServiceInformation ServiceInformation(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation changeTrackingAndInventory = null, Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation azureMonitorInsights = null, Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? azureUpdateManagerEnablementStatus = default(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus?), Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? azurePolicyAndMachineEnablementStatus = default(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus?), Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? defenderForServersEnablementStatus = default(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus?), Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? defenderCspmEnablementStatus = default(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus?)) { throw null; }
    }
    public partial class AzureMonitorInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>
    {
        internal AzureMonitorInformation() { }
        public Azure.Core.ResourceIdentifier DcrId { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus EnablementStatus { get { throw null; } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ChangeTrackingInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>
    {
        internal ChangeTrackingInformation() { }
        public Azure.Core.ResourceIdentifier DcrId { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus EnablementStatus { get { throw null; } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ChangeTrackingInformationEnablementStatus : System.IEquatable<Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ChangeTrackingInformationEnablementStatus(string value) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus Enabled { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus InProgress { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus left, Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus left, Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DesiredConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>
    {
        public DesiredConfiguration(Azure.Core.ResourceIdentifier changeTrackingAndInventoryLogAnalyticsWorkspaceId, Azure.Core.ResourceIdentifier azureMonitorWorkspaceId, Azure.Core.ResourceIdentifier userAssignedManagedIdentityId) { }
        public Azure.Core.ResourceIdentifier AzureMonitorWorkspaceId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ChangeTrackingAndInventoryLogAnalyticsWorkspaceId { get { throw null; } set { } }
        public Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers? DefenderCspm { get { throw null; } set { } }
        public Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers? DefenderForServers { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier UserAssignedManagedIdentityId { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DesiredConfigurationDefenderForServers : System.IEquatable<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DesiredConfigurationDefenderForServers(string value) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers Disable { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers Enable { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers left, Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers right) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers left, Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DesiredConfigurationUpdate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>
    {
        public DesiredConfigurationUpdate() { }
        public Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers? DefenderCspm { get { throw null; } set { } }
        public Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationDefenderForServers? DefenderForServers { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedOpPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>
    {
        public ManagedOpPatch() { }
        public Azure.ResourceManager.ManagedOps.Models.DesiredConfigurationUpdate ManagedOpUpdateDesiredConfiguration { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedOpsProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>
    {
        public ManagedOpsProperties(Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration desiredConfiguration) { }
        public Azure.ResourceManager.ManagedOps.Models.DesiredConfiguration DesiredConfiguration { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PolicyInitiativeAssignmentId { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ServiceInformation Services { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku Sku { get { throw null; } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedOpsSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>
    {
        internal ManagedOpsSku() { }
        public string Name { get { throw null; } }
        public string Tier { get { throw null; } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ManagedOpsSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.ManagedOps.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ManagedOps.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.ManagedOps.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ManagedOps.Models.ProvisioningState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ManagedOps.Models.ProvisioningState left, Azure.ResourceManager.ManagedOps.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagedOps.Models.ProvisioningState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagedOps.Models.ProvisioningState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ManagedOps.Models.ProvisioningState left, Azure.ResourceManager.ManagedOps.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>
    {
        internal ServiceInformation() { }
        public Azure.ResourceManager.ManagedOps.Models.AzureMonitorInformation AzureMonitorInsights { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? AzurePolicyAndMachineEnablementStatus { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? AzureUpdateManagerEnablementStatus { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformation ChangeTrackingAndInventory { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? DefenderCspmEnablementStatus { get { throw null; } }
        public Azure.ResourceManager.ManagedOps.Models.ChangeTrackingInformationEnablementStatus? DefenderForServersEnablementStatus { get { throw null; } }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ServiceInformation JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ManagedOps.Models.ServiceInformation PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagedOps.Models.ServiceInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ManagedOps.Models.ServiceInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ManagedOps.Models.ServiceInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
