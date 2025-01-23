namespace Azure.ResourceManager.PineconeVectorDb
{
    public partial class OrganizationResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected OrganizationResource() { }
        public virtual Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string organizationname) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> Update(Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> UpdateAsync(Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class OrganizationResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>, System.Collections.IEnumerable
    {
        protected OrganizationResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string organizationname, Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string organizationname, Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> Get(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> GetAsync(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetIfExists(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> GetIfExistsAsync(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class OrganizationResourceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>
    {
        public OrganizationResourceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class PineconeVectorDbExtensions
    {
        public static Azure.ResourceManager.PineconeVectorDb.OrganizationResource GetOrganizationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetOrganizationResource(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> GetOrganizationResourceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.OrganizationResourceCollection GetOrganizationResources(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetOrganizationResources(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetOrganizationResourcesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.PineconeVectorDb.Mocking
{
    public partial class MockablePineconeVectorDbArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockablePineconeVectorDbArmClient() { }
        public virtual Azure.ResourceManager.PineconeVectorDb.OrganizationResource GetOrganizationResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockablePineconeVectorDbResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockablePineconeVectorDbResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetOrganizationResource(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.PineconeVectorDb.OrganizationResource>> GetOrganizationResourceAsync(string organizationname, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.PineconeVectorDb.OrganizationResourceCollection GetOrganizationResources() { throw null; }
    }
    public partial class MockablePineconeVectorDbSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockablePineconeVectorDbSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetOrganizationResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.PineconeVectorDb.OrganizationResource> GetOrganizationResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.PineconeVectorDb.Models
{
    public static partial class ArmPineconeVectorDbModelFactory
    {
        public static Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails MarketplaceDetails(string subscriptionId = null, Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus? subscriptionStatus = default(Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus?), Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails offerDetails = null) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties OrganizationProperties(Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails marketplace = null, Azure.ResourceManager.PineconeVectorDb.Models.UserDetails user = null, Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState? provisioningState = default(Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState?), string partnerDisplayName = null, Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2 singleSignOnProperties = null) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.OrganizationResourceData OrganizationResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties properties = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null) { throw null; }
    }
    public partial class MarketplaceDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>
    {
        public MarketplaceDetails(string subscriptionId, Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails offerDetails) { }
        public Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails OfferDetails { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus? SubscriptionStatus { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MarketplaceSubscriptionStatus : System.IEquatable<Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MarketplaceSubscriptionStatus(string value) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus PendingFulfillmentStart { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus Subscribed { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus Suspended { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus Unsubscribed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus left, Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus left, Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceSubscriptionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OfferDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>
    {
        public OfferDetails(string publisherId, string offerId, string planId) { }
        public string OfferId { get { throw null; } set { } }
        public string PlanId { get { throw null; } set { } }
        public string PlanName { get { throw null; } set { } }
        public string PublisherId { get { throw null; } set { } }
        public string TermId { get { throw null; } set { } }
        public string TermUnit { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OfferDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OrganizationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>
    {
        public OrganizationProperties(Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails marketplace, Azure.ResourceManager.PineconeVectorDb.Models.UserDetails user) { }
        public Azure.ResourceManager.PineconeVectorDb.Models.MarketplaceDetails Marketplace { get { throw null; } set { } }
        public string PartnerDisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2 SingleSignOnProperties { get { throw null; } set { } }
        public Azure.ResourceManager.PineconeVectorDb.Models.UserDetails User { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OrganizationResourcePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>
    {
        public OrganizationResourcePatch() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.OrganizationResourcePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceProvisioningState : System.IEquatable<Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState left, Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState left, Azure.ResourceManager.PineconeVectorDb.Models.ResourceProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SingleSignOnPropertiesV2 : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>
    {
        public SingleSignOnPropertiesV2(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType type) { }
        public System.Collections.Generic.IList<string> AadDomains { get { throw null; } }
        public string EnterpriseAppId { get { throw null; } set { } }
        public Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState? State { get { throw null; } set { } }
        public Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType Type { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2 System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2 System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnPropertiesV2>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SingleSignOnState : System.IEquatable<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SingleSignOnState(string value) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState Disable { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState Enable { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState Initial { get { throw null; } }
        public bool Equals(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState left, Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState right) { throw null; }
        public static implicit operator Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState left, Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SingleSignOnType : System.IEquatable<Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SingleSignOnType(string value) { throw null; }
        public static Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType OpenId { get { throw null; } }
        public static Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType Saml { get { throw null; } }
        public bool Equals(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType left, Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType right) { throw null; }
        public static implicit operator Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType left, Azure.ResourceManager.PineconeVectorDb.Models.SingleSignOnType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UserDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>
    {
        public UserDetails(string firstName, string lastName, string emailAddress) { }
        public string EmailAddress { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public string LastName { get { throw null; } set { } }
        public string PhoneNumber { get { throw null; } set { } }
        public string Upn { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.UserDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.PineconeVectorDb.Models.UserDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.PineconeVectorDb.Models.UserDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
