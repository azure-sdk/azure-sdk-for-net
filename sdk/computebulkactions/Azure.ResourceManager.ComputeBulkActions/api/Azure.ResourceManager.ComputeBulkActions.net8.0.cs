namespace Azure.ResourceManager.ComputeBulkActions
{
    public partial class AzureResourceManagerComputeBulkActionsContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerComputeBulkActionsContext() { }
        public static Azure.ResourceManager.ComputeBulkActions.AzureResourceManagerComputeBulkActionsContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class BulkActionCollection : Azure.ResourceManager.ArmCollection
    {
        protected BulkActionCollection() { }
        public virtual Azure.Response<bool> Exists(Azure.Core.AzureLocation location, string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.Core.AzureLocation location, string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Models.OperationStatusResult> Get(Azure.Core.AzureLocation location, string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Models.OperationStatusResult>> GetAsync(Azure.Core.AzureLocation location, string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ComputeBulkActions.BulkActionResource> GetIfExists(Azure.Core.AzureLocation location, string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ComputeBulkActions.BulkActionResource>> GetIfExistsAsync(Azure.Core.AzureLocation location, string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BulkActionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BulkActionResource() { }
        public virtual Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, Azure.Core.AzureLocation location, string id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Models.OperationStatusResult> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Models.OperationStatusResult>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ComputeBulkActionsExtensions
    {
        public static Azure.ResourceManager.ComputeBulkActions.BulkActionResource GetBulkActionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.BulkActionCollection GetBulkActions(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, Azure.Core.AzureLocation location) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.BulkActionCollection GetBulkActions(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ComputeBulkActions.BulkActionResource> GetBulkActions(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ComputeBulkActions.BulkActionResource> GetBulkActionsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse> VirtualMachinesCancelOperations(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>> VirtualMachinesCancelOperationsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse> VirtualMachinesExecuteCreate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>> VirtualMachinesExecuteCreateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse> VirtualMachinesExecuteDeallocate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>> VirtualMachinesExecuteDeallocateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse> VirtualMachinesExecuteDelete(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>> VirtualMachinesExecuteDeleteAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse> VirtualMachinesExecuteHibernate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>> VirtualMachinesExecuteHibernateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse> VirtualMachinesExecuteStart(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>> VirtualMachinesExecuteStartAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse> VirtualMachinesGetOperationStatus(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>> VirtualMachinesGetOperationStatusAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LocationBasedLaunchBulkInstancesOperationData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>
    {
        public LocationBasedLaunchBulkInstancesOperationData() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public Azure.ResourceManager.Models.ArmPlan Plan { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public System.Collections.Generic.IList<string> Zones { get { throw null; } }
        protected virtual Azure.ResourceManager.Models.ResourceData JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.Models.ResourceData PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.ComputeBulkActions.Mocking
{
    public partial class MockableComputeBulkActionsArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableComputeBulkActionsArmClient() { }
        public virtual Azure.ResourceManager.ComputeBulkActions.BulkActionResource GetBulkActionResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableComputeBulkActionsResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableComputeBulkActionsResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.BulkActionResource> GetBulkAction(Azure.Core.AzureLocation location, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.BulkActionResource>> GetBulkActionAsync(Azure.Core.AzureLocation location, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ComputeBulkActions.BulkActionCollection GetBulkActions(Azure.Core.AzureLocation location) { throw null; }
    }
    public partial class MockableComputeBulkActionsSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableComputeBulkActionsSubscriptionResource() { }
        public virtual Azure.ResourceManager.ComputeBulkActions.BulkActionCollection GetBulkActions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeBulkActions.BulkActionResource> GetBulkActions(Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeBulkActions.BulkActionResource> GetBulkActionsAsync(Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse> VirtualMachinesCancelOperations(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>> VirtualMachinesCancelOperationsAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse> VirtualMachinesExecuteCreate(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>> VirtualMachinesExecuteCreateAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse> VirtualMachinesExecuteDeallocate(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>> VirtualMachinesExecuteDeallocateAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse> VirtualMachinesExecuteDelete(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>> VirtualMachinesExecuteDeleteAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse> VirtualMachinesExecuteHibernate(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>> VirtualMachinesExecuteHibernateAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse> VirtualMachinesExecuteStart(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>> VirtualMachinesExecuteStartAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse> VirtualMachinesGetOperationStatus(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>> VirtualMachinesGetOperationStatusAsync(Azure.Core.AzureLocation location, Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ComputeBulkActions.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AcceleratorManufacturer : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AcceleratorManufacturer(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer AMD { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer Nvidia { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer Xilinx { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer left, Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer left, Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AcceleratorType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AcceleratorType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType FPGA { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType GPU { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType left, Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType left, Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AdditionalCapabilities : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>
    {
        public AdditionalCapabilities() { }
        public bool? HibernationEnabled { get { throw null; } set { } }
        public bool? UltraSSDEnabled { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AdditionalUnattendContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>
    {
        public AdditionalUnattendContent() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName? ComponentName { get { throw null; } set { } }
        public string Content { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName? PassName { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.SettingNames? SettingName { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AdditionalUnattendContentComponentName : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AdditionalUnattendContentComponentName(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName MicrosoftWindowsShellSetup { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName left, Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName left, Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentComponentName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AdditionalUnattendContentPassName : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AdditionalUnattendContentPassName(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName OobeSystem { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName left, Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName left, Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContentPassName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AllocationStrategy : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AllocationStrategy(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy CapacityOptimized { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy LowestPrice { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy Prioritized { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy left, Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy left, Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>
    {
        internal ApiError() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase> Details { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.InnerError Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ApiError JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ApiError PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ApiError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ApiError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiErrorBase : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>
    {
        internal ApiErrorBase() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArchitectureType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArchitectureType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType ARM64 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType X64 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType left, Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType left, Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmComputeBulkActionsModelFactory
    {
        public static Azure.ResourceManager.ComputeBulkActions.Models.ApiError ApiError(string code = null, string target = null, string message = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase> details = null, Azure.ResourceManager.ComputeBulkActions.Models.InnerError innererror = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ApiErrorBase ApiErrorBase(string code = null, string target = null, string message = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest CancelOperationsRequest(System.Collections.Generic.IEnumerable<string> operationIds = null, string correlationid = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse CancelOperationsResponse(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile ComputeProfile(Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile virtualMachineProfile = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension> extensions = null, string computeApiVersion = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse CreateResourceOperationResponse(string description = null, string type = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse DeallocateResourceOperationResponse(string description = null, string type = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse DeleteResourceOperationResponse(string description = null, string type = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest ExecuteCreateRequest(Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload resourceConfigParameters = null, Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters = null, string correlationid = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest ExecuteDeallocateRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters = null, System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resourcesIds = null, string correlationid = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest ExecuteDeleteRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters = null, System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resourcesIds = null, string correlationid = null, bool? forceDeletion = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest ExecuteHibernateRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters = null, System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resourcesIds = null, string correlationid = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest ExecuteStartRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters = null, System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resourcesIds = null, string correlationid = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest GetOperationStatusRequest(System.Collections.Generic.IEnumerable<string> operationIds = null, string correlationid = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse GetOperationStatusResponse(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse HibernateResourceOperationResponse(string description = null, string type = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.InnerError InnerError(string exceptionType = null, string errorDetail = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties LaunchBulkInstancesOperationProperties(Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState?), int capacity = 0, Azure.ResourceManager.ComputeBulkActions.Models.CapacityType? capacityType = default(Azure.ResourceManager.ComputeBulkActions.Models.CapacityType?), Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile priorityProfile = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile> vmSizesProfile = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes vmAttributes = null, Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile computeProfile = null, Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy zoneAllocationPolicy = null, Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy retryPolicy = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.LocationBasedLaunchBulkInstancesOperationData LocationBasedLaunchBulkInstancesOperationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties properties = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<string> zones = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.Models.ArmPlan plan = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile NetworkProfile(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference> networkInterfaces = null, Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion? networkApiVersion = default(Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration> networkInterfaceConfigurations = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OSProfile OSProfile(string computerName = null, string adminUsername = null, string adminPassword = null, string customData = null, Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration windowsConfiguration = null, Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration linuxConfiguration = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup> secrets = null, bool? allowExtensionOperations = default(bool?), bool? requireGuestProvisionSignal = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation ResourceOperation(Azure.Core.ResourceIdentifier resourceId = null, string errorCode = null, string errorDetails = null, Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails operation = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails ResourceOperationDetails(string operationId = null, Azure.Core.ResourceIdentifier resourceId = null, Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType? opType = default(Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType?), string subscriptionId = null, System.DateTimeOffset? deadline = default(System.DateTimeOffset?), Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType? deadlineType = default(Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType?), Azure.ResourceManager.ComputeBulkActions.Models.OperationState? state = default(Azure.ResourceManager.ComputeBulkActions.Models.OperationState?), string timezone = null, Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError resourceOperationError = null, System.DateTimeOffset? completedOn = default(System.DateTimeOffset?), Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy retryPolicy = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError ResourceOperationError(string errorCode = null, string errorDetails = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload ResourceProvisionPayload(System.Collections.Generic.IDictionary<string, System.BinaryData> baseProfile = null, System.Collections.Generic.IEnumerable<System.Collections.Generic.IDictionary<string, System.BinaryData>> resourceOverrides = null, int resourceCount = 0, string resourcePrefix = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse StartResourceOperationResponse(string description = null, string type = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile StorageProfile(Azure.ResourceManager.ComputeBulkActions.Models.ImageReference imageReference = null, Azure.ResourceManager.ComputeBulkActions.Models.OSDisk osDisk = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk> dataDisks = null, Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes? diskControllerType = default(Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes?)) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup VaultSecretGroup(string sourceVaultId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate> vaultCertificates = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine VirtualMachine(string name = null, Azure.Core.ResourceIdentifier id = null, string type = null, Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus operationStatus = default(Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus), Azure.ResourceManager.ComputeBulkActions.Models.ApiError error = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties VirtualMachineExtensionProperties(string forceUpdateTag = null, string publisher = null, string type = null, string typeHandlerVersion = null, bool? autoUpgradeMinorVersion = default(bool?), bool? enableAutomaticUpgrade = default(bool?), System.Collections.Generic.IDictionary<string, System.BinaryData> settings = null, System.Collections.Generic.IDictionary<string, System.BinaryData> protectedSettings = null, bool? suppressFailures = default(bool?), Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference protectedSettingsFromKeyVault = null, System.Collections.Generic.IEnumerable<string> provisionAfterExtensions = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration VirtualMachineNetworkInterfaceConfiguration(string name = null, Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties VirtualMachineNetworkInterfaceConfigurationProperties(bool? primary = default(bool?), Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions? deleteOption = default(Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions?), bool? enableAcceleratedNetworking = default(bool?), bool? disableTcpStateTracking = default(bool?), bool? enableFpga = default(bool?), bool? enableIPForwarding = default(bool?), string networkSecurityGroupId = null, System.Collections.Generic.IEnumerable<string> dnsServers = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration> ipConfigurations = null, string dscpConfigurationId = null, Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode? auxiliaryMode = default(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode?), Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku? auxiliarySku = default(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku?)) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties VirtualMachineNetworkInterfaceIPConfigurationProperties(string subnetId = null, bool? primary = default(bool?), Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration publicIPAddressConfiguration = null, Azure.ResourceManager.ComputeBulkActions.Models.IPVersions? privateIPAddressVersion = default(Azure.ResourceManager.ComputeBulkActions.Models.IPVersions?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.SubResource> applicationSecurityGroups = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.SubResource> applicationGatewayBackendAddressPools = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.SubResource> loadBalancerBackendAddressPools = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration VirtualMachinePublicIPAddressConfiguration(string name = null, Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties properties = null, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku sku = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties VirtualMachinePublicIPAddressConfigurationProperties(int? idleTimeoutInMinutes = default(int?), Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions? deleteOption = default(Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions?), Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration dnsSettings = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag> ipTags = null, string publicIPPrefixId = null, Azure.ResourceManager.ComputeBulkActions.Models.IPVersions? publicIPAddressVersion = default(Azure.ResourceManager.ComputeBulkActions.Models.IPVersions?), Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod? publicIPAllocationMethod = default(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod?)) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes VMAttributes(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger vCpuCount = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble memoryInGiB = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType> architectureTypes = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble memoryInGiBPerVCpu = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? localStorageSupport = default(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport?), Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble localStorageInGiB = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType> localStorageDiskTypes = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger dataDiskCount = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger networkInterfaceCount = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble networkBandwidthInMbps = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? rdmaSupport = default(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport?), Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger rdmaNetworkInterfaceCount = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? acceleratorSupport = default(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer> acceleratorManufacturers = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType> acceleratorTypes = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger acceleratorCount = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VMCategory> vmCategories = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer> cpuManufacturers = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration> hyperVGenerations = null, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? burstableSupport = default(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport?), System.Collections.Generic.IEnumerable<string> allowedVMSizes = null, System.Collections.Generic.IEnumerable<string> excludedVMSizes = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration WindowsConfiguration(bool? provisionVMAgent = default(bool?), bool? enableAutomaticUpdates = default(bool?), string timeZone = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent> additionalUnattendContent = null, Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings patchSettings = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener> winRMListeners = null) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy ZoneAllocationPolicy(Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy distributionStrategy = default(Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference> zonePreferences = null) { throw null; }
    }
    public partial class BootDiagnostics : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>
    {
        public BootDiagnostics() { }
        public bool? Enabled { get { throw null; } set { } }
        public string StorageUri { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CachingTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CachingTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes None { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes ReadOnly { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes ReadWrite { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes left, Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes left, Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CancelOperationsRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>
    {
        public CancelOperationsRequest(System.Collections.Generic.IEnumerable<string> operationIds, string correlationid) { }
        public string Correlationid { get { throw null; } }
        public System.Collections.Generic.IList<string> OperationIds { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CancelOperationsResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>
    {
        internal CancelOperationsResponse() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CancelOperationsResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CapacityType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.CapacityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CapacityType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CapacityType VCpu { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CapacityType VM { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.CapacityType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.CapacityType left, Azure.ResourceManager.ComputeBulkActions.Models.CapacityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.CapacityType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.CapacityType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.CapacityType left, Azure.ResourceManager.ComputeBulkActions.Models.CapacityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ComputeProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>
    {
        public ComputeProfile(Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile virtualMachineProfile) { }
        public string ComputeApiVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension> Extensions { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile VirtualMachineProfile { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CpuManufacturer : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CpuManufacturer(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer AMD { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer Ampere { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer Intel { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer Microsoft { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer left, Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer left, Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CreateResourceOperationResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>
    {
        internal CreateResourceOperationResponse() { }
        public string Description { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.CreateResourceOperationResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataDisk : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>
    {
        public DataDisk(int lun, Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes createOption) { }
        public Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes? Caching { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes CreateOption { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes? DeleteOption { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes? DetachOption { get { throw null; } set { } }
        public int? DiskSizeGB { get { throw null; } set { } }
        public string ImageUri { get { throw null; } set { } }
        public int Lun { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters ManagedDisk { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string SourceResourceId { get { throw null; } set { } }
        public bool? ToBeDetached { get { throw null; } set { } }
        public string VhdUri { get { throw null; } set { } }
        public bool? WriteAcceleratorEnabled { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DataDisk JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DataDisk PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.DataDisk System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.DataDisk System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeadlineType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeadlineType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType CompleteBy { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType InitiateAt { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType left, Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType left, Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeallocateResourceOperationResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>
    {
        internal DeallocateResourceOperationResponse() { }
        public string Description { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeallocateResourceOperationResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteOptions : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteOptions(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions Delete { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions Detach { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions left, Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions left, Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeleteResourceOperationResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>
    {
        internal DeleteResourceOperationResponse() { }
        public string Description { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DeleteResourceOperationResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiffDiskOptions : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiffDiskOptions(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions Local { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions left, Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions left, Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiffDiskPlacement : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiffDiskPlacement(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement CacheDisk { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement NvmeDisk { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement ResourceDisk { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement left, Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement left, Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiffDiskSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>
    {
        public DiffDiskSettings() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskOptions? Option { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskPlacement? Placement { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskControllerTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskControllerTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes NVMe { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes SCSI { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskCreateOptionTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskCreateOptionTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes Attach { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes Copy { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes Empty { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes FromImage { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes Restore { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskDeleteOptionTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskDeleteOptionTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes Delete { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes Detach { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskDetachOptionTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskDetachOptionTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes ForceDetach { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DiskDetachOptionTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiskEncryptionSetParameters : Azure.ResourceManager.ComputeBulkActions.Models.SubResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>
    {
        public DiskEncryptionSetParameters() { }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSetParameters>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DiskEncryptionSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>
    {
        public DiskEncryptionSettings() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference DiskEncryptionKey { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference KeyEncryptionKey { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainNameLabelScopeTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainNameLabelScopeTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes NoReuse { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes ResourceGroupReuse { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes SubscriptionReuse { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes TenantReuse { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes left, Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EventGridAndResourceGraph : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>
    {
        public EventGridAndResourceGraph() { }
        public bool? Enable { get { throw null; } set { } }
        public string ScheduledEventsApiVersion { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EvictionPolicy : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EvictionPolicy(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy Deallocate { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy Delete { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy left, Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy left, Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ExecuteCreateRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>
    {
        public ExecuteCreateRequest(Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload resourceConfigParameters, Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters) { }
        public string Correlationid { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters ExecutionParameters { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload ResourceConfigParameters { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteCreateRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteDeallocateRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>
    {
        public ExecuteDeallocateRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters, string correlationid) { }
        public string Correlationid { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ResourcesIds { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeallocateRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteDeleteRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>
    {
        public ExecuteDeleteRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters, string correlationid) { }
        public string Correlationid { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters ExecutionParameters { get { throw null; } }
        public bool? ForceDeletion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ResourcesIds { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteDeleteRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteHibernateRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>
    {
        public ExecuteHibernateRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters, string correlationid) { }
        public string Correlationid { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ResourcesIds { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteHibernateRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteStartRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>
    {
        public ExecuteStartRequest(Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters executionParameters, string correlationid) { }
        public string Correlationid { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ResourcesIds { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecuteStartRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecutionParameters : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>
    {
        public ExecutionParameters() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference? OptimizationPreference { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy RetryPolicy { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ExecutionParameters>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GetOperationStatusRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>
    {
        public GetOperationStatusRequest(System.Collections.Generic.IEnumerable<string> operationIds, string correlationid) { }
        public string Correlationid { get { throw null; } }
        public System.Collections.Generic.IList<string> OperationIds { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GetOperationStatusResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>
    {
        internal GetOperationStatusResponse() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.GetOperationStatusResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HibernateResourceOperationResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>
    {
        internal HibernateResourceOperationResponse() { }
        public string Description { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HibernateResourceOperationResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HostEndpointSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>
    {
        public HostEndpointSettings() { }
        public string InVMAccessControlProfileReferenceId { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.Modes? Mode { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HyperVGeneration : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HyperVGeneration(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration Gen1 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration Gen2 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration left, Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration left, Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ImageReference : Azure.ResourceManager.ComputeBulkActions.Models.SubResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>
    {
        public ImageReference() { }
        public string CommunityGalleryImageId { get { throw null; } set { } }
        public string Offer { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public string SharedGalleryImageId { get { throw null; } set { } }
        public string Sku { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ImageReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ImageReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ImageReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class InnerError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>
    {
        internal InnerError() { }
        public string ErrorDetail { get { throw null; } }
        public string ExceptionType { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.InnerError JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.InnerError PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.InnerError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.InnerError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.InnerError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IPVersions : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.IPVersions>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IPVersions(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.IPVersions IPv4 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.IPVersions IPv6 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.IPVersions other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.IPVersions left, Azure.ResourceManager.ComputeBulkActions.Models.IPVersions right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.IPVersions (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.IPVersions? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.IPVersions left, Azure.ResourceManager.ComputeBulkActions.Models.IPVersions right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KeyVaultKeyReference : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>
    {
        public KeyVaultKeyReference(string keyUri) { }
        public string KeyUri { get { throw null; } set { } }
        public string SourceVaultId { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultKeyReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultSecretReference : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>
    {
        public KeyVaultSecretReference(string secretUri) { }
        public string SecretUri { get { throw null; } set { } }
        public string SourceVaultId { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LaunchBulkInstancesOperationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>
    {
        public LaunchBulkInstancesOperationProperties(int capacity, Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile priorityProfile, Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile computeProfile) { }
        public int Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.CapacityType? CapacityType { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ComputeProfile ComputeProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile PriorityProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy RetryPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes VmAttributes { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile> VmSizesProfile { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy ZoneAllocationPolicy { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LaunchBulkInstancesOperationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LinuxConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>
    {
        public LinuxConfiguration() { }
        public bool? DisablePasswordAuthentication { get { throw null; } set { } }
        public bool? EnableVMAgentPlatformUpdates { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings PatchSettings { get { throw null; } set { } }
        public bool? ProvisionVMAgent { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey> SshPublicKeys { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinuxPatchAssessmentMode : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinuxPatchAssessmentMode(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode AutomaticByPlatform { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode ImageDefault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode left, Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode left, Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinuxPatchSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>
    {
        public LinuxPatchSettings() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchAssessmentMode? AssessmentMode { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode? PatchMode { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxPatchSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinuxVMGuestPatchAutomaticByPlatformRebootSetting : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinuxVMGuestPatchAutomaticByPlatformRebootSetting(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting Always { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting IfRequired { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting Never { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting left, Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting left, Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinuxVMGuestPatchAutomaticByPlatformSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>
    {
        public LinuxVMGuestPatchAutomaticByPlatformSettings() { }
        public bool? BypassPlatformSafetyChecksOnUserSchedule { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformRebootSetting? RebootSetting { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchAutomaticByPlatformSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinuxVMGuestPatchMode : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinuxVMGuestPatchMode(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode AutomaticByPlatform { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode ImageDefault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode left, Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode left, Azure.ResourceManager.ComputeBulkActions.Models.LinuxVMGuestPatchMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LocalStorageDiskType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LocalStorageDiskType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType HDD { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType SSD { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType left, Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType left, Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedDiskParameters : Azure.ResourceManager.ComputeBulkActions.Models.SubResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>
    {
        public ManagedDiskParameters() { }
        public string DiskEncryptionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile SecurityProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes? StorageAccountType { get { throw null; } set { } }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Mode : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.Mode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Mode(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.Mode Audit { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.Mode Enforce { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.Mode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.Mode left, Azure.ResourceManager.ComputeBulkActions.Models.Mode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.Mode (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.Mode? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.Mode left, Azure.ResourceManager.ComputeBulkActions.Models.Mode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Modes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.Modes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Modes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.Modes Audit { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.Modes Disabled { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.Modes Enforce { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.Modes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.Modes left, Azure.ResourceManager.ComputeBulkActions.Models.Modes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.Modes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.Modes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.Modes left, Azure.ResourceManager.ComputeBulkActions.Models.Modes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkApiVersion : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkApiVersion(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion _20201101 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion _20221101 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion left, Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion left, Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkInterfaceAuxiliaryMode : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkInterfaceAuxiliaryMode(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode AcceleratedConnections { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode Floating { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode left, Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode left, Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkInterfaceAuxiliarySku : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkInterfaceAuxiliarySku(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku A1 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku A2 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku A4 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku A8 { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku left, Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku left, Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NetworkInterfaceReference : Azure.ResourceManager.ComputeBulkActions.Models.SubResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>
    {
        public NetworkInterfaceReference() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties Properties { get { throw null; } set { } }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.ResourceManager.ComputeBulkActions.Models.SubResource PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkInterfaceReferenceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>
    {
        public NetworkInterfaceReferenceProperties() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions? DeleteOption { get { throw null; } set { } }
        public bool? Primary { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReferenceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>
    {
        public NetworkProfile() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.NetworkApiVersion? NetworkApiVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration> NetworkInterfaceConfigurations { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceReference> NetworkInterfaces { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OperatingSystemTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OperatingSystemTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes Linux { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes Windows { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes left, Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes left, Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OperationState : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.OperationState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OperationState(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Blocked { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Cancelled { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Executing { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState PendingExecution { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState PendingScheduling { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Scheduled { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OperationState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.OperationState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.OperationState left, Azure.ResourceManager.ComputeBulkActions.Models.OperationState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.OperationState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.OperationState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.OperationState left, Azure.ResourceManager.ComputeBulkActions.Models.OperationState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OptimizationPreference : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OptimizationPreference(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference Availability { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference Cost { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference CostAvailabilityBalanced { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference left, Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference left, Azure.ResourceManager.ComputeBulkActions.Models.OptimizationPreference right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OSDisk : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>
    {
        public OSDisk(Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes createOption) { }
        public Azure.ResourceManager.ComputeBulkActions.Models.CachingTypes? Caching { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskCreateOptionTypes CreateOption { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskDeleteOptionTypes? DeleteOption { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiffDiskSettings DiffDiskSettings { get { throw null; } set { } }
        public int? DiskSizeGB { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskEncryptionSettings EncryptionSettings { get { throw null; } set { } }
        public string ImageUri { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ManagedDiskParameters ManagedDisk { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.OperatingSystemTypes? OsType { get { throw null; } set { } }
        public string VhdUri { get { throw null; } set { } }
        public bool? WriteAcceleratorEnabled { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.OSDisk JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.OSDisk PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.OSDisk System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.OSDisk System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSDisk>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSImageNotificationProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>
    {
        public OSImageNotificationProfile() { }
        public bool? Enable { get { throw null; } set { } }
        public string NotBeforeTimeout { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>
    {
        public OSProfile() { }
        public string AdminPassword { get { throw null; } set { } }
        public string AdminUsername { get { throw null; } set { } }
        public bool? AllowExtensionOperations { get { throw null; } set { } }
        public string ComputerName { get { throw null; } set { } }
        public string CustomData { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.LinuxConfiguration LinuxConfiguration { get { throw null; } set { } }
        public bool? RequireGuestProvisionSignal { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup> Secrets { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration WindowsConfiguration { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.OSProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.OSProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.OSProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.OSProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.OSProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PatchSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>
    {
        public PatchSettings() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode? AssessmentMode { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSettings { get { throw null; } set { } }
        public bool? EnableHotpatching { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode? PatchMode { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PriorityProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>
    {
        public PriorityProfile() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.AllocationStrategy? AllocationStrategy { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.EvictionPolicy? EvictionPolicy { get { throw null; } set { } }
        public float? MaxPricePerVM { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType? Type { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PriorityProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProtocolTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProtocolTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes Http { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes Https { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes left, Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes left, Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState left, Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState left, Azure.ResourceManager.ComputeBulkActions.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProxyAgentSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>
    {
        public ProxyAgentSettings() { }
        public bool? AddProxyAgentExtension { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings Imds { get { throw null; } set { } }
        public int? KeyIncarnationId { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.Mode? Mode { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.HostEndpointSettings WireServer { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PublicIPAddressSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>
    {
        public PublicIPAddressSku() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName? Name { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier? Tier { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicIPAddressSkuName : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicIPAddressSkuName(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName Basic { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName left, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName left, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicIPAddressSkuTier : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicIPAddressSkuTier(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier Global { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier Regional { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier left, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier left, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSkuTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicIPAllocationMethod : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicIPAllocationMethod(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod Dynamic { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod Static { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod left, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod left, Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceOperation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>
    {
        internal ResourceOperation() { }
        public string ErrorCode { get { throw null; } }
        public string ErrorDetails { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails Operation { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceOperationDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>
    {
        internal ResourceOperationDetails() { }
        public System.DateTimeOffset? CompletedOn { get { throw null; } }
        public System.DateTimeOffset? Deadline { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DeadlineType? DeadlineType { get { throw null; } }
        public string OperationId { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType? OpType { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError ResourceOperationError { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy RetryPolicy { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.OperationState? State { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public string Timezone { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceOperationError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>
    {
        internal ResourceOperationError() { }
        public string ErrorCode { get { throw null; } }
        public string ErrorDetails { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceOperationType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceOperationType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType Create { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType Deallocate { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType Delete { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType Hibernate { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType Start { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType left, Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType left, Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceProvisionPayload : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>
    {
        public ResourceProvisionPayload(int resourceCount) { }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> BaseProfile { get { throw null; } }
        public int ResourceCount { get { throw null; } }
        public System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, System.BinaryData>> ResourceOverrides { get { throw null; } }
        public string ResourcePrefix { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ResourceProvisionPayload>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RetryPolicy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>
    {
        public RetryPolicy() { }
        public int? RetryCount { get { throw null; } set { } }
        public int? RetryWindowInMinutes { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.RetryPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ScheduledEventsPolicy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>
    {
        public ScheduledEventsPolicy() { }
        public bool? IsAllInstancesDownAutomaticallyApproved { get { throw null; } set { } }
        public bool? IsRebootAutomaticallyApproved { get { throw null; } set { } }
        public bool? IsRedeployAutomaticallyApproved { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.EventGridAndResourceGraph ScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ScheduledEventsProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>
    {
        public ScheduledEventsProfile() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.OSImageNotificationProfile OsImageNotificationProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile TerminateNotificationProfile { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SecurityEncryptionTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SecurityEncryptionTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes DiskWithVMGuestState { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes NonPersistedTPM { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes VMGuestStateOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes left, Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SecurityProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>
    {
        public SecurityProfile() { }
        public bool? EncryptionAtHost { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ProxyAgentSettings ProxyAgentSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes? SecurityType { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings UefiSettings { get { throw null; } set { } }
        public string UserAssignedIdentityResourceId { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SecurityTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SecurityTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes ConfidentialVM { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes TrustedLaunch { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes left, Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes left, Azure.ResourceManager.ComputeBulkActions.Models.SecurityTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SettingNames : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.SettingNames>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SettingNames(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SettingNames AutoLogon { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.SettingNames FirstLogonCommands { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.SettingNames other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.SettingNames left, Azure.ResourceManager.ComputeBulkActions.Models.SettingNames right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.SettingNames (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.SettingNames? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.SettingNames left, Azure.ResourceManager.ComputeBulkActions.Models.SettingNames right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SshPublicKey : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>
    {
        public SshPublicKey() { }
        public string KeyData { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SshPublicKey>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StartResourceOperationResponse : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>
    {
        internal StartResourceOperationResponse() { }
        public string Description { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ResourceOperation> Results { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StartResourceOperationResponse>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StorageAccountTypes : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StorageAccountTypes(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes PremiumLRS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes PremiumV2LRS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes PremiumZRS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes StandardLRS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes StandardSSDLRS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes StandardSSDZRS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes UltraSSDLRS { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes left, Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes left, Azure.ResourceManager.ComputeBulkActions.Models.StorageAccountTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class StorageProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>
    {
        public StorageProfile() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.DataDisk> DataDisks { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DiskControllerTypes? DiskControllerType { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ImageReference ImageReference { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.OSDisk OsDisk { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubResource : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>
    {
        public SubResource() { }
        public string Id { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.SubResource JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.SubResource PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.SubResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.SubResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.SubResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TerminateNotificationProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>
    {
        public TerminateNotificationProfile() { }
        public bool? Enable { get { throw null; } set { } }
        public string NotBeforeTimeout { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.TerminateNotificationProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UefiSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>
    {
        public UefiSettings() { }
        public bool? SecureBootEnabled { get { throw null; } set { } }
        public bool? VTpmEnabled { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.UefiSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VaultCertificate : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>
    {
        public VaultCertificate() { }
        public string CertificateStore { get { throw null; } set { } }
        public string CertificateUri { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VaultSecretGroup : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>
    {
        public VaultSecretGroup() { }
        public string SourceVaultId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VaultCertificate> VaultCertificates { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VaultSecretGroup>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachine : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>
    {
        internal VirtualMachine() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.ApiError Error { get { throw null; } }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus OperationStatus { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachine>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineExtension : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>
    {
        public VirtualMachineExtension(string name, Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties properties) { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtension>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineExtensionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>
    {
        public VirtualMachineExtensionProperties() { }
        public bool? AutoUpgradeMinorVersion { get { throw null; } set { } }
        public bool? EnableAutomaticUpgrade { get { throw null; } set { } }
        public string ForceUpdateTag { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> ProtectedSettings { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.KeyVaultSecretReference ProtectedSettingsFromKeyVault { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ProvisionAfterExtensions { get { throw null; } }
        public string Publisher { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Settings { get { throw null; } }
        public bool? SuppressFailures { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public string TypeHandlerVersion { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineExtensionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineIpTag : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>
    {
        public VirtualMachineIpTag() { }
        public string IpTagType { get { throw null; } set { } }
        public string Tag { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineNetworkInterfaceConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>
    {
        public VirtualMachineNetworkInterfaceConfiguration(string name) { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineNetworkInterfaceConfigurationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>
    {
        public VirtualMachineNetworkInterfaceConfigurationProperties(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration> ipConfigurations) { }
        public Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliaryMode? AuxiliaryMode { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.NetworkInterfaceAuxiliarySku? AuxiliarySku { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions? DeleteOption { get { throw null; } set { } }
        public bool? DisableTcpStateTracking { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> DnsServers { get { throw null; } }
        public string DscpConfigurationId { get { throw null; } set { } }
        public bool? EnableAcceleratedNetworking { get { throw null; } set { } }
        public bool? EnableFpga { get { throw null; } set { } }
        public bool? EnableIPForwarding { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration> IpConfigurations { get { throw null; } }
        public string NetworkSecurityGroupId { get { throw null; } set { } }
        public bool? Primary { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceConfigurationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineNetworkInterfaceIPConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>
    {
        public VirtualMachineNetworkInterfaceIPConfiguration(string name) { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties Properties { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineNetworkInterfaceIPConfigurationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>
    {
        public VirtualMachineNetworkInterfaceIPConfigurationProperties() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.SubResource> ApplicationGatewayBackendAddressPools { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.SubResource> ApplicationSecurityGroups { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.SubResource> LoadBalancerBackendAddressPools { get { throw null; } }
        public bool? Primary { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.IPVersions? PrivateIPAddressVersion { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration PublicIPAddressConfiguration { get { throw null; } set { } }
        public string SubnetId { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineNetworkInterfaceIPConfigurationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachineProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>
    {
        public VirtualMachineProfile() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.AdditionalCapabilities AdditionalCapabilities { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.BootDiagnostics BootDiagnostics { get { throw null; } set { } }
        public string CapacityReservationGroupId { get { throw null; } set { } }
        public string ExtensionsTimeBudget { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication> GalleryApplications { get { throw null; } }
        public string LicenseType { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.NetworkProfile NetworkProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.OSProfile OsProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsPolicy ScheduledEventsPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ScheduledEventsProfile ScheduledEventsProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.SecurityProfile SecurityProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.StorageProfile StorageProfile { get { throw null; } set { } }
        public string UserData { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachinePublicIPAddressConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>
    {
        public VirtualMachinePublicIPAddressConfiguration(string name) { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties Properties { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAddressSku Sku { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachinePublicIPAddressConfigurationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>
    {
        public VirtualMachinePublicIPAddressConfigurationProperties() { }
        public Azure.ResourceManager.ComputeBulkActions.Models.DeleteOptions? DeleteOption { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration DnsSettings { get { throw null; } set { } }
        public int? IdleTimeoutInMinutes { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineIpTag> IpTags { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.IPVersions? PublicIPAddressVersion { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.PublicIPAllocationMethod? PublicIPAllocationMethod { get { throw null; } set { } }
        public string PublicIPPrefixId { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressConfigurationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VirtualMachinePublicIPAddressDnsSettingsConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>
    {
        public VirtualMachinePublicIPAddressDnsSettingsConfiguration(string domainNameLabel) { }
        public string DomainNameLabel { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.DomainNameLabelScopeTypes? DomainNameLabelScope { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VirtualMachineType : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VirtualMachineType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType Regular { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType Spot { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType left, Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType left, Azure.ResourceManager.ComputeBulkActions.Models.VirtualMachineType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VMAttributeMinMaxDouble : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>
    {
        public VMAttributeMinMaxDouble() { }
        public double? Max { get { throw null; } set { } }
        public double? Min { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMAttributeMinMaxInteger : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>
    {
        public VMAttributeMinMaxInteger() { }
        public int? Max { get { throw null; } set { } }
        public int? Min { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMAttributes : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>
    {
        public VMAttributes(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger vCpuCount, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble memoryInGiB, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType> architectureTypes) { }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger AcceleratorCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorManufacturer> AcceleratorManufacturers { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? AcceleratorSupport { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.AcceleratorType> AcceleratorTypes { get { throw null; } }
        public System.Collections.Generic.IList<string> AllowedVMSizes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ArchitectureType> ArchitectureTypes { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? BurstableSupport { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.CpuManufacturer> CpuManufacturers { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger DataDiskCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ExcludedVMSizes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.HyperVGeneration> HyperVGenerations { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.LocalStorageDiskType> LocalStorageDiskTypes { get { throw null; } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble LocalStorageInGiB { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? LocalStorageSupport { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble MemoryInGiB { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble MemoryInGiBPerVCpu { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxDouble NetworkBandwidthInMbps { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger NetworkInterfaceCount { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger RdmaNetworkInterfaceCount { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? RdmaSupport { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeMinMaxInteger VCpuCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.VMCategory> VmCategories { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributes>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VMAttributeSupport : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VMAttributeSupport(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport Excluded { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport Included { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport Required { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport left, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport left, Azure.ResourceManager.ComputeBulkActions.Models.VMAttributeSupport right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VMCategory : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.VMCategory>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VMCategory(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory ComputeOptimized { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory FpgaAccelerated { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory GeneralPurpose { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory GpuAccelerated { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory HighPerformanceCompute { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory MemoryOptimized { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMCategory StorageOptimized { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.VMCategory other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.VMCategory left, Azure.ResourceManager.ComputeBulkActions.Models.VMCategory right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VMCategory (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VMCategory? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.VMCategory left, Azure.ResourceManager.ComputeBulkActions.Models.VMCategory right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VMDiskSecurityProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>
    {
        public VMDiskSecurityProfile() { }
        public string DiskEncryptionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.SecurityEncryptionTypes? SecurityEncryptionType { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMDiskSecurityProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class VMGalleryApplication : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>
    {
        public VMGalleryApplication(string packageReferenceId) { }
        public string ConfigurationReference { get { throw null; } set { } }
        public bool? EnableAutomaticUpgrade { get { throw null; } set { } }
        public int? Order { get { throw null; } set { } }
        public string PackageReferenceId { get { throw null; } set { } }
        public string Tags { get { throw null; } set { } }
        public bool? TreatFailureAsDeploymentFailure { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VMGalleryApplication>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VMOperationStatus : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VMOperationStatus(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus Canceled { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus CancelFailedStatusUnknown { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus Cancelling { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus Creating { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus Deleting { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus left, Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus left, Azure.ResourceManager.ComputeBulkActions.Models.VMOperationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VmSizeProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>
    {
        public VmSizeProfile(string name) { }
        public string Name { get { throw null; } set { } }
        public int? Rank { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.VmSizeProfile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WindowsConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>
    {
        public WindowsConfiguration() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.AdditionalUnattendContent> AdditionalUnattendContent { get { throw null; } }
        public bool? EnableAutomaticUpdates { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.PatchSettings PatchSettings { get { throw null; } set { } }
        public bool? ProvisionVMAgent { get { throw null; } set { } }
        public string TimeZone { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener> WinRMListeners { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WindowsPatchAssessmentMode : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WindowsPatchAssessmentMode(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode AutomaticByPlatform { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode ImageDefault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode left, Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode left, Azure.ResourceManager.ComputeBulkActions.Models.WindowsPatchAssessmentMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WindowsVMGuestPatchAutomaticByPlatformRebootSetting : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WindowsVMGuestPatchAutomaticByPlatformRebootSetting(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting Always { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting IfRequired { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting Never { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting left, Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting left, Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WindowsVMGuestPatchAutomaticByPlatformSettings : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>
    {
        public WindowsVMGuestPatchAutomaticByPlatformSettings() { }
        public bool? BypassPlatformSafetyChecksOnUserSchedule { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformRebootSetting? RebootSetting { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchAutomaticByPlatformSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WindowsVMGuestPatchMode : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WindowsVMGuestPatchMode(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode AutomaticByOS { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode AutomaticByPlatform { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode Manual { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode left, Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode left, Azure.ResourceManager.ComputeBulkActions.Models.WindowsVMGuestPatchMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WinRMListener : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>
    {
        public WinRMListener() { }
        public string CertificateUri { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeBulkActions.Models.ProtocolTypes? Protocol { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.WinRMListener>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ZoneAllocationPolicy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>
    {
        public ZoneAllocationPolicy(Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy distributionStrategy) { }
        public Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy DistributionStrategy { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference> ZonePreferences { get { throw null; } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZoneAllocationPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ZoneDistributionStrategy : System.IEquatable<Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ZoneDistributionStrategy(string value) { throw null; }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy BestEffortBalanced { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy BestEffortSingleZone { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy Prioritized { get { throw null; } }
        public static Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy StrictBalanced { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy left, Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy (string value) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy? (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy left, Azure.ResourceManager.ComputeBulkActions.Models.ZoneDistributionStrategy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ZonePreference : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>
    {
        public ZonePreference(string zone) { }
        public int? Rank { get { throw null; } set { } }
        public string Zone { get { throw null; } set { } }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeBulkActions.Models.ZonePreference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
