namespace Azure.ResourceManager.IotOperations
{
    public partial class AssociationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.AssociationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.AssociationResource>, System.Collections.IEnumerable
    {
        protected AssociationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.AssociationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string associationName, Azure.ResourceManager.IotOperations.AssociationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.AssociationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string associationName, Azure.ResourceManager.IotOperations.AssociationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> Get(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.IotOperations.AssociationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IotOperations.AssociationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> GetAsync(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.IotOperations.AssociationResource> GetIfExists(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.IotOperations.AssociationResource>> GetIfExistsAsync(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.IotOperations.AssociationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.AssociationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.IotOperations.AssociationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.AssociationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AssociationData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.AssociationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>
    {
        public AssociationData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.IotOperations.Models.AssociationProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.AssociationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.AssociationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.AssociationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.AssociationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssociationResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.AssociationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AssociationResource() { }
        public virtual Azure.ResourceManager.IotOperations.AssociationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string trafficControllerName, string associationName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.IotOperations.AssociationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.AssociationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.AssociationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.AssociationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.AssociationData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> Update(Azure.ResourceManager.IotOperations.Models.AssociationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> UpdateAsync(Azure.ResourceManager.IotOperations.Models.AssociationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FrontendCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.FrontendResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.FrontendResource>, System.Collections.IEnumerable
    {
        protected FrontendCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.FrontendResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string frontendName, Azure.ResourceManager.IotOperations.FrontendData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.FrontendResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string frontendName, Azure.ResourceManager.IotOperations.FrontendData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> Get(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.IotOperations.FrontendResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IotOperations.FrontendResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> GetAsync(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.IotOperations.FrontendResource> GetIfExists(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.IotOperations.FrontendResource>> GetIfExistsAsync(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.IotOperations.FrontendResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.FrontendResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.IotOperations.FrontendResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.FrontendResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FrontendData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.FrontendData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>
    {
        public FrontendData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.IotOperations.Models.FrontendProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.FrontendData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.FrontendData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.FrontendData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.FrontendData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FrontendResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.FrontendData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FrontendResource() { }
        public virtual Azure.ResourceManager.IotOperations.FrontendData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string trafficControllerName, string frontendName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.IotOperations.FrontendData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.FrontendData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.FrontendData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.FrontendData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.FrontendData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> Update(Azure.ResourceManager.IotOperations.Models.FrontendPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> UpdateAsync(Azure.ResourceManager.IotOperations.Models.FrontendPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class IotOperationsExtensions
    {
        public static Azure.ResourceManager.IotOperations.AssociationResource GetAssociationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.IotOperations.FrontendResource GetFrontendResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.IotOperations.SecurityPolicyResource GetSecurityPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetTrafficController(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> GetTrafficControllerAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.IotOperations.TrafficControllerResource GetTrafficControllerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.IotOperations.TrafficControllerCollection GetTrafficControllers(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetTrafficControllers(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetTrafficControllersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SecurityPolicyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.SecurityPolicyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.SecurityPolicyResource>, System.Collections.IEnumerable
    {
        protected SecurityPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.SecurityPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string securityPolicyName, Azure.ResourceManager.IotOperations.SecurityPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string securityPolicyName, Azure.ResourceManager.IotOperations.SecurityPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> Get(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.IotOperations.SecurityPolicyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IotOperations.SecurityPolicyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> GetAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.IotOperations.SecurityPolicyResource> GetIfExists(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> GetIfExistsAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.IotOperations.SecurityPolicyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.SecurityPolicyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.IotOperations.SecurityPolicyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.SecurityPolicyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SecurityPolicyData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>
    {
        public SecurityPolicyData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.SecurityPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.SecurityPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecurityPolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SecurityPolicyResource() { }
        public virtual Azure.ResourceManager.IotOperations.SecurityPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string trafficControllerName, string securityPolicyName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.IotOperations.SecurityPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.SecurityPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.SecurityPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> Update(Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> UpdateAsync(Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TrafficControllerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.TrafficControllerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.TrafficControllerResource>, System.Collections.IEnumerable
    {
        protected TrafficControllerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.TrafficControllerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string trafficControllerName, Azure.ResourceManager.IotOperations.TrafficControllerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IotOperations.TrafficControllerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string trafficControllerName, Azure.ResourceManager.IotOperations.TrafficControllerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> Get(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> GetAsync(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetIfExists(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.IotOperations.TrafficControllerResource>> GetIfExistsAsync(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.IotOperations.TrafficControllerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IotOperations.TrafficControllerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.IotOperations.TrafficControllerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.IotOperations.TrafficControllerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TrafficControllerData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.TrafficControllerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>
    {
        public TrafficControllerData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.TrafficControllerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.TrafficControllerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrafficControllerResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.TrafficControllerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TrafficControllerResource() { }
        public virtual Azure.ResourceManager.IotOperations.TrafficControllerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string trafficControllerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource> GetAssociation(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.AssociationResource>> GetAssociationAsync(string associationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.IotOperations.AssociationCollection GetAssociations() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource> GetFrontend(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.FrontendResource>> GetFrontendAsync(string frontendName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.IotOperations.FrontendCollection GetFrontends() { throw null; }
        public virtual Azure.ResourceManager.IotOperations.SecurityPolicyCollection GetSecurityPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource> GetSecurityPolicy(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.SecurityPolicyResource>> GetSecurityPolicyAsync(string securityPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.IotOperations.TrafficControllerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.TrafficControllerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.TrafficControllerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> Update(Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> UpdateAsync(Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.IotOperations.Mocking
{
    public partial class MockableIotOperationsArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableIotOperationsArmClient() { }
        public virtual Azure.ResourceManager.IotOperations.AssociationResource GetAssociationResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.IotOperations.FrontendResource GetFrontendResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.IotOperations.SecurityPolicyResource GetSecurityPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.IotOperations.TrafficControllerResource GetTrafficControllerResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableIotOperationsResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableIotOperationsResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetTrafficController(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IotOperations.TrafficControllerResource>> GetTrafficControllerAsync(string trafficControllerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.IotOperations.TrafficControllerCollection GetTrafficControllers() { throw null; }
    }
    public partial class MockableIotOperationsSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableIotOperationsSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetTrafficControllers(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IotOperations.TrafficControllerResource> GetTrafficControllersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.IotOperations.Models
{
    public static partial class ArmIotOperationsModelFactory
    {
        public static Azure.ResourceManager.IotOperations.AssociationData AssociationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.IotOperations.Models.AssociationProperties properties = null) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.AssociationProperties AssociationProperties(Azure.ResourceManager.IotOperations.Models.AssociationType associationType = default(Azure.ResourceManager.IotOperations.Models.AssociationType), Azure.Core.ResourceIdentifier subnetId = null, Azure.ResourceManager.IotOperations.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.IotOperations.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.IotOperations.FrontendData FrontendData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.IotOperations.Models.FrontendProperties properties = null) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.FrontendProperties FrontendProperties(string fqdn = null, Azure.ResourceManager.IotOperations.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.IotOperations.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.IotOperations.SecurityPolicyData SecurityPolicyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties properties = null) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties SecurityPolicyProperties(Azure.ResourceManager.IotOperations.Models.PolicyType? policyType = default(Azure.ResourceManager.IotOperations.Models.PolicyType?), Azure.Core.ResourceIdentifier wafPolicyId = null, Azure.ResourceManager.IotOperations.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.IotOperations.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.IotOperations.TrafficControllerData TrafficControllerData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties properties = null) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties TrafficControllerProperties(System.Collections.Generic.IEnumerable<string> configurationEndpoints = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> frontends = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> associations = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.SubResource> securityPolicies = null, Azure.Core.ResourceIdentifier wafSecurityPolicyId = null, Azure.ResourceManager.IotOperations.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.IotOperations.Models.ProvisioningState?)) { throw null; }
    }
    public partial class AssociationPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>
    {
        public AssociationPatch() { }
        public Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.AssociationPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.AssociationPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssociationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>
    {
        public AssociationProperties(Azure.ResourceManager.IotOperations.Models.AssociationType associationType) { }
        public Azure.ResourceManager.IotOperations.Models.AssociationType AssociationType { get { throw null; } set { } }
        public Azure.ResourceManager.IotOperations.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.AssociationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.AssociationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AssociationType : System.IEquatable<Azure.ResourceManager.IotOperations.Models.AssociationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AssociationType(string value) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.AssociationType Subnets { get { throw null; } }
        public bool Equals(Azure.ResourceManager.IotOperations.Models.AssociationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.IotOperations.Models.AssociationType left, Azure.ResourceManager.IotOperations.Models.AssociationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.IotOperations.Models.AssociationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.IotOperations.Models.AssociationType left, Azure.ResourceManager.IotOperations.Models.AssociationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AssociationUpdateProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>
    {
        public AssociationUpdateProperties() { }
        public Azure.ResourceManager.IotOperations.Models.AssociationType? AssociationType { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.AssociationUpdateProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FrontendPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>
    {
        public FrontendPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.FrontendPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.FrontendPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FrontendProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>
    {
        public FrontendProperties() { }
        public string Fqdn { get { throw null; } }
        public Azure.ResourceManager.IotOperations.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.FrontendProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.FrontendProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.FrontendProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyType : System.IEquatable<Azure.ResourceManager.IotOperations.Models.PolicyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyType(string value) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.PolicyType WAF { get { throw null; } }
        public bool Equals(Azure.ResourceManager.IotOperations.Models.PolicyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.IotOperations.Models.PolicyType left, Azure.ResourceManager.IotOperations.Models.PolicyType right) { throw null; }
        public static implicit operator Azure.ResourceManager.IotOperations.Models.PolicyType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.IotOperations.Models.PolicyType left, Azure.ResourceManager.IotOperations.Models.PolicyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.IotOperations.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.IotOperations.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.IotOperations.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.IotOperations.Models.ProvisioningState left, Azure.ResourceManager.IotOperations.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.IotOperations.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.IotOperations.Models.ProvisioningState left, Azure.ResourceManager.IotOperations.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SecurityPolicyPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>
    {
        public SecurityPolicyPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.Core.ResourceIdentifier WafPolicyId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecurityPolicyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>
    {
        public SecurityPolicyProperties() { }
        public Azure.ResourceManager.IotOperations.Models.PolicyType? PolicyType { get { throw null; } }
        public Azure.ResourceManager.IotOperations.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier WafPolicyId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.SecurityPolicyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrafficControllerPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>
    {
        public TrafficControllerPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.Core.ResourceIdentifier WafSecurityPolicyId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrafficControllerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>
    {
        public TrafficControllerProperties() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> Associations { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ConfigurationEndpoints { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> Frontends { get { throw null; } }
        public Azure.ResourceManager.IotOperations.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> SecurityPolicies { get { throw null; } }
        public Azure.Core.ResourceIdentifier WafSecurityPolicyId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IotOperations.Models.TrafficControllerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
