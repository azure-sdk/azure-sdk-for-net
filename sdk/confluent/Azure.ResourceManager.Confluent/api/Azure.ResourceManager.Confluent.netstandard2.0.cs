namespace Azure.ResourceManager.Confluent
{
    public static partial class ConfluentExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Confluent.Models.ConfluentAgreement> CreateMarketplaceAgreement(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Confluent.Models.ConfluentAgreement body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.ConfluentAgreement>> CreateMarketplaceAgreementAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Confluent.Models.ConfluentAgreement body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> GetConfluentOrganization(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> GetConfluentOrganizationAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Confluent.ConfluentOrganizationResource GetConfluentOrganizationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Confluent.ConfluentOrganizationCollection GetConfluentOrganizations(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> GetConfluentOrganizations(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> GetConfluentOrganizationsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Confluent.Models.ConfluentAgreement> GetMarketplaceAgreements(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Confluent.Models.ConfluentAgreement> GetMarketplaceAgreementsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> ValidateOrganization(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationName, Azure.ResourceManager.Confluent.ConfluentOrganizationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> ValidateOrganizationAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationName, Azure.ResourceManager.Confluent.ConfluentOrganizationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Confluent.Models.ValidationResponse> ValidateOrganizationV2Validation(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationName, Azure.ResourceManager.Confluent.ConfluentOrganizationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.ValidationResponse>> ValidateOrganizationV2ValidationAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string organizationName, Azure.ResourceManager.Confluent.ConfluentOrganizationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConfluentOrganizationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>, System.Collections.IEnumerable
    {
        protected ConfluentOrganizationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string organizationName, Azure.ResourceManager.Confluent.ConfluentOrganizationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string organizationName, Azure.ResourceManager.Confluent.ConfluentOrganizationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> Get(string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> GetAsync(string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> GetIfExists(string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> GetIfExistsAsync(string organizationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConfluentOrganizationData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ConfluentOrganizationData(Azure.Core.AzureLocation location, Azure.ResourceManager.Confluent.Models.ConfluentOfferDetail offerDetail, Azure.ResourceManager.Confluent.Models.ConfluentUserDetail userDetail) : base (default(Azure.Core.AzureLocation)) { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string LinkOrganizationToken { get { throw null; } set { } }
        public Azure.ResourceManager.Confluent.Models.ConfluentOfferDetail OfferDetail { get { throw null; } set { } }
        public System.Guid? OrganizationId { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentProvisionState? ProvisioningState { get { throw null; } }
        public System.Uri SsoUri { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentUserDetail UserDetail { get { throw null; } set { } }
    }
    public partial class ConfluentOrganizationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConfluentOrganizationResource() { }
        public virtual Azure.ResourceManager.Confluent.ConfluentOrganizationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string organizationName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListClusterSuccessResponse> GetClustersAcces(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListClusterSuccessResponse>> GetClustersAccesAsync(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListEnvironmentsSuccessResponse> GetEnvironmentsAcces(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListEnvironmentsSuccessResponse>> GetEnvironmentsAccesAsync(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListInvitationsSuccessResponse> GetInvitationsAcces(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListInvitationsSuccessResponse>> GetInvitationsAccesAsync(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListRoleBindingsSuccessResponse> GetRoleBindingsAcces(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListRoleBindingsSuccessResponse>> GetRoleBindingsAccesAsync(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListServiceAccountsSuccessResponse> GetServiceAccountsAcces(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListServiceAccountsSuccessResponse>> GetServiceAccountsAccesAsync(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListUsersSuccessResponse> GetUsersAcces(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.AccessListUsersSuccessResponse>> GetUsersAccesAsync(Azure.ResourceManager.Confluent.Models.ListAccessRequestModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.Models.InvitationRecord> InviteUserAcces(Azure.ResourceManager.Confluent.Models.AccessInviteUserAccountModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.Models.InvitationRecord>> InviteUserAccesAsync(Azure.ResourceManager.Confluent.Models.AccessInviteUserAccountModel body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource> Update(Azure.ResourceManager.Confluent.Models.ConfluentOrganizationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Confluent.ConfluentOrganizationResource>> UpdateAsync(Azure.ResourceManager.Confluent.Models.ConfluentOrganizationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Confluent.Models
{
    public partial class AccessInvitedUserDetails
    {
        public AccessInvitedUserDetails() { }
        public string AuthType { get { throw null; } set { } }
        public string InvitedEmail { get { throw null; } set { } }
    }
    public partial class AccessInviteUserAccountModel
    {
        public AccessInviteUserAccountModel() { }
        public string Email { get { throw null; } set { } }
        public Azure.ResourceManager.Confluent.Models.AccessInvitedUserDetails InvitedUserDetails { get { throw null; } set { } }
        public string OrganizationId { get { throw null; } set { } }
        public string Upn { get { throw null; } set { } }
    }
    public partial class AccessListClusterSuccessResponse
    {
        internal AccessListClusterSuccessResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Confluent.Models.ClusterRecord> Data { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentListMetadata Metadata { get { throw null; } }
    }
    public partial class AccessListEnvironmentsSuccessResponse
    {
        internal AccessListEnvironmentsSuccessResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Confluent.Models.EnvironmentRecord> Data { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentListMetadata Metadata { get { throw null; } }
    }
    public partial class AccessListInvitationsSuccessResponse
    {
        internal AccessListInvitationsSuccessResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Confluent.Models.InvitationRecord> Data { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentListMetadata Metadata { get { throw null; } }
    }
    public partial class AccessListRoleBindingsSuccessResponse
    {
        internal AccessListRoleBindingsSuccessResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Confluent.Models.RoleBindingRecord> Data { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentListMetadata Metadata { get { throw null; } }
    }
    public partial class AccessListServiceAccountsSuccessResponse
    {
        internal AccessListServiceAccountsSuccessResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Confluent.Models.ServiceAccountRecord> Data { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentListMetadata Metadata { get { throw null; } }
    }
    public partial class AccessListUsersSuccessResponse
    {
        internal AccessListUsersSuccessResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Confluent.Models.UserRecord> Data { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ConfluentListMetadata Metadata { get { throw null; } }
    }
    public static partial class ArmConfluentModelFactory
    {
        public static Azure.ResourceManager.Confluent.Models.AccessListClusterSuccessResponse AccessListClusterSuccessResponse(string kind = null, Azure.ResourceManager.Confluent.Models.ConfluentListMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.Models.ClusterRecord> data = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.AccessListEnvironmentsSuccessResponse AccessListEnvironmentsSuccessResponse(string kind = null, Azure.ResourceManager.Confluent.Models.ConfluentListMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.Models.EnvironmentRecord> data = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.AccessListInvitationsSuccessResponse AccessListInvitationsSuccessResponse(string kind = null, Azure.ResourceManager.Confluent.Models.ConfluentListMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.Models.InvitationRecord> data = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.AccessListRoleBindingsSuccessResponse AccessListRoleBindingsSuccessResponse(string kind = null, Azure.ResourceManager.Confluent.Models.ConfluentListMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.Models.RoleBindingRecord> data = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.AccessListServiceAccountsSuccessResponse AccessListServiceAccountsSuccessResponse(string kind = null, Azure.ResourceManager.Confluent.Models.ConfluentListMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.Models.ServiceAccountRecord> data = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.AccessListUsersSuccessResponse AccessListUsersSuccessResponse(string kind = null, Azure.ResourceManager.Confluent.Models.ConfluentListMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Confluent.Models.UserRecord> data = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ClusterByokEntity ClusterByokEntity(string id = null, string related = null, string resourceName = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ClusterEnvironmentEntity ClusterEnvironmentEntity(string id = null, string environment = null, string related = null, string resourceName = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ClusterNetworkEntity ClusterNetworkEntity(string id = null, string environment = null, string related = null, string resourceName = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ClusterRecord ClusterRecord(string kind = null, string id = null, Azure.ResourceManager.Confluent.Models.MetadataEntity metadata = null, string displayName = null, Azure.ResourceManager.Confluent.Models.ClusterSpecEntity spec = null, Azure.ResourceManager.Confluent.Models.ClusterStatusEntity status = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ClusterSpecEntity ClusterSpecEntity(string displayName = null, string availability = null, string cloud = null, string zone = null, string region = null, string kafkaBootstrapEndpoint = null, string httpEndpoint = null, string apiEndpoint = null, string configKind = null, Azure.ResourceManager.Confluent.Models.ClusterEnvironmentEntity environment = null, Azure.ResourceManager.Confluent.Models.ClusterNetworkEntity network = null, Azure.ResourceManager.Confluent.Models.ClusterByokEntity byok = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ClusterStatusEntity ClusterStatusEntity(string phase = null, int? cku = default(int?)) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ConfluentAgreement ConfluentAgreement(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string publisher = null, string product = null, string plan = null, string licenseTextLink = null, string privacyPolicyLink = null, System.DateTimeOffset? retrieveOn = default(System.DateTimeOffset?), string signature = null, bool? isAccepted = default(bool?)) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ConfluentListMetadata ConfluentListMetadata(string first = null, string last = null, string prev = null, string next = null, int? totalSize = default(int?)) { throw null; }
        public static Azure.ResourceManager.Confluent.ConfluentOrganizationData ConfluentOrganizationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), Azure.ResourceManager.Confluent.Models.ConfluentProvisionState? provisioningState = default(Azure.ResourceManager.Confluent.Models.ConfluentProvisionState?), System.Guid? organizationId = default(System.Guid?), System.Uri ssoUri = null, Azure.ResourceManager.Confluent.Models.ConfluentOfferDetail offerDetail = null, Azure.ResourceManager.Confluent.Models.ConfluentUserDetail userDetail = null, string linkOrganizationToken = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.EnvironmentRecord EnvironmentRecord(string kind = null, string id = null, Azure.ResourceManager.Confluent.Models.MetadataEntity metadata = null, string displayName = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.InvitationRecord InvitationRecord(string kind = null, string id = null, Azure.ResourceManager.Confluent.Models.MetadataEntity metadata = null, string email = null, string authType = null, string status = null, string acceptedAt = null, string expiresAt = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.MetadataEntity MetadataEntity(string self = null, string resourceName = null, string createdAt = null, string updatedAt = null, string deletedAt = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.RoleBindingRecord RoleBindingRecord(string kind = null, string id = null, Azure.ResourceManager.Confluent.Models.MetadataEntity metadata = null, string principal = null, string roleName = null, string crnPattern = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ServiceAccountRecord ServiceAccountRecord(string kind = null, string id = null, Azure.ResourceManager.Confluent.Models.MetadataEntity metadata = null, string displayName = null, string description = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.UserRecord UserRecord(string kind = null, string id = null, Azure.ResourceManager.Confluent.Models.MetadataEntity metadata = null, string email = null, string fullName = null, string authType = null) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ValidationResponse ValidationResponse(System.Collections.Generic.IReadOnlyDictionary<string, string> info = null) { throw null; }
    }
    public partial class ClusterByokEntity
    {
        internal ClusterByokEntity() { }
        public string Id { get { throw null; } }
        public string Related { get { throw null; } }
        public string ResourceName { get { throw null; } }
    }
    public partial class ClusterEnvironmentEntity
    {
        internal ClusterEnvironmentEntity() { }
        public string Environment { get { throw null; } }
        public string Id { get { throw null; } }
        public string Related { get { throw null; } }
        public string ResourceName { get { throw null; } }
    }
    public partial class ClusterNetworkEntity
    {
        internal ClusterNetworkEntity() { }
        public string Environment { get { throw null; } }
        public string Id { get { throw null; } }
        public string Related { get { throw null; } }
        public string ResourceName { get { throw null; } }
    }
    public partial class ClusterRecord
    {
        internal ClusterRecord() { }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.MetadataEntity Metadata { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ClusterSpecEntity Spec { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ClusterStatusEntity Status { get { throw null; } }
    }
    public partial class ClusterSpecEntity
    {
        internal ClusterSpecEntity() { }
        public string ApiEndpoint { get { throw null; } }
        public string Availability { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ClusterByokEntity Byok { get { throw null; } }
        public string Cloud { get { throw null; } }
        public string ConfigKind { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ClusterEnvironmentEntity Environment { get { throw null; } }
        public string HttpEndpoint { get { throw null; } }
        public string KafkaBootstrapEndpoint { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.ClusterNetworkEntity Network { get { throw null; } }
        public string Region { get { throw null; } }
        public string Zone { get { throw null; } }
    }
    public partial class ClusterStatusEntity
    {
        internal ClusterStatusEntity() { }
        public int? Cku { get { throw null; } }
        public string Phase { get { throw null; } }
    }
    public partial class ConfluentAgreement : Azure.ResourceManager.Models.ResourceData
    {
        public ConfluentAgreement() { }
        public bool? IsAccepted { get { throw null; } set { } }
        public string LicenseTextLink { get { throw null; } set { } }
        public string Plan { get { throw null; } set { } }
        public string PrivacyPolicyLink { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public System.DateTimeOffset? RetrieveOn { get { throw null; } set { } }
        public string Signature { get { throw null; } set { } }
    }
    public partial class ConfluentListMetadata
    {
        internal ConfluentListMetadata() { }
        public string First { get { throw null; } }
        public string Last { get { throw null; } }
        public string Next { get { throw null; } }
        public string Prev { get { throw null; } }
        public int? TotalSize { get { throw null; } }
    }
    public partial class ConfluentOfferDetail
    {
        public ConfluentOfferDetail(string publisherId, string id, string planId, string planName, string termUnit) { }
        public string Id { get { throw null; } set { } }
        public string PlanId { get { throw null; } set { } }
        public string PlanName { get { throw null; } set { } }
        public string PrivateOfferId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> PrivateOfferIds { get { throw null; } }
        public string PublisherId { get { throw null; } set { } }
        public Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus? Status { get { throw null; } set { } }
        public string TermId { get { throw null; } set { } }
        public string TermUnit { get { throw null; } set { } }
    }
    public partial class ConfluentOrganizationPatch
    {
        public ConfluentOrganizationPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfluentProvisionState : System.IEquatable<Azure.ResourceManager.Confluent.Models.ConfluentProvisionState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfluentProvisionState(string value) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Creating { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Deleted { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Failed { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState NotSpecified { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentProvisionState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Confluent.Models.ConfluentProvisionState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Confluent.Models.ConfluentProvisionState left, Azure.ResourceManager.Confluent.Models.ConfluentProvisionState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Confluent.Models.ConfluentProvisionState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Confluent.Models.ConfluentProvisionState left, Azure.ResourceManager.Confluent.Models.ConfluentProvisionState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfluentSaaSOfferStatus : System.IEquatable<Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfluentSaaSOfferStatus(string value) { throw null; }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus InProgress { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus PendingFulfillmentStart { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Reinstated { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Started { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Subscribed { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Suspended { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Unsubscribed { get { throw null; } }
        public static Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus left, Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus left, Azure.ResourceManager.Confluent.Models.ConfluentSaaSOfferStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfluentUserDetail
    {
        public ConfluentUserDetail(string emailAddress) { }
        public string AadEmail { get { throw null; } set { } }
        public string EmailAddress { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public string LastName { get { throw null; } set { } }
        public string UserPrincipalName { get { throw null; } set { } }
    }
    public partial class EnvironmentRecord
    {
        internal EnvironmentRecord() { }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.MetadataEntity Metadata { get { throw null; } }
    }
    public partial class InvitationRecord
    {
        internal InvitationRecord() { }
        public string AcceptedAt { get { throw null; } }
        public string AuthType { get { throw null; } }
        public string Email { get { throw null; } }
        public string ExpiresAt { get { throw null; } }
        public string Id { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.MetadataEntity Metadata { get { throw null; } }
        public string Status { get { throw null; } }
    }
    public partial class ListAccessRequestModel
    {
        public ListAccessRequestModel() { }
        public System.Collections.Generic.IDictionary<string, string> SearchFilters { get { throw null; } }
    }
    public partial class MetadataEntity
    {
        internal MetadataEntity() { }
        public string CreatedAt { get { throw null; } }
        public string DeletedAt { get { throw null; } }
        public string ResourceName { get { throw null; } }
        public string Self { get { throw null; } }
        public string UpdatedAt { get { throw null; } }
    }
    public partial class RoleBindingRecord
    {
        internal RoleBindingRecord() { }
        public string CrnPattern { get { throw null; } }
        public string Id { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.MetadataEntity Metadata { get { throw null; } }
        public string Principal { get { throw null; } }
        public string RoleName { get { throw null; } }
    }
    public partial class ServiceAccountRecord
    {
        internal ServiceAccountRecord() { }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.MetadataEntity Metadata { get { throw null; } }
    }
    public partial class UserRecord
    {
        internal UserRecord() { }
        public string AuthType { get { throw null; } }
        public string Email { get { throw null; } }
        public string FullName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.ResourceManager.Confluent.Models.MetadataEntity Metadata { get { throw null; } }
    }
    public partial class ValidationResponse
    {
        internal ValidationResponse() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Info { get { throw null; } }
    }
}
