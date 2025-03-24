namespace Azure.ResourceManager.SiteManager
{
    public partial class ResourceGroupSiteCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>, System.Collections.IEnumerable
    {
        protected ResourceGroupSiteCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string siteName, Azure.ResourceManager.SiteManager.SiteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string siteName, Azure.ResourceManager.SiteManager.SiteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> Get(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> GetAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> GetIfExists(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> GetIfExistsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ResourceGroupSiteResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ResourceGroupSiteResource() { }
        public virtual Azure.ResourceManager.SiteManager.SiteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SiteManager.SiteData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.SiteData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> Update(Azure.ResourceManager.SiteManager.Models.SiteUpdate properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> UpdateAsync(Azure.ResourceManager.SiteManager.Models.SiteUpdate properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>
    {
        public SiteData() { }
        public Azure.ResourceManager.SiteManager.Models.SiteProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.SiteData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.SiteData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class SiteManagerExtensions
    {
        public static Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> GetResourceGroupSite(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> GetResourceGroupSiteAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SiteManager.ResourceGroupSiteResource GetResourceGroupSiteResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SiteManager.ResourceGroupSiteCollection GetResourceGroupSites(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> GetSubscriptionSite(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> GetSubscriptionSiteAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SiteManager.SubscriptionSiteResource GetSubscriptionSiteResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SiteManager.SubscriptionSiteCollection GetSubscriptionSites(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
    }
    public partial class SubscriptionSiteCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>, System.Collections.IEnumerable
    {
        protected SubscriptionSiteCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string siteName, Azure.ResourceManager.SiteManager.SiteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string siteName, Azure.ResourceManager.SiteManager.SiteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> Get(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> GetAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> GetIfExists(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> GetIfExistsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SubscriptionSiteResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SubscriptionSiteResource() { }
        public virtual Azure.ResourceManager.SiteManager.SiteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string siteName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SiteManager.SiteData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.SiteData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.SiteData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.SiteData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> Update(Azure.ResourceManager.SiteManager.Models.SiteUpdate properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> UpdateAsync(Azure.ResourceManager.SiteManager.Models.SiteUpdate properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SiteManager.Mocking
{
    public partial class MockableSiteManagerArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableSiteManagerArmClient() { }
        public virtual Azure.ResourceManager.SiteManager.ResourceGroupSiteResource GetResourceGroupSiteResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SiteManager.SubscriptionSiteResource GetSubscriptionSiteResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableSiteManagerResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSiteManagerResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource> GetResourceGroupSite(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.ResourceGroupSiteResource>> GetResourceGroupSiteAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SiteManager.ResourceGroupSiteCollection GetResourceGroupSites() { throw null; }
    }
    public partial class MockableSiteManagerSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSiteManagerSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource> GetSubscriptionSite(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SiteManager.SubscriptionSiteResource>> GetSubscriptionSiteAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SiteManager.SubscriptionSiteCollection GetSubscriptionSites() { throw null; }
    }
}
namespace Azure.ResourceManager.SiteManager.Models
{
    public static partial class ArmSiteManagerModelFactory
    {
        public static Azure.ResourceManager.SiteManager.SiteData SiteData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.SiteManager.Models.SiteProperties properties = null) { throw null; }
        public static Azure.ResourceManager.SiteManager.Models.SiteProperties SiteProperties(string displayName = null, string description = null, Azure.Core.ResourceIdentifier addressResourceId = null, Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState? provisioningState = default(Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState?)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceProvisioningState : System.IEquatable<Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState left, Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState left, Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SiteProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>
    {
        public SiteProperties() { }
        public Azure.Core.ResourceIdentifier AddressResourceId { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.SiteManager.Models.ResourceProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.Models.SiteProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.Models.SiteProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SiteUpdate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>
    {
        public SiteUpdate() { }
        public Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties Properties { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.Models.SiteUpdate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.Models.SiteUpdate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SiteUpdateProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>
    {
        public SiteUpdateProperties() { }
        public Azure.Core.ResourceIdentifier AddressResourceId { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SiteManager.Models.SiteUpdateProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
