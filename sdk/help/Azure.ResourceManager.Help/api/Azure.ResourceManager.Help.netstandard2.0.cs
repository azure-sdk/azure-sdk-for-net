namespace Azure.ResourceManager.Help
{
    public partial class AzureResourceManagerHelpContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerHelpContext() { }
        public static Azure.ResourceManager.Help.AzureResourceManagerHelpContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class DiagnosticResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.DiagnosticResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DiagnosticResource() { }
        public virtual Azure.ResourceManager.Help.DiagnosticResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope, string diagnosticsResourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.DiagnosticResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.DiagnosticResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Help.DiagnosticResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.DiagnosticResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.DiagnosticResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.DiagnosticResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.DiagnosticResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.DiagnosticResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DiagnosticResourceCollection : Azure.ResourceManager.ArmCollection
    {
        protected DiagnosticResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.DiagnosticResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string diagnosticsResourceName, Azure.ResourceManager.Help.DiagnosticResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.DiagnosticResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string diagnosticsResourceName, Azure.ResourceManager.Help.DiagnosticResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.DiagnosticResource> Get(string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.DiagnosticResource>> GetAsync(string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Help.DiagnosticResource> GetIfExists(string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Help.DiagnosticResource>> GetIfExistsAsync(string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DiagnosticResourceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.DiagnosticResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>
    {
        public DiagnosticResourceData() { }
        public string AcceptedAt { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Diagnostic> Diagnostics { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> GlobalParameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Help.Models.DiagnosticInvocation> Insights { get { throw null; } }
        public Azure.ResourceManager.Help.Models.DiagnosticProvisioningState? ProvisioningState { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.DiagnosticResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.DiagnosticResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.DiagnosticResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class HelpExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult> CheckAvailabilityCheckNameAvailabilityOperationGroup(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>> CheckAvailabilityCheckNameAvailabilityOperationGroupAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsBySubscriptionDiscoverySolutionNLPOperationGroups(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsBySubscriptionDiscoverySolutionNLPOperationGroupsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsDiscoverySolutionNLPOperationGroups(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsDiscoverySolutionNLPOperationGroupsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.DiagnosticResource GetDiagnosticResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Help.DiagnosticResource> GetDiagnosticResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.DiagnosticResource>> GetDiagnosticResourceAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.DiagnosticResourceCollection GetDiagnosticResources(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Help.Models.SolutionMetadataResource> GetDiscoverySolutionOperationGroups(this Azure.ResourceManager.Resources.TenantResource tenantResource, string filter = null, string skiptoken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Help.Models.SolutionMetadataResource> GetDiscoverySolutionOperationGroupsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string filter = null, string skiptoken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.SimplifiedSolutionsResource GetSimplifiedSolutionsResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource> GetSimplifiedSolutionsResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> GetSimplifiedSolutionsResourceAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.SimplifiedSolutionsResourceCollection GetSimplifiedSolutionsResources(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
        public static Azure.ResourceManager.Help.SolutionResource GetSolutionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Help.SolutionResource> GetSolutionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResource>> GetSolutionResourceAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.SolutionResourceCollection GetSolutionResources(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource> GetSolutionResourceSelfHelp(this Azure.ResourceManager.Resources.TenantResource tenantResource, string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource>> GetSolutionResourceSelfHelpAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.SolutionResourceSelfHelpResource GetSolutionResourceSelfHelpResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Help.SolutionResourceSelfHelpCollection GetSolutionResourceSelfHelps(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.Help.TroubleshooterResource GetTroubleshooterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource> GetTroubleshooterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource>> GetTroubleshooterResourceAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Help.TroubleshooterResourceCollection GetTroubleshooterResources(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
    }
    public partial class SimplifiedSolutionsResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SimplifiedSolutionsResource() { }
        public virtual Azure.ResourceManager.Help.SimplifiedSolutionsResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope, string simplifiedSolutionsResourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Help.SimplifiedSolutionsResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SimplifiedSolutionsResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SimplifiedSolutionsResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.SimplifiedSolutionsResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.SimplifiedSolutionsResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SimplifiedSolutionsResourceCollection : Azure.ResourceManager.ArmCollection
    {
        protected SimplifiedSolutionsResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SimplifiedSolutionsResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string simplifiedSolutionsResourceName, Azure.ResourceManager.Help.SimplifiedSolutionsResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string simplifiedSolutionsResourceName, Azure.ResourceManager.Help.SimplifiedSolutionsResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource> Get(string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> GetAsync(string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Help.SimplifiedSolutionsResource> GetIfExists(string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> GetIfExistsAsync(string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SimplifiedSolutionsResourceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>
    {
        public SimplifiedSolutionsResourceData() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Appendix { get { throw null; } }
        public string Content { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Parameters { get { throw null; } }
        public Azure.ResourceManager.Help.Models.SolutionProvisioningState? ProvisioningState { get { throw null; } }
        public string SolutionId { get { throw null; } set { } }
        public string Title { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SimplifiedSolutionsResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SimplifiedSolutionsResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SimplifiedSolutionsResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SolutionResource() { }
        public virtual Azure.ResourceManager.Help.SolutionResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope, string solutionResourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SolutionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Help.SolutionResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SolutionResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SolutionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.Models.SolutionResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SolutionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.Models.SolutionResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response WarmUp(Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody solutionWarmUpRequestBody = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> WarmUpAsync(Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody solutionWarmUpRequestBody = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SolutionResourceCollection : Azure.ResourceManager.ArmCollection
    {
        protected SolutionResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SolutionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string solutionResourceName, Azure.ResourceManager.Help.SolutionResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.SolutionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string solutionResourceName, Azure.ResourceManager.Help.SolutionResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SolutionResource> Get(string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResource>> GetAsync(string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Help.SolutionResource> GetIfExists(string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Help.SolutionResource>> GetIfExistsAsync(string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SolutionResourceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>
    {
        public SolutionResourceData() { }
        public string Content { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Parameters { get { throw null; } }
        public Azure.ResourceManager.Help.Models.SolutionProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ReplacementMaps ReplacementMaps { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Section> Sections { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public string Title { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Help.Models.TriggerCriterion> TriggerCriteria { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SolutionResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SolutionResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionResourceSelfHelpCollection : Azure.ResourceManager.ArmCollection
    {
        protected SolutionResourceSelfHelpCollection() { }
        public virtual Azure.Response<bool> Exists(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource> Get(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource>> GetAsync(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource> GetIfExists(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource>> GetIfExistsAsync(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SolutionResourceSelfHelpData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>
    {
        internal SolutionResourceSelfHelpData() { }
        public string Content { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp ReplacementMaps { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.SectionSelfHelp> Sections { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public string Title { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SolutionResourceSelfHelpData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SolutionResourceSelfHelpData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionResourceSelfHelpResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SolutionResourceSelfHelpResource() { }
        public virtual Azure.ResourceManager.Help.SolutionResourceSelfHelpData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string solutionId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Help.SolutionResourceSelfHelpData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.SolutionResourceSelfHelpData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.SolutionResourceSelfHelpData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TroubleshooterResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.TroubleshooterResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TroubleshooterResource() { }
        public virtual Azure.ResourceManager.Help.TroubleshooterResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response Continue(Azure.ResourceManager.Help.Models.ContinueRequestBody continueRequestBody = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ContinueAsync(Azure.ResourceManager.Help.Models.ContinueRequestBody continueRequestBody = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope, string troubleshooterName) { throw null; }
        public virtual Azure.Response End(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> EndAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult> Restart(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>> RestartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Help.TroubleshooterResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.TroubleshooterResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.TroubleshooterResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.TroubleshooterResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.TroubleshooterResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Help.TroubleshooterResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TroubleshooterResourceCollection : Azure.ResourceManager.ArmCollection
    {
        protected TroubleshooterResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.TroubleshooterResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string troubleshooterName, Azure.ResourceManager.Help.TroubleshooterResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Help.TroubleshooterResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string troubleshooterName, Azure.ResourceManager.Help.TroubleshooterResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource> Get(string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource>> GetAsync(string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Help.TroubleshooterResource> GetIfExists(string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Help.TroubleshooterResource>> GetIfExistsAsync(string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TroubleshooterResourceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.TroubleshooterResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>
    {
        public TroubleshooterResourceData() { }
        public System.Collections.Generic.IDictionary<string, string> Parameters { get { throw null; } }
        public Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState? ProvisioningState { get { throw null; } }
        public string SolutionId { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Step> Steps { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.TroubleshooterResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.TroubleshooterResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.TroubleshooterResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.Help.Mocking
{
    public partial class MockableHelpArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableHelpArmClient() { }
        public virtual Azure.Response<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult> CheckAvailabilityCheckNameAvailabilityOperationGroup(Azure.Core.ResourceIdentifier scope, Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>> CheckAvailabilityCheckNameAvailabilityOperationGroupAsync(Azure.Core.ResourceIdentifier scope, Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Help.DiagnosticResource GetDiagnosticResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.DiagnosticResource> GetDiagnosticResource(Azure.Core.ResourceIdentifier scope, string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.DiagnosticResource>> GetDiagnosticResourceAsync(Azure.Core.ResourceIdentifier scope, string diagnosticsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Help.DiagnosticResourceCollection GetDiagnosticResources(Azure.Core.ResourceIdentifier scope) { throw null; }
        public virtual Azure.ResourceManager.Help.SimplifiedSolutionsResource GetSimplifiedSolutionsResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource> GetSimplifiedSolutionsResource(Azure.Core.ResourceIdentifier scope, string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SimplifiedSolutionsResource>> GetSimplifiedSolutionsResourceAsync(Azure.Core.ResourceIdentifier scope, string simplifiedSolutionsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Help.SimplifiedSolutionsResourceCollection GetSimplifiedSolutionsResources(Azure.Core.ResourceIdentifier scope) { throw null; }
        public virtual Azure.ResourceManager.Help.SolutionResource GetSolutionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SolutionResource> GetSolutionResource(Azure.Core.ResourceIdentifier scope, string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResource>> GetSolutionResourceAsync(Azure.Core.ResourceIdentifier scope, string solutionResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Help.SolutionResourceCollection GetSolutionResources(Azure.Core.ResourceIdentifier scope) { throw null; }
        public virtual Azure.ResourceManager.Help.SolutionResourceSelfHelpResource GetSolutionResourceSelfHelpResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Help.TroubleshooterResource GetTroubleshooterResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource> GetTroubleshooterResource(Azure.Core.ResourceIdentifier scope, string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.TroubleshooterResource>> GetTroubleshooterResourceAsync(Azure.Core.ResourceIdentifier scope, string troubleshooterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Help.TroubleshooterResourceCollection GetTroubleshooterResources(Azure.Core.ResourceIdentifier scope) { throw null; }
    }
    public partial class MockableHelpSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHelpSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsBySubscriptionDiscoverySolutionNLPOperationGroups(Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsBySubscriptionDiscoverySolutionNLPOperationGroupsAsync(Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MockableHelpTenantResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHelpTenantResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsDiscoverySolutionNLPOperationGroups(Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource> DiscoverSolutionsDiscoverySolutionNLPOperationGroupsAsync(Azure.ResourceManager.Help.Models.DiscoveryNlpContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Help.Models.SolutionMetadataResource> GetDiscoverySolutionOperationGroups(string filter = null, string skiptoken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Help.Models.SolutionMetadataResource> GetDiscoverySolutionOperationGroupsAsync(string filter = null, string skiptoken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource> GetSolutionResourceSelfHelp(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Help.SolutionResourceSelfHelpResource>> GetSolutionResourceSelfHelpAsync(string solutionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Help.SolutionResourceSelfHelpCollection GetSolutionResourceSelfHelps() { throw null; }
    }
}
namespace Azure.ResourceManager.Help.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AggregationType : System.IEquatable<Azure.ResourceManager.Help.Models.AggregationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AggregationType(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.AggregationType Avg { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AggregationType Count { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AggregationType Max { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AggregationType Min { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AggregationType Sum { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.AggregationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.AggregationType left, Azure.ResourceManager.Help.Models.AggregationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.AggregationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.AggregationType left, Azure.ResourceManager.Help.Models.AggregationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmHelpModelFactory
    {
        public static Azure.ResourceManager.Help.Models.AutomatedCheckResult AutomatedCheckResult(string version = null, string status = null, string result = null, Azure.ResourceManager.Help.Models.AutomatedCheckResultType? type = default(Azure.ResourceManager.Help.Models.AutomatedCheckResultType?)) { throw null; }
        public static Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult CheckNameAvailabilityResult(bool? nameAvailable = default(bool?), string reason = null, string message = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.ClassificationService ClassificationService(Azure.Core.ResourceIdentifier serviceId = null, string displayName = null, System.Collections.Generic.IEnumerable<string> resourceTypes = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Diagnostic Diagnostic(string solutionId = null, Azure.ResourceManager.Help.Models.Status? status = default(Azure.ResourceManager.Help.Models.Status?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Insight> insights = null, Azure.ResourceManager.Help.Models.Error error = null) { throw null; }
        public static Azure.ResourceManager.Help.DiagnosticResourceData DiagnosticResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> globalParameters = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.DiagnosticInvocation> insights = null, string acceptedAt = null, Azure.ResourceManager.Help.Models.DiagnosticProvisioningState? provisioningState = default(Azure.ResourceManager.Help.Models.DiagnosticProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Diagnostic> diagnostics = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.DiscoveryNlpContent DiscoveryNlpContent(string issueSummary = null, string resourceId = null, string serviceId = null, string additionalContext = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Error Error(string code = null, string type = null, string message = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Error> details = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Filter Filter(string name = null, string values = null, string @operator = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Insight Insight(string id = null, string title = null, string results = null, Azure.ResourceManager.Help.Models.ImportanceLevel? importanceLevel = default(Azure.ResourceManager.Help.Models.ImportanceLevel?)) { throw null; }
        public static Azure.ResourceManager.Help.Models.MetricsBasedChart MetricsBasedChart(string name = null, Azure.ResourceManager.Help.Models.AggregationType? aggregationType = default(Azure.ResourceManager.Help.Models.AggregationType?), string timeSpanDuration = null, string title = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Filter> filter = null, string replacementKey = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.ReplacementMaps ReplacementMaps(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.WebResult> webResults = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.SolutionsDiagnostic> diagnostics = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters> troubleshooters = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.MetricsBasedChart> metricsBasedCharts = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Video> videos = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.VideoGroup> videoGroups = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp ReplacementMapsSelfHelp(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.WebResult> webResults = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Video> videos = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.VideoGroup> videoGroups = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.ResponseConfig ResponseConfig(string key = null, string value = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.ResponseValidationProperties ResponseValidationProperties(string regex = null, Azure.ResourceManager.Help.Models.ValidationScope? validationScope = default(Azure.ResourceManager.Help.Models.ValidationScope?), bool? isRequired = default(bool?), string validationErrorMessage = null, long? maxLength = default(long?)) { throw null; }
        public static Azure.ResourceManager.Help.Models.RestartTroubleshooterResult RestartTroubleshooterResult(string troubleshooterResourceName = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SearchResult SearchResult(string solutionId = null, string content = null, string title = null, Azure.ResourceManager.Help.Models.Confidence? confidence = default(Azure.ResourceManager.Help.Models.Confidence?), string source = null, Azure.ResourceManager.Help.Models.ResultType? resultType = default(Azure.ResourceManager.Help.Models.ResultType?), int? rank = default(int?), string link = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Section Section(string title = null, string content = null, Azure.ResourceManager.Help.Models.ReplacementMaps replacementMaps = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SectionSelfHelp SectionSelfHelp(string title = null, string content = null, Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp replacementMaps = null) { throw null; }
        public static Azure.ResourceManager.Help.SimplifiedSolutionsResourceData SimplifiedSolutionsResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string solutionId = null, System.Collections.Generic.IDictionary<string, string> parameters = null, string title = null, System.Collections.Generic.IReadOnlyDictionary<string, string> appendix = null, string content = null, Azure.ResourceManager.Help.Models.SolutionProvisioningState? provisioningState = default(Azure.ResourceManager.Help.Models.SolutionProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionMetadataProperties SolutionMetadataProperties(string solutionId = null, Azure.ResourceManager.Help.Models.SolutionType? solutionType = default(Azure.ResourceManager.Help.Models.SolutionType?), string description = null, System.Collections.Generic.IEnumerable<string> requiredInputs = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionMetadataResource SolutionMetadataResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.SolutionMetadataProperties> solutions = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource SolutionNlpMetadataResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string problemTitle = null, string problemDescription = null, string serviceId = null, string problemClassificationId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.SolutionMetadataProperties> solutions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.ClassificationService> relatedServices = null) { throw null; }
        public static Azure.ResourceManager.Help.SolutionResourceData SolutionResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.TriggerCriterion> triggerCriteria = null, System.Collections.Generic.IDictionary<string, string> parameters = null, string solutionId = null, Azure.ResourceManager.Help.Models.SolutionProvisioningState? provisioningState = default(Azure.ResourceManager.Help.Models.SolutionProvisioningState?), string title = null, string content = null, Azure.ResourceManager.Help.Models.ReplacementMaps replacementMaps = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Section> sections = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionResourcePatch SolutionResourcePatch(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.TriggerCriterion> triggerCriteria = null, System.Collections.Generic.IDictionary<string, string> parameters = null, string solutionId = null, Azure.ResourceManager.Help.Models.SolutionProvisioningState? provisioningState = default(Azure.ResourceManager.Help.Models.SolutionProvisioningState?), string title = null, string content = null, Azure.ResourceManager.Help.Models.ReplacementMaps replacementMaps = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Section> sections = null) { throw null; }
        public static Azure.ResourceManager.Help.SolutionResourceSelfHelpData SolutionResourceSelfHelpData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string solutionId = null, string title = null, string content = null, Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp replacementMaps = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.SectionSelfHelp> sections = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionsDiagnostic SolutionsDiagnostic(string solutionId = null, Azure.ResourceManager.Help.Models.Status? status = default(Azure.ResourceManager.Help.Models.Status?), string statusDetails = null, string replacementKey = null, string estimatedCompletionTime = null, System.Collections.Generic.IEnumerable<string> requiredParameters = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Insight> insights = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionsTroubleshooters SolutionsTroubleshooters(string solutionId = null, string title = null, string summary = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Step Step(string id = null, string title = null, string description = null, string guidance = null, Azure.ResourceManager.Help.Models.ExecutionStatus? executionStatus = default(Azure.ResourceManager.Help.Models.ExecutionStatus?), string executionStatusDescription = null, Azure.ResourceManager.Help.Models.Type? type = default(Azure.ResourceManager.Help.Models.Type?), bool? isLastStep = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.StepInput> inputs = null, Azure.ResourceManager.Help.Models.AutomatedCheckResult automatedCheckResults = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Insight> insights = null, Azure.ResponseError error = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.StepInput StepInput(string questionId = null, Azure.ResourceManager.Help.Models.QuestionType? questionType = default(Azure.ResourceManager.Help.Models.QuestionType?), string questionTitle = null, string questionContent = null, Azure.ResourceManager.Help.Models.QuestionContentType? questionContentType = default(Azure.ResourceManager.Help.Models.QuestionContentType?), string responseHint = null, string recommendedOption = null, string selectedOptionValue = null, Azure.ResourceManager.Help.Models.ResponseValidationProperties responseValidationProperties = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.ResponseConfig> responseOptions = null) { throw null; }
        public static Azure.ResourceManager.Help.TroubleshooterResourceData TroubleshooterResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string solutionId = null, System.Collections.Generic.IDictionary<string, string> parameters = null, Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState? provisioningState = default(Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.Step> steps = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.Video Video(string src = null, string title = null, string replacementKey = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.VideoGroup VideoGroup(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.VideoGroupVideo> videos = null, string replacementKey = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.VideoGroupVideo VideoGroupVideo(string src = null, string title = null) { throw null; }
        public static Azure.ResourceManager.Help.Models.WebResult WebResult(string replacementKey = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Help.Models.SearchResult> searchResults = null) { throw null; }
    }
    public partial class AutomatedCheckResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>
    {
        internal AutomatedCheckResult() { }
        public string Result { get { throw null; } }
        public string Status { get { throw null; } }
        public Azure.ResourceManager.Help.Models.AutomatedCheckResultType? Type { get { throw null; } }
        public string Version { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.AutomatedCheckResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.AutomatedCheckResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.AutomatedCheckResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutomatedCheckResultType : System.IEquatable<Azure.ResourceManager.Help.Models.AutomatedCheckResultType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutomatedCheckResultType(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.AutomatedCheckResultType Error { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AutomatedCheckResultType Information { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AutomatedCheckResultType Success { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.AutomatedCheckResultType Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.AutomatedCheckResultType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.AutomatedCheckResultType left, Azure.ResourceManager.Help.Models.AutomatedCheckResultType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.AutomatedCheckResultType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.AutomatedCheckResultType left, Azure.ResourceManager.Help.Models.AutomatedCheckResultType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CheckNameAvailabilityContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>
    {
        public CheckNameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CheckNameAvailabilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>
    {
        internal CheckNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public string Reason { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.CheckNameAvailabilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClassificationService : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ClassificationService>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ClassificationService>
    {
        internal ClassificationService() { }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ResourceTypes { get { throw null; } }
        public Azure.Core.ResourceIdentifier ServiceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ClassificationService System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ClassificationService>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ClassificationService>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ClassificationService System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ClassificationService>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ClassificationService>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ClassificationService>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Confidence : System.IEquatable<Azure.ResourceManager.Help.Models.Confidence>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Confidence(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.Confidence High { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Confidence Low { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Confidence Medium { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.Confidence other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.Confidence left, Azure.ResourceManager.Help.Models.Confidence right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.Confidence (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.Confidence left, Azure.ResourceManager.Help.Models.Confidence right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContinueRequestBody : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>
    {
        public ContinueRequestBody() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Help.Models.TroubleshooterResult> Responses { get { throw null; } }
        public string StepId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ContinueRequestBody System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ContinueRequestBody System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ContinueRequestBody>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Diagnostic : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Diagnostic>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Diagnostic>
    {
        internal Diagnostic() { }
        public Azure.ResourceManager.Help.Models.Error Error { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Insight> Insights { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public Azure.ResourceManager.Help.Models.Status? Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Diagnostic System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Diagnostic>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Diagnostic>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Diagnostic System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Diagnostic>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Diagnostic>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Diagnostic>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DiagnosticInvocation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>
    {
        public DiagnosticInvocation() { }
        public System.Collections.Generic.IDictionary<string, string> AdditionalParameters { get { throw null; } }
        public string SolutionId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.DiagnosticInvocation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.DiagnosticInvocation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiagnosticInvocation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiagnosticProvisioningState : System.IEquatable<Azure.ResourceManager.Help.Models.DiagnosticProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiagnosticProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.DiagnosticProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.DiagnosticProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.DiagnosticProvisioningState PartialComplete { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.DiagnosticProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.DiagnosticProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.DiagnosticProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.DiagnosticProvisioningState left, Azure.ResourceManager.Help.Models.DiagnosticProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.DiagnosticProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.DiagnosticProvisioningState left, Azure.ResourceManager.Help.Models.DiagnosticProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiscoveryNlpContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>
    {
        public DiscoveryNlpContent(string issueSummary) { }
        public string AdditionalContext { get { throw null; } set { } }
        public string IssueSummary { get { throw null; } }
        public string ResourceId { get { throw null; } set { } }
        public string ServiceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.DiscoveryNlpContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.DiscoveryNlpContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.DiscoveryNlpContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Error : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Error>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Error>
    {
        internal Error() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Error> Details { get { throw null; } }
        public string Message { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Error System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Error>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Error>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Error System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Error>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Error>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Error>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ExecutionStatus : System.IEquatable<Azure.ResourceManager.Help.Models.ExecutionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ExecutionStatus(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.ExecutionStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ExecutionStatus Running { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ExecutionStatus Success { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ExecutionStatus Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.ExecutionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.ExecutionStatus left, Azure.ResourceManager.Help.Models.ExecutionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.ExecutionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.ExecutionStatus left, Azure.ResourceManager.Help.Models.ExecutionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Filter : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Filter>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Filter>
    {
        internal Filter() { }
        public string Name { get { throw null; } }
        public string Operator { get { throw null; } }
        public string Values { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Filter System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Filter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Filter>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Filter System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Filter>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Filter>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Filter>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ImportanceLevel : System.IEquatable<Azure.ResourceManager.Help.Models.ImportanceLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ImportanceLevel(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.ImportanceLevel Critical { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ImportanceLevel Information { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ImportanceLevel Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.ImportanceLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.ImportanceLevel left, Azure.ResourceManager.Help.Models.ImportanceLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.ImportanceLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.ImportanceLevel left, Azure.ResourceManager.Help.Models.ImportanceLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Insight : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Insight>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Insight>
    {
        internal Insight() { }
        public string Id { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ImportanceLevel? ImportanceLevel { get { throw null; } }
        public string Results { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Insight System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Insight>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Insight>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Insight System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Insight>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Insight>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Insight>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MetricsBasedChart : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>
    {
        internal MetricsBasedChart() { }
        public Azure.ResourceManager.Help.Models.AggregationType? AggregationType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Filter> Filter { get { throw null; } }
        public string Name { get { throw null; } }
        public string ReplacementKey { get { throw null; } }
        public string TimeSpanDuration { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.MetricsBasedChart System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.MetricsBasedChart System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.MetricsBasedChart>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Name : System.IEquatable<Azure.ResourceManager.Help.Models.Name>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Name(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.Name ProblemClassificationId { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Name ReplacementKey { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Name SolutionId { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.Name other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.Name left, Azure.ResourceManager.Help.Models.Name right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.Name (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.Name left, Azure.ResourceManager.Help.Models.Name right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QuestionContentType : System.IEquatable<Azure.ResourceManager.Help.Models.QuestionContentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QuestionContentType(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.QuestionContentType Html { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionContentType Markdown { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionContentType Text { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.QuestionContentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.QuestionContentType left, Azure.ResourceManager.Help.Models.QuestionContentType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.QuestionContentType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.QuestionContentType left, Azure.ResourceManager.Help.Models.QuestionContentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QuestionType : System.IEquatable<Azure.ResourceManager.Help.Models.QuestionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QuestionType(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.QuestionType DateTimePicker { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionType Dropdown { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionType MultiLineInfoBox { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionType MultiSelect { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionType RadioButton { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.QuestionType TextInput { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.QuestionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.QuestionType left, Azure.ResourceManager.Help.Models.QuestionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.QuestionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.QuestionType left, Azure.ResourceManager.Help.Models.QuestionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ReplacementMaps : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ReplacementMaps>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMaps>
    {
        internal ReplacementMaps() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.SolutionsDiagnostic> Diagnostics { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.MetricsBasedChart> MetricsBasedCharts { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters> Troubleshooters { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.VideoGroup> VideoGroups { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Video> Videos { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.WebResult> WebResults { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ReplacementMaps System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ReplacementMaps>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ReplacementMaps>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ReplacementMaps System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMaps>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMaps>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMaps>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReplacementMapsSelfHelp : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>
    {
        internal ReplacementMapsSelfHelp() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.VideoGroup> VideoGroups { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Video> Videos { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.WebResult> WebResults { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResponseConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ResponseConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseConfig>
    {
        internal ResponseConfig() { }
        public string Key { get { throw null; } }
        public string Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ResponseConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ResponseConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ResponseConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ResponseConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResponseValidationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>
    {
        internal ResponseValidationProperties() { }
        public bool? IsRequired { get { throw null; } }
        public long? MaxLength { get { throw null; } }
        public string Regex { get { throw null; } }
        public string ValidationErrorMessage { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ValidationScope? ValidationScope { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ResponseValidationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.ResponseValidationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.ResponseValidationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RestartTroubleshooterResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>
    {
        internal RestartTroubleshooterResult() { }
        public string TroubleshooterResourceName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.RestartTroubleshooterResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.RestartTroubleshooterResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.RestartTroubleshooterResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResultType : System.IEquatable<Azure.ResourceManager.Help.Models.ResultType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResultType(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.ResultType Community { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ResultType Documentation { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.ResultType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.ResultType left, Azure.ResourceManager.Help.Models.ResultType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.ResultType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.ResultType left, Azure.ResourceManager.Help.Models.ResultType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SearchResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SearchResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SearchResult>
    {
        internal SearchResult() { }
        public Azure.ResourceManager.Help.Models.Confidence? Confidence { get { throw null; } }
        public string Content { get { throw null; } }
        public string Link { get { throw null; } }
        public int? Rank { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ResultType? ResultType { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public string Source { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SearchResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SearchResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SearchResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SearchResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SearchResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SearchResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SearchResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Section : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Section>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Section>
    {
        internal Section() { }
        public string Content { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ReplacementMaps ReplacementMaps { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Section System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Section>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Section>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Section System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Section>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Section>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Section>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SectionSelfHelp : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>
    {
        internal SectionSelfHelp() { }
        public string Content { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ReplacementMapsSelfHelp ReplacementMaps { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SectionSelfHelp System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SectionSelfHelp System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SectionSelfHelp>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionMetadataProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>
    {
        internal SolutionMetadataProperties() { }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredInputs { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public Azure.ResourceManager.Help.Models.SolutionType? SolutionType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionMetadataProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionMetadataProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionMetadataResource : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>
    {
        internal SolutionMetadataResource() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.SolutionMetadataProperties> Solutions { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionMetadataResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionMetadataResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionMetadataResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionNlpMetadataResource : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>
    {
        internal SolutionNlpMetadataResource() { }
        public string ProblemClassificationId { get { throw null; } }
        public string ProblemDescription { get { throw null; } }
        public string ProblemTitle { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.ClassificationService> RelatedServices { get { throw null; } }
        public string ServiceId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.SolutionMetadataProperties> Solutions { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionNlpMetadataResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SolutionProvisioningState : System.IEquatable<Azure.ResourceManager.Help.Models.SolutionProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SolutionProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionProvisioningState PartialComplete { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.SolutionProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.SolutionProvisioningState left, Azure.ResourceManager.Help.Models.SolutionProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.SolutionProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.SolutionProvisioningState left, Azure.ResourceManager.Help.Models.SolutionProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SolutionResourcePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>
    {
        public SolutionResourcePatch() { }
        public string Content { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Parameters { get { throw null; } }
        public Azure.ResourceManager.Help.Models.SolutionProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ReplacementMaps ReplacementMaps { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Section> Sections { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public string Title { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Help.Models.TriggerCriterion> TriggerCriteria { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionResourcePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionResourcePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionResourcePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionsDiagnostic : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>
    {
        internal SolutionsDiagnostic() { }
        public string EstimatedCompletionTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Insight> Insights { get { throw null; } }
        public string ReplacementKey { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredParameters { get { throw null; } }
        public string SolutionId { get { throw null; } }
        public Azure.ResourceManager.Help.Models.Status? Status { get { throw null; } }
        public string StatusDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionsDiagnostic System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionsDiagnostic System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsDiagnostic>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SolutionsTroubleshooters : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>
    {
        internal SolutionsTroubleshooters() { }
        public string SolutionId { get { throw null; } }
        public string Summary { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionsTroubleshooters System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionsTroubleshooters System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionsTroubleshooters>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SolutionType : System.IEquatable<Azure.ResourceManager.Help.Models.SolutionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SolutionType(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.SolutionType Diagnostics { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionType SelfHelp { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionType Solutions { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.SolutionType Troubleshooters { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.SolutionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.SolutionType left, Azure.ResourceManager.Help.Models.SolutionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.SolutionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.SolutionType left, Azure.ResourceManager.Help.Models.SolutionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SolutionWarmUpRequestBody : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>
    {
        public SolutionWarmUpRequestBody() { }
        public System.Collections.Generic.IDictionary<string, string> Parameters { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.SolutionWarmUpRequestBody>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Status : System.IEquatable<Azure.ResourceManager.Help.Models.Status>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Status(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.Status Failed { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Status MissingInputs { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Status Running { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Status Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Status Timeout { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.Status other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.Status left, Azure.ResourceManager.Help.Models.Status right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.Status (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.Status left, Azure.ResourceManager.Help.Models.Status right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Step : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Step>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Step>
    {
        internal Step() { }
        public Azure.ResourceManager.Help.Models.AutomatedCheckResult AutomatedCheckResults { get { throw null; } }
        public string Description { get { throw null; } }
        public Azure.ResponseError Error { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ExecutionStatus? ExecutionStatus { get { throw null; } }
        public string ExecutionStatusDescription { get { throw null; } }
        public string Guidance { get { throw null; } }
        public string Id { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.StepInput> Inputs { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.Insight> Insights { get { throw null; } }
        public bool? IsLastStep { get { throw null; } }
        public string Title { get { throw null; } }
        public Azure.ResourceManager.Help.Models.Type? Type { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Step System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Step>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Step>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Step System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Step>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Step>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Step>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StepInput : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.StepInput>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.StepInput>
    {
        internal StepInput() { }
        public string QuestionContent { get { throw null; } }
        public Azure.ResourceManager.Help.Models.QuestionContentType? QuestionContentType { get { throw null; } }
        public string QuestionId { get { throw null; } }
        public string QuestionTitle { get { throw null; } }
        public Azure.ResourceManager.Help.Models.QuestionType? QuestionType { get { throw null; } }
        public string RecommendedOption { get { throw null; } }
        public string ResponseHint { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.ResponseConfig> ResponseOptions { get { throw null; } }
        public Azure.ResourceManager.Help.Models.ResponseValidationProperties ResponseValidationProperties { get { throw null; } }
        public string SelectedOptionValue { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.StepInput System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.StepInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.StepInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.StepInput System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.StepInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.StepInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.StepInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TriggerCriterion : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.TriggerCriterion>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TriggerCriterion>
    {
        public TriggerCriterion() { }
        public Azure.ResourceManager.Help.Models.Name? Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.TriggerCriterion System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.TriggerCriterion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.TriggerCriterion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.TriggerCriterion System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TriggerCriterion>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TriggerCriterion>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TriggerCriterion>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TroubleshooterProvisioningState : System.IEquatable<Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TroubleshooterProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState AutoContinue { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState left, Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState left, Azure.ResourceManager.Help.Models.TroubleshooterProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TroubleshooterResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>
    {
        public TroubleshooterResult() { }
        public string QuestionId { get { throw null; } set { } }
        public Azure.ResourceManager.Help.Models.QuestionType? QuestionType { get { throw null; } set { } }
        public string Response { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.TroubleshooterResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.TroubleshooterResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.TroubleshooterResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Type : System.IEquatable<Azure.ResourceManager.Help.Models.Type>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Type(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.Type AutomatedCheck { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Type Decision { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Type Input { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Type Insight { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.Type Solution { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.Type other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.Type left, Azure.ResourceManager.Help.Models.Type right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.Type (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.Type left, Azure.ResourceManager.Help.Models.Type right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ValidationScope : System.IEquatable<Azure.ResourceManager.Help.Models.ValidationScope>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ValidationScope(string value) { throw null; }
        public static Azure.ResourceManager.Help.Models.ValidationScope GuidFormat { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ValidationScope IPAddressFormat { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ValidationScope None { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ValidationScope NumberOnlyFormat { get { throw null; } }
        public static Azure.ResourceManager.Help.Models.ValidationScope URLFormat { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Help.Models.ValidationScope other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Help.Models.ValidationScope left, Azure.ResourceManager.Help.Models.ValidationScope right) { throw null; }
        public static implicit operator Azure.ResourceManager.Help.Models.ValidationScope (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Help.Models.ValidationScope left, Azure.ResourceManager.Help.Models.ValidationScope right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Video : Azure.ResourceManager.Help.Models.VideoGroupVideo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Video>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Video>
    {
        internal Video() { }
        public string ReplacementKey { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Video System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Video>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.Video>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.Video System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Video>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Video>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.Video>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VideoGroup : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.VideoGroup>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroup>
    {
        internal VideoGroup() { }
        public string ReplacementKey { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.VideoGroupVideo> Videos { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.VideoGroup System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.VideoGroup>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.VideoGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.VideoGroup System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroup>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroup>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroup>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VideoGroupVideo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>
    {
        internal VideoGroupVideo() { }
        public string Src { get { throw null; } }
        public string Title { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.VideoGroupVideo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.VideoGroupVideo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.VideoGroupVideo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WebResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.WebResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.WebResult>
    {
        internal WebResult() { }
        public string ReplacementKey { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Help.Models.SearchResult> SearchResults { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.WebResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.WebResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Help.Models.WebResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Help.Models.WebResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.WebResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.WebResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Help.Models.WebResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
