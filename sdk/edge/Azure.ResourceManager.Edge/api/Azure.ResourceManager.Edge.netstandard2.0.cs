namespace Azure.ResourceManager.Edge
{
    public static partial class EdgeExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Edge.UpdateResource> GetUpdate(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Edge.UpdateResource>> GetUpdateAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Edge.UpdateResource GetUpdateResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Edge.UpdateCollection GetUpdates(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope) { throw null; }
    }
    public partial class UpdateCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Edge.UpdateResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Edge.UpdateResource>, System.Collections.IEnumerable
    {
        protected UpdateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Edge.UpdateResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string updateName, Azure.ResourceManager.Edge.UpdateData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Edge.UpdateResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string updateName, Azure.ResourceManager.Edge.UpdateData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Edge.UpdateResource> Get(string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Edge.UpdateResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Edge.UpdateResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Edge.UpdateResource>> GetAsync(string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Edge.UpdateResource> GetIfExists(string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Edge.UpdateResource>> GetIfExistsAsync(string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Edge.UpdateResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Edge.UpdateResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Edge.UpdateResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Edge.UpdateResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class UpdateData : Azure.ResourceManager.Models.ResourceData
    {
        public UpdateData() { }
        public Azure.ResourceManager.Edge.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Edge.Models.UpdateStatus? Status { get { throw null; } set { } }
    }
    public partial class UpdateResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected UpdateResource() { }
        public virtual Azure.ResourceManager.Edge.UpdateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string resourceUri, string updateName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Edge.UpdateResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Edge.UpdateResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Edge.UpdateResource> Update(Azure.ResourceManager.Edge.Models.UpdatePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Edge.UpdateResource>> UpdateAsync(Azure.ResourceManager.Edge.Models.UpdatePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Edge.Mocking
{
    public partial class MockableEdgeArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableEdgeArmClient() { }
        public virtual Azure.Response<Azure.ResourceManager.Edge.UpdateResource> GetUpdate(Azure.Core.ResourceIdentifier scope, string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Edge.UpdateResource>> GetUpdateAsync(Azure.Core.ResourceIdentifier scope, string updateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Edge.UpdateResource GetUpdateResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Edge.UpdateCollection GetUpdates(Azure.Core.ResourceIdentifier scope) { throw null; }
    }
}
namespace Azure.ResourceManager.Edge.Models
{
    public static partial class ArmEdgeModelFactory
    {
        public static Azure.ResourceManager.Edge.UpdateData UpdateData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Edge.Models.UpdateStatus? status = default(Azure.ResourceManager.Edge.Models.UpdateStatus?), Azure.ResourceManager.Edge.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Edge.Models.ProvisioningState?)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Edge.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Edge.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Edge.Models.ProvisioningState left, Azure.ResourceManager.Edge.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Edge.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Edge.Models.ProvisioningState left, Azure.ResourceManager.Edge.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UpdatePatch
    {
        public UpdatePatch() { }
        public string Status { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UpdateStatus : System.IEquatable<Azure.ResourceManager.Edge.Models.UpdateStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UpdateStatus(string value) { throw null; }
        public static Azure.ResourceManager.Edge.Models.UpdateStatus NeedsAttention { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.UpdateStatus Unknown { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.UpdateStatus UpdateAvailable { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.UpdateStatus UpdateInProgress { get { throw null; } }
        public static Azure.ResourceManager.Edge.Models.UpdateStatus UptoDate { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Edge.Models.UpdateStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Edge.Models.UpdateStatus left, Azure.ResourceManager.Edge.Models.UpdateStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Edge.Models.UpdateStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Edge.Models.UpdateStatus left, Azure.ResourceManager.Edge.Models.UpdateStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
}
