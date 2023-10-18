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
    public partial class CertificateProfileData : Azure.ResourceManager.Models.ResourceData
    {
        public CertificateProfileData(Azure.ResourceManager.Codesigning.Models.ProfileType profileType, Azure.ResourceManager.Codesigning.Models.RotationPolicy rotationPolicy, string commonName, string organization) { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Codesigning.Models.Certificate> Certificates { get { throw null; } }
        public string City { get { throw null; } }
        public string CommonName { get { throw null; } set { } }
        public string Country { get { throw null; } }
        public string EnhancedKeyUsage { get { throw null; } }
        public string IdentityValidationId { get { throw null; } }
        public bool? IncludeCity { get { throw null; } set { } }
        public bool? IncludeCountry { get { throw null; } set { } }
        public bool? IncludePostalCode { get { throw null; } set { } }
        public bool? IncludeState { get { throw null; } set { } }
        public bool? IncludeStreetAddress { get { throw null; } set { } }
        public string Organization { get { throw null; } set { } }
        public string OrganizationUnit { get { throw null; } set { } }
        public string PostalCode { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.ProfileType ProfileType { get { throw null; } set { } }
        public Azure.ResourceManager.Codesigning.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.RotationPolicy RotationPolicy { get { throw null; } set { } }
        public string State { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus? Status { get { throw null; } }
        public string StreetAddress { get { throw null; } }
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
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource> Update(Azure.ResourceManager.Codesigning.Models.CertificateProfilePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CertificateProfileResource>> UpdateAsync(Azure.ResourceManager.Codesigning.Models.CertificateProfilePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
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
    public partial class CodeSigningAccountData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public CodeSigningAccountData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Uri AccountUri { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.ProvisioningState? ProvisioningState { get { throw null; } }
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
        public virtual Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> Update(Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> UpdateAsync(Azure.ResourceManager.Codesigning.Models.CodeSigningAccountPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class CodesigningExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult> CheckNameAvailabilityCodeSigningAccount(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Codesigning.Models.CheckNameAvailability accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult>> CheckNameAvailabilityCodeSigningAccountAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Codesigning.Models.CheckNameAvailability accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Codesigning.CertificateProfileResource GetCertificateProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccount(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Codesigning.CodeSigningAccountResource>> GetCodeSigningAccountAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Codesigning.CodeSigningAccountResource GetCodeSigningAccountResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Codesigning.CodeSigningAccountCollection GetCodeSigningAccounts(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccounts(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Codesigning.CodeSigningAccountResource> GetCodeSigningAccountsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Codesigning.Models
{
    public static partial class ArmCodesigningModelFactory
    {
        public static Azure.ResourceManager.Codesigning.CertificateProfileData CertificateProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Codesigning.Models.ProfileType profileType = default(Azure.ResourceManager.Codesigning.Models.ProfileType), Azure.ResourceManager.Codesigning.Models.RotationPolicy rotationPolicy = default(Azure.ResourceManager.Codesigning.Models.RotationPolicy), string commonName = null, string organization = null, string organizationUnit = null, string streetAddress = null, bool? includeStreetAddress = default(bool?), string state = null, bool? includeState = default(bool?), string city = null, bool? includeCity = default(bool?), string postalCode = null, bool? includePostalCode = default(bool?), string country = null, bool? includeCountry = default(bool?), string enhancedKeyUsage = null, string identityValidationId = null, Azure.ResourceManager.Codesigning.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Codesigning.Models.ProvisioningState?), Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus? status = default(Azure.ResourceManager.Codesigning.Models.CertificateProfileStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Codesigning.Models.Certificate> certificates = null) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.CheckNameAvailabilityResult CheckNameAvailabilityResult(bool? nameAvailable = default(bool?), Azure.ResourceManager.Codesigning.Models.Reason? reason = default(Azure.ResourceManager.Codesigning.Models.Reason?), string message = null) { throw null; }
        public static Azure.ResourceManager.Codesigning.CodeSigningAccountData CodeSigningAccountData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Uri accountUri = null, Azure.ResourceManager.Codesigning.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Codesigning.Models.ProvisioningState?)) { throw null; }
    }
    public partial class Certificate
    {
        public Certificate() { }
        public string CreatedDate { get { throw null; } set { } }
        public string ExpiryDate { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Codesigning.Models.Revocation> Revocations { get { throw null; } }
        public string SerialNumber { get { throw null; } set { } }
        public Azure.ResourceManager.Codesigning.Models.CertificateStatus? Status { get { throw null; } set { } }
        public string SubjectName { get { throw null; } set { } }
        public string Thumbprint { get { throw null; } set { } }
    }
    public partial class CertificateProfilePatch
    {
        public CertificateProfilePatch() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Codesigning.Models.Certificate> Certificates { get { throw null; } }
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
        public static Azure.ResourceManager.Codesigning.Models.CertificateStatus RevocationFailed { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CertificateStatus RevocationInitiated { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.CertificateStatus RevocationInProgress { get { throw null; } }
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
    public partial class CheckNameAvailability
    {
        public CheckNameAvailability(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class CheckNameAvailabilityResult
    {
        internal CheckNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.Codesigning.Models.Reason? Reason { get { throw null; } }
    }
    public partial class CodeSigningAccountPatch
    {
        public CodeSigningAccountPatch() { }
        public System.Uri AccountUri { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
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
        public static Azure.ResourceManager.Codesigning.Models.ProvisioningState Provisioning { get { throw null; } }
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
    public enum Reason
    {
        AccountNameInvalid = 0,
        AlreadyExists = 1,
    }
    public partial class Revocation
    {
        public Revocation() { }
        public string Reason { get { throw null; } set { } }
        public string Remarks { get { throw null; } set { } }
        public string RequestedAt { get { throw null; } set { } }
        public string RevokedAt { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RotationPolicy : System.IEquatable<Azure.ResourceManager.Codesigning.Models.RotationPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RotationPolicy(string value) { throw null; }
        public static Azure.ResourceManager.Codesigning.Models.RotationPolicy ThirtyDays { get { throw null; } }
        public static Azure.ResourceManager.Codesigning.Models.RotationPolicy ThreeDays { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Codesigning.Models.RotationPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Codesigning.Models.RotationPolicy left, Azure.ResourceManager.Codesigning.Models.RotationPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Codesigning.Models.RotationPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Codesigning.Models.RotationPolicy left, Azure.ResourceManager.Codesigning.Models.RotationPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
}
