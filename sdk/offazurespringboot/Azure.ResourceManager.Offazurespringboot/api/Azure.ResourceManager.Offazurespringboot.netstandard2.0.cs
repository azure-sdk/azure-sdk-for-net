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
    public partial class ErrorSummaryData : Azure.ResourceManager.Models.ResourceData
    {
        public ErrorSummaryData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.ErrorSummariesProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
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
    public partial class SpringbootappsModelData : Azure.ResourceManager.Models.ResourceData
    {
        public SpringbootappsModelData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
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
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootappsModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
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
    public partial class SpringbootserversModelData : Azure.ResourceManager.Models.ResourceData
    {
        public SpringbootserversModelData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
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
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Offazurespringboot.SpringbootserversModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
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
    public partial class SpringbootsitesModelData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public SpringbootsitesModelData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties Properties { get { throw null; } set { } }
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
    public partial class SummaryData : Azure.ResourceManager.Models.ResourceData
    {
        public SummaryData() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
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
        public static Azure.ResourceManager.Offazurespringboot.SpringbootserversModelData SpringbootserversModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversModelPatch SpringbootserversModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SpringbootsitesModelData SpringbootsitesModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties properties = null, Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelExtendedLocation extendedLocation = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesModelPatch SpringbootsitesModelPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Offazurespringboot.SummaryData SummaryData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Offazurespringboot.Models.SummariesProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
    }
    public partial class Error
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
    }
    public partial class ErrorSummariesProperties
    {
        public ErrorSummariesProperties() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.ErrorSummaryModel> DiscoveryScopeErrorSummaries { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
    }
    public partial class ErrorSummaryModel
    {
        public ErrorSummaryModel() { }
        public long? AffectedObjectsCount { get { throw null; } set { } }
        public string AffectedResourceType { get { throw null; } set { } }
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
    public partial class SpringbootappsModelPatch : Azure.ResourceManager.Models.ResourceData
    {
        public SpringbootappsModelPatch() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class SpringbootappsProperties
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
        public System.DateTimeOffset? LastModifiedOn { get { throw null; } set { } }
        public System.DateTimeOffset? LastUpdatedOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> MachineArmIds { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.SpringbootappsPropertiesMiscsItem> Miscs { get { throw null; } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        public string RuntimeJdkVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Servers { get { throw null; } }
        public string SiteName { get { throw null; } set { } }
        public string SpringBootVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> StaticContentLocations { get { throw null; } }
    }
    public partial class SpringbootappsPropertiesApplicationConfigurationsItem
    {
        public SpringbootappsPropertiesApplicationConfigurationsItem(string key) { }
        public string Key { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class SpringbootappsPropertiesInstancesItem
    {
        public SpringbootappsPropertiesInstancesItem(string machineArmId) { }
        public int? InstanceCount { get { throw null; } set { } }
        public int? JvmMemoryInMB { get { throw null; } set { } }
        public string MachineArmId { get { throw null; } set { } }
    }
    public partial class SpringbootappsPropertiesMiscsItem
    {
        public SpringbootappsPropertiesMiscsItem(string key) { }
        public string Key { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class SpringbootserversModelPatch : Azure.ResourceManager.Models.ResourceData
    {
        public SpringbootserversModelPatch() { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootserversProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class SpringbootserversProperties
    {
        public SpringbootserversProperties(string server) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public System.Collections.Generic.IList<string> FqdnAndIPAddressList { get { throw null; } }
        public string MachineArmId { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        public string Server { get { throw null; } set { } }
        public int? SpringBootApps { get { throw null; } set { } }
        public int? TotalApps { get { throw null; } set { } }
    }
    public partial class SpringbootsitesModelExtendedLocation
    {
        public SpringbootsitesModelExtendedLocation() { }
        public string Name { get { throw null; } set { } }
        public string SpringbootsitesModelExtendedLocationType { get { throw null; } set { } }
    }
    public partial class SpringbootsitesModelPatch : Azure.ResourceManager.Models.TrackedResourceData
    {
        public SpringbootsitesModelPatch(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Offazurespringboot.Models.SpringbootsitesProperties Properties { get { throw null; } set { } }
    }
    public partial class SpringbootsitesProperties
    {
        public SpringbootsitesProperties() { }
        public string MasterSiteId { get { throw null; } set { } }
        public string MigrateProjectId { get { throw null; } set { } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
    }
    public partial class SummariesProperties
    {
        public SummariesProperties() { }
        public long? DiscoveredApps { get { throw null; } set { } }
        public long? DiscoveredServers { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Offazurespringboot.Models.Error> Errors { get { throw null; } }
        public Azure.ResourceManager.Offazurespringboot.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
    }
}
