namespace Azure.ResourceManager.Migrate
{
    public partial class AzureResourceManagerMigrateContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerMigrateContext() { }
        public static Azure.ResourceManager.Migrate.AzureResourceManagerMigrateContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class CompoundAssessmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Migrate.CompoundAssessmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.CompoundAssessmentResource>, System.Collections.IEnumerable
    {
        protected CompoundAssessmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Migrate.CompoundAssessmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string compoundAssessmentName, Azure.ResourceManager.Migrate.CompoundAssessmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string compoundAssessmentName, Azure.ResourceManager.Migrate.CompoundAssessmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource> Get(string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Migrate.CompoundAssessmentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Migrate.CompoundAssessmentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> GetAsync(string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Migrate.CompoundAssessmentResource> GetIfExists(string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> GetIfExistsAsync(string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Migrate.CompoundAssessmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Migrate.CompoundAssessmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Migrate.CompoundAssessmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.CompoundAssessmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CompoundAssessmentData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>
    {
        public CompoundAssessmentData() { }
        public Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.CompoundAssessmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.CompoundAssessmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CompoundAssessmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CompoundAssessmentResource() { }
        public virtual Azure.ResourceManager.Migrate.CompoundAssessmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string compoundAssessmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Migrate.Models.DownloadUri> DownloadUrl(Azure.WaitUntil waitUntil, Azure.ResourceManager.Migrate.Models.DownloadUrlContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Migrate.Models.DownloadUri>> DownloadUrlAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Migrate.Models.DownloadUrlContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryCollection GetWebAppCompoundAssessmentSummaries() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> GetWebAppCompoundAssessmentSummary(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>> GetWebAppCompoundAssessmentSummaryAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Migrate.CompoundAssessmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.CompoundAssessmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.CompoundAssessmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Migrate.CompoundAssessmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Migrate.CompoundAssessmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Migrate.CompoundAssessmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class MigrateExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource> GetCompoundAssessment(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string projectName, string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> GetCompoundAssessmentAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string projectName, string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Migrate.CompoundAssessmentResource GetCompoundAssessmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Migrate.CompoundAssessmentCollection GetCompoundAssessments(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string projectName) { throw null; }
        public static Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource GetWebAppCompoundAssessmentSummaryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class WebAppCompoundAssessmentSummaryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>, System.Collections.IEnumerable
    {
        protected WebAppCompoundAssessmentSummaryCollection() { }
        public virtual Azure.Response<bool> Exists(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> Get(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>> GetAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> GetIfExists(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>> GetIfExistsAsync(string summaryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class WebAppCompoundAssessmentSummaryData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>
    {
        internal WebAppCompoundAssessmentSummaryData() { }
        public Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WebAppCompoundAssessmentSummaryResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected WebAppCompoundAssessmentSummaryResource() { }
        public virtual Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string compoundAssessmentName, string summaryName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.Migrate.Mocking
{
    public partial class MockableMigrateArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableMigrateArmClient() { }
        public virtual Azure.ResourceManager.Migrate.CompoundAssessmentResource GetCompoundAssessmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryResource GetWebAppCompoundAssessmentSummaryResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableMigrateResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableMigrateResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource> GetCompoundAssessment(string projectName, string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Migrate.CompoundAssessmentResource>> GetCompoundAssessmentAsync(string projectName, string compoundAssessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Migrate.CompoundAssessmentCollection GetCompoundAssessments(string projectName) { throw null; }
    }
}
namespace Azure.ResourceManager.Migrate.Models
{
    public static partial class ArmMigrateModelFactory
    {
        public static Azure.ResourceManager.Migrate.CompoundAssessmentData CompoundAssessmentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails CompoundAssessmentDetails(System.DateTimeOffset? createdTimestamp = default(System.DateTimeOffset?), System.DateTimeOffset? updatedTimestamp = default(System.DateTimeOffset?), Azure.ResourceManager.Migrate.Models.AssessmentStatus status = default(Azure.ResourceManager.Migrate.Models.AssessmentStatus)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties CompoundAssessmentProperties(Azure.ResourceManager.Migrate.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Migrate.Models.ProvisioningState?), Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds targetAssessmentArmIds = null, string fallbackMachineAssessmentArmId = null, Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails details = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.CostDetailsCommon CostDetailsCommon(Azure.ResourceManager.Migrate.Models.SavingsOption? savingOptions = default(Azure.ResourceManager.Migrate.Models.SavingsOption?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.NameValuePairCostType> costDetail = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary DiscoveredLightSummary(int numberOfWebApps = 0, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.WebAppsPerType> numberOfWebAppsPerType = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.WebServersPerType> numberOfWebServersPerType = null, int numberOfWebServers = 0, int numberOfServers = 0) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.DownloadUri DownloadUri(string assessmentReportUri = null, System.DateTimeOffset expireOn = default(System.DateTimeOffset)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.ManagementDetails ManagementDetails(Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType? name = default(Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon> readinessSummary = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.MigrationDetails MigrationDetails(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon> readinessSummary = null, Azure.ResourceManager.Migrate.Models.MigrationType? migrationType = default(Azure.ResourceManager.Migrate.Models.MigrationType?)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon NameValuePairCloudSuitabilityCommon(Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon? name = default(Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon?), int? value = default(int?)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.NameValuePairCostType NameValuePairCostType(Azure.ResourceManager.Migrate.Models.CostType? name = default(Azure.ResourceManager.Migrate.Models.CostType?), float? value = default(float?)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType NameValuePairSavingsType(Azure.ResourceManager.Migrate.Models.SavingsType? name = default(Azure.ResourceManager.Migrate.Models.SavingsType?), float? value = default(float?)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon SavingsDetailsCommon(Azure.ResourceManager.Migrate.Models.SavingsOption? savingOptions = default(Azure.ResourceManager.Migrate.Models.SavingsOption?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType> savingsDetail = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.SourceDetails SourceDetails(Azure.ResourceManager.Migrate.Models.AssessmentSource? sourceName = default(Azure.ResourceManager.Migrate.Models.AssessmentSource?), Azure.ResourceManager.Migrate.Models.MigrateWorkloadType? sourceType = default(Azure.ResourceManager.Migrate.Models.MigrateWorkloadType?), Azure.ResourceManager.Migrate.Models.MigrationPlatform? platform = default(Azure.ResourceManager.Migrate.Models.MigrationPlatform?), int? count = default(int?)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.TargetDetails TargetDetails(Azure.ResourceManager.Migrate.Models.AzureTarget? targetName = default(Azure.ResourceManager.Migrate.Models.AzureTarget?), Azure.ResourceManager.Migrate.Models.MigrateWorkloadType? targetType = default(Azure.ResourceManager.Migrate.Models.MigrateWorkloadType?), Azure.ResourceManager.Migrate.Models.MigrationPlatform? platform = default(Azure.ResourceManager.Migrate.Models.MigrationPlatform?), int? count = default(int?)) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.TargetSourcePair TargetSourcePair(Azure.ResourceManager.Migrate.Models.AssessmentSource? sourceRef = default(Azure.ResourceManager.Migrate.Models.AssessmentSource?), Azure.ResourceManager.Migrate.Models.AzureTarget? targetRef = default(Azure.ResourceManager.Migrate.Models.AzureTarget?), int? sourceCount = default(int?), int? targetCount = default(int?), Azure.ResourceManager.Migrate.Models.MigrationDetails migrationDetails = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.ManagementDetails> managementDetails = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.CostDetailsCommon> costDetails = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon> savingsDetails = null, double? confidenceScore = default(double?)) { throw null; }
        public static Azure.ResourceManager.Migrate.WebAppCompoundAssessmentSummaryData WebAppCompoundAssessmentSummaryData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties properties = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties WebAppCompoundAssessmentSummaryProperties(Azure.ResourceManager.Migrate.Models.SummaryType? summaryType = default(Azure.ResourceManager.Migrate.Models.SummaryType?), string summaryName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.SourceDetails> sources = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.TargetDetails> targets = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.TargetSourcePair> targetSourceMapping = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.CostDetailsCommon> costComponents = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon> savingsComponents = null, string assessmentName = null, Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary discoveredLightSummary = null) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.WebAppsPerType WebAppsPerType(Azure.ResourceManager.Migrate.Models.WebAppType webAppType = default(Azure.ResourceManager.Migrate.Models.WebAppType), int count = 0) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.WebServersPerType WebServersPerType(Azure.ResourceManager.Migrate.Models.WebServerType webServerType = default(Azure.ResourceManager.Migrate.Models.WebServerType), int count = 0) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AssessmentSource : System.IEquatable<Azure.ResourceManager.Migrate.Models.AssessmentSource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AssessmentSource(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource IIS { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource Machine { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource MySQLServer { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource OracleDatabase { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource OracleServer { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource SAPInstance { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource SpringbootApplication { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource SqlDatabase { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource SqlInstance { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource TomCat { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource Unknown { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentSource WebApps { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.AssessmentSource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.AssessmentSource left, Azure.ResourceManager.Migrate.Models.AssessmentSource right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.AssessmentSource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.AssessmentSource left, Azure.ResourceManager.Migrate.Models.AssessmentSource right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AssessmentStatus : System.IEquatable<Azure.ResourceManager.Migrate.Models.AssessmentStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AssessmentStatus(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Created { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Invalid { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus OutDated { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus OutOfSync { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Running { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AssessmentStatus Updated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.AssessmentStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.AssessmentStatus left, Azure.ResourceManager.Migrate.Models.AssessmentStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.AssessmentStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.AssessmentStatus left, Azure.ResourceManager.Migrate.Models.AssessmentStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AzureManagementOfferingType : System.IEquatable<Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AzureManagementOfferingType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType AUM { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType AzMon { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType AzureBackup { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType No { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType SCOMMI { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType left, Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType left, Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AzureTarget : System.IEquatable<Azure.ResourceManager.Migrate.Models.AzureTarget>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AzureTarget(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget AKS { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget Avs { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget AzureAppService { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget AzureAppServiceContainer { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget AzureSpringApps { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget AzureSQLVM { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget AzureVm { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget FlexServerPG { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget MySQLAzureFlexServer { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget OracleIaasVm { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget SAPAzureInstance { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget SqlDatabase { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget SqlMI { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.AzureTarget Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.AzureTarget other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.AzureTarget left, Azure.ResourceManager.Migrate.Models.AzureTarget right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.AzureTarget (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.AzureTarget left, Azure.ResourceManager.Migrate.Models.AzureTarget right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CloudSuitabilityCommon : System.IEquatable<Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CloudSuitabilityCommon(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon ConditionallySuitable { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon NotSuitable { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon ReadinessUnknown { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon Suitable { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon SuitableWithWarnings { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon left, Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon left, Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CompoundAssessmentDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>
    {
        internal CompoundAssessmentDetails() { }
        public System.DateTimeOffset? CreatedTimestamp { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.AssessmentStatus Status { get { throw null; } }
        public System.DateTimeOffset? UpdatedTimestamp { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CompoundAssessmentProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>
    {
        public CompoundAssessmentProperties(Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds targetAssessmentArmIds) { }
        public Azure.ResourceManager.Migrate.Models.CompoundAssessmentDetails Details { get { throw null; } }
        public string FallbackMachineAssessmentArmId { get { throw null; } set { } }
        public Azure.ResourceManager.Migrate.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds TargetAssessmentArmIds { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CompoundAssessmentProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CostDetailsCommon : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>
    {
        internal CostDetailsCommon() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.NameValuePairCostType> CostDetail { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.SavingsOption? SavingOptions { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.CostDetailsCommon System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.CostDetailsCommon System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.CostDetailsCommon>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CostType : System.IEquatable<Azure.ResourceManager.Migrate.Models.CostType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CostType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.CostType DataProtectionService { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonitoringService { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyAvsExternalStorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyAvsNetworkCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyAvsNodeCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyAzureHybridCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyBandwidthCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyComputeCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyLicensingCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyLinuxAzureHybridCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyManagementCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyPremiumStorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyPremiumV2StorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlySecurityCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyStandardHddStorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyStandardSsdStorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyStorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyUltraDiskCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType MonthlyUltraStorageCost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType PatchingService { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.CostType TotalMonthlyCost { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.CostType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.CostType left, Azure.ResourceManager.Migrate.Models.CostType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.CostType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.CostType left, Azure.ResourceManager.Migrate.Models.CostType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiscoveredLightSummary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>
    {
        internal DiscoveredLightSummary() { }
        public int NumberOfServers { get { throw null; } }
        public int NumberOfWebApps { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.WebAppsPerType> NumberOfWebAppsPerType { get { throw null; } }
        public int NumberOfWebServers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.WebServersPerType> NumberOfWebServersPerType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DownloadUri : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DownloadUri>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUri>
    {
        internal DownloadUri() { }
        public string AssessmentReportUri { get { throw null; } }
        public System.DateTimeOffset ExpireOn { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.DownloadUri System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DownloadUri>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DownloadUri>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.DownloadUri System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUri>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUri>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUri>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DownloadUrlContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>
    {
        public DownloadUrlContent() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.DownloadUrlContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.DownloadUrlContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.DownloadUrlContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>
    {
        internal ManagementDetails() { }
        public Azure.ResourceManager.Migrate.Models.AzureManagementOfferingType? Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon> ReadinessSummary { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.ManagementDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.ManagementDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.ManagementDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MigrateWorkloadType : System.IEquatable<Azure.ResourceManager.Migrate.Models.MigrateWorkloadType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MigrateWorkloadType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType Database { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType Host { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType Instance { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType Machine { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType ManagementServer { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType Server { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType Unknown { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType WebApplication { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrateWorkloadType WebServer { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.MigrateWorkloadType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.MigrateWorkloadType left, Azure.ResourceManager.Migrate.Models.MigrateWorkloadType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.MigrateWorkloadType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.MigrateWorkloadType left, Azure.ResourceManager.Migrate.Models.MigrateWorkloadType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MigrationDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>
    {
        internal MigrationDetails() { }
        public Azure.ResourceManager.Migrate.Models.MigrationType? MigrationType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon> ReadinessSummary { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.MigrationDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.MigrationDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.MigrationDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MigrationPlatform : System.IEquatable<Azure.ResourceManager.Migrate.Models.MigrationPlatform>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MigrationPlatform(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.MigrationPlatform IaaS { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationPlatform PaaS { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationPlatform SaaS { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationPlatform Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.MigrationPlatform other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.MigrationPlatform left, Azure.ResourceManager.Migrate.Models.MigrationPlatform right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.MigrationPlatform (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.MigrationPlatform left, Azure.ResourceManager.Migrate.Models.MigrationPlatform right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MigrationType : System.IEquatable<Azure.ResourceManager.Migrate.Models.MigrationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MigrationType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.MigrationType Rearchitect { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationType Rehost { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationType Replatform { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationType Retain { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.MigrationType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.MigrationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.MigrationType left, Azure.ResourceManager.Migrate.Models.MigrationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.MigrationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.MigrationType left, Azure.ResourceManager.Migrate.Models.MigrationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NameValuePairCloudSuitabilityCommon : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>
    {
        internal NameValuePairCloudSuitabilityCommon() { }
        public Azure.ResourceManager.Migrate.Models.CloudSuitabilityCommon? Name { get { throw null; } }
        public int? Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCloudSuitabilityCommon>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NameValuePairCostType : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>
    {
        internal NameValuePairCostType() { }
        public Azure.ResourceManager.Migrate.Models.CostType? Name { get { throw null; } }
        public float? Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.NameValuePairCostType System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.NameValuePairCostType System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairCostType>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NameValuePairSavingsType : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>
    {
        internal NameValuePairSavingsType() { }
        public Azure.ResourceManager.Migrate.Models.SavingsType? Name { get { throw null; } }
        public float? Value { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Migrate.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.ProvisioningState left, Azure.ResourceManager.Migrate.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.ProvisioningState left, Azure.ResourceManager.Migrate.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SavingsDetailsCommon : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>
    {
        internal SavingsDetailsCommon() { }
        public Azure.ResourceManager.Migrate.Models.SavingsOption? SavingOptions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.NameValuePairSavingsType> SavingsDetail { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SavingsOption : System.IEquatable<Azure.ResourceManager.Migrate.Models.SavingsOption>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SavingsOption(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.SavingsOption CustomAzureOfferCode { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsOption None { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsOption RI1Year { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsOption RI3Year { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsOption SavingsPlan1Year { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsOption SavingsPlan3Year { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.SavingsOption other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.SavingsOption left, Azure.ResourceManager.Migrate.Models.SavingsOption right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.SavingsOption (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.SavingsOption left, Azure.ResourceManager.Migrate.Models.SavingsOption right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SavingsType : System.IEquatable<Azure.ResourceManager.Migrate.Models.SavingsType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SavingsType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.SavingsType MonthlyAhubSqlCostSavings { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsType MonthlyAzureHybridCostSavings { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsType MonthlyLinuxAzureHybridCostSavings { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SavingsType MonthlyVcfByolCostDifference { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.SavingsType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.SavingsType left, Azure.ResourceManager.Migrate.Models.SavingsType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.SavingsType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.SavingsType left, Azure.ResourceManager.Migrate.Models.SavingsType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SourceDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.SourceDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SourceDetails>
    {
        internal SourceDetails() { }
        public int? Count { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.MigrationPlatform? Platform { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.AssessmentSource? SourceName { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.MigrateWorkloadType? SourceType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.SourceDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.SourceDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.SourceDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.SourceDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SourceDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SourceDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.SourceDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SummaryType : System.IEquatable<Azure.ResourceManager.Migrate.Models.SummaryType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SummaryType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.SummaryType Strategy { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SummaryType Target { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.SummaryType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.SummaryType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.SummaryType left, Azure.ResourceManager.Migrate.Models.SummaryType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.SummaryType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.SummaryType left, Azure.ResourceManager.Migrate.Models.SummaryType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TargetAssessmentArmIds : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>
    {
        public TargetAssessmentArmIds() { }
        public string Aks { get { throw null; } set { } }
        public string AzureAppService { get { throw null; } set { } }
        public string AzureAppServiceContainer { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetAssessmentArmIds>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TargetDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetDetails>
    {
        internal TargetDetails() { }
        public int? Count { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.MigrationPlatform? Platform { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.AzureTarget? TargetName { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.MigrateWorkloadType? TargetType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.TargetDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.TargetDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TargetSourcePair : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>
    {
        internal TargetSourcePair() { }
        public double? ConfidenceScore { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.CostDetailsCommon> CostDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.ManagementDetails> ManagementDetails { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.MigrationDetails MigrationDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon> SavingsDetails { get { throw null; } }
        public int? SourceCount { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.AssessmentSource? SourceRef { get { throw null; } }
        public int? TargetCount { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.AzureTarget? TargetRef { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.TargetSourcePair System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.TargetSourcePair System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.TargetSourcePair>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WebAppCompoundAssessmentSummaryProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>
    {
        internal WebAppCompoundAssessmentSummaryProperties() { }
        public string AssessmentName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.CostDetailsCommon> CostComponents { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.DiscoveredLightSummary DiscoveredLightSummary { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.SavingsDetailsCommon> SavingsComponents { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.SourceDetails> Sources { get { throw null; } }
        public string SummaryName { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.SummaryType? SummaryType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.TargetDetails> Targets { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Migrate.Models.TargetSourcePair> TargetSourceMapping { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppCompoundAssessmentSummaryProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WebAppsPerType : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>
    {
        internal WebAppsPerType() { }
        public int Count { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.WebAppType WebAppType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.WebAppsPerType System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.WebAppsPerType System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebAppsPerType>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WebAppType : System.IEquatable<Azure.ResourceManager.Migrate.Models.WebAppType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WebAppType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.WebAppType ASPNET { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.WebAppType Java { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.WebAppType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.WebAppType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.WebAppType left, Azure.ResourceManager.Migrate.Models.WebAppType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.WebAppType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.WebAppType left, Azure.ResourceManager.Migrate.Models.WebAppType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WebServersPerType : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>
    {
        internal WebServersPerType() { }
        public int Count { get { throw null; } }
        public Azure.ResourceManager.Migrate.Models.WebServerType WebServerType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.WebServersPerType System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Migrate.Models.WebServersPerType System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Migrate.Models.WebServersPerType>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WebServerType : System.IEquatable<Azure.ResourceManager.Migrate.Models.WebServerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WebServerType(string value) { throw null; }
        public static Azure.ResourceManager.Migrate.Models.WebServerType IIS { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.WebServerType Tomcat { get { throw null; } }
        public static Azure.ResourceManager.Migrate.Models.WebServerType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Migrate.Models.WebServerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Migrate.Models.WebServerType left, Azure.ResourceManager.Migrate.Models.WebServerType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Migrate.Models.WebServerType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Migrate.Models.WebServerType left, Azure.ResourceManager.Migrate.Models.WebServerType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
