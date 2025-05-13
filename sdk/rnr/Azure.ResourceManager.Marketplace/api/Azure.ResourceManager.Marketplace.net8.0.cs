namespace Azure.ResourceManager.Marketplace
{
    public partial class AzureResourceManagerMarketplaceContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerMarketplaceContext() { }
        public static Azure.ResourceManager.Marketplace.AzureResourceManagerMarketplaceContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public static partial class MarketplaceExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Marketplace.Models.UserHasReview> CheckUserHasReviewRatingAndReviewsOperation(this Azure.ResourceManager.Resources.TenantResource tenantResource, string uniqueProductId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Marketplace.Models.UserHasReview>> CheckUserHasReviewRatingAndReviewsOperationAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string uniqueProductId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Marketplace.Mocking
{
    public partial class MockableMarketplaceTenantResource : Azure.ResourceManager.ArmResource
    {
        protected MockableMarketplaceTenantResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Marketplace.Models.UserHasReview> CheckUserHasReviewRatingAndReviewsOperation(string uniqueProductId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Marketplace.Models.UserHasReview>> CheckUserHasReviewRatingAndReviewsOperationAsync(string uniqueProductId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Marketplace.Models
{
    public static partial class ArmMarketplaceModelFactory
    {
        public static Azure.ResourceManager.Marketplace.Models.UserHasReview UserHasReview(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties UserHasReviewProperties(bool hasReview = false, string updatedAt = null) { throw null; }
    }
    public partial class UserHasReview : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>
    {
        internal UserHasReview() { }
        public Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Marketplace.Models.UserHasReview System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Marketplace.Models.UserHasReview System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReview>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserHasReviewProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>
    {
        internal UserHasReviewProperties() { }
        public bool HasReview { get { throw null; } }
        public string UpdatedAt { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Marketplace.Models.UserHasReviewProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
