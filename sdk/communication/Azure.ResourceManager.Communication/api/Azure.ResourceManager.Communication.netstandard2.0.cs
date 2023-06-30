namespace Azure.ResourceManager.Communication
{
    public static partial class CommunicationExtensions
    {
        public static Azure.ResourceManager.ArmOperation CancelVerificationDomain(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.DomainsRecordVerificationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CancelVerificationDomainAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.DomainsRecordVerificationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityResult> CheckCommunicationNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Communication.Models.CommunicationServiceNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityResult>> CheckCommunicationNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Communication.Models.CommunicationServiceNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> CreateOrUpdateCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string communicationServiceName, Azure.ResourceManager.Communication.Models.CommunicationServiceResource communicationServiceResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.CommunicationServiceResource>> CreateOrUpdateCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string communicationServiceName, Azure.ResourceManager.Communication.Models.CommunicationServiceResource communicationServiceResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.CommunicationDomainResource> CreateOrUpdateDomain(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.CommunicationDomainResource communicationDomainResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.CommunicationDomainResource>> CreateOrUpdateDomainAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.CommunicationDomainResource communicationDomainResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.EmailServiceResource> CreateOrUpdateEmailService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, Azure.ResourceManager.Communication.Models.EmailServiceResource emailServiceResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.EmailServiceResource>> CreateOrUpdateEmailServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, Azure.ResourceManager.Communication.Models.EmailServiceResource emailServiceResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.SenderUsernameResource> CreateOrUpdateSenderUsername(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, string senderUsername, Azure.ResourceManager.Communication.Models.SenderUsernameResource senderUsernameResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.SenderUsernameResource>> CreateOrUpdateSenderUsernameAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, string senderUsername, Azure.ResourceManager.Communication.Models.SenderUsernameResource senderUsernameResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation DeleteCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string communicationServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string communicationServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation DeleteDomain(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteDomainAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation DeleteEmailService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteEmailServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response DeleteSenderUsername(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, string senderUsername, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> DeleteSenderUsernameAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, string senderUsername, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> GetCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceResource>> GetCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> GetCommunicationServicesByResourceGroup(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> GetCommunicationServicesByResourceGroupAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> GetCommunicationServicesBySubscription(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> GetCommunicationServicesBySubscriptionAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationDomainResource> GetDomain(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationDomainResource>> GetDomainAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Communication.Models.CommunicationDomainResource> GetDomainsByEmailServiceResource(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Communication.Models.CommunicationDomainResource> GetDomainsByEmailServiceResourceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.EmailServiceResource> GetEmailService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.EmailServiceResource>> GetEmailServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Communication.Models.EmailServiceResource> GetEmailServicesByResourceGroup(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Communication.Models.EmailServiceResource> GetEmailServicesByResourceGroupAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Communication.Models.EmailServiceResource> GetEmailServicesBySubscription(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Communication.Models.EmailServiceResource> GetEmailServicesBySubscriptionAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceKeys> GetKeysCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceKeys>> GetKeysCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.SenderUsernameResource> GetSenderUsername(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, string senderUsername, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.SenderUsernameResource>> GetSenderUsernameAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, string senderUsername, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Communication.Models.SenderUsernameResource> GetSenderUsernamesByDomains(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Communication.Models.SenderUsernameResource> GetSenderUsernamesByDomainsAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string emailServiceName, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<string> GetVerifiedExchangeOnlineDomainsEmailServices(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<string> GetVerifiedExchangeOnlineDomainsEmailServicesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation InitiateVerificationDomain(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.DomainsRecordVerificationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> InitiateVerificationDomainAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.DomainsRecordVerificationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.LinkedNotificationHub> LinkNotificationHubCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, Azure.ResourceManager.Communication.Models.LinkNotificationHubContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.LinkedNotificationHub>> LinkNotificationHubCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, Azure.ResourceManager.Communication.Models.LinkNotificationHubContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceKeys> RegenerateKeyCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, Azure.ResourceManager.Communication.Models.RegenerateCommunicationServiceKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceKeys>> RegenerateKeyCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, Azure.ResourceManager.Communication.Models.RegenerateCommunicationServiceKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceResource> UpdateCommunicationService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, Azure.ResourceManager.Communication.Models.CommunicationServiceResourceUpdate communicationServiceResourceUpdate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Communication.Models.CommunicationServiceResource>> UpdateCommunicationServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string communicationServiceName, Azure.ResourceManager.Communication.Models.CommunicationServiceResourceUpdate communicationServiceResourceUpdate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.CommunicationDomainResource> UpdateDomain(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.UpdateDomainRequestContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.CommunicationDomainResource>> UpdateDomainAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, string domainName, Azure.ResourceManager.Communication.Models.UpdateDomainRequestContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.EmailServiceResource> UpdateEmailService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, Azure.ResourceManager.Communication.Models.EmailServiceResourceUpdate emailServiceResourceUpdate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Communication.Models.EmailServiceResource>> UpdateEmailServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.WaitUntil waitUntil, string emailServiceName, Azure.ResourceManager.Communication.Models.EmailServiceResourceUpdate emailServiceResourceUpdate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Communication.Models
{
    public static partial class ArmCommunicationModelFactory
    {
        public static Azure.ResourceManager.Communication.Models.CommunicationDomainResource CommunicationDomainResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Communication.Models.DomainProvisioningState? provisioningState = default(Azure.ResourceManager.Communication.Models.DomainProvisioningState?), string dataLocation = null, string fromSenderDomain = null, string mailFromSenderDomain = null, Azure.ResourceManager.Communication.Models.DomainManagement? domainManagement = default(Azure.ResourceManager.Communication.Models.DomainManagement?), Azure.ResourceManager.Communication.Models.DomainPropertiesVerificationStates verificationStates = null, Azure.ResourceManager.Communication.Models.DomainPropertiesVerificationRecords verificationRecords = null, Azure.ResourceManager.Communication.Models.UserEngagementTracking? userEngagementTracking = default(Azure.ResourceManager.Communication.Models.UserEngagementTracking?)) { throw null; }
        public static Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityResult CommunicationNameAvailabilityResult(bool? isNameAvailable = default(bool?), Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason? reason = default(Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason?), string message = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceKeys CommunicationServiceKeys(string primaryKey = null, string secondaryKey = null, string primaryConnectionString = null, string secondaryConnectionString = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceResource CommunicationServiceResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState? provisioningState = default(Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState?), string hostName = null, string dataLocation = null, Azure.Core.ResourceIdentifier notificationHubId = null, string version = null, System.Guid? immutableResourceId = default(System.Guid?), System.Collections.Generic.IEnumerable<string> linkedDomains = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainPropertiesVerificationRecords DomainPropertiesVerificationRecords(Azure.ResourceManager.Communication.Models.VerificationDnsRecord domain = null, Azure.ResourceManager.Communication.Models.VerificationDnsRecord spf = null, Azure.ResourceManager.Communication.Models.VerificationDnsRecord dkim = null, Azure.ResourceManager.Communication.Models.VerificationDnsRecord dkim2 = null, Azure.ResourceManager.Communication.Models.VerificationDnsRecord dmarc = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainPropertiesVerificationStates DomainPropertiesVerificationStates(Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord domain = null, Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord spf = null, Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord dkim = null, Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord dkim2 = null, Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord dmarc = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord DomainVerificationStatusRecord(Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus? status = default(Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus?), string errorCode = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.EmailServiceResource EmailServiceResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState? provisioningState = default(Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState?), string dataLocation = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.LinkedNotificationHub LinkedNotificationHub(Azure.Core.ResourceIdentifier resourceId = null) { throw null; }
        public static Azure.ResourceManager.Communication.Models.SenderUsernameResource SenderUsernameResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string dataLocation = null, string username = null, string displayName = null, Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState? provisioningState = default(Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.Communication.Models.VerificationDnsRecord VerificationDnsRecord(string dnsRecordType = null, string name = null, string value = null, int? timeToLiveInSeconds = default(int?)) { throw null; }
    }
    public partial class CommunicationAcceptTags
    {
        public CommunicationAcceptTags() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class CommunicationDomainResource : Azure.ResourceManager.Models.TrackedResourceData
    {
        public CommunicationDomainResource(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string DataLocation { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainManagement? DomainManagement { get { throw null; } set { } }
        public string FromSenderDomain { get { throw null; } }
        public string MailFromSenderDomain { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.UserEngagementTracking? UserEngagementTracking { get { throw null; } set { } }
        public Azure.ResourceManager.Communication.Models.DomainPropertiesVerificationRecords VerificationRecords { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainPropertiesVerificationStates VerificationStates { get { throw null; } }
    }
    public partial class CommunicationNameAvailabilityContent
    {
        public CommunicationNameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public Azure.Core.ResourceType? ResourceType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CommunicationNameAvailabilityReason : System.IEquatable<Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CommunicationNameAvailabilityReason(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason AlreadyExists { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason Invalid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason left, Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason left, Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CommunicationNameAvailabilityResult
    {
        internal CommunicationNameAvailabilityResult() { }
        public bool? IsNameAvailable { get { throw null; } }
        public string Message { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityReason? Reason { get { throw null; } }
    }
    public partial class CommunicationServiceKeys
    {
        internal CommunicationServiceKeys() { }
        public string PrimaryConnectionString { get { throw null; } }
        public string PrimaryKey { get { throw null; } }
        public string SecondaryConnectionString { get { throw null; } }
        public string SecondaryKey { get { throw null; } }
    }
    public enum CommunicationServiceKeyType
    {
        Primary = 0,
        Secondary = 1,
    }
    public partial class CommunicationServiceNameAvailabilityContent : Azure.ResourceManager.Communication.Models.CommunicationNameAvailabilityContent
    {
        public CommunicationServiceNameAvailabilityContent() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CommunicationServiceProvisioningState : System.IEquatable<Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CommunicationServiceProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Moving { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Unknown { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState left, Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState left, Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CommunicationServiceResource : Azure.ResourceManager.Models.TrackedResourceData
    {
        public CommunicationServiceResource(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string DataLocation { get { throw null; } set { } }
        public string HostName { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Guid? ImmutableResourceId { get { throw null; } }
        public System.Collections.Generic.IList<string> LinkedDomains { get { throw null; } }
        public Azure.Core.ResourceIdentifier NotificationHubId { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState? ProvisioningState { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class CommunicationServiceResourceUpdate : Azure.ResourceManager.Communication.Models.CommunicationAcceptTags
    {
        public CommunicationServiceResourceUpdate() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LinkedDomains { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CommunicationServicesProvisioningState : System.IEquatable<Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CommunicationServicesProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Moving { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Unknown { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState left, Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState left, Azure.ResourceManager.Communication.Models.CommunicationServicesProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainManagement : System.IEquatable<Azure.ResourceManager.Communication.Models.DomainManagement>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainManagement(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainManagement AzureManaged { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainManagement CustomerManaged { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainManagement CustomerManagedInExchangeOnline { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.DomainManagement other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.DomainManagement left, Azure.ResourceManager.Communication.Models.DomainManagement right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.DomainManagement (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.DomainManagement left, Azure.ResourceManager.Communication.Models.DomainManagement right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DomainPropertiesVerificationRecords
    {
        internal DomainPropertiesVerificationRecords() { }
        public Azure.ResourceManager.Communication.Models.VerificationDnsRecord Dkim { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.VerificationDnsRecord Dkim2 { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.VerificationDnsRecord Dmarc { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.VerificationDnsRecord Domain { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.VerificationDnsRecord Spf { get { throw null; } }
    }
    public partial class DomainPropertiesVerificationStates
    {
        internal DomainPropertiesVerificationStates() { }
        public Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord Dkim { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord Dkim2 { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord Dmarc { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord Domain { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainVerificationStatusRecord Spf { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainProvisioningState : System.IEquatable<Azure.ResourceManager.Communication.Models.DomainProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Moving { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Unknown { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.DomainProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.DomainProvisioningState left, Azure.ResourceManager.Communication.Models.DomainProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.DomainProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.DomainProvisioningState left, Azure.ResourceManager.Communication.Models.DomainProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainRecordVerificationStatus : System.IEquatable<Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainRecordVerificationStatus(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus CancellationRequested { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus NotStarted { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus VerificationFailed { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus VerificationInProgress { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus VerificationRequested { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus Verified { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus left, Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus left, Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainRecordVerificationType : System.IEquatable<Azure.ResourceManager.Communication.Models.DomainRecordVerificationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainRecordVerificationType(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationType Dkim { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationType Dkim2 { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationType Dmarc { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationType Domain { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.DomainRecordVerificationType Spf { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.DomainRecordVerificationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.DomainRecordVerificationType left, Azure.ResourceManager.Communication.Models.DomainRecordVerificationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.DomainRecordVerificationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.DomainRecordVerificationType left, Azure.ResourceManager.Communication.Models.DomainRecordVerificationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DomainsRecordVerificationContent
    {
        public DomainsRecordVerificationContent(Azure.ResourceManager.Communication.Models.DomainRecordVerificationType verificationType) { }
        public Azure.ResourceManager.Communication.Models.DomainRecordVerificationType VerificationType { get { throw null; } }
    }
    public partial class DomainVerificationStatusRecord
    {
        internal DomainVerificationStatusRecord() { }
        public string ErrorCode { get { throw null; } }
        public Azure.ResourceManager.Communication.Models.DomainRecordVerificationStatus? Status { get { throw null; } }
    }
    public partial class EmailServiceResource : Azure.ResourceManager.Models.TrackedResourceData
    {
        public EmailServiceResource(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string DataLocation { get { throw null; } set { } }
        public Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class EmailServiceResourceUpdate : Azure.ResourceManager.Communication.Models.CommunicationAcceptTags
    {
        public EmailServiceResourceUpdate() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EmailServicesProvisioningState : System.IEquatable<Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EmailServicesProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Moving { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Running { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Unknown { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState left, Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState left, Azure.ResourceManager.Communication.Models.EmailServicesProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinkedNotificationHub
    {
        internal LinkedNotificationHub() { }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
    }
    public partial class LinkNotificationHubContent
    {
        public LinkNotificationHubContent(Azure.Core.ResourceIdentifier resourceId, string connectionString) { }
        public string ConnectionString { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
    }
    public partial class RegenerateCommunicationServiceKeyContent
    {
        public RegenerateCommunicationServiceKeyContent() { }
        public Azure.ResourceManager.Communication.Models.CommunicationServiceKeyType? KeyType { get { throw null; } set { } }
    }
    public partial class SenderUsernameResource : Azure.ResourceManager.Models.ResourceData
    {
        public SenderUsernameResource() { }
        public string DataLocation { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.Communication.Models.CommunicationServiceProvisioningState? ProvisioningState { get { throw null; } }
        public string Username { get { throw null; } set { } }
    }
    public partial class UpdateDomainRequestContent : Azure.ResourceManager.Communication.Models.CommunicationAcceptTags
    {
        public UpdateDomainRequestContent() { }
        public Azure.ResourceManager.Communication.Models.UserEngagementTracking? UserEngagementTracking { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UserEngagementTracking : System.IEquatable<Azure.ResourceManager.Communication.Models.UserEngagementTracking>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UserEngagementTracking(string value) { throw null; }
        public static Azure.ResourceManager.Communication.Models.UserEngagementTracking Disabled { get { throw null; } }
        public static Azure.ResourceManager.Communication.Models.UserEngagementTracking Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Communication.Models.UserEngagementTracking other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Communication.Models.UserEngagementTracking left, Azure.ResourceManager.Communication.Models.UserEngagementTracking right) { throw null; }
        public static implicit operator Azure.ResourceManager.Communication.Models.UserEngagementTracking (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Communication.Models.UserEngagementTracking left, Azure.ResourceManager.Communication.Models.UserEngagementTracking right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VerificationDnsRecord
    {
        internal VerificationDnsRecord() { }
        public string DnsRecordType { get { throw null; } }
        public string Name { get { throw null; } }
        public int? TimeToLiveInSeconds { get { throw null; } }
        public string Value { get { throw null; } }
    }
}
