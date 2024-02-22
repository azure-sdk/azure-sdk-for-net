namespace Azure.ResourceManager.Offazurespringboot
{
    public partial class ErrorSummaryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>, System.Collections.IEnumerable
    {
        protected ErrorSummaryCollection() { }
        public virtual Azure.Response<bool> Exists(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> Get(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>> GetAsync(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> GetIfExists(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>> GetIfExistsAsync(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ErrorSummaryData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>
    {
        public ErrorSummaryData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.ErrorSummaryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.ErrorSummaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.ErrorSummaryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorSummaryResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ErrorSummaryResource() { }
        public virtual Azure.ResourceManager.Offazurespringboot.ErrorSummaryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string errorSummaryName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class OffazurespringbootExtensions
    {
        public static Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource GetErrorSummaryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource GetSpringbootappsModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetSpringbootappsModels(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetSpringbootappsModelsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource GetSpringbootserversModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetSpringbootserversModels(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetSpringbootserversModelsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetSpringbootsitesModel(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> GetSpringbootsitesModelAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource GetSpringbootsitesModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelCollection GetSpringbootsitesModels(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetSpringbootsitesModels(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetSpringbootsitesModelsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SummaryResource GetSummaryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class SpringbootappsModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>, System.Collections.IEnumerable
    {
        protected SpringbootappsModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string springbootappsName, Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string springbootappsName, Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> Get(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> GetAsync(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetIfExists(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> GetIfExistsAsync(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SpringbootappsModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>
    {
        public SpringbootappsModelData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootappsModelResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SpringbootappsModelResource() { }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string springbootappsName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> Update(Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> UpdateAsync(Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SpringbootserversModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>, System.Collections.IEnumerable
    {
        protected SpringbootserversModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string springbootserversName, Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string springbootserversName, Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> Get(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> GetAsync(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetIfExists(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> GetIfExistsAsync(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SpringbootserversModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>
    {
        public SpringbootserversModelData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootserversModelResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SpringbootserversModelResource() { }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string springbootserversName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> Update(Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> UpdateAsync(Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SpringbootsitesModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>, System.Collections.IEnumerable
    {
        protected SpringbootsitesModelCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string springbootsitesName, Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string springbootsitesName, Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> Get(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> GetAsync(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetIfExists(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> GetIfExistsAsync(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SpringbootsitesModelData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>
    {
        public SpringbootsitesModelData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties Properties { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootsitesModelResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SpringbootsitesModelResource() { }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string springbootsitesName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.ErrorSummaryCollection GetErrorSummaries() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource> GetErrorSummary(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource>> GetErrorSummaryAsync(string errorSummaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetSpringbootappsModel(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> GetSpringbootappsModelAsync(string springbootappsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootappsModelCollection GetSpringbootappsModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetSpringbootserversModel(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> GetSpringbootserversModelAsync(string springbootserversName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootserversModelCollection GetSpringbootserversModels() { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SummaryCollection GetSummaries() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SummaryResource> GetSummary(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SummaryResource>> GetSummaryAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation TriggerRefreshSite(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> TriggerRefreshSiteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SummaryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SummaryResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SummaryResource>, System.Collections.IEnumerable
    {
        protected SummaryCollection() { }
        public virtual Azure.Response<bool> Exists(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SummaryResource> Get(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SummaryResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SummaryResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SummaryResource>> GetAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SummaryResource> GetIfExists(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Offazurespringboot.SummaryResource>> GetIfExistsAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Offazurespringboot.SummaryResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Offazurespringboot.SummaryResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Offazurespringboot.SummaryResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.SummaryResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SummaryData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SummaryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SummaryData>
    {
        public SummaryData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.SummaryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SummaryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.SummaryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.SummaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SummaryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SummaryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.SummaryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SummaryResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SummaryResource() { }
        public virtual Azure.ResourceManager.Offazurespringboot.SummaryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string summaryName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SummaryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SummaryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Offazurespringboot.Mocking
{
    public partial class MockableOffazurespringbootArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableOffazurespringbootArmClient() { }
        public virtual Azure.ResourceManager.Offazurespringboot.ErrorSummaryResource GetErrorSummaryResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource GetSpringbootappsModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource GetSpringbootserversModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource GetSpringbootsitesModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SummaryResource GetSummaryResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableOffazurespringbootResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableOffazurespringbootResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetSpringbootsitesModel(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource>> GetSpringbootsitesModelAsync(string springbootsitesName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelCollection GetSpringbootsitesModels() { throw null; }
    }
    public partial class MockableOffazurespringbootSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableOffazurespringbootSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetSpringbootappsModels(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> GetSpringbootappsModelsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetSpringbootserversModels(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> GetSpringbootserversModelsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetSpringbootsitesModels(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelResource> GetSpringbootsitesModelsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Offazurespringboot.Models
{
    public static partial class ArmOffazurespringbootModelFactory
    {
        public static Azure.ResourceManager.Offazurespringboot.ErrorSummaryData ErrorSummaryData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootappsModelData SpringbootappsModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch SpringbootappsModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties SpringbootappsProperties(string appName = null, string artifactName = null, int? appPort = default(int?), string appType = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem> applicationConfigurations = null, System.Collections.Generic.IEnumerable<int> bindingPorts = null, string buildJdkVersion = null, System.Collections.Generic.IEnumerable<string> certificates = null, string checksum = null, System.Collections.Generic.IEnumerable<string> dependencies = null, System.Collections.Generic.IEnumerable<string> environments = null, int? instanceCount = default(int?), string jarFileLocation = null, int? jvmMemoryInMB = default(int?), System.Collections.Generic.IEnumerable<string> jvmOptions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem> miscs = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem> instances = null, string runtimeJdkVersion = null, System.Collections.Generic.IEnumerable<string> servers = null, System.Collections.Generic.IEnumerable<string> machineArmIds = null, string springBootVersion = null, System.Collections.Generic.IEnumerable<string> staticContentLocations = null, System.Collections.Generic.IEnumerable<string> connectionStrings = null, System.DateTimeOffset? lastModifiedOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastUpdatedOn = default(System.DateTimeOffset?), Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Offazurespringboot.Models.Error> errors = null, System.Collections.Generic.IDictionary<string, string> labels = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData SpringbootserversModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch SpringbootserversModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData SpringbootsitesModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties properties = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation extendedLocation = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SummaryData SummaryData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
    }
    public partial class Error : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.Error>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.Error>
    {
        public Error() { }
        public string Code { get { throw null; } set { } }
        public long? Id { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public string PossibleCauses { get { throw null; } set { } }
        public string RecommendedAction { get { throw null; } set { } }
        public string RunAsAccountId { get { throw null; } set { } }
        public string Severity { get { throw null; } set { } }
        public string SummaryMessage { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedTimeStamp { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.Error System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.Error>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.Error>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.Error System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.Error>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.Error>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.Error>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorSummariesProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>
    {
        public ErrorSummariesProperties() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel> DiscoveryScopeErrorSummaries { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorSummaryModel : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>
    {
        public ErrorSummaryModel() { }
        public long? AffectedObjectsCount { get { throw null; } set { } }
        public string AffectedResourceType { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState left, Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState left, Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SpringbootappsModelPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>
    {
        public SpringbootappsModelPatch() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootappsProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>
    {
        public SpringbootappsProperties() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem> ApplicationConfigurations { get { throw null; } }
        public string AppName { get { throw null; } set { } }
        public int? AppPort { get { throw null; } set { } }
        public string AppType { get { throw null; } set { } }
        public string ArtifactName { get { throw null; } set { } }
        public System.Collections.Generic.IList<int> BindingPorts { get { throw null; } }
        public string BuildJdkVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Certificates { get { throw null; } }
        public string Checksum { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ConnectionStrings { get { throw null; } }
        public System.Collections.Generic.IList<string> Dependencies { get { throw null; } }
        public System.Collections.Generic.IList<string> Environments { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public int? InstanceCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem> Instances { get { throw null; } }
        public string JarFileLocation { get { throw null; } set { } }
        public int? JvmMemoryInMB { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> JvmOptions { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Labels { get { throw null; } }
        public System.DateTimeOffset? LastModifiedOn { get { throw null; } set { } }
        public System.DateTimeOffset? LastUpdatedOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> MachineArmIds { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem> Miscs { get { throw null; } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string RuntimeJdkVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Servers { get { throw null; } }
        public string SpringBootVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> StaticContentLocations { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootappsPropertiesApplicationConfigurationsItem : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>
    {
        public SpringbootappsPropertiesApplicationConfigurationsItem(string key) { }
        public string Key { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesApplicationConfigurationsItem>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootappsPropertiesInstancesItem : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>
    {
        public SpringbootappsPropertiesInstancesItem(string machineArmId) { }
        public int? InstanceCount { get { throw null; } set { } }
        public int? JvmMemoryInMB { get { throw null; } set { } }
        public string MachineArmId { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesInstancesItem>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootappsPropertiesMiscsItem : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>
    {
        public SpringbootappsPropertiesMiscsItem(string key) { }
        public string Key { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootserversModelPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>
    {
        public SpringbootserversModelPatch() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootserversProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>
    {
        public SpringbootserversProperties(string server) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public System.Collections.Generic.IList<string> FqdnAndIPAddressList { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Labels { get { throw null; } }
        public string MachineArmId { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        public string Server { get { throw null; } set { } }
        public int? SpringBootApps { get { throw null; } set { } }
        public int? TotalApps { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootsitesModelExtendedLocation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>
    {
        public SpringbootsitesModelExtendedLocation() { }
        public string Name { get { throw null; } set { } }
        public string SpringbootsitesModelExtendedLocationType { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootsitesModelPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>
    {
        public SpringbootsitesModelPatch() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpringbootsitesProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>
    {
        public SpringbootsitesProperties() { }
        public string MasterSiteId { get { throw null; } set { } }
        public string MigrateProjectId { get { throw null; } set { } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SummariesProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>
    {
        public SummariesProperties() { }
        public long? DiscoveredApps { get { throw null; } set { } }
        public long? DiscoveredServers { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
