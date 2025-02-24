namespace Azure.ResourceManager.Impact
{
    public partial class ConnectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Impact.ConnectorResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.ConnectorResource>, System.Collections.IEnumerable
    {
        protected ConnectorCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.ConnectorResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string connectorName, Azure.ResourceManager.Impact.ConnectorData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.ConnectorResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string connectorName, Azure.ResourceManager.Impact.ConnectorData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ConnectorResource> Get(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Impact.ConnectorResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Impact.ConnectorResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ConnectorResource>> GetAsync(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Impact.ConnectorResource> GetIfExists(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Impact.ConnectorResource>> GetIfExistsAsync(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Impact.ConnectorResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Impact.ConnectorResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Impact.ConnectorResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.ConnectorResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConnectorData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ConnectorData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>
    {
        public ConnectorData() { }
        public Azure.ResourceManager.Impact.Models.ConnectorProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.ConnectorData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ConnectorData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ConnectorData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.ConnectorData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectorResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ConnectorData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConnectorResource() { }
        public virtual Azure.ResourceManager.Impact.ConnectorData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string connectorName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ConnectorResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ConnectorResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Impact.ConnectorData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ConnectorData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ConnectorData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.ConnectorData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ConnectorData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ConnectorResource> Update(Azure.ResourceManager.Impact.Models.ConnectorPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ConnectorResource>> UpdateAsync(Azure.ResourceManager.Impact.Models.ConnectorPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ImpactCategoryCollection : Azure.ResourceManager.ArmCollection
    {
        protected ImpactCategoryCollection() { }
        public virtual Azure.Response<bool> Exists(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource> Get(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Impact.ImpactCategoryResource> GetAll(string resourceType, string categoryName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Impact.ImpactCategoryResource> GetAllAsync(string resourceType, string categoryName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource>> GetAsync(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Impact.ImpactCategoryResource> GetIfExists(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Impact.ImpactCategoryResource>> GetIfExistsAsync(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ImpactCategoryData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ImpactCategoryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>
    {
        internal ImpactCategoryData() { }
        public Azure.ResourceManager.Impact.Models.ImpactCategoryProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.ImpactCategoryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.ImpactCategoryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ImpactCategoryResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ImpactCategoryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ImpactCategoryResource() { }
        public virtual Azure.ResourceManager.Impact.ImpactCategoryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string impactCategoryName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Impact.ImpactCategoryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.ImpactCategoryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.ImpactCategoryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ImpactExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Impact.ConnectorResource> GetConnector(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ConnectorResource>> GetConnectorAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Impact.ConnectorResource GetConnectorResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Impact.ConnectorCollection GetConnectors(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
        public static Azure.ResourceManager.Impact.ImpactCategoryCollection GetImpactCategories(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource> GetImpactCategory(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource>> GetImpactCategoryAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Impact.ImpactCategoryResource GetImpactCategoryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Impact.InsightResource GetInsightResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource> GetWorkloadImpact(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource>> GetWorkloadImpactAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Impact.WorkloadImpactResource GetWorkloadImpactResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Impact.WorkloadImpactCollection GetWorkloadImpacts(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
    }
    public partial class InsightCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Impact.InsightResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.InsightResource>, System.Collections.IEnumerable
    {
        protected InsightCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.InsightResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string insightName, Azure.ResourceManager.Impact.InsightData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.InsightResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string insightName, Azure.ResourceManager.Impact.InsightData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.InsightResource> Get(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Impact.InsightResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Impact.InsightResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.InsightResource>> GetAsync(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Impact.InsightResource> GetIfExists(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Impact.InsightResource>> GetIfExistsAsync(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Impact.InsightResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Impact.InsightResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Impact.InsightResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.InsightResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class InsightData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.InsightData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>
    {
        public InsightData() { }
        public Azure.ResourceManager.Impact.Models.InsightProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.InsightData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.InsightData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.InsightData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.InsightData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class InsightResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.InsightData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected InsightResource() { }
        public virtual Azure.ResourceManager.Impact.InsightData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string workloadImpactName, string insightName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.InsightResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.InsightResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Impact.InsightData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.InsightData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.InsightData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.InsightData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.InsightData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.InsightResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Impact.InsightData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.InsightResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Impact.InsightData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WorkloadImpactCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Impact.WorkloadImpactResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.WorkloadImpactResource>, System.Collections.IEnumerable
    {
        protected WorkloadImpactCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.WorkloadImpactResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string workloadImpactName, Azure.ResourceManager.Impact.WorkloadImpactData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.WorkloadImpactResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string workloadImpactName, Azure.ResourceManager.Impact.WorkloadImpactData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource> Get(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Impact.WorkloadImpactResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Impact.WorkloadImpactResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource>> GetAsync(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Impact.WorkloadImpactResource> GetIfExists(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Impact.WorkloadImpactResource>> GetIfExistsAsync(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Impact.WorkloadImpactResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Impact.WorkloadImpactResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Impact.WorkloadImpactResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.WorkloadImpactResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class WorkloadImpactData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.WorkloadImpactData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>
    {
        public WorkloadImpactData() { }
        public Azure.ResourceManager.Impact.Models.WorkloadImpactProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.WorkloadImpactData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.WorkloadImpactData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WorkloadImpactResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.WorkloadImpactData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected WorkloadImpactResource() { }
        public virtual Azure.ResourceManager.Impact.WorkloadImpactData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string workloadImpactName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.InsightResource> GetInsight(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.InsightResource>> GetInsightAsync(string insightName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Impact.InsightCollection GetInsights() { throw null; }
        Azure.ResourceManager.Impact.WorkloadImpactData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.WorkloadImpactData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.WorkloadImpactData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.WorkloadImpactResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Impact.WorkloadImpactData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Impact.WorkloadImpactResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Impact.WorkloadImpactData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Impact.Mocking
{
    public partial class MockableImpactArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableImpactArmClient() { }
        public virtual Azure.ResourceManager.Impact.ConnectorResource GetConnectorResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Impact.ImpactCategoryResource GetImpactCategoryResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Impact.InsightResource GetInsightResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Impact.WorkloadImpactResource GetWorkloadImpactResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableImpactSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableImpactSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ConnectorResource> GetConnector(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ConnectorResource>> GetConnectorAsync(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Impact.ConnectorCollection GetConnectors() { throw null; }
        public virtual Azure.ResourceManager.Impact.ImpactCategoryCollection GetImpactCategories() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource> GetImpactCategory(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.ImpactCategoryResource>> GetImpactCategoryAsync(string impactCategoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource> GetWorkloadImpact(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Impact.WorkloadImpactResource>> GetWorkloadImpactAsync(string workloadImpactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Impact.WorkloadImpactCollection GetWorkloadImpacts() { throw null; }
    }
}
namespace Azure.ResourceManager.Impact.Models
{
    public static partial class ArmImpactModelFactory
    {
        public static Azure.ResourceManager.Impact.ConnectorData ConnectorData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Impact.Models.ConnectorProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Impact.Models.ConnectorProperties ConnectorProperties(Azure.ResourceManager.Impact.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Impact.Models.ProvisioningState?), string connectorId = null, string tenantId = null, Azure.ResourceManager.Impact.Models.Platform connectorType = default(Azure.ResourceManager.Impact.Models.Platform), System.DateTimeOffset lastRunTimeStamp = default(System.DateTimeOffset)) { throw null; }
        public static Azure.ResourceManager.Impact.ImpactCategoryData ImpactCategoryData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Impact.Models.ImpactCategoryProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Impact.Models.ImpactCategoryProperties ImpactCategoryProperties(Azure.ResourceManager.Impact.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Impact.Models.ProvisioningState?), string categoryId = null, string parentCategoryId = null, string description = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.Models.RequiredImpactProperties> requiredImpactProperties = null) { throw null; }
        public static Azure.ResourceManager.Impact.InsightData InsightData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Impact.Models.InsightProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Impact.Models.InsightProperties InsightProperties(Azure.ResourceManager.Impact.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Impact.Models.ProvisioningState?), string category = null, string status = null, string eventId = null, string groupId = null, Azure.ResourceManager.Impact.Models.Content content = null, System.DateTimeOffset? eventOn = default(System.DateTimeOffset?), string insightUniqueId = null, Azure.ResourceManager.Impact.Models.ImpactDetails impact = null, Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails additionalDetails = null) { throw null; }
        public static Azure.ResourceManager.Impact.Models.RequiredImpactProperties RequiredImpactProperties(string name = null, System.Collections.Generic.IEnumerable<string> allowedValues = null) { throw null; }
        public static Azure.ResourceManager.Impact.WorkloadImpactData WorkloadImpactData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Impact.Models.WorkloadImpactProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Impact.Models.WorkloadImpactProperties WorkloadImpactProperties(Azure.ResourceManager.Impact.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Impact.Models.ProvisioningState?), System.DateTimeOffset startOn = default(System.DateTimeOffset), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), string impactedResourceId = null, string impactUniqueId = null, System.DateTimeOffset? reportedTimeUtc = default(System.DateTimeOffset?), string impactCategory = null, string impactDescription = null, System.Collections.Generic.IEnumerable<string> armCorrelationIds = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Impact.Models.Performance> performance = null, Azure.ResourceManager.Impact.Models.Connectivity connectivity = null, Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties additionalProperties = null, Azure.ResourceManager.Impact.Models.ErrorDetailProperties errorDetails = null, Azure.ResourceManager.Impact.Models.Workload workload = null, string impactGroupId = null, Azure.ResourceManager.Impact.Models.ConfidenceLevel? confidenceLevel = default(Azure.ResourceManager.Impact.Models.ConfidenceLevel?), Azure.ResourceManager.Impact.Models.ClientIncidentDetails clientIncidentDetails = null) { throw null; }
    }
    public partial class ClientIncidentDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>
    {
        public ClientIncidentDetails() { }
        public string ClientIncidentId { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.IncidentSource? ClientIncidentSource { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ClientIncidentDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ClientIncidentDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ClientIncidentDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfidenceLevel : System.IEquatable<Azure.ResourceManager.Impact.Models.ConfidenceLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfidenceLevel(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.ConfidenceLevel High { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.ConfidenceLevel Low { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.ConfidenceLevel Medium { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.ConfidenceLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.ConfidenceLevel left, Azure.ResourceManager.Impact.Models.ConfidenceLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.ConfidenceLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.ConfidenceLevel left, Azure.ResourceManager.Impact.Models.ConfidenceLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Connectivity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Connectivity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Connectivity>
    {
        public Connectivity() { }
        public int? Port { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.Protocol? Protocol { get { throw null; } set { } }
        public string SourceAzureResourceId { get { throw null; } set { } }
        public string TargetAzureResourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Connectivity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Connectivity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Connectivity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Connectivity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Connectivity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Connectivity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Connectivity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectorPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>
    {
        public ConnectorPatch() { }
        public Azure.ResourceManager.Impact.Models.Platform? ConnectorType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ConnectorPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ConnectorPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectorProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>
    {
        public ConnectorProperties(string connectorId, string tenantId, Azure.ResourceManager.Impact.Models.Platform connectorType, System.DateTimeOffset lastRunTimeStamp) { }
        public string ConnectorId { get { throw null; } }
        public Azure.ResourceManager.Impact.Models.Platform ConnectorType { get { throw null; } set { } }
        public System.DateTimeOffset LastRunTimeStamp { get { throw null; } }
        public Azure.ResourceManager.Impact.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string TenantId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ConnectorProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ConnectorProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ConnectorProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Content : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Content>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Content>
    {
        public Content(string title, string description) { }
        public string Description { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Content System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Content>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Content>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Content System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Content>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Content>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Content>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorDetailProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>
    {
        public ErrorDetailProperties() { }
        public string ErrorCode { get { throw null; } set { } }
        public string ErrorMessage { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ErrorDetailProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ErrorDetailProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ErrorDetailProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExpectedValueRange : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>
    {
        public ExpectedValueRange(double min, double max) { }
        public double Max { get { throw null; } set { } }
        public double Min { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ExpectedValueRange System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ExpectedValueRange System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ExpectedValueRange>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ImpactCategoryProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>
    {
        internal ImpactCategoryProperties() { }
        public string CategoryId { get { throw null; } }
        public string Description { get { throw null; } }
        public string ParentCategoryId { get { throw null; } }
        public Azure.ResourceManager.Impact.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Impact.Models.RequiredImpactProperties> RequiredImpactProperties { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ImpactCategoryProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ImpactCategoryProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactCategoryProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ImpactDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ImpactDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactDetails>
    {
        public ImpactDetails(string impactedResourceId, System.DateTimeOffset startOn, string impactId) { }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public string ImpactedResourceId { get { throw null; } set { } }
        public string ImpactId { get { throw null; } set { } }
        public System.DateTimeOffset StartOn { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ImpactDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ImpactDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.ImpactDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.ImpactDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.ImpactDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IncidentSource : System.IEquatable<Azure.ResourceManager.Impact.Models.IncidentSource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IncidentSource(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.IncidentSource AzureDevops { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.IncidentSource ICM { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.IncidentSource Jira { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.IncidentSource Other { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.IncidentSource ServiceNow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.IncidentSource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.IncidentSource left, Azure.ResourceManager.Impact.Models.IncidentSource right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.IncidentSource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.IncidentSource left, Azure.ResourceManager.Impact.Models.IncidentSource right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InsightProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.InsightProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightProperties>
    {
        public InsightProperties(string category, Azure.ResourceManager.Impact.Models.Content content, string insightUniqueId, Azure.ResourceManager.Impact.Models.ImpactDetails impact) { }
        public Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails AdditionalDetails { get { throw null; } set { } }
        public string Category { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.Content Content { get { throw null; } set { } }
        public string EventId { get { throw null; } set { } }
        public System.DateTimeOffset? EventOn { get { throw null; } set { } }
        public string GroupId { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.ImpactDetails Impact { get { throw null; } set { } }
        public string InsightUniqueId { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string Status { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.InsightProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.InsightProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.InsightProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.InsightProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class InsightPropertiesAdditionalDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>
    {
        public InsightPropertiesAdditionalDetails() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.InsightPropertiesAdditionalDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MetricUnit : System.IEquatable<Azure.ResourceManager.Impact.Models.MetricUnit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MetricUnit(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.MetricUnit Bytes { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit ByteSeconds { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit BytesPerSecond { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit Cores { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit Count { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit CountPerSecond { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit MilliCores { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit MilliSeconds { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit NanoCores { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit Other { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit Percent { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.MetricUnit Seconds { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.MetricUnit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.MetricUnit left, Azure.ResourceManager.Impact.Models.MetricUnit right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.MetricUnit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.MetricUnit left, Azure.ResourceManager.Impact.Models.MetricUnit right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Performance : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Performance>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Performance>
    {
        public Performance() { }
        public double? Actual { get { throw null; } set { } }
        public double? Expected { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.ExpectedValueRange ExpectedValueRange { get { throw null; } set { } }
        public string MetricName { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.MetricUnit? Unit { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Performance System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Performance>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Performance>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Performance System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Performance>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Performance>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Performance>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Platform : System.IEquatable<Azure.ResourceManager.Impact.Models.Platform>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Platform(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.Platform AzureMonitor { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.Platform other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.Platform left, Azure.ResourceManager.Impact.Models.Platform right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.Platform (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.Platform left, Azure.ResourceManager.Impact.Models.Platform right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Protocol : System.IEquatable<Azure.ResourceManager.Impact.Models.Protocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Protocol(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.Protocol FTP { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol HTTP { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol HTTPS { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol Other { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol RDP { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol SSH { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol TCP { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Protocol UDP { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.Protocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.Protocol left, Azure.ResourceManager.Impact.Models.Protocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.Protocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.Protocol left, Azure.ResourceManager.Impact.Models.Protocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Impact.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.ProvisioningState left, Azure.ResourceManager.Impact.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.ProvisioningState left, Azure.ResourceManager.Impact.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequiredImpactProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>
    {
        internal RequiredImpactProperties() { }
        public System.Collections.Generic.IReadOnlyList<string> AllowedValues { get { throw null; } }
        public string Name { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.RequiredImpactProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.RequiredImpactProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.RequiredImpactProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Toolset : System.IEquatable<Azure.ResourceManager.Impact.Models.Toolset>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Toolset(string value) { throw null; }
        public static Azure.ResourceManager.Impact.Models.Toolset Ansible { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset ARM { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset Chef { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset Other { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset Portal { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset Puppet { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset SDK { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset Shell { get { throw null; } }
        public static Azure.ResourceManager.Impact.Models.Toolset Terraform { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Impact.Models.Toolset other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Impact.Models.Toolset left, Azure.ResourceManager.Impact.Models.Toolset right) { throw null; }
        public static implicit operator Azure.ResourceManager.Impact.Models.Toolset (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Impact.Models.Toolset left, Azure.ResourceManager.Impact.Models.Toolset right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Workload : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Workload>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Workload>
    {
        public Workload() { }
        public string Context { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.Toolset? Toolset { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Workload System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Workload>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.Workload>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.Workload System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Workload>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Workload>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.Workload>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WorkloadImpactProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>
    {
        public WorkloadImpactProperties(System.DateTimeOffset startOn, string impactedResourceId, string impactCategory) { }
        public Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties AdditionalProperties { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ArmCorrelationIds { get { throw null; } }
        public Azure.ResourceManager.Impact.Models.ClientIncidentDetails ClientIncidentDetails { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.ConfidenceLevel? ConfidenceLevel { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.Connectivity Connectivity { get { throw null; } set { } }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.ErrorDetailProperties ErrorDetails { get { throw null; } set { } }
        public string ImpactCategory { get { throw null; } set { } }
        public string ImpactDescription { get { throw null; } set { } }
        public string ImpactedResourceId { get { throw null; } set { } }
        public string ImpactGroupId { get { throw null; } set { } }
        public string ImpactUniqueId { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Impact.Models.Performance> Performance { get { throw null; } }
        public Azure.ResourceManager.Impact.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.DateTimeOffset? ReportedTimeUtc { get { throw null; } }
        public System.DateTimeOffset StartOn { get { throw null; } set { } }
        public Azure.ResourceManager.Impact.Models.Workload Workload { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.WorkloadImpactProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.WorkloadImpactProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WorkloadImpactPropertiesAdditionalProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>
    {
        public WorkloadImpactPropertiesAdditionalProperties() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Impact.Models.WorkloadImpactPropertiesAdditionalProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
