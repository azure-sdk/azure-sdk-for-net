namespace Azure.ResourceManager.ServiceLinker
{
    public partial class DryrunCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.DryrunResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.DryrunResource>, System.Collections.IEnumerable
    {
        protected DryrunCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.DryrunResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string dryrunName, Azure.ResourceManager.ServiceLinker.DryrunResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.DryrunResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string dryrunName, Azure.ResourceManager.ServiceLinker.DryrunResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.DryrunResource> Get(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceLinker.DryrunResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.DryrunResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.DryrunResource>> GetAsync(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceLinker.DryrunResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.DryrunResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceLinker.DryrunResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.DryrunResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DryrunResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DryrunResource() { }
        public virtual Azure.ResourceManager.ServiceLinker.DryrunResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string resourceUri, string dryrunName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.DryrunResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.DryrunResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.DryrunResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.DryrunPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.DryrunResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.DryrunPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DryrunResourceData : Azure.ResourceManager.Models.ResourceData
    {
        public DryrunResourceData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.DryrunOperationPreview> OperationPreviews { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.DryrunParameters Parameters { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.DryrunPrerequisiteResult> PrerequisiteResults { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
    }
    public partial class LinkerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.LinkerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.LinkerResource>, System.Collections.IEnumerable
    {
        protected LinkerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LinkerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string linkerName, Azure.ResourceManager.ServiceLinker.LinkerResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LinkerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string linkerName, Azure.ResourceManager.ServiceLinker.LinkerResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource> Get(string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceLinker.LinkerResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.LinkerResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource>> GetAsync(string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceLinker.LinkerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.LinkerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceLinker.LinkerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.LinkerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class LinkerResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected LinkerResource() { }
        public virtual Azure.ResourceManager.ServiceLinker.LinkerResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string resourceUri, string linkerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult> GenerateConfigurations(Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo info = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult>> GenerateConfigurationsAsync(Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo info = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult> GetConfigurations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult>> GetConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LinkerResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.LinkerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LinkerResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.LinkerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult> Validate(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>> ValidateAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LinkerResourceData : Azure.ResourceManager.Models.ResourceData
    {
        public LinkerResourceData() { }
        public Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo AuthInfo { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? ClientType { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo ConfigurationInfo { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.PublicNetworkSolution PublicNetworkSolution { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerSecretStore SecretStore { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo TargetService { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.VnetSolution VnetSolution { get { throw null; } set { } }
    }
    public partial class LocationConnectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>, System.Collections.IEnumerable
    {
        protected LocationConnectorCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string connectorName, Azure.ResourceManager.ServiceLinker.LinkerResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string connectorName, Azure.ResourceManager.ServiceLinker.LinkerResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> Get(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>> GetAsync(string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class LocationConnectorResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected LocationConnectorResource() { }
        public virtual Azure.ResourceManager.ServiceLinker.LinkerResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, Azure.Core.AzureLocation location, string connectorName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult> GenerateConfigurations(Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo info = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult>> GenerateConfigurationsAsync(Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo info = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.LinkerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.LinkerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult> Validate(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>> ValidateAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LocationDryrunCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>, System.Collections.IEnumerable
    {
        protected LocationDryrunCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string dryrunName, Azure.ResourceManager.ServiceLinker.DryrunResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string dryrunName, Azure.ResourceManager.ServiceLinker.DryrunResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> Get(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>> GetAsync(string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class LocationDryrunResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected LocationDryrunResource() { }
        public virtual Azure.ResourceManager.ServiceLinker.DryrunResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, Azure.Core.AzureLocation location, string dryrunName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.DryrunPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceLinker.Models.DryrunPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ServiceLinkerExtensions
    {
        public static Azure.Pageable<Azure.ResourceManager.ServiceLinker.Models.ConfigurationNameItem> GetConfigurationNames(this Azure.ResourceManager.Resources.TenantResource tenantResource, string filter = null, string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.Models.ConfigurationNameItem> GetConfigurationNamesAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string filter = null, string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ServiceLinker.DryrunResource> GetDryrun(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.DryrunResource>> GetDryrunAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.DryrunResource GetDryrunResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.DryrunCollection GetDryruns(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource> GetLinker(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource> GetLinker(this Azure.ResourceManager.ArmResource armResource, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource>> GetLinkerAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LinkerResource>> GetLinkerAsync(this Azure.ResourceManager.ArmResource armResource, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LinkerResource GetLinkerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LinkerCollection GetLinkers(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LinkerCollection GetLinkers(this Azure.ResourceManager.ArmResource armResource) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ServiceLinker.LocationConnectorResource> GetLocationConnector(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location, string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LocationConnectorResource>> GetLocationConnectorAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location, string connectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LocationConnectorResource GetLocationConnectorResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LocationConnectorCollection GetLocationConnectors(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ServiceLinker.LocationDryrunResource> GetLocationDryrun(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location, string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.LocationDryrunResource>> GetLocationDryrunAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location, string dryrunName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LocationDryrunResource GetLocationDryrunResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LocationDryrunCollection GetLocationDryruns(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location) { throw null; }
    }
}
namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class AccessKeyInfoBase : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public AccessKeyInfoBase() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission> Permissions { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AccessKeyPermission : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AccessKeyPermission(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission Listen { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission Manage { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission Read { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission Send { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission Write { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission left, Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission left, Azure.ResourceManager.ServiceLinker.Models.AccessKeyPermission right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.ActionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ActionType Enable { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.ActionType Internal { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.ActionType OptOut { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.ActionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.ActionType left, Azure.ResourceManager.ServiceLinker.Models.ActionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.ActionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.ActionType left, Azure.ResourceManager.ServiceLinker.Models.ActionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AllowType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.AllowType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AllowType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.AllowType False { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.AllowType True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.AllowType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.AllowType left, Azure.ResourceManager.ServiceLinker.Models.AllowType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.AllowType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.AllowType left, Azure.ResourceManager.ServiceLinker.Models.AllowType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmServiceLinkerModelFactory
    {
        public static Azure.ResourceManager.ServiceLinker.Models.BasicErrorDryrunPrerequisiteResult BasicErrorDryrunPrerequisiteResult(string code = null, string message = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ConfigurationName ConfigurationName(string value = null, string description = null, bool? required = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ConfigurationNameItem ConfigurationNameItem(string targetService = null, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? clientType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType?), Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType? authType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType?), Azure.ResourceManager.ServiceLinker.Models.DaprProperties daprProperties = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.ConfigurationName> names = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ConfigurationResult ConfigurationResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration> configurations = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.CreateOrUpdateDryrunParameters CreateOrUpdateDryrunParameters(Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo targetService = null, Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo authInfo = null, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? clientType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType?), string provisioningState = null, Azure.ResourceManager.ServiceLinker.Models.VnetSolution vnetSolution = null, Azure.ResourceManager.ServiceLinker.Models.LinkerSecretStore secretStore = null, string scope = null, Azure.ResourceManager.ServiceLinker.Models.PublicNetworkSolution publicNetworkSolution = null, Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo configurationInfo = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.DryrunOperationPreview DryrunOperationPreview(string name = null, Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType? operationType = default(Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType?), string description = null, string action = null, string scope = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.DryrunResourceData DryrunResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ServiceLinker.Models.DryrunParameters parameters = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.DryrunPrerequisiteResult> prerequisiteResults = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.DryrunOperationPreview> operationPreviews = null, string provisioningState = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.LinkerResourceData LinkerResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo targetService = null, Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo authInfo = null, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? clientType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType?), string provisioningState = null, Azure.ResourceManager.ServiceLinker.Models.VnetSolution vnetSolution = null, Azure.ResourceManager.ServiceLinker.Models.LinkerSecretStore secretStore = null, string scope = null, Azure.ResourceManager.ServiceLinker.Models.PublicNetworkSolution publicNetworkSolution = null, Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo configurationInfo = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult LinkerValidateOperationResult(Azure.Core.ResourceIdentifier resourceId = null, string status = null, string linkerName = null, bool? isConnectionAvailable = default(bool?), System.DateTimeOffset? reportStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? reportEndOn = default(System.DateTimeOffset?), Azure.Core.ResourceIdentifier sourceId = null, Azure.Core.ResourceIdentifier targetId = null, Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType? authType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo> validationDetail = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo LinkerValidationResultItemInfo(string name = null, string description = null, Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus? result = default(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus?), string errorMessage = null, string errorCode = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.PermissionsMissingDryrunPrerequisiteResult PermissionsMissingDryrunPrerequisiteResult(string scope = null, System.Collections.Generic.IEnumerable<string> permissions = null, string recommendedRole = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration SourceConfiguration(string name = null, string value = null) { throw null; }
    }
    public abstract partial class AuthBaseInfo
    {
        protected AuthBaseInfo() { }
    }
    public partial class AzureKeyVaultProperties : Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties
    {
        public AzureKeyVaultProperties() { }
        public bool? DoesConnectAsKubernetesCsiDriver { get { throw null; } set { } }
    }
    public abstract partial class AzureResourceBaseProperties
    {
        protected AzureResourceBaseProperties() { }
    }
    public partial class AzureResourceInfo : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo
    {
        public AzureResourceInfo() { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties ResourceProperties { get { throw null; } set { } }
    }
    public partial class BasicErrorDryrunPrerequisiteResult : Azure.ResourceManager.ServiceLinker.Models.DryrunPrerequisiteResult
    {
        internal BasicErrorDryrunPrerequisiteResult() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class ConfigurationInfo
    {
        public ConfigurationInfo() { }
        public Azure.ResourceManager.ServiceLinker.Models.ActionType? Action { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> AdditionalConfigurations { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> CustomizedKeys { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.DaprProperties DaprProperties { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
    }
    public partial class ConfigurationName
    {
        internal ConfigurationName() { }
        public string Description { get { throw null; } }
        public bool? Required { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class ConfigurationNameItem
    {
        internal ConfigurationNameItem() { }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType? AuthType { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? ClientType { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.DaprProperties DaprProperties { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.ConfigurationName> Names { get { throw null; } }
        public string TargetService { get { throw null; } }
    }
    public partial class ConfigurationResult
    {
        internal ConfigurationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration> Configurations { get { throw null; } }
    }
    public partial class ConfluentBootstrapServerInfo : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo
    {
        public ConfluentBootstrapServerInfo() { }
        public string Endpoint { get { throw null; } set { } }
    }
    public partial class ConfluentSchemaRegistryInfo : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo
    {
        public ConfluentSchemaRegistryInfo() { }
        public string Endpoint { get { throw null; } set { } }
    }
    public partial class CreateOrUpdateDryrunParameters : Azure.ResourceManager.ServiceLinker.Models.DryrunParameters
    {
        public CreateOrUpdateDryrunParameters() { }
        public Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo AuthInfo { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? ClientType { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo ConfigurationInfo { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.PublicNetworkSolution PublicNetworkSolution { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerSecretStore SecretStore { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo TargetService { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.VnetSolution VnetSolution { get { throw null; } set { } }
    }
    public partial class DaprMetadata
    {
        public DaprMetadata() { }
        public string Name { get { throw null; } set { } }
        public string SecretRef { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class DaprProperties
    {
        public DaprProperties() { }
        public string ComponentType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceLinker.Models.DaprMetadata> Metadata { get { throw null; } }
        public System.Collections.Generic.IList<string> Scopes { get { throw null; } }
        public string SecretStoreComponent { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteOrUpdateBehavior : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteOrUpdateBehavior(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior Default { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior ForcedCleanup { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior left, Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior left, Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DryrunOperationPreview
    {
        internal DryrunOperationPreview() { }
        public string Action { get { throw null; } }
        public string Description { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType? OperationType { get { throw null; } }
        public string Scope { get { throw null; } }
    }
    public abstract partial class DryrunParameters
    {
        protected DryrunParameters() { }
    }
    public partial class DryrunPatch
    {
        public DryrunPatch() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.DryrunOperationPreview> OperationPreviews { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.DryrunParameters Parameters { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.DryrunPrerequisiteResult> PrerequisiteResults { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
    }
    public abstract partial class DryrunPrerequisiteResult
    {
        protected DryrunPrerequisiteResult() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DryrunPreviewOperationType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DryrunPreviewOperationType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType ConfigAuth { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType ConfigConnection { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType ConfigNetwork { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType left, Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType left, Azure.ResourceManager.ServiceLinker.Models.DryrunPreviewOperationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FirewallRules
    {
        public FirewallRules() { }
        public Azure.ResourceManager.ServiceLinker.Models.AllowType? AzureServices { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.AllowType? CallerClientIP { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> IPRanges { get { throw null; } }
    }
    public partial class KeyVaultSecretReferenceSecretInfo : Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo
    {
        public KeyVaultSecretReferenceSecretInfo() { }
        public string Name { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    public partial class KeyVaultSecretUriSecretInfo : Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo
    {
        public KeyVaultSecretUriSecretInfo() { }
        public string Value { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkerAuthType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkerAuthType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType AccessKey { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType Secret { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType ServicePrincipalCertificate { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType ServicePrincipalSecret { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType SystemAssignedIdentity { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType UserAccount { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType UserAssignedIdentity { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType left, Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType left, Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkerClientType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.LinkerClientType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkerClientType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Dapr { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Django { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Dotnet { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Go { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Java { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType KafkaSpringBoot { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Nodejs { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType None { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Php { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Python { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Ruby { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType SpringBoot { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType left, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.LinkerClientType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType left, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinkerPatch
    {
        public LinkerPatch() { }
        public Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo AuthInfo { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? ClientType { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.ConfigurationInfo ConfigurationInfo { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.PublicNetworkSolution PublicNetworkSolution { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerSecretStore SecretStore { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo TargetService { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.VnetSolution VnetSolution { get { throw null; } set { } }
    }
    public partial class LinkerSecretStore
    {
        public LinkerSecretStore() { }
        public Azure.Core.ResourceIdentifier KeyVaultId { get { throw null; } set { } }
        public string KeyVaultSecretName { get { throw null; } set { } }
    }
    public partial class LinkerValidateOperationResult
    {
        internal LinkerValidateOperationResult() { }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType? AuthType { get { throw null; } }
        public bool? IsConnectionAvailable { get { throw null; } }
        public string LinkerName { get { throw null; } }
        public System.DateTimeOffset? ReportEndOn { get { throw null; } }
        public System.DateTimeOffset? ReportStartOn { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        public Azure.Core.ResourceIdentifier SourceId { get { throw null; } }
        public string Status { get { throw null; } }
        public Azure.Core.ResourceIdentifier TargetId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo> ValidationDetail { get { throw null; } }
    }
    public partial class LinkerValidationResultItemInfo
    {
        internal LinkerValidationResultItemInfo() { }
        public string Description { get { throw null; } }
        public string ErrorCode { get { throw null; } }
        public string ErrorMessage { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus? Result { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkerValidationResultStatus : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkerValidationResultStatus(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus Failure { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus Success { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus left, Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus left, Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PermissionsMissingDryrunPrerequisiteResult : Azure.ResourceManager.ServiceLinker.Models.DryrunPrerequisiteResult
    {
        internal PermissionsMissingDryrunPrerequisiteResult() { }
        public System.Collections.Generic.IReadOnlyList<string> Permissions { get { throw null; } }
        public string RecommendedRole { get { throw null; } }
        public string Scope { get { throw null; } }
    }
    public partial class PublicNetworkSolution
    {
        public PublicNetworkSolution() { }
        public Azure.ResourceManager.ServiceLinker.Models.ActionType? Action { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.FirewallRules FirewallRules { get { throw null; } set { } }
    }
    public partial class RawValueSecretInfo : Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo
    {
        public RawValueSecretInfo() { }
        public string Value { get { throw null; } set { } }
    }
    public partial class SecretAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public SecretAuthInfo() { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo SecretInfo { get { throw null; } set { } }
    }
    public abstract partial class SecretBaseInfo
    {
        protected SecretBaseInfo() { }
    }
    public partial class SelfHostedServer : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo
    {
        public SelfHostedServer() { }
        public string Endpoint { get { throw null; } set { } }
    }
    public partial class ServicePrincipalCertificateAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public ServicePrincipalCertificateAuthInfo(string clientId, System.Guid principalId, string certificate) { }
        public string Certificate { get { throw null; } set { } }
        public string ClientId { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public System.Guid PrincipalId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Roles { get { throw null; } }
    }
    public partial class ServicePrincipalSecretAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public ServicePrincipalSecretAuthInfo(string clientId, System.Guid principalId, string secret) { }
        public string ClientId { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public System.Guid PrincipalId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Roles { get { throw null; } }
        public string Secret { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
    }
    public partial class SourceConfiguration
    {
        internal SourceConfiguration() { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class SystemAssignedIdentityAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public SystemAssignedIdentityAuthInfo() { }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Roles { get { throw null; } }
        public string UserName { get { throw null; } set { } }
    }
    public abstract partial class TargetServiceBaseInfo
    {
        protected TargetServiceBaseInfo() { }
    }
    public partial class UserAccountAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public UserAccountAuthInfo() { }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public System.Guid? PrincipalId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Roles { get { throw null; } }
        public string UserName { get { throw null; } set { } }
    }
    public partial class UserAssignedIdentityAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo
    {
        public UserAssignedIdentityAuthInfo() { }
        public string ClientId { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Roles { get { throw null; } }
        public string SubscriptionId { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
    }
    public partial class VnetSolution
    {
        public VnetSolution() { }
        public Azure.ResourceManager.ServiceLinker.Models.DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType? SolutionType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VnetSolutionType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VnetSolutionType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType PrivateLink { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType ServiceEndpoint { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType left, Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType left, Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
