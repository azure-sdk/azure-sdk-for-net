namespace Azure.ResourceManager.ContainerServiceFleet
{
    public partial class AutoUpgradeProfileCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>, System.Collections.IEnumerable
    {
        protected AutoUpgradeProfileCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string autoUpgradeProfileName, Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string autoUpgradeProfileName, Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> Get(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>> GetAsync(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> GetIfExists(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>> GetIfExistsAsync(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AutoUpgradeProfileData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>
    {
        public AutoUpgradeProfileData() { }
        public Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus AutoUpgradeProfileStatus { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel? Channel { get { throw null; } set { } }
        public bool? Disabled { get { throw null; } set { } }
        public string ETag { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType? NodeImageSelectionType { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier UpdateStrategyId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoUpgradeProfileResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AutoUpgradeProfileResource() { }
        public virtual Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string autoUpgradeProfileName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation GenerateUpdateRunAutoUpgradeProfileOperation(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> GenerateUpdateRunAutoUpgradeProfileOperationAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ContainerServiceFleetExtensions
    {
        public static Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource GetAutoUpgradeProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetFleet(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> GetFleetAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource GetFleetMemberResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetResource GetFleetResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetCollection GetFleets(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetFleets(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetFleetsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource GetFleetUpdateStrategyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource GetUpdateRunResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class FleetCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetResource>, System.Collections.IEnumerable
    {
        protected FleetCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fleetName, Azure.ResourceManager.ContainerServiceFleet.FleetData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fleetName, Azure.ResourceManager.ContainerServiceFleet.FleetData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> Get(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> GetAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetIfExists(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> GetIfExistsAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerServiceFleet.FleetResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerServiceFleet.FleetResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FleetData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>
    {
        public FleetData(Azure.Core.AzureLocation location) { }
        public string ETag { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile HubProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus Status { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetMemberCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>, System.Collections.IEnumerable
    {
        protected FleetMemberCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fleetMemberName, Azure.ResourceManager.ContainerServiceFleet.FleetMemberData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fleetMemberName, Azure.ResourceManager.ContainerServiceFleet.FleetMemberData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> Get(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>> GetAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> GetIfExists(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>> GetIfExistsAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FleetMemberData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>
    {
        public FleetMemberData() { }
        public Azure.Core.ResourceIdentifier ClusterResourceId { get { throw null; } set { } }
        public string ETag { get { throw null; } }
        public string Group { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus Status { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetMemberData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetMemberData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetMemberResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FleetMemberResource() { }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetMemberData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string fleetMemberName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ContainerServiceFleet.FleetMemberData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetMemberData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetMemberData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch patch, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch patch, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FleetResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FleetResource() { }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource> GetAutoUpgradeProfile(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource>> GetAutoUpgradeProfileAsync(string autoUpgradeProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileCollection GetAutoUpgradeProfiles() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults> GetCredentials(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>> GetCredentialsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource> GetFleetMember(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource>> GetFleetMemberAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetMemberCollection GetFleetMembers() { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyCollection GetFleetUpdateStrategies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> GetFleetUpdateStrategy(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>> GetFleetUpdateStrategyAsync(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> GetUpdateRun(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> GetUpdateRunAsync(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.UpdateRunCollection GetUpdateRuns() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ContainerServiceFleet.FleetData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch patch, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch patch, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FleetUpdateStrategyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>, System.Collections.IEnumerable
    {
        protected FleetUpdateStrategyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string updateStrategyName, Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string updateStrategyName, Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> Get(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>> GetAsync(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> GetIfExists(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>> GetIfExistsAsync(string updateStrategyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FleetUpdateStrategyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>
    {
        public FleetUpdateStrategyData() { }
        public string ETag { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage> StrategyStages { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetUpdateStrategyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FleetUpdateStrategyResource() { }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string updateStrategyName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class UpdateRunCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>, System.Collections.IEnumerable
    {
        protected UpdateRunCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string updateRunName, Azure.ResourceManager.ContainerServiceFleet.UpdateRunData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string updateRunName, Azure.ResourceManager.ContainerServiceFleet.UpdateRunData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> Get(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> GetAsync(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> GetIfExists(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> GetIfExistsAsync(string updateRunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class UpdateRunData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>
    {
        public UpdateRunData() { }
        public Azure.Core.ResourceIdentifier AutoUpgradeProfileId { get { throw null; } }
        public string ETag { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate ManagedClusterUpdate { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus Status { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage> StrategyStages { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier UpdateStrategyId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.UpdateRunData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.UpdateRunData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UpdateRunResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected UpdateRunResource() { }
        public virtual Azure.ResourceManager.ContainerServiceFleet.UpdateRunData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string updateRunName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> Skip(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties body, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> SkipAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties body, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> Start(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> StartAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> Stop(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> StopAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ContainerServiceFleet.UpdateRunData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.UpdateRunData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.UpdateRunData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.UpdateRunData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerServiceFleet.UpdateRunData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ContainerServiceFleet.Mocking
{
    public partial class MockableContainerServiceFleetArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableContainerServiceFleetArmClient() { }
        public virtual Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileResource GetAutoUpgradeProfileResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetMemberResource GetFleetMemberResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetResource GetFleetResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyResource GetFleetUpdateStrategyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.UpdateRunResource GetUpdateRunResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableContainerServiceFleetResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableContainerServiceFleetResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetFleet(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerServiceFleet.FleetResource>> GetFleetAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerServiceFleet.FleetCollection GetFleets() { throw null; }
    }
    public partial class MockableContainerServiceFleetSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableContainerServiceFleetSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetFleets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerServiceFleet.FleetResource> GetFleetsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    public partial class AgentProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>
    {
        public AgentProfile() { }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } set { } }
        public string VmSize { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class APIServerAccessProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>
    {
        public APIServerAccessProfile() { }
        public bool? EnablePrivateCluster { get { throw null; } set { } }
        public bool? EnableVnetIntegration { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmContainerServiceFleetModelFactory
    {
        public static Azure.ResourceManager.ContainerServiceFleet.AutoUpgradeProfileData AutoUpgradeProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState?), Azure.Core.ResourceIdentifier updateStrategyId = null, Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel? channel = default(Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel?), Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType? nodeImageSelectionType = default(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType?), bool? disabled = default(bool?), Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus autoUpgradeProfileStatus = null, string etag = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus AutoUpgradeProfileStatus(System.DateTimeOffset? lastTriggeredOn = default(System.DateTimeOffset?), Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus? lastTriggerStatus = default(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus?), Azure.ResponseError lastTriggerError = null, System.Collections.Generic.IEnumerable<string> lastTriggerUpgradeVersions = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult FleetCredentialResult(string name = null, byte[] value = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults FleetCredentialResults(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult> kubeconfigs = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetData FleetData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState?), Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile hubProfile = null, Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus status = null, string etag = null, Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity identity = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile FleetHubProfile(string dnsPrefix = null, Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile apiServerAccessProfile = null, Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile agentProfile = null, string fqdn = null, string kubernetesVersion = null, string portalFqdn = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetMemberData FleetMemberData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.ResourceIdentifier clusterResourceId = null, string group = null, Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState?), Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus status = null, string etag = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus FleetMemberStatus(string lastOperationId = null, Azure.ResponseError lastOperationError = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus FleetStatus(string lastOperationId = null, Azure.ResponseError lastOperationError = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.FleetUpdateStrategyData FleetUpdateStrategyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage> strategyStages = null, string etag = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity ManagedServiceIdentity(System.Guid? principalId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?), Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType type = default(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType), System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Models.UserAssignedIdentity> userAssignedIdentities = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus MemberUpdateStatus(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus status = null, string name = null, string clusterResourceId = null, string operationId = null, string message = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion NodeImageVersion(string version = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus UpdateGroupStatus(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus status = null, string name = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus> members = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.UpdateRunData UpdateRunData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState?), Azure.Core.ResourceIdentifier updateStrategyId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage> strategyStages = null, Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate managedClusterUpdate = null, Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus status = null, Azure.Core.ResourceIdentifier autoUpgradeProfileId = null, string etag = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus UpdateRunStatus(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus status = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus> stages = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion> selectedNodeImageVersions = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus UpdateStageStatus(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus status = null, string name = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus> groups = null, Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus afterStageWaitStatus = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus UpdateStatus(System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? completedOn = default(System.DateTimeOffset?), Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState? state = default(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState?), Azure.ResponseError error = null) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus WaitStatus(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus status = null, int? waitDurationInSeconds = default(int?)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoUpgradeLastTriggerStatus : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoUpgradeLastTriggerStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus left, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus left, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoUpgradeNodeImageSelectionType : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoUpgradeNodeImageSelectionType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType Consistent { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType Latest { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType left, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType left, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoUpgradeProfileProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoUpgradeProfileProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AutoUpgradeProfileStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>
    {
        public AutoUpgradeProfileStatus() { }
        public System.DateTimeOffset? LastTriggeredOn { get { throw null; } }
        public Azure.ResponseError LastTriggerError { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeLastTriggerStatus? LastTriggerStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> LastTriggerUpgradeVersions { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.AutoUpgradeProfileStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetCredentialResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>
    {
        internal FleetCredentialResult() { }
        public string Name { get { throw null; } }
        public byte[] Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetCredentialResults : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>
    {
        internal FleetCredentialResults() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResult> Kubeconfigs { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetCredentialResults>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetHubProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>
    {
        public FleetHubProfile() { }
        public Azure.ResourceManager.ContainerServiceFleet.Models.AgentProfile AgentProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.APIServerAccessProfile ApiServerAccessProfile { get { throw null; } set { } }
        public string DnsPrefix { get { throw null; } set { } }
        public string Fqdn { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        public string PortalFqdn { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetHubProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetMemberPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>
    {
        public FleetMemberPatch() { }
        public string Group { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FleetMemberProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FleetMemberProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState Joining { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState Leaving { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FleetMemberStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>
    {
        internal FleetMemberStatus() { }
        public Azure.ResponseError LastOperationError { get { throw null; } }
        public string LastOperationId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetMemberStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FleetPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>
    {
        public FleetPatch() { }
        public Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FleetProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FleetProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.FleetProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FleetStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>
    {
        internal FleetStatus() { }
        public Azure.ResponseError LastOperationError { get { throw null; } }
        public string LastOperationId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.FleetStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FleetUpdateStrategyProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FleetUpdateStrategyProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.FleetUpdateStrategyProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterUpdate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>
    {
        public ManagedClusterUpdate(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec upgrade) { }
        public Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection NodeImageSelection { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec Upgrade { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterUpgradeSpec : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>
    {
        public ManagedClusterUpgradeSpec(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType type) { }
        public string KubernetesVersion { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterUpgradeType : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterUpgradeType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType ControlPlaneOnly { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType Full { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType NodeImageOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType left, Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType left, Azure.ResourceManager.ContainerServiceFleet.Models.ManagedClusterUpgradeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedServiceIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>
    {
        public ManagedServiceIdentity(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType type) { }
        public System.Guid? PrincipalId { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType Type { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Models.UserAssignedIdentity> UserAssignedIdentities { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedServiceIdentityType : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedServiceIdentityType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType None { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType SystemAndUserAssigned { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType SystemAssigned { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType UserAssigned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType left, Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType left, Azure.ResourceManager.ContainerServiceFleet.Models.ManagedServiceIdentityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MemberUpdateStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>
    {
        internal MemberUpdateStatus() { }
        public string ClusterResourceId { get { throw null; } }
        public string Message { get { throw null; } }
        public string Name { get { throw null; } }
        public string OperationId { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NodeImageSelection : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>
    {
        public NodeImageSelection(Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType type) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion> CustomNodeImageVersions { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelection>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NodeImageSelectionType : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NodeImageSelectionType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType Consistent { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType Custom { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType Latest { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType left, Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType left, Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageSelectionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NodeImageVersion : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>
    {
        public NodeImageVersion() { }
        public string Version { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SkipProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>
    {
        public SkipProperties(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget> targets) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget> Targets { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SkipTarget : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>
    {
        public SkipTarget(Azure.ResourceManager.ContainerServiceFleet.Models.TargetType type, string name) { }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.TargetType Type { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.SkipTarget>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TargetType : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.TargetType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TargetType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.TargetType AfterStageWait { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.TargetType Group { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.TargetType Member { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.TargetType Stage { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.TargetType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.TargetType left, Azure.ResourceManager.ContainerServiceFleet.Models.TargetType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.TargetType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.TargetType left, Azure.ResourceManager.ContainerServiceFleet.Models.TargetType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UpdateGroup : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>
    {
        public UpdateGroup(string name) { }
        public string Name { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UpdateGroupStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>
    {
        internal UpdateGroupStatus() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerServiceFleet.Models.MemberUpdateStatus> Members { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UpdateRunProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UpdateRunProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState left, Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UpdateRunStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>
    {
        internal UpdateRunStatus() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerServiceFleet.Models.NodeImageVersion> SelectedNodeImageVersions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus> Stages { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateRunStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UpdateStage : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>
    {
        public UpdateStage(string name) { }
        public int? AfterStageWaitInSeconds { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroup> Groups { get { throw null; } }
        public string Name { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStage>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UpdateStageStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>
    {
        internal UpdateStageStatus() { }
        public Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus AfterStageWaitStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateGroupStatus> Groups { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStageStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UpdateState : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UpdateState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState Completed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState NotStarted { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState Running { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState Skipped { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState Stopped { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState Stopping { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState left, Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState left, Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UpdateStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>
    {
        internal UpdateStatus() { }
        public System.DateTimeOffset? CompletedOn { get { throw null; } }
        public Azure.ResponseError Error { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateState? State { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UpgradeChannel : System.IEquatable<Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UpgradeChannel(string value) { throw null; }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel NodeImage { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel Rapid { get { throw null; } }
        public static Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel Stable { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel left, Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel left, Azure.ResourceManager.ContainerServiceFleet.Models.UpgradeChannel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WaitStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>
    {
        internal WaitStatus() { }
        public Azure.ResourceManager.ContainerServiceFleet.Models.UpdateStatus Status { get { throw null; } }
        public int? WaitDurationInSeconds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerServiceFleet.Models.WaitStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
