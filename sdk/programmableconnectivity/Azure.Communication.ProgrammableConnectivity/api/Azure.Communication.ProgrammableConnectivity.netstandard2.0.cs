namespace Azure.Communication.ProgrammableConnectivity
{
    public static partial class CommunicationProgrammableConnectivityModelFactory
    {
        public static Azure.Communication.ProgrammableConnectivity.DeviceLocationVerificationResult DeviceLocationVerificationResult(bool verificationResult = false) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.NetworkRetrievalResult NetworkRetrievalResult(string networkCode = null) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.NumberRetrievalResult NumberRetrievalResult(string phoneNumber = null) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.NumberVerificationResult NumberVerificationResult(bool verificationResult = false) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.SimSwapRetrievalResult SimSwapRetrievalResult(System.DateTimeOffset date = default(System.DateTimeOffset)) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.SimSwapVerificationResult SimSwapVerificationResult(bool verificationResult = false) { throw null; }
    }
    public partial class DeviceLocation
    {
        protected DeviceLocation() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.Communication.ProgrammableConnectivity.DeviceLocationVerificationResult> Verify(Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum location, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.DeviceLocationVerificationContent deviceLocationVerificationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Verify(string location, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.ProgrammableConnectivity.DeviceLocationVerificationResult>> VerifyAsync(Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum location, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.DeviceLocationVerificationContent deviceLocationVerificationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyAsync(string location, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeviceLocationEnum : System.IEquatable<Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeviceLocationEnum(string value) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum Location { get { throw null; } }
        public bool Equals(Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum left, Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum right) { throw null; }
        public static implicit operator Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum (string value) { throw null; }
        public static bool operator !=(Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum left, Azure.Communication.ProgrammableConnectivity.DeviceLocationEnum right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeviceLocationVerificationContent
    {
        public DeviceLocationVerificationContent(Azure.Communication.ProgrammableConnectivity.NetworkIdentifier networkIdentifier, float latitude, float longitude, int accuracy, Azure.Communication.ProgrammableConnectivity.LocationDevice locationDevice) { }
        public int Accuracy { get { throw null; } }
        public float Latitude { get { throw null; } }
        public Azure.Communication.ProgrammableConnectivity.LocationDevice LocationDevice { get { throw null; } }
        public float Longitude { get { throw null; } }
        public Azure.Communication.ProgrammableConnectivity.NetworkIdentifier NetworkIdentifier { get { throw null; } }
    }
    public partial class DeviceLocationVerificationResult
    {
        internal DeviceLocationVerificationResult() { }
        public bool VerificationResult { get { throw null; } }
    }
    public partial class DeviceNetwork
    {
        protected DeviceNetwork() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.Communication.ProgrammableConnectivity.NetworkRetrievalResult> Retrieve(Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum network, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.DeviceNetworkIdentifier deviceNetworkIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Retrieve(string network, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.ProgrammableConnectivity.NetworkRetrievalResult>> RetrieveAsync(Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum network, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.DeviceNetworkIdentifier deviceNetworkIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RetrieveAsync(string network, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeviceNetworkEnum : System.IEquatable<Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeviceNetworkEnum(string value) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum Network { get { throw null; } }
        public bool Equals(Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum left, Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum right) { throw null; }
        public static implicit operator Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum (string value) { throw null; }
        public static bool operator !=(Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum left, Azure.Communication.ProgrammableConnectivity.DeviceNetworkEnum right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeviceNetworkIdentifier
    {
        public DeviceNetworkIdentifier(string identifierType, string deviceIdentifier) { }
        public string DeviceIdentifier { get { throw null; } }
        public string IdentifierType { get { throw null; } }
    }
    public partial class Ipv4Address
    {
        public Ipv4Address(string ipv4, int port) { }
        public string Ipv4 { get { throw null; } }
        public int Port { get { throw null; } }
    }
    public partial class Ipv6Address
    {
        public Ipv6Address(string ipv6, int port) { }
        public string Ipv6 { get { throw null; } }
        public int Port { get { throw null; } }
    }
    public partial class LocationDevice
    {
        public LocationDevice() { }
        public Azure.Communication.ProgrammableConnectivity.Ipv4Address Ipv4Address { get { throw null; } set { } }
        public Azure.Communication.ProgrammableConnectivity.Ipv6Address Ipv6Address { get { throw null; } set { } }
        public string NetworkAccessIdentifier { get { throw null; } set { } }
        public string PhoneNumber { get { throw null; } set { } }
    }
    public partial class NetworkIdentifier
    {
        public NetworkIdentifier(string identifierType, string identifier) { }
        public string Identifier { get { throw null; } }
        public string IdentifierType { get { throw null; } }
    }
    public partial class NetworkRetrievalResult
    {
        internal NetworkRetrievalResult() { }
        public string NetworkCode { get { throw null; } }
    }
    public partial class NumberRetrievalResult
    {
        internal NumberRetrievalResult() { }
        public string PhoneNumber { get { throw null; } }
    }
    public partial class NumberVerification
    {
        protected NumberVerification() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.Communication.ProgrammableConnectivity.NumberRetrievalResult> Retrieve(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum number, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.NetworkIdentifier networkIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Retrieve(string number, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.ProgrammableConnectivity.NumberRetrievalResult>> RetrieveAsync(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum number, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.NetworkIdentifier networkIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RetrieveAsync(string number, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Communication.ProgrammableConnectivity.NumberVerificationResult> Verify(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum number, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.NumberVerificationContent numberVerificationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Verify(string number, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.ProgrammableConnectivity.NumberVerificationResult>> VerifyAsync(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum number, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.NumberVerificationContent numberVerificationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyAsync(string number, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class NumberVerificationContent
    {
        public NumberVerificationContent(Azure.Communication.ProgrammableConnectivity.NetworkIdentifier networkIdentifier) { }
        public string HashedPhoneNumber { get { throw null; } set { } }
        public Azure.Communication.ProgrammableConnectivity.NetworkIdentifier NetworkIdentifier { get { throw null; } }
        public string PhoneNumber { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NumberVerificationEnum : System.IEquatable<Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NumberVerificationEnum(string value) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum Number { get { throw null; } }
        public bool Equals(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum left, Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum right) { throw null; }
        public static implicit operator Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum (string value) { throw null; }
        public static bool operator !=(Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum left, Azure.Communication.ProgrammableConnectivity.NumberVerificationEnum right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NumberVerificationResult
    {
        internal NumberVerificationResult() { }
        public bool VerificationResult { get { throw null; } }
    }
    public partial class ProgrammableConnectivityClient
    {
        protected ProgrammableConnectivityClient() { }
        public ProgrammableConnectivityClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public ProgrammableConnectivityClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Communication.ProgrammableConnectivity.DeviceLocation GetDeviceLocationClient(string apiVersion = "v2024_01_09_preview") { throw null; }
        public virtual Azure.Communication.ProgrammableConnectivity.DeviceNetwork GetDeviceNetworkClient(string apiVersion = "v2024_01_09_preview") { throw null; }
        public virtual Azure.Communication.ProgrammableConnectivity.NumberVerification GetNumberVerificationClient(string apiVersion = "v2024_01_09_preview") { throw null; }
        public virtual Azure.Communication.ProgrammableConnectivity.SimSwap GetSimSwapClient(string apiVersion = "v2024_01_09_preview") { throw null; }
    }
    public partial class ProgrammableConnectivityClientOptions : Azure.Core.ClientOptions
    {
        public ProgrammableConnectivityClientOptions(Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClientOptions.ServiceVersion version = Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClientOptions.ServiceVersion.V2024_01_09_Preview) { }
        public enum ServiceVersion
        {
            V2024_01_09_Preview = 1,
        }
    }
    public partial class SimSwap
    {
        protected SimSwap() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.Communication.ProgrammableConnectivity.SimSwapRetrievalResult> Retrieve(Azure.Communication.ProgrammableConnectivity.SimSwapEnum simSwap, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.SimSwapRetrievalContent simSwapRetrievalContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Retrieve(string simSwap, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.ProgrammableConnectivity.SimSwapRetrievalResult>> RetrieveAsync(Azure.Communication.ProgrammableConnectivity.SimSwapEnum simSwap, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.SimSwapRetrievalContent simSwapRetrievalContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RetrieveAsync(string simSwap, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Communication.ProgrammableConnectivity.SimSwapVerificationResult> Verify(Azure.Communication.ProgrammableConnectivity.SimSwapEnum simSwap, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.SimSwapVerificationContent simSwapVerificationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Verify(string simSwap, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.ProgrammableConnectivity.SimSwapVerificationResult>> VerifyAsync(Azure.Communication.ProgrammableConnectivity.SimSwapEnum simSwap, string apcGatewayId, Azure.Communication.ProgrammableConnectivity.SimSwapVerificationContent simSwapVerificationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyAsync(string simSwap, string apcGatewayId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SimSwapEnum : System.IEquatable<Azure.Communication.ProgrammableConnectivity.SimSwapEnum>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SimSwapEnum(string value) { throw null; }
        public static Azure.Communication.ProgrammableConnectivity.SimSwapEnum SimSwap { get { throw null; } }
        public bool Equals(Azure.Communication.ProgrammableConnectivity.SimSwapEnum other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.ProgrammableConnectivity.SimSwapEnum left, Azure.Communication.ProgrammableConnectivity.SimSwapEnum right) { throw null; }
        public static implicit operator Azure.Communication.ProgrammableConnectivity.SimSwapEnum (string value) { throw null; }
        public static bool operator !=(Azure.Communication.ProgrammableConnectivity.SimSwapEnum left, Azure.Communication.ProgrammableConnectivity.SimSwapEnum right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SimSwapRetrievalContent
    {
        public SimSwapRetrievalContent(Azure.Communication.ProgrammableConnectivity.NetworkIdentifier networkIdentifier) { }
        public Azure.Communication.ProgrammableConnectivity.NetworkIdentifier NetworkIdentifier { get { throw null; } }
        public string PhoneNumber { get { throw null; } set { } }
    }
    public partial class SimSwapRetrievalResult
    {
        internal SimSwapRetrievalResult() { }
        public System.DateTimeOffset Date { get { throw null; } }
    }
    public partial class SimSwapVerificationContent
    {
        public SimSwapVerificationContent(Azure.Communication.ProgrammableConnectivity.NetworkIdentifier networkIdentifier) { }
        public int? MaxAgeHours { get { throw null; } set { } }
        public Azure.Communication.ProgrammableConnectivity.NetworkIdentifier NetworkIdentifier { get { throw null; } }
        public string PhoneNumber { get { throw null; } set { } }
    }
    public partial class SimSwapVerificationResult
    {
        internal SimSwapVerificationResult() { }
        public bool VerificationResult { get { throw null; } }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class CommunicationProgrammableConnectivityClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClient, Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClientOptions> AddProgrammableConnectivityClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClient, Azure.Communication.ProgrammableConnectivity.ProgrammableConnectivityClientOptions> AddProgrammableConnectivityClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
