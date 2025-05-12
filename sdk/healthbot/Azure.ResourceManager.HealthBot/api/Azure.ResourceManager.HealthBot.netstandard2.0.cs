namespace Azure.ResourceManager.HealthBot
{
    public partial class AzureResourceManagerHealthBotContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerHealthBotContext() { }
        public static Azure.ResourceManager.HealthBot.AzureResourceManagerHealthBotContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class HealthBotCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HealthBot.HealthBotResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HealthBot.HealthBotResource>, System.Collections.IEnumerable
    {
        protected HealthBotCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HealthBot.HealthBotResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string botName, Azure.ResourceManager.HealthBot.HealthBotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HealthBot.HealthBotResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string botName, Azure.ResourceManager.HealthBot.HealthBotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> Get(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HealthBot.HealthBotResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HealthBot.HealthBotResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> GetAsync(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HealthBot.HealthBotResource> GetIfExists(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HealthBot.HealthBotResource>> GetIfExistsAsync(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HealthBot.HealthBotResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HealthBot.HealthBotResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HealthBot.HealthBotResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HealthBot.HealthBotResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HealthBotData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.HealthBotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>
    {
        public HealthBotData(Azure.Core.AzureLocation location, Azure.ResourceManager.HealthBot.Models.HealthBotSku sku) { }
        public Azure.ResourceManager.HealthBot.Models.Identity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.HealthBot.Models.HealthBotProperties Properties { get { throw null; } set { } }
        public Azure.ResourceManager.HealthBot.Models.HealthBotSkuName? SkuName { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.HealthBotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.HealthBotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.HealthBotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.HealthBotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class HealthBotExtensions
    {
        public static Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> GetHealthBot(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> GetHealthBotAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HealthBot.HealthBotResource GetHealthBotResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HealthBot.HealthBotCollection GetHealthBots(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HealthBot.HealthBotResource> GetHealthBots(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HealthBot.HealthBotResource> GetHealthBotsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HealthBot.Models.OperationDetail> GetOperations(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HealthBot.Models.OperationDetail> GetOperationsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HealthBotResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.HealthBotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HealthBotResource() { }
        public virtual Azure.ResourceManager.HealthBot.HealthBotData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string botName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.Models.HealthBotKey> RegenerateApiJwtSecret(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.Models.HealthBotKey>> RegenerateApiJwtSecretAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.HealthBot.HealthBotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.HealthBotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.HealthBotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.HealthBotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.HealthBotData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.HealthBot.Models.HealthBotPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HealthBot.Models.HealthBotPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.HealthBot.Mocking
{
    public partial class MockableHealthBotArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableHealthBotArmClient() { }
        public virtual Azure.ResourceManager.HealthBot.HealthBotResource GetHealthBotResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableHealthBotResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHealthBotResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource> GetHealthBot(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HealthBot.HealthBotResource>> GetHealthBotAsync(string botName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HealthBot.HealthBotCollection GetHealthBots() { throw null; }
    }
    public partial class MockableHealthBotSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHealthBotSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.HealthBot.HealthBotResource> GetHealthBots(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HealthBot.HealthBotResource> GetHealthBotsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MockableHealthBotTenantResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHealthBotTenantResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.HealthBot.Models.OperationDetail> GetOperations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HealthBot.Models.OperationDetail> GetOperationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.HealthBot.Models
{
    public static partial class ArmHealthBotModelFactory
    {
        public static Azure.ResourceManager.HealthBot.HealthBotData HealthBotData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HealthBot.Models.HealthBotSkuName? skuName = default(Azure.ResourceManager.HealthBot.Models.HealthBotSkuName?), Azure.ResourceManager.HealthBot.Models.Identity identity = null, Azure.ResourceManager.HealthBot.Models.HealthBotProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.HealthBotKey HealthBotKey(string keyName = null, string value = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult HealthBotKeysResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.HealthBot.Models.HealthBotKey> secrets = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.HealthBotProperties HealthBotProperties(string provisioningState = null, string botManagementPortalLink = null, Azure.ResourceManager.HealthBot.Models.KeyVaultProperties keyVaultProperties = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.Identity Identity(string principalId = null, string tenantId = null, Azure.ResourceManager.HealthBot.Models.ResourceIdentityType? type = default(Azure.ResourceManager.HealthBot.Models.ResourceIdentityType?), Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap userAssignedIdentities = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.OperationDetail OperationDetail(string name = null, bool? isDataAction = default(bool?), Azure.ResourceManager.HealthBot.Models.OperationDisplay display = null, string origin = null, Azure.ResourceManager.HealthBot.Models.OperationDetailProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.OperationDisplay OperationDisplay(string provider = null, string resource = null, string operation = null, string description = null) { throw null; }
        public static Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity UserAssignedIdentity(string principalId = null, string clientId = null) { throw null; }
    }
    public partial class HealthBotKey : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>
    {
        internal HealthBotKey() { }
        public string KeyName { get { throw null; } }
        public string Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotKey System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotKey System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKey>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HealthBotKeysResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>
    {
        internal HealthBotKeysResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HealthBot.Models.HealthBotKey> Secrets { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotKeysResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HealthBotPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>
    {
        public HealthBotPatch() { }
        public Azure.ResourceManager.HealthBot.Models.Identity Identity { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public Azure.ResourceManager.HealthBot.Models.HealthBotProperties Properties { get { throw null; } set { } }
        public Azure.ResourceManager.HealthBot.Models.HealthBotSkuName? SkuName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HealthBotProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>
    {
        public HealthBotProperties() { }
        public string BotManagementPortalLink { get { throw null; } }
        public Azure.ResourceManager.HealthBot.Models.KeyVaultProperties KeyVaultProperties { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HealthBotSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>
    {
        public HealthBotSku(Azure.ResourceManager.HealthBot.Models.HealthBotSkuName name) { }
        public Azure.ResourceManager.HealthBot.Models.HealthBotSkuName Name { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.HealthBotSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.HealthBotSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum HealthBotSkuName
    {
        F0 = 0,
        S1 = 1,
        C0 = 2,
        PES = 3,
        C1 = 4,
    }
    public partial class Identity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.Identity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.Identity>
    {
        public Identity() { }
        public string PrincipalId { get { throw null; } }
        public string TenantId { get { throw null; } }
        public Azure.ResourceManager.HealthBot.Models.ResourceIdentityType? Type { get { throw null; } set { } }
        public Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap UserAssignedIdentities { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.Identity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.Identity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.Identity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.Identity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.Identity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.Identity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.Identity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>
    {
        public KeyVaultProperties(string keyName, string keyVaultUri) { }
        public string KeyName { get { throw null; } set { } }
        public string KeyVaultUri { get { throw null; } set { } }
        public string KeyVersion { get { throw null; } set { } }
        public string UserIdentity { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.KeyVaultProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.KeyVaultProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.KeyVaultProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OperationDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>
    {
        internal OperationDetail() { }
        public Azure.ResourceManager.HealthBot.Models.OperationDisplay Display { get { throw null; } }
        public bool? IsDataAction { get { throw null; } }
        public string Name { get { throw null; } }
        public string Origin { get { throw null; } }
        public Azure.ResourceManager.HealthBot.Models.OperationDetailProperties Properties { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.OperationDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.OperationDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OperationDetailProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>
    {
        internal OperationDetailProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.OperationDetailProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.OperationDetailProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDetailProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OperationDisplay : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>
    {
        internal OperationDisplay() { }
        public string Description { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.OperationDisplay System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.OperationDisplay System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.OperationDisplay>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ResourceIdentityType
    {
        SystemAssigned = 0,
        UserAssigned = 1,
        SystemAssignedUserAssigned = 2,
        None = 3,
    }
    public partial class UserAssignedIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>
    {
        public UserAssignedIdentity() { }
        public string ClientId { get { throw null; } }
        public string PrincipalId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserAssignedIdentityMap : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>
    {
        public UserAssignedIdentityMap() { }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.HealthBot.Models.UserAssignedIdentityMap>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
