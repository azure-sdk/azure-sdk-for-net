namespace Azure.ResourceManager.Codesigning
{
    public partial class CertificateProfileCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Codesigning.CertificateProfileResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Codesigning.CertificateProfileResource>, System.Collections.IEnumerable
    {
        protected CertificateProfileCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CertificateProfileResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string profileName, Azure.ResourceManager.Codesigning.CertificateProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CertificateProfileResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string profileName, Azure.ResourceManager.Codesigning.CertificateProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource> Get(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Codesigning.CertificateProfileResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Codesigning.CertificateProfileResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource>> GetAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Codesigning.CertificateProfileResource> GetIfExists(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Codesigning.CertificateProfileResource>> GetIfExistsAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Codesigning.CertificateProfileResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Codesigning.CertificateProfileResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Codesigning.CertificateProfileResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Codesigning.CertificateProfileResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CertificateProfileData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.CertificateProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CertificateProfileData>
    {
        public CertificateProfileData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Codesigning.Models.Certificate> Certificates { get { throw null; } }
        public string City { get { throw null; } }
        public string CommonName { get { throw null; } }
        public string Country { get { throw null; } }
        public string EnhancedKeyUsage { get { throw null; } }
        public string IdentityValidationId { get { throw null; } set { } }
        public bool? IncludeCity { get { throw null; } set { } }
        public bool? IncludeCountry { get { throw null; } set { } }
        public bool? IncludePostalCode { get { throw null; } set { } }
        public bool? IncludeState { get { throw null; } set { } }
        public bool? IncludeStreetAddress { get { throw null; } set { } }
        public string Organization { get { throw null; } }
        public string OrganizationUnit { get { throw null; } }
        public string PostalCode { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.ProfileType? ProfileType { get { throw null; } set { } }
        public Azure.ResourceManager.Codesigning.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string State { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus? Status { get { throw null; } }
        public string StreetAddress { get { throw null; } }
        Azure.ResourceManager.Codesigning.CertificateProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.CertificateProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.CertificateProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.CertificateProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CertificateProfileData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CertificateProfileData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CertificateProfileData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CertificateProfileResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CertificateProfileResource() { }
        public virtual Azure.ResourceManager.Codesigning.CertificateProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string profileName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RevokeCertificate(Azure.ResourceManager.Codesigning.Models.RevokeCertificate body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RevokeCertificateAsync(Azure.ResourceManager.Codesigning.Models.RevokeCertificate body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CertificateProfileResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Codesigning.CertificateProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CertificateProfileResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Codesigning.CertificateProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CodeSigningAccountCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>, System.Collections.IEnumerable
    {
        protected CodeSigningAccountCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string accountName, Azure.ResourceManager.Codesigning.CodeSigningAccountData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string accountName, Azure.ResourceManager.Codesigning.CodeSigningAccountData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> Get(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> GetAsync(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetIfExists(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> GetIfExistsAsync(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CodeSigningAccountData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>
    {
        public CodeSigningAccountData(Azure.Core.AzureLocation location) { }
        public System.Uri AccountUri { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.CodesigningSkuName? SkuName { get { throw null; } set { } }
        Azure.ResourceManager.Codesigning.CodeSigningAccountData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.CodeSigningAccountData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.CodeSigningAccountData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CodeSigningAccountResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CodeSigningAccountResource() { }
        public virtual Azure.ResourceManager.Codesigning.CodeSigningAccountData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource> GetCertificateProfile(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource>> GetCertificateProfileAsync(string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Codesigning.CertificateProfileCollection GetCertificateProfiles() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class CodesigningExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult> CheckNameAvailabilityCodeSigningAccount(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Codesigning.Models.CheckNameAvailability body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>> CheckNameAvailabilityCodeSigningAccountAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Codesigning.Models.CheckNameAvailability body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Codesigning.CertificateProfileResource GetCertificateProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccount(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> GetCodeSigningAccountAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Codesigning.CodeSigningAccountResource GetCodeSigningAccountResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Codesigning.CodeSigningAccountCollection GetCodeSigningAccounts(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccounts(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccountsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Codesigning.Mocking
{
    public partial class MockableCodesigningArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableCodesigningArmClient() { }
        public virtual Azure.ResourceManager.Codesigning.CertificateProfileResource GetCertificateProfileResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Codesigning.CodeSigningAccountResource GetCodeSigningAccountResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableCodesigningResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableCodesigningResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccount(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> GetCodeSigningAccountAsync(string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Codesigning.CodeSigningAccountCollection GetCodeSigningAccounts() { throw null; }
    }
    public partial class MockableCodesigningSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableCodesigningSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult> CheckNameAvailabilityCodeSigningAccount(Azure.ResourceManager.Codesigning.Models.CheckNameAvailability body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>> CheckNameAvailabilityCodeSigningAccountAsync(Azure.ResourceManager.Codesigning.Models.CheckNameAvailability body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccounts(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccountsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Codesigning.Models
{
    public static partial class ArmCodesigningModelFactory
    {
        public static Azure.ResourceManager.Codesigning.Models.Certificate Certificate(string serialNumber = null, string subjectName = null, string thumbprint = null, string createdDate = null, string expiryDate = null, Azure.ResourceManager.Codesigning.Models.CertificateStatus? status = default(Azure.ResourceManager.Codesigning.Models.CertificateStatus?), System.DateTimeOffset? requestedOn = default(System.DateTimeOffset?), System.DateTimeOffset? effectiveOn = default(System.DateTimeOffset?), string reason = null, string remarks = null, Azure.ResourceManager.Codesigning.Models.RevocationStatus? statusRevocationStatus = default(Azure.ResourceManager.Codesigning.Models.RevocationStatus?), string failureReason = null) { throw null; }
        public static Azure.ResourceManager.Codesigning.CertificateProfileData CertificateProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Codesigning.Models.ProfileType? profileType = default(Azure.ResourceManager.Codesigning.Models.ProfileType?), string commonName = null, string organization = null, string organizationUnit = null, string streetAddress = null, bool? includeStreetAddress = default(bool?), string city = null, bool? includeCity = default(bool?), string state = null, bool? includeState = default(bool?), string country = null, bool? includeCountry = default(bool?), string postalCode = null, bool? includePostalCode = default(bool?), string enhancedKeyUsage = null, string identityValidationId = null, Azure.ResourceManager.Codesigning.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Codesigning.Models.ProvisioningState?), Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus? status = default(Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Codesigning.Models.Certificate> certificates = null) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult CheckNameAvailabilityResult(bool? nameAvailable = default(bool?), Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason? reason = default(Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason?), string message = null) { throw null; }
        public static Azure.ResourceManager.Codesigning.CodeSigningAccountData CodeSigningAccountData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Uri accountUri = null, Azure.ResourceManager.Codesigning.Models.CodesigningSkuName? skuName = default(Azure.ResourceManager.Codesigning.Models.CodesigningSkuName?), Azure.ResourceManager.Codesigning.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Codesigning.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.RevokeCertificate RevokeCertificate(string serialNumber = null, string thumbprint = null, System.DateTimeOffset effectiveOn = default(System.DateTimeOffset), string reason = null, string remarks = null) { throw null; }
    }
    public partial class Certificate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.Certificate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.Certificate>
    {
        internal Certificate() { }
        public string CreatedDate { get { throw null; } }
        public System.DateTimeOffset? EffectiveOn { get { throw null; } }
        public string ExpiryDate { get { throw null; } }
        public string FailureReason { get { throw null; } }
        public string Reason { get { throw null; } }
        public string Remarks { get { throw null; } }
        public System.DateTimeOffset? RequestedOn { get { throw null; } }
        public string SerialNumber { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.CertificateStatus? Status { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.RevocationStatus? StatusRevocationStatus { get { throw null; } }
        public string SubjectName { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        Azure.ResourceManager.Codesigning.Models.Certificate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.Certificate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.Certificate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.Models.Certificate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.Certificate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.Certificate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.Certificate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CertificateProfileStatus : System.IEquatable<Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CertificateProfileStatus(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus Suspended { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus left, Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus left, Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CertificateStatus : System.IEquatable<Azure.ResourceManager.Codesigning.Models.CertificateStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CertificateStatus(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.CertificateStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CertificateStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CertificateStatus Revoked { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.CertificateStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.CertificateStatus left, Azure.ResourceManager.Codesigning.Models.CertificateStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.CertificateStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.CertificateStatus left, Azure.ResourceManager.Codesigning.Models.CertificateStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CheckNameAvailability : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>
    {
        public CheckNameAvailability(string name) { }
        public string Name { get { throw null; } }
        Azure.ResourceManager.Codesigning.Models.CheckNameAvailability System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.Models.CheckNameAvailability System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailability>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CheckNameAvailabilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>
    {
        internal CheckNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason? Reason { get { throw null; } }
        Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CodeSigningAccountPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>
    {
        public CodeSigningAccountPatch() { }
        public Azure.ResourceManager.Codesigning.Models.CodesigningSkuName? SkuName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CodesigningSkuName : System.IEquatable<Azure.ResourceManager.Codesigning.Models.CodesigningSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CodesigningSkuName(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.CodesigningSkuName Basic { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CodesigningSkuName Premium { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.CodesigningSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.CodesigningSkuName left, Azure.ResourceManager.Codesigning.Models.CodesigningSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.CodesigningSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.CodesigningSkuName left, Azure.ResourceManager.Codesigning.Models.CodesigningSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NameUnavailabilityReason : System.IEquatable<Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NameUnavailabilityReason(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason AccountNameInvalid { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason AlreadyExists { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason left, Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason left, Azure.ResourceManager.Codesigning.Models.NameUnavailabilityReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProfileType : System.IEquatable<Azure.ResourceManager.Codesigning.Models.ProfileType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProfileType(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.ProfileType PrivateTrust { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProfileType PrivateTrustCIPolicy { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProfileType PublicTrust { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProfileType PublicTrustTest { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProfileType VBSEnclave { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.ProfileType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.ProfileType left, Azure.ResourceManager.Codesigning.Models.ProfileType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.ProfileType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.ProfileType left, Azure.ResourceManager.Codesigning.Models.ProfileType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Codesigning.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.ProvisioningState left, Azure.ResourceManager.Codesigning.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.ProvisioningState left, Azure.ResourceManager.Codesigning.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RevocationStatus : System.IEquatable<Azure.ResourceManager.Codesigning.Models.RevocationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RevocationStatus(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.RevocationStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.RevocationStatus InProgress { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.RevocationStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.RevocationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.RevocationStatus left, Azure.ResourceManager.Codesigning.Models.RevocationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.RevocationStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.RevocationStatus left, Azure.ResourceManager.Codesigning.Models.RevocationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RevokeCertificate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>
    {
        public RevokeCertificate(string serialNumber, string thumbprint, System.DateTimeOffset effectiveOn, string reason) { }
        public System.DateTimeOffset EffectiveOn { get { throw null; } }
        public string Reason { get { throw null; } }
        public string Remarks { get { throw null; } set { } }
        public string SerialNumber { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        Azure.ResourceManager.Codesigning.Models.RevokeCertificate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Codesigning.Models.RevokeCertificate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Codesigning.Models.RevokeCertificate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
