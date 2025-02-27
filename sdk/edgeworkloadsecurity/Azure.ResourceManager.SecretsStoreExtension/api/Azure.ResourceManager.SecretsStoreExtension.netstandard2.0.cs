namespace Azure.ResourceManager.SecretsStoreExtension
{
    public partial class AzureKeyVaultSecretProviderClassCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>, System.Collections.IEnumerable
    {
        protected AzureKeyVaultSecretProviderClassCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string azureKeyVaultSecretProviderClassName, Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string azureKeyVaultSecretProviderClassName, Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> Get(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> GetAsync(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetIfExists(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> GetIfExistsAsync(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AzureKeyVaultSecretProviderClassData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>
    {
        public AzureKeyVaultSecretProviderClassData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Resources.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureKeyVaultSecretProviderClassResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AzureKeyVaultSecretProviderClassResource() { }
        public virtual Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string azureKeyVaultSecretProviderClassName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class SecretsStoreExtensionExtensions
    {
        public static Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAzureKeyVaultSecretProviderClass(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> GetAzureKeyVaultSecretProviderClassAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassCollection GetAzureKeyVaultSecretProviderClasses(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAzureKeyVaultSecretProviderClasses(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAzureKeyVaultSecretProviderClassesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource GetAzureKeyVaultSecretProviderClassResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetSecretSync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> GetSecretSyncAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource GetSecretSyncResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.SecretSyncCollection GetSecretSyncs(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetSecretSyncs(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetSecretSyncsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SecretSyncCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>, System.Collections.IEnumerable
    {
        protected SecretSyncCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string secretSyncName, Azure.ResourceManager.SecretsStoreExtension.SecretSyncData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string secretSyncName, Azure.ResourceManager.SecretsStoreExtension.SecretSyncData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> Get(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> GetAsync(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetIfExists(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> GetIfExistsAsync(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SecretSyncData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>
    {
        public SecretSyncData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Resources.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.SecretSyncData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.SecretSyncData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecretSyncResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SecretSyncResource() { }
        public virtual Azure.ResourceManager.SecretsStoreExtension.SecretSyncData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string secretSyncName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.SecretsStoreExtension.SecretSyncData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.SecretSyncData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.SecretSyncData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SecretsStoreExtension.Mocking
{
    public partial class MockableSecretsStoreExtensionArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableSecretsStoreExtensionArmClient() { }
        public virtual Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource GetAzureKeyVaultSecretProviderClassResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource GetSecretSyncResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableSecretsStoreExtensionResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSecretsStoreExtensionResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAzureKeyVaultSecretProviderClass(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource>> GetAzureKeyVaultSecretProviderClassAsync(string azureKeyVaultSecretProviderClassName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassCollection GetAzureKeyVaultSecretProviderClasses() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetSecretSync(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource>> GetSecretSyncAsync(string secretSyncName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.SecretsStoreExtension.SecretSyncCollection GetSecretSyncs() { throw null; }
    }
    public partial class MockableSecretsStoreExtensionSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableSecretsStoreExtensionSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAzureKeyVaultSecretProviderClasses(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassResource> GetAzureKeyVaultSecretProviderClassesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetSecretSyncs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.SecretsStoreExtension.SecretSyncResource> GetSecretSyncsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.SecretsStoreExtension.Models
{
    public static partial class ArmSecretsStoreExtensionModelFactory
    {
        public static Azure.ResourceManager.SecretsStoreExtension.AzureKeyVaultSecretProviderClassData AzureKeyVaultSecretProviderClassData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties properties = null, Azure.ResourceManager.Resources.Models.ExtendedLocation extendedLocation = null) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties AzureKeyVaultSecretProviderClassProperties(string keyvaultName = null, string clientId = null, string tenantId = null, string objects = null, Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition SecretSyncCondition(System.DateTimeOffset? lastTransitionOn = default(System.DateTimeOffset?), string message = null, long? observedGeneration = default(long?), string reason = null, Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType status = default(Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType), string type = null) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.SecretSyncData SecretSyncData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties properties = null, Azure.ResourceManager.Resources.Models.ExtendedLocation extendedLocation = null) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties SecretSyncProperties(string secretProviderClassName = null, string serviceAccountName = null, Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType kubernetesSecretType = default(Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType), string forceSynchronization = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping> objectSecretMapping = null, Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus status = null, Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus SecretSyncStatus(System.DateTimeOffset? lastSuccessfulSyncOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition> conditions = null) { throw null; }
    }
    public partial class AzureKeyVaultSecretProviderClassPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>
    {
        public AzureKeyVaultSecretProviderClassPatch() { }
        public Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureKeyVaultSecretProviderClassProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>
    {
        public AzureKeyVaultSecretProviderClassProperties(string keyvaultName, string clientId, string tenantId) { }
        public string ClientId { get { throw null; } set { } }
        public string KeyvaultName { get { throw null; } set { } }
        public string Objects { get { throw null; } set { } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string TenantId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureKeyVaultSecretProviderClassUpdateProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>
    {
        public AzureKeyVaultSecretProviderClassUpdateProperties() { }
        public string ClientId { get { throw null; } set { } }
        public string KeyvaultName { get { throw null; } set { } }
        public string Objects { get { throw null; } set { } }
        public string TenantId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.AzureKeyVaultSecretProviderClassUpdateProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KubernetesSecretObjectMapping : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>
    {
        public KubernetesSecretObjectMapping(string sourcePath, string targetKey) { }
        public string SourcePath { get { throw null; } set { } }
        public string TargetKey { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct KubernetesSecretType : System.IEquatable<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public KubernetesSecretType(string value) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType Opaque { get { throw null; } }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType Tls { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType left, Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType left, Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState left, Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState left, Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SecretSyncCondition : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>
    {
        internal SecretSyncCondition() { }
        public System.DateTimeOffset? LastTransitionOn { get { throw null; } }
        public string Message { get { throw null; } }
        public long? ObservedGeneration { get { throw null; } }
        public string Reason { get { throw null; } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType Status { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecretSyncPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>
    {
        public SecretSyncPatch() { }
        public Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecretSyncProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>
    {
        public SecretSyncProperties(string secretProviderClassName, string serviceAccountName, Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType kubernetesSecretType, System.Collections.Generic.IEnumerable<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping> objectSecretMapping) { }
        public string ForceSynchronization { get { throw null; } set { } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType KubernetesSecretType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping> ObjectSecretMapping { get { throw null; } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string SecretProviderClassName { get { throw null; } set { } }
        public string ServiceAccountName { get { throw null; } set { } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecretSyncStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>
    {
        internal SecretSyncStatus() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncCondition> Conditions { get { throw null; } }
        public System.DateTimeOffset? LastSuccessfulSyncOn { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecretSyncUpdateProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>
    {
        public SecretSyncUpdateProperties() { }
        public string ForceSynchronization { get { throw null; } set { } }
        public Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretType? KubernetesSecretType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.SecretsStoreExtension.Models.KubernetesSecretObjectMapping> ObjectSecretMapping { get { throw null; } }
        public string SecretProviderClassName { get { throw null; } set { } }
        public string ServiceAccountName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.SecretsStoreExtension.Models.SecretSyncUpdateProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StatusConditionType : System.IEquatable<Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StatusConditionType(string value) { throw null; }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType False { get { throw null; } }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType True { get { throw null; } }
        public static Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType left, Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType left, Azure.ResourceManager.SecretsStoreExtension.Models.StatusConditionType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
