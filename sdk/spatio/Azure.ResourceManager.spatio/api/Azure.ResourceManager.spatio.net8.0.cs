namespace Azure.ResourceManager.spatio
{
    public partial class GeoCatalogCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.spatio.GeoCatalogResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.spatio.GeoCatalogResource>, System.Collections.IEnumerable
    {
        protected GeoCatalogCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.spatio.GeoCatalogResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string catalogName, Azure.ResourceManager.spatio.GeoCatalogData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.spatio.GeoCatalogResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string catalogName, Azure.ResourceManager.spatio.GeoCatalogData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> Get(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.spatio.GeoCatalogResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.spatio.GeoCatalogResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> GetAsync(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.spatio.GeoCatalogResource> GetIfExists(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.spatio.GeoCatalogResource>> GetIfExistsAsync(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.spatio.GeoCatalogResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.spatio.GeoCatalogResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.spatio.GeoCatalogResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.spatio.GeoCatalogResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GeoCatalogData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.GeoCatalogData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>
    {
        public GeoCatalogData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.spatio.Models.GeoCatalogProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.GeoCatalogData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.GeoCatalogData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.GeoCatalogData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.GeoCatalogData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoCatalogResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.GeoCatalogData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected GeoCatalogResource() { }
        public virtual Azure.ResourceManager.spatio.GeoCatalogData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string catalogName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.spatio.GeoCatalogData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.GeoCatalogData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.GeoCatalogData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.GeoCatalogData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.GeoCatalogData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.spatio.GeoCatalogResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.spatio.Models.GeoCatalogPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.spatio.GeoCatalogResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.spatio.Models.GeoCatalogPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class spatioExtensions
    {
        public static Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> GetGeoCatalog(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> GetGeoCatalogAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.spatio.GeoCatalogResource GetGeoCatalogResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.spatio.GeoCatalogCollection GetGeoCatalogs(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.spatio.GeoCatalogResource> GetGeoCatalogs(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.spatio.GeoCatalogResource> GetGeoCatalogsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.spatio.Mocking
{
    public partial class MockablespatioArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockablespatioArmClient() { }
        public virtual Azure.ResourceManager.spatio.GeoCatalogResource GetGeoCatalogResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockablespatioResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockablespatioResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource> GetGeoCatalog(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.spatio.GeoCatalogResource>> GetGeoCatalogAsync(string catalogName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.spatio.GeoCatalogCollection GetGeoCatalogs() { throw null; }
    }
    public partial class MockablespatioSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockablespatioSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.spatio.GeoCatalogResource> GetGeoCatalogs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.spatio.GeoCatalogResource> GetGeoCatalogsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.spatio.Models
{
    public static partial class ArmspatioModelFactory
    {
        public static Azure.ResourceManager.spatio.GeoCatalogData GeoCatalogData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.spatio.Models.GeoCatalogProperties properties = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null) { throw null; }
        public static Azure.ResourceManager.spatio.Models.GeoCatalogProperties GeoCatalogProperties(Azure.ResourceManager.spatio.Models.CatalogTier? tier = default(Azure.ResourceManager.spatio.Models.CatalogTier?), string catalogUri = null, Azure.ResourceManager.spatio.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.spatio.Models.ProvisioningState?), Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope = default(Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope?)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoGeneratedDomainNameLabelScope : System.IEquatable<Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoGeneratedDomainNameLabelScope(string value) { throw null; }
        public static Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope NoReuse { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope ResourceGroupReuse { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope SubscriptionReuse { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope TenantReuse { get { throw null; } }
        public bool Equals(Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope left, Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope right) { throw null; }
        public static implicit operator Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope left, Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CatalogTier : System.IEquatable<Azure.ResourceManager.spatio.Models.CatalogTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CatalogTier(string value) { throw null; }
        public static Azure.ResourceManager.spatio.Models.CatalogTier Basic { get { throw null; } }
        public bool Equals(Azure.ResourceManager.spatio.Models.CatalogTier other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.spatio.Models.CatalogTier left, Azure.ResourceManager.spatio.Models.CatalogTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.spatio.Models.CatalogTier (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.spatio.Models.CatalogTier left, Azure.ResourceManager.spatio.Models.CatalogTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GeoCatalogPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>
    {
        public GeoCatalogPatch() { }
        public Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate Identity { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.Models.GeoCatalogPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.Models.GeoCatalogPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoCatalogProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>
    {
        public GeoCatalogProperties() { }
        public Azure.ResourceManager.spatio.Models.AutoGeneratedDomainNameLabelScope? AutoGeneratedDomainNameLabelScope { get { throw null; } set { } }
        public string CatalogUri { get { throw null; } }
        public Azure.ResourceManager.spatio.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.spatio.Models.CatalogTier? Tier { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.Models.GeoCatalogProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.Models.GeoCatalogProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.GeoCatalogProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedServiceIdentityType : System.IEquatable<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedServiceIdentityType(string value) { throw null; }
        public static Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType None { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType SystemAssigned { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType SystemAssignedUserAssigned { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType UserAssigned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType left, Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType left, Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedServiceIdentityUpdate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>
    {
        public ManagedServiceIdentityUpdate() { }
        public Azure.ResourceManager.spatio.Models.ManagedServiceIdentityType? Type { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Models.UserAssignedIdentity> UserAssignedIdentities { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.spatio.Models.ManagedServiceIdentityUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.spatio.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.spatio.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.spatio.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.spatio.Models.ProvisioningState left, Azure.ResourceManager.spatio.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.spatio.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.spatio.Models.ProvisioningState left, Azure.ResourceManager.spatio.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
}
