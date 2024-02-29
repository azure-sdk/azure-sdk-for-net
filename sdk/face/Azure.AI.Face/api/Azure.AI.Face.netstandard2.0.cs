namespace Azure.AI.Face
{
    public partial class AccessoryItem : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AccessoryItem>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AccessoryItem>
    {
        internal AccessoryItem() { }
        public float Confidence { get { throw null; } }
        public Azure.AI.Face.AccessoryType Type { get { throw null; } }
        Azure.AI.Face.AccessoryItem System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AccessoryItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AccessoryItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.AccessoryItem System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AccessoryItem>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AccessoryItem>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AccessoryItem>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AccessoryType : System.IEquatable<Azure.AI.Face.AccessoryType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AccessoryType(string value) { throw null; }
        public static Azure.AI.Face.AccessoryType Glasses { get { throw null; } }
        public static Azure.AI.Face.AccessoryType Headwear { get { throw null; } }
        public static Azure.AI.Face.AccessoryType Mask { get { throw null; } }
        public bool Equals(Azure.AI.Face.AccessoryType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.AccessoryType left, Azure.AI.Face.AccessoryType right) { throw null; }
        public static implicit operator Azure.AI.Face.AccessoryType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.AccessoryType left, Azure.AI.Face.AccessoryType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AddFaceFromUrlContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AddFaceFromUrlContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceFromUrlContent>
    {
        public AddFaceFromUrlContent(System.Uri url) { }
        public System.Uri Url { get { throw null; } }
        Azure.AI.Face.AddFaceFromUrlContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AddFaceFromUrlContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AddFaceFromUrlContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.AddFaceFromUrlContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceFromUrlContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceFromUrlContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceFromUrlContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AddFaceResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AddFaceResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceResult>
    {
        internal AddFaceResult() { }
        public string PersistedFaceId { get { throw null; } }
        Azure.AI.Face.AddFaceResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AddFaceResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AddFaceResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.AddFaceResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AddFaceResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class AIFaceModelFactory
    {
        public static Azure.AI.Face.AccessoryItem AccessoryItem(Azure.AI.Face.AccessoryType type = default(Azure.AI.Face.AccessoryType), float confidence = 0f) { throw null; }
        public static Azure.AI.Face.AddFaceResult AddFaceResult(string persistedFaceId = null) { throw null; }
        public static Azure.AI.Face.AsyncOperationStatus AsyncOperationStatus(Azure.AI.Face.OperationStatus status = default(Azure.AI.Face.OperationStatus), System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset? finishedDateTime = default(System.DateTimeOffset?), string message = null) { throw null; }
        public static Azure.AI.Face.BlurProperties BlurProperties(Azure.AI.Face.BlurLevel blurLevel = default(Azure.AI.Face.BlurLevel), float value = 0f) { throw null; }
        public static Azure.AI.Face.CreatePersonResult CreatePersonResult(string personId = null) { throw null; }
        public static Azure.AI.Face.DynamicPersonGroup DynamicPersonGroup(string dynamicPersonGroupId = null, string name = null, string userData = null, System.Collections.Generic.IEnumerable<string> addPersonIds = null) { throw null; }
        public static Azure.AI.Face.ExposureProperties ExposureProperties(Azure.AI.Face.ExposureLevel exposureLevel = default(Azure.AI.Face.ExposureLevel), float value = 0f) { throw null; }
        public static Azure.AI.Face.FaceAttributes FaceAttributes(int? age = default(int?), float? smile = default(float?), Azure.AI.Face.FacialHair facialHair = null, Azure.AI.Face.GlassesType? glasses = default(Azure.AI.Face.GlassesType?), Azure.AI.Face.HeadPose headPose = null, Azure.AI.Face.HairProperties hair = null, Azure.AI.Face.OcclusionProperties occlusion = null, System.Collections.Generic.IEnumerable<Azure.AI.Face.AccessoryItem> accessories = null, Azure.AI.Face.BlurProperties blur = null, Azure.AI.Face.ExposureProperties exposure = null, Azure.AI.Face.NoiseProperties noise = null, Azure.AI.Face.MaskProperties mask = null, Azure.AI.Face.QualityForRecognition? qualityForRecognition = default(Azure.AI.Face.QualityForRecognition?)) { throw null; }
        public static Azure.AI.Face.FaceDetectionResult FaceDetectionResult(string faceId = null, string recognitionModel = null, Azure.AI.Face.FaceRectangle faceRectangle = null, Azure.AI.Face.FaceLandmarks faceLandmarks = null, Azure.AI.Face.FaceAttributes faceAttributes = null) { throw null; }
        public static Azure.AI.Face.FaceLandmarks FaceLandmarks(Azure.AI.Face.LandmarkCoordinate pupilLeft = null, Azure.AI.Face.LandmarkCoordinate pupilRight = null, Azure.AI.Face.LandmarkCoordinate noseTip = null, Azure.AI.Face.LandmarkCoordinate mouthLeft = null, Azure.AI.Face.LandmarkCoordinate mouthRight = null, Azure.AI.Face.LandmarkCoordinate eyebrowLeftOuter = null, Azure.AI.Face.LandmarkCoordinate eyebrowLeftInner = null, Azure.AI.Face.LandmarkCoordinate eyeLeftOuter = null, Azure.AI.Face.LandmarkCoordinate eyeLeftTop = null, Azure.AI.Face.LandmarkCoordinate eyeLeftBottom = null, Azure.AI.Face.LandmarkCoordinate eyeLeftInner = null, Azure.AI.Face.LandmarkCoordinate eyebrowRightInner = null, Azure.AI.Face.LandmarkCoordinate eyebrowRightOuter = null, Azure.AI.Face.LandmarkCoordinate eyeRightInner = null, Azure.AI.Face.LandmarkCoordinate eyeRightTop = null, Azure.AI.Face.LandmarkCoordinate eyeRightBottom = null, Azure.AI.Face.LandmarkCoordinate eyeRightOuter = null, Azure.AI.Face.LandmarkCoordinate noseRootLeft = null, Azure.AI.Face.LandmarkCoordinate noseRootRight = null, Azure.AI.Face.LandmarkCoordinate noseLeftAlarTop = null, Azure.AI.Face.LandmarkCoordinate noseRightAlarTop = null, Azure.AI.Face.LandmarkCoordinate noseLeftAlarOutTip = null, Azure.AI.Face.LandmarkCoordinate noseRightAlarOutTip = null, Azure.AI.Face.LandmarkCoordinate upperLipTop = null, Azure.AI.Face.LandmarkCoordinate upperLipBottom = null, Azure.AI.Face.LandmarkCoordinate underLipTop = null, Azure.AI.Face.LandmarkCoordinate underLipBottom = null) { throw null; }
        public static Azure.AI.Face.FaceList FaceList(string name = null, string userData = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), string faceListId = null, System.Collections.Generic.IEnumerable<Azure.AI.Face.FaceListFace> persistedFaces = null) { throw null; }
        public static Azure.AI.Face.FaceListFace FaceListFace(string persistedFaceId = null, string userData = null) { throw null; }
        public static Azure.AI.Face.FaceRectangle FaceRectangle(int top = 0, int left = 0, int width = 0, int height = 0) { throw null; }
        public static Azure.AI.Face.FacialHair FacialHair(float moustache = 0f, float beard = 0f, float sideburns = 0f) { throw null; }
        public static Azure.AI.Face.FindSimilarResult FindSimilarResult(float confidence = 0f, string faceId = null, string persistedFaceId = null) { throw null; }
        public static Azure.AI.Face.GroupResult GroupResult(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<string>> groups = null, System.Collections.Generic.IEnumerable<string> messyGroup = null) { throw null; }
        public static Azure.AI.Face.HairColor HairColor(Azure.AI.Face.HairColorType color = default(Azure.AI.Face.HairColorType), float confidence = 0f) { throw null; }
        public static Azure.AI.Face.HairProperties HairProperties(float bald = 0f, bool invisible = false, System.Collections.Generic.IEnumerable<Azure.AI.Face.HairColor> hairColor = null) { throw null; }
        public static Azure.AI.Face.HeadPose HeadPose(float pitch = 0f, float roll = 0f, float yaw = 0f) { throw null; }
        public static Azure.AI.Face.IdentifyCandidate IdentifyCandidate(string personId = null, float confidence = 0f) { throw null; }
        public static Azure.AI.Face.IdentifyResult IdentifyResult(string faceId = null, System.Collections.Generic.IEnumerable<Azure.AI.Face.IdentifyCandidate> candidates = null) { throw null; }
        public static Azure.AI.Face.LandmarkCoordinate LandmarkCoordinate(float x = 0f, float y = 0f) { throw null; }
        public static Azure.AI.Face.LargeFaceList LargeFaceList(string name = null, string userData = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), string largeFaceListId = null) { throw null; }
        public static Azure.AI.Face.LargeFaceListFace LargeFaceListFace(string persistedFaceId = null, string userData = null) { throw null; }
        public static Azure.AI.Face.LargePersonGroup LargePersonGroup(string name = null, string userData = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), string largePersonGroupId = null) { throw null; }
        public static Azure.AI.Face.LargePersonGroupPerson LargePersonGroupPerson(string personId = null, string name = null, string userData = null, System.Collections.Generic.IEnumerable<string> persistedFaceIds = null) { throw null; }
        public static Azure.AI.Face.LargePersonGroupPersonFace LargePersonGroupPersonFace(string persistedFaceId = null, string userData = null) { throw null; }
        public static Azure.AI.Face.ListFaceResult ListFaceResult(string personId = null, System.Collections.Generic.IEnumerable<string> persistedFaceIds = null) { throw null; }
        public static Azure.AI.Face.ListGroupReferenceResult ListGroupReferenceResult(System.Collections.Generic.IEnumerable<string> dynamicPersonGroupIds = null) { throw null; }
        public static Azure.AI.Face.ListPersonResult ListPersonResult(System.Collections.Generic.IEnumerable<string> personIds = null) { throw null; }
        public static Azure.AI.Face.LivenessSession LivenessSession(string id = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset? sessionStartDateTime = default(System.DateTimeOffset?), bool sessionExpired = false, string deviceCorrelationId = null, int? authTokenTimeToLiveInSeconds = default(int?), Azure.AI.Face.SessionStatus status = default(Azure.AI.Face.SessionStatus), Azure.AI.Face.LivenessSessionAuditEntry result = null) { throw null; }
        public static Azure.AI.Face.LivenessSessionAuditEntry LivenessSessionAuditEntry(long id = (long)0, string sessionId = null, string requestId = null, string clientRequestId = null, System.DateTimeOffset receivedDateTime = default(System.DateTimeOffset), Azure.AI.Face.SessionAuditEntryRequestInfo request = null, Azure.AI.Face.SessionAuditEntryResponseInfo response = null, string digest = null) { throw null; }
        public static Azure.AI.Face.LivenessSessionCreationContent LivenessSessionCreationContent(string livenessOperationMode = null, bool? sendResultsToClient = default(bool?), bool? deviceCorrelationIdSetInClient = default(bool?), string deviceCorrelationId = null, int? authTokenTimeToLiveInSeconds = default(int?)) { throw null; }
        public static Azure.AI.Face.LivenessSessionCreationContentForMultipart LivenessSessionCreationContentForMultipart(string livenessOperationMode = null, bool? sendResultsToClient = default(bool?), bool? deviceCorrelationIdSetInClient = default(bool?), string deviceCorrelationId = null, int? authTokenTimeToLiveInSeconds = default(int?)) { throw null; }
        public static Azure.AI.Face.LivenessSessionCreationResult LivenessSessionCreationResult(string sessionId = null, string authToken = null) { throw null; }
        public static Azure.AI.Face.LivenessSessionItem LivenessSessionItem(string id = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset? sessionStartDateTime = default(System.DateTimeOffset?), bool sessionExpired = false, string deviceCorrelationId = null, int? authTokenTimeToLiveInSeconds = default(int?)) { throw null; }
        public static Azure.AI.Face.LivenessWithVerifySession LivenessWithVerifySession(string id = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset? sessionStartDateTime = default(System.DateTimeOffset?), bool sessionExpired = false, string deviceCorrelationId = null, int? authTokenTimeToLiveInSeconds = default(int?), Azure.AI.Face.SessionStatus status = default(Azure.AI.Face.SessionStatus), Azure.AI.Face.LivenessWithVerifySessionAuditEntry result = null) { throw null; }
        public static Azure.AI.Face.LivenessWithVerifySessionAuditEntry LivenessWithVerifySessionAuditEntry(long id = (long)0, string sessionId = null, string requestId = null, string clientRequestId = null, System.DateTimeOffset receivedDateTime = default(System.DateTimeOffset), Azure.AI.Face.SessionAuditEntryRequestInfo request = null, Azure.AI.Face.SessionAuditEntryResponseInfo response = null, string digest = null) { throw null; }
        public static Azure.AI.Face.MaskProperties MaskProperties(bool noseAndMouthCovered = false, Azure.AI.Face.MaskType type = default(Azure.AI.Face.MaskType)) { throw null; }
        public static Azure.AI.Face.NoiseProperties NoiseProperties(Azure.AI.Face.NoiseLevel noiseLevel = default(Azure.AI.Face.NoiseLevel), float value = 0f) { throw null; }
        public static Azure.AI.Face.OcclusionProperties OcclusionProperties(bool foreheadOccluded = false, bool eyeOccluded = false, bool mouthOccluded = false) { throw null; }
        public static Azure.AI.Face.PersonDirectoryFace PersonDirectoryFace(string persistedFaceId = null, string userData = null) { throw null; }
        public static Azure.AI.Face.PersonDirectoryPerson PersonDirectoryPerson(string personId = null, string name = null, string userData = null) { throw null; }
        public static Azure.AI.Face.PersonGroup PersonGroup(string name = null, string userData = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), string personGroupId = null) { throw null; }
        public static Azure.AI.Face.PersonGroupPerson PersonGroupPerson(string personId = null, string name = null, string userData = null, System.Collections.Generic.IEnumerable<string> persistedFaceIds = null) { throw null; }
        public static Azure.AI.Face.PersonGroupPersonFace PersonGroupPersonFace(string persistedFaceId = null, string userData = null) { throw null; }
        public static Azure.AI.Face.SessionAuditEntryRequestInfo SessionAuditEntryRequestInfo(System.Uri url = null, string method = null, long? contentLength = default(long?), string contentType = null, string userAgent = null) { throw null; }
        public static Azure.AI.Face.SessionAuditEntryResponseInfo SessionAuditEntryResponseInfo(System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> body = null, int statusCode = 0, long latencyInMilliseconds = (long)0) { throw null; }
        public static Azure.AI.Face.TrainingStatus TrainingStatus(Azure.AI.Face.TrainingStatusType status = default(Azure.AI.Face.TrainingStatusType), System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastActionDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastSuccessfulTrainingDateTime = default(System.DateTimeOffset), string message = null) { throw null; }
        public static Azure.AI.Face.VerifyResult VerifyResult(bool isIdentical = false, float confidence = 0f) { throw null; }
    }
    public partial class AsyncOperationStatus : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AsyncOperationStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AsyncOperationStatus>
    {
        internal AsyncOperationStatus() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.DateTimeOffset? FinishedDateTime { get { throw null; } }
        public string Message { get { throw null; } }
        public Azure.AI.Face.OperationStatus Status { get { throw null; } }
        Azure.AI.Face.AsyncOperationStatus System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AsyncOperationStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.AsyncOperationStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.AsyncOperationStatus System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AsyncOperationStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AsyncOperationStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.AsyncOperationStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BlurLevel : System.IEquatable<Azure.AI.Face.BlurLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BlurLevel(string value) { throw null; }
        public static Azure.AI.Face.BlurLevel High { get { throw null; } }
        public static Azure.AI.Face.BlurLevel Low { get { throw null; } }
        public static Azure.AI.Face.BlurLevel Medium { get { throw null; } }
        public bool Equals(Azure.AI.Face.BlurLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.BlurLevel left, Azure.AI.Face.BlurLevel right) { throw null; }
        public static implicit operator Azure.AI.Face.BlurLevel (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.BlurLevel left, Azure.AI.Face.BlurLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BlurProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.BlurProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.BlurProperties>
    {
        internal BlurProperties() { }
        public Azure.AI.Face.BlurLevel BlurLevel { get { throw null; } }
        public float Value { get { throw null; } }
        Azure.AI.Face.BlurProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.BlurProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.BlurProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.BlurProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.BlurProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.BlurProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.BlurProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreatePersonResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.CreatePersonResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.CreatePersonResult>
    {
        internal CreatePersonResult() { }
        public string PersonId { get { throw null; } }
        Azure.AI.Face.CreatePersonResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.CreatePersonResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.CreatePersonResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.CreatePersonResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.CreatePersonResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.CreatePersonResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.CreatePersonResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DetectionModel : System.IEquatable<Azure.AI.Face.DetectionModel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DetectionModel(string value) { throw null; }
        public static Azure.AI.Face.DetectionModel Detection01 { get { throw null; } }
        public static Azure.AI.Face.DetectionModel Detection02 { get { throw null; } }
        public static Azure.AI.Face.DetectionModel Detection03 { get { throw null; } }
        public bool Equals(Azure.AI.Face.DetectionModel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.DetectionModel left, Azure.AI.Face.DetectionModel right) { throw null; }
        public static implicit operator Azure.AI.Face.DetectionModel (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.DetectionModel left, Azure.AI.Face.DetectionModel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DynamicPersonGroup : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.DynamicPersonGroup>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.DynamicPersonGroup>
    {
        public DynamicPersonGroup(string name) { }
        public System.Collections.Generic.IList<string> AddPersonIds { get { throw null; } }
        public string DynamicPersonGroupId { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.DynamicPersonGroup System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.DynamicPersonGroup>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.DynamicPersonGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.DynamicPersonGroup System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.DynamicPersonGroup>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.DynamicPersonGroup>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.DynamicPersonGroup>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ExposureLevel : System.IEquatable<Azure.AI.Face.ExposureLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ExposureLevel(string value) { throw null; }
        public static Azure.AI.Face.ExposureLevel GoodExposure { get { throw null; } }
        public static Azure.AI.Face.ExposureLevel OverExposure { get { throw null; } }
        public static Azure.AI.Face.ExposureLevel UnderExposure { get { throw null; } }
        public bool Equals(Azure.AI.Face.ExposureLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.ExposureLevel left, Azure.AI.Face.ExposureLevel right) { throw null; }
        public static implicit operator Azure.AI.Face.ExposureLevel (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.ExposureLevel left, Azure.AI.Face.ExposureLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ExposureProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ExposureProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ExposureProperties>
    {
        internal ExposureProperties() { }
        public Azure.AI.Face.ExposureLevel ExposureLevel { get { throw null; } }
        public float Value { get { throw null; } }
        Azure.AI.Face.ExposureProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ExposureProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ExposureProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.ExposureProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ExposureProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ExposureProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ExposureProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FaceAsync
    {
        protected FaceAsync() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response GetStatus(string operationId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AsyncOperationStatus> GetStatus(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetStatusAsync(string operationId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AsyncOperationStatus>> GetStatusAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FaceAttributes : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceAttributes>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceAttributes>
    {
        internal FaceAttributes() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Face.AccessoryItem> Accessories { get { throw null; } }
        public int? Age { get { throw null; } }
        public Azure.AI.Face.BlurProperties Blur { get { throw null; } }
        public Azure.AI.Face.ExposureProperties Exposure { get { throw null; } }
        public Azure.AI.Face.FacialHair FacialHair { get { throw null; } }
        public Azure.AI.Face.GlassesType? Glasses { get { throw null; } }
        public Azure.AI.Face.HairProperties Hair { get { throw null; } }
        public Azure.AI.Face.HeadPose HeadPose { get { throw null; } }
        public Azure.AI.Face.MaskProperties Mask { get { throw null; } }
        public Azure.AI.Face.NoiseProperties Noise { get { throw null; } }
        public Azure.AI.Face.OcclusionProperties Occlusion { get { throw null; } }
        public Azure.AI.Face.QualityForRecognition? QualityForRecognition { get { throw null; } }
        public float? Smile { get { throw null; } }
        Azure.AI.Face.FaceAttributes System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceAttributes>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceAttributes>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FaceAttributes System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceAttributes>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceAttributes>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceAttributes>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FaceClient
    {
        protected FaceClient() { }
        public FaceClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public FaceClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Face.FaceClientOptions options) { }
        public FaceClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public FaceClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.AI.Face.FaceClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response DetectFromStream(Azure.Core.RequestContent content, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, string recognitionModel = null, bool? returnRecognitionModel = default(bool?), string detectionModel = null, int? faceIdTimeToLive = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceDetectionResult>> DetectFromStream(System.BinaryData imageContent, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), bool? returnRecognitionModel = default(bool?), Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), int? faceIdTimeToLive = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectFromStreamAsync(Azure.Core.RequestContent content, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, string recognitionModel = null, bool? returnRecognitionModel = default(bool?), string detectionModel = null, int? faceIdTimeToLive = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceDetectionResult>>> DetectFromStreamAsync(System.BinaryData imageContent, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), bool? returnRecognitionModel = default(bool?), Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), int? faceIdTimeToLive = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectFromUrl(Azure.Core.RequestContent content, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, string recognitionModel = null, bool? returnRecognitionModel = default(bool?), string detectionModel = null, int? faceIdTimeToLive = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceDetectionResult>> DetectFromUrl(System.Uri url, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), bool? returnRecognitionModel = default(bool?), Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), int? faceIdTimeToLive = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectFromUrlAsync(Azure.Core.RequestContent content, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, string recognitionModel = null, bool? returnRecognitionModel = default(bool?), string detectionModel = null, int? faceIdTimeToLive = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceDetectionResult>>> DetectFromUrlAsync(System.Uri url, bool? returnFaceId = default(bool?), bool? returnFaceLandmarks = default(bool?), string returnFaceAttributes = null, Azure.AI.Face.RecognitionModel? recognitionModel = default(Azure.AI.Face.RecognitionModel?), bool? returnRecognitionModel = default(bool?), Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), int? faceIdTimeToLive = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response FindSimilar(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FindSimilarResult>> FindSimilar(string faceId, System.Collections.Generic.IEnumerable<string> faceIds, int? maxNumOfCandidatesReturned = default(int?), Azure.AI.Face.FindSimilarMatchMode? mode = default(Azure.AI.Face.FindSimilarMatchMode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> FindSimilarAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FindSimilarResult>>> FindSimilarAsync(string faceId, System.Collections.Generic.IEnumerable<string> faceIds, int? maxNumOfCandidatesReturned = default(int?), Azure.AI.Face.FindSimilarMatchMode? mode = default(Azure.AI.Face.FindSimilarMatchMode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AI.Face.FaceAsync GetFaceAsyncClient() { throw null; }
        public virtual Azure.AI.Face.FaceLists GetFaceListsClient() { throw null; }
        public virtual Azure.AI.Face.LargeFaceLists GetLargeFaceListsClient() { throw null; }
        public virtual Azure.AI.Face.LargePersonGroups GetLargePersonGroupsClient() { throw null; }
        public virtual Azure.AI.Face.LivenessSessions GetLivenessSessionsClient() { throw null; }
        public virtual Azure.AI.Face.LivenessWithVerifySessions GetLivenessWithVerifySessionsClient() { throw null; }
        public virtual Azure.AI.Face.PersonDirectoryDynamicPersonGroups GetPersonDirectoryDynamicPersonGroupsClient() { throw null; }
        public virtual Azure.AI.Face.PersonDirectoryPersons GetPersonDirectoryPersonsClient() { throw null; }
        public virtual Azure.AI.Face.PersonGroups GetPersonGroupsClient() { throw null; }
        public virtual Azure.Response Group(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.GroupResult> Group(System.Collections.Generic.IEnumerable<string> faceIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GroupAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.GroupResult>> GroupAsync(System.Collections.Generic.IEnumerable<string> faceIds, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Verify(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.VerifyResult> Verify(string faceId1, string faceId2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.VerifyResult>> VerifyAsync(string faceId1, string faceId2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FaceClientOptions : Azure.Core.ClientOptions
    {
        public FaceClientOptions(Azure.AI.Face.FaceClientOptions.ServiceVersion version = Azure.AI.Face.FaceClientOptions.ServiceVersion.V1_1_Preview_1) { }
        public enum ServiceVersion
        {
            V1_1_Preview_1 = 1,
        }
    }
    public partial class FaceDetectionResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceDetectionResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceDetectionResult>
    {
        internal FaceDetectionResult() { }
        public Azure.AI.Face.FaceAttributes FaceAttributes { get { throw null; } }
        public string FaceId { get { throw null; } }
        public Azure.AI.Face.FaceLandmarks FaceLandmarks { get { throw null; } }
        public Azure.AI.Face.FaceRectangle FaceRectangle { get { throw null; } }
        public string RecognitionModel { get { throw null; } }
        Azure.AI.Face.FaceDetectionResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceDetectionResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceDetectionResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FaceDetectionResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceDetectionResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceDetectionResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceDetectionResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FaceLandmarks : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceLandmarks>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceLandmarks>
    {
        internal FaceLandmarks() { }
        public Azure.AI.Face.LandmarkCoordinate EyebrowLeftInner { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyebrowLeftOuter { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyebrowRightInner { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyebrowRightOuter { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeLeftBottom { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeLeftInner { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeLeftOuter { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeLeftTop { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeRightBottom { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeRightInner { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeRightOuter { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate EyeRightTop { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate MouthLeft { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate MouthRight { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseLeftAlarOutTip { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseLeftAlarTop { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseRightAlarOutTip { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseRightAlarTop { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseRootLeft { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseRootRight { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate NoseTip { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate PupilLeft { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate PupilRight { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate UnderLipBottom { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate UnderLipTop { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate UpperLipBottom { get { throw null; } }
        public Azure.AI.Face.LandmarkCoordinate UpperLipTop { get { throw null; } }
        Azure.AI.Face.FaceLandmarks System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceLandmarks>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceLandmarks>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FaceLandmarks System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceLandmarks>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceLandmarks>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceLandmarks>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FaceList : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceList>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceList>
    {
        public FaceList(string name) { }
        public string FaceListId { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceListFace> PersistedFaces { get { throw null; } }
        public Azure.AI.Face.RecognitionModel? RecognitionModel { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.FaceList System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceList>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceList>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FaceList System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceList>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceList>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceList>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FaceListFace : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceListFace>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceListFace>
    {
        public FaceListFace() { }
        public string PersistedFaceId { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.FaceListFace System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceListFace>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceListFace>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FaceListFace System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceListFace>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceListFace>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceListFace>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FaceLists
    {
        protected FaceLists() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddFaceFromStream(string faceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromStream(string faceListId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromStreamAsync(string faceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromStreamAsync(string faceListId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromUrl(string faceListId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response AddFaceFromUrl(string faceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromUrlAsync(string faceListId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromUrlAsync(string faceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateList(string faceListId, Azure.AI.Face.FaceList resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateList(string faceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateListAsync(string faceListId, Azure.AI.Face.FaceList resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateListAsync(string faceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteFace(string faceListId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteFaceAsync(string faceListId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteList(string faceListId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteListAsync(string faceListId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response FindSimilarFromFaceList(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FindSimilarResult>> FindSimilarFromFaceList(string faceId, string faceListId, int? maxNumOfCandidatesReturned = default(int?), Azure.AI.Face.FindSimilarMatchMode? mode = default(Azure.AI.Face.FindSimilarMatchMode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> FindSimilarFromFaceListAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FindSimilarResult>>> FindSimilarFromFaceListAsync(string faceId, string faceListId, int? maxNumOfCandidatesReturned = default(int?), Azure.AI.Face.FindSimilarMatchMode? mode = default(Azure.AI.Face.FindSimilarMatchMode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetList(string faceListId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.FaceList> GetList(string faceListId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetListAsync(string faceListId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.FaceList>> GetListAsync(string faceListId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetLists(bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceList>> GetLists(bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetListsAsync(bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FaceList>>> GetListsAsync(bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateList(string faceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateListAsync(string faceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class FaceRectangle : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceRectangle>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceRectangle>
    {
        internal FaceRectangle() { }
        public int Height { get { throw null; } }
        public int Left { get { throw null; } }
        public int Top { get { throw null; } }
        public int Width { get { throw null; } }
        Azure.AI.Face.FaceRectangle System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceRectangle>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FaceRectangle>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FaceRectangle System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceRectangle>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceRectangle>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FaceRectangle>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FacialHair : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FacialHair>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FacialHair>
    {
        internal FacialHair() { }
        public float Beard { get { throw null; } }
        public float Moustache { get { throw null; } }
        public float Sideburns { get { throw null; } }
        Azure.AI.Face.FacialHair System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FacialHair>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FacialHair>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FacialHair System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FacialHair>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FacialHair>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FacialHair>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FindSimilarMatchMode : System.IEquatable<Azure.AI.Face.FindSimilarMatchMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FindSimilarMatchMode(string value) { throw null; }
        public static Azure.AI.Face.FindSimilarMatchMode MatchFace { get { throw null; } }
        public static Azure.AI.Face.FindSimilarMatchMode MatchPerson { get { throw null; } }
        public bool Equals(Azure.AI.Face.FindSimilarMatchMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.FindSimilarMatchMode left, Azure.AI.Face.FindSimilarMatchMode right) { throw null; }
        public static implicit operator Azure.AI.Face.FindSimilarMatchMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.FindSimilarMatchMode left, Azure.AI.Face.FindSimilarMatchMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FindSimilarResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FindSimilarResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FindSimilarResult>
    {
        internal FindSimilarResult() { }
        public float Confidence { get { throw null; } }
        public string FaceId { get { throw null; } }
        public string PersistedFaceId { get { throw null; } }
        Azure.AI.Face.FindSimilarResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FindSimilarResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.FindSimilarResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.FindSimilarResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FindSimilarResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FindSimilarResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.FindSimilarResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GlassesType : System.IEquatable<Azure.AI.Face.GlassesType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GlassesType(string value) { throw null; }
        public static Azure.AI.Face.GlassesType NoGlasses { get { throw null; } }
        public static Azure.AI.Face.GlassesType ReadingGlasses { get { throw null; } }
        public static Azure.AI.Face.GlassesType Sunglasses { get { throw null; } }
        public static Azure.AI.Face.GlassesType SwimmingGoggles { get { throw null; } }
        public bool Equals(Azure.AI.Face.GlassesType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.GlassesType left, Azure.AI.Face.GlassesType right) { throw null; }
        public static implicit operator Azure.AI.Face.GlassesType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.GlassesType left, Azure.AI.Face.GlassesType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GroupResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.GroupResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.GroupResult>
    {
        internal GroupResult() { }
        public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IList<string>> Groups { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> MessyGroup { get { throw null; } }
        Azure.AI.Face.GroupResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.GroupResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.GroupResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.GroupResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.GroupResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.GroupResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.GroupResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HairColor : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HairColor>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairColor>
    {
        internal HairColor() { }
        public Azure.AI.Face.HairColorType Color { get { throw null; } }
        public float Confidence { get { throw null; } }
        Azure.AI.Face.HairColor System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HairColor>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HairColor>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.HairColor System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairColor>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairColor>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairColor>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HairColorType : System.IEquatable<Azure.AI.Face.HairColorType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HairColorType(string value) { throw null; }
        public static Azure.AI.Face.HairColorType Black { get { throw null; } }
        public static Azure.AI.Face.HairColorType Blond { get { throw null; } }
        public static Azure.AI.Face.HairColorType Brown { get { throw null; } }
        public static Azure.AI.Face.HairColorType Gray { get { throw null; } }
        public static Azure.AI.Face.HairColorType Other { get { throw null; } }
        public static Azure.AI.Face.HairColorType Red { get { throw null; } }
        public static Azure.AI.Face.HairColorType UnknownHairColor { get { throw null; } }
        public static Azure.AI.Face.HairColorType White { get { throw null; } }
        public bool Equals(Azure.AI.Face.HairColorType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.HairColorType left, Azure.AI.Face.HairColorType right) { throw null; }
        public static implicit operator Azure.AI.Face.HairColorType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.HairColorType left, Azure.AI.Face.HairColorType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HairProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HairProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairProperties>
    {
        internal HairProperties() { }
        public float Bald { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Face.HairColor> HairColor { get { throw null; } }
        public bool Invisible { get { throw null; } }
        Azure.AI.Face.HairProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HairProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HairProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.HairProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HairProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HeadPose : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HeadPose>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HeadPose>
    {
        internal HeadPose() { }
        public float Pitch { get { throw null; } }
        public float Roll { get { throw null; } }
        public float Yaw { get { throw null; } }
        Azure.AI.Face.HeadPose System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HeadPose>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.HeadPose>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.HeadPose System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HeadPose>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HeadPose>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.HeadPose>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class IdentifyCandidate : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.IdentifyCandidate>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyCandidate>
    {
        internal IdentifyCandidate() { }
        public float Confidence { get { throw null; } }
        public string PersonId { get { throw null; } }
        Azure.AI.Face.IdentifyCandidate System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.IdentifyCandidate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.IdentifyCandidate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.IdentifyCandidate System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyCandidate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyCandidate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyCandidate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class IdentifyResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.IdentifyResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyResult>
    {
        internal IdentifyResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyCandidate> Candidates { get { throw null; } }
        public string FaceId { get { throw null; } }
        Azure.AI.Face.IdentifyResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.IdentifyResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.IdentifyResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.IdentifyResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.IdentifyResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LandmarkCoordinate : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LandmarkCoordinate>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LandmarkCoordinate>
    {
        internal LandmarkCoordinate() { }
        public float X { get { throw null; } }
        public float Y { get { throw null; } }
        Azure.AI.Face.LandmarkCoordinate System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LandmarkCoordinate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LandmarkCoordinate>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LandmarkCoordinate System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LandmarkCoordinate>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LandmarkCoordinate>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LandmarkCoordinate>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LargeFaceList : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargeFaceList>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceList>
    {
        public LargeFaceList(string name) { }
        public string LargeFaceListId { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Azure.AI.Face.RecognitionModel? RecognitionModel { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.LargeFaceList System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargeFaceList>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargeFaceList>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LargeFaceList System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceList>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceList>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceList>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LargeFaceListFace : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargeFaceListFace>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceListFace>
    {
        internal LargeFaceListFace() { }
        public string PersistedFaceId { get { throw null; } }
        public string UserData { get { throw null; } }
        Azure.AI.Face.LargeFaceListFace System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargeFaceListFace>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargeFaceListFace>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LargeFaceListFace System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceListFace>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceListFace>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargeFaceListFace>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LargeFaceLists
    {
        protected LargeFaceLists() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddFaceFromStream(string largeFaceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromStream(string largeFaceListId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromStreamAsync(string largeFaceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromStreamAsync(string largeFaceListId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromUrl(string largeFaceListId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response AddFaceFromUrl(string largeFaceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromUrlAsync(string largeFaceListId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromUrlAsync(string largeFaceListId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateList(string largeFaceListId, Azure.AI.Face.LargeFaceList resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateList(string largeFaceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateListAsync(string largeFaceListId, Azure.AI.Face.LargeFaceList resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateListAsync(string largeFaceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteFace(string largeFaceListId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteFaceAsync(string largeFaceListId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteList(string largeFaceListId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteListAsync(string largeFaceListId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response FindSimilarFromLargeFaceList(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FindSimilarResult>> FindSimilarFromLargeFaceList(string faceId, string largeFaceListId, int? maxNumOfCandidatesReturned = default(int?), Azure.AI.Face.FindSimilarMatchMode? mode = default(Azure.AI.Face.FindSimilarMatchMode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> FindSimilarFromLargeFaceListAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.FindSimilarResult>>> FindSimilarFromLargeFaceListAsync(string faceId, string largeFaceListId, int? maxNumOfCandidatesReturned = default(int?), Azure.AI.Face.FindSimilarMatchMode? mode = default(Azure.AI.Face.FindSimilarMatchMode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetFace(string largeFaceListId, string persistedFaceId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LargeFaceListFace> GetFace(string largeFaceListId, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetFaceAsync(string largeFaceListId, string persistedFaceId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LargeFaceListFace>> GetFaceAsync(string largeFaceListId, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetFaces(string largeFaceListId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargeFaceListFace>> GetFaces(string largeFaceListId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetFacesAsync(string largeFaceListId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargeFaceListFace>>> GetFacesAsync(string largeFaceListId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetList(string largeFaceListId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LargeFaceList> GetList(string largeFaceListId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetListAsync(string largeFaceListId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LargeFaceList>> GetListAsync(string largeFaceListId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetLists(string start, int? top, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargeFaceList>> GetLists(string start = null, int? top = default(int?), bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetListsAsync(string start, int? top, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargeFaceList>>> GetListsAsync(string start = null, int? top = default(int?), bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainingStatus(string largeFaceListId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.TrainingStatus> GetTrainingStatus(string largeFaceListId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainingStatusAsync(string largeFaceListId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.TrainingStatus>> GetTrainingStatusAsync(string largeFaceListId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation TrainList(Azure.WaitUntil waitUntil, string largeFaceListId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> TrainListAsync(Azure.WaitUntil waitUntil, string largeFaceListId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateFace(string largeFaceListId, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateFaceAsync(string largeFaceListId, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateList(string largeFaceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateListAsync(string largeFaceListId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class LargePersonGroup : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroup>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroup>
    {
        public LargePersonGroup(string name) { }
        public string LargePersonGroupId { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Azure.AI.Face.RecognitionModel? RecognitionModel { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.LargePersonGroup System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroup>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LargePersonGroup System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroup>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroup>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroup>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LargePersonGroupPerson : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroupPerson>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPerson>
    {
        public LargePersonGroupPerson(string name) { }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> PersistedFaceIds { get { throw null; } }
        public string PersonId { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.LargePersonGroupPerson System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroupPerson>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroupPerson>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LargePersonGroupPerson System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPerson>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPerson>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPerson>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LargePersonGroupPersonFace : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroupPersonFace>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPersonFace>
    {
        internal LargePersonGroupPersonFace() { }
        public string PersistedFaceId { get { throw null; } }
        public string UserData { get { throw null; } }
        Azure.AI.Face.LargePersonGroupPersonFace System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroupPersonFace>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LargePersonGroupPersonFace>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LargePersonGroupPersonFace System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPersonFace>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPersonFace>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LargePersonGroupPersonFace>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LargePersonGroups
    {
        protected LargePersonGroups() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddFaceFromStream(string largePersonGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromStream(string largePersonGroupId, string personId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromStreamAsync(string largePersonGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromStreamAsync(string largePersonGroupId, string personId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromUrl(string largePersonGroupId, string personId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response AddFaceFromUrl(string largePersonGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromUrlAsync(string largePersonGroupId, string personId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromUrlAsync(string largePersonGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGroup(string largePersonGroupId, Azure.AI.Face.LargePersonGroup resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateGroup(string largePersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGroupAsync(string largePersonGroupId, Azure.AI.Face.LargePersonGroup resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGroupAsync(string largePersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LargePersonGroupPerson> CreatePerson(string largePersonGroupId, Azure.AI.Face.LargePersonGroupPerson resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreatePerson(string largePersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LargePersonGroupPerson>> CreatePersonAsync(string largePersonGroupId, Azure.AI.Face.LargePersonGroupPerson resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreatePersonAsync(string largePersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteFace(string largePersonGroupId, string personId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteFaceAsync(string largePersonGroupId, string personId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteGroup(string largePersonGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGroupAsync(string largePersonGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeletePerson(string largePersonGroupId, string personId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeletePersonAsync(string largePersonGroupId, string personId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetFace(string largePersonGroupId, string personId, string persistedFaceId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LargePersonGroupPersonFace> GetFace(string largePersonGroupId, string personId, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetFaceAsync(string largePersonGroupId, string personId, string persistedFaceId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LargePersonGroupPersonFace>> GetFaceAsync(string largePersonGroupId, string personId, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetGroup(string largePersonGroupId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LargePersonGroup> GetGroup(string largePersonGroupId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupAsync(string largePersonGroupId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LargePersonGroup>> GetGroupAsync(string largePersonGroupId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetGroups(string start, int? top, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargePersonGroup>> GetGroups(string start = null, int? top = default(int?), bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupsAsync(string start, int? top, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargePersonGroup>>> GetGroupsAsync(string start = null, int? top = default(int?), bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetPeople(string largePersonGroupId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargePersonGroupPerson>> GetPeople(string largePersonGroupId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPeopleAsync(string largePersonGroupId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LargePersonGroupPerson>>> GetPeopleAsync(string largePersonGroupId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetPerson(string largePersonGroupId, string personId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LargePersonGroupPerson> GetPerson(string largePersonGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPersonAsync(string largePersonGroupId, string personId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LargePersonGroupPerson>> GetPersonAsync(string largePersonGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainingStatus(string largePersonGroupId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.TrainingStatus> GetTrainingStatus(string largePersonGroupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainingStatusAsync(string largePersonGroupId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.TrainingStatus>> GetTrainingStatusAsync(string largePersonGroupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response IdentifyFromLargePersonGroup(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>> IdentifyFromLargePersonGroup(System.Collections.Generic.IEnumerable<string> faceIds, string largePersonGroupId, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> IdentifyFromLargePersonGroupAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>>> IdentifyFromLargePersonGroupAsync(System.Collections.Generic.IEnumerable<string> faceIds, string largePersonGroupId, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation TrainGroup(Azure.WaitUntil waitUntil, string largePersonGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> TrainGroupAsync(Azure.WaitUntil waitUntil, string largePersonGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateFace(string largePersonGroupId, string personId, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateFaceAsync(string largePersonGroupId, string personId, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateGroup(string largePersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGroupAsync(string largePersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdatePerson(string largePersonGroupId, string personId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdatePersonAsync(string largePersonGroupId, string personId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response VerifyFromLargePersonGroup(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.VerifyResult> VerifyFromLargePersonGroup(string faceId, string largePersonGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyFromLargePersonGroupAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.VerifyResult>> VerifyFromLargePersonGroupAsync(string faceId, string largePersonGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ListFaceResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListFaceResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListFaceResult>
    {
        internal ListFaceResult() { }
        public System.Collections.Generic.IReadOnlyList<string> PersistedFaceIds { get { throw null; } }
        public string PersonId { get { throw null; } }
        Azure.AI.Face.ListFaceResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListFaceResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListFaceResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.ListFaceResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListFaceResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListFaceResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListFaceResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ListGroupReferenceResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListGroupReferenceResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListGroupReferenceResult>
    {
        internal ListGroupReferenceResult() { }
        public System.Collections.Generic.IReadOnlyList<string> DynamicPersonGroupIds { get { throw null; } }
        Azure.AI.Face.ListGroupReferenceResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListGroupReferenceResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListGroupReferenceResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.ListGroupReferenceResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListGroupReferenceResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListGroupReferenceResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListGroupReferenceResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ListPersonResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListPersonResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListPersonResult>
    {
        internal ListPersonResult() { }
        public System.Collections.Generic.IReadOnlyList<string> PersonIds { get { throw null; } }
        Azure.AI.Face.ListPersonResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListPersonResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.ListPersonResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.ListPersonResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListPersonResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListPersonResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.ListPersonResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSession : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSession>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSession>
    {
        internal LivenessSession() { }
        public int? AuthTokenTimeToLiveInSeconds { get { throw null; } }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public string DeviceCorrelationId { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.AI.Face.LivenessSessionAuditEntry Result { get { throw null; } }
        public bool SessionExpired { get { throw null; } }
        public System.DateTimeOffset? SessionStartDateTime { get { throw null; } }
        public Azure.AI.Face.SessionStatus Status { get { throw null; } }
        Azure.AI.Face.LivenessSession System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSession>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSession>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSession System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSession>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSession>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSession>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSessionAuditEntry : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionAuditEntry>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionAuditEntry>
    {
        internal LivenessSessionAuditEntry() { }
        public string ClientRequestId { get { throw null; } }
        public string Digest { get { throw null; } }
        public long Id { get { throw null; } }
        public System.DateTimeOffset ReceivedDateTime { get { throw null; } }
        public Azure.AI.Face.SessionAuditEntryRequestInfo Request { get { throw null; } }
        public string RequestId { get { throw null; } }
        public Azure.AI.Face.SessionAuditEntryResponseInfo Response { get { throw null; } }
        public string SessionId { get { throw null; } }
        Azure.AI.Face.LivenessSessionAuditEntry System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionAuditEntry>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionAuditEntry>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSessionAuditEntry System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionAuditEntry>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionAuditEntry>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionAuditEntry>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSessionCreationContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContent>
    {
        public LivenessSessionCreationContent(string livenessOperationMode, string deviceCorrelationId) { }
        public int? AuthTokenTimeToLiveInSeconds { get { throw null; } set { } }
        public string DeviceCorrelationId { get { throw null; } }
        public bool? DeviceCorrelationIdSetInClient { get { throw null; } set { } }
        public string LivenessOperationMode { get { throw null; } }
        public bool? SendResultsToClient { get { throw null; } set { } }
        Azure.AI.Face.LivenessSessionCreationContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSessionCreationContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSessionCreationContentForMultipart : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>
    {
        public LivenessSessionCreationContentForMultipart(string livenessOperationMode, string deviceCorrelationId) { }
        public int? AuthTokenTimeToLiveInSeconds { get { throw null; } set { } }
        public string DeviceCorrelationId { get { throw null; } }
        public bool? DeviceCorrelationIdSetInClient { get { throw null; } set { } }
        public string LivenessOperationMode { get { throw null; } }
        public bool? SendResultsToClient { get { throw null; } set { } }
        Azure.AI.Face.LivenessSessionCreationContentForMultipart System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSessionCreationContentForMultipart System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationContentForMultipart>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSessionCreationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationResult>
    {
        internal LivenessSessionCreationResult() { }
        public string AuthToken { get { throw null; } }
        public string SessionId { get { throw null; } }
        Azure.AI.Face.LivenessSessionCreationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionCreationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSessionCreationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionCreationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSessionItem : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionItem>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionItem>
    {
        internal LivenessSessionItem() { }
        public int? AuthTokenTimeToLiveInSeconds { get { throw null; } }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public string DeviceCorrelationId { get { throw null; } }
        public string Id { get { throw null; } }
        public bool SessionExpired { get { throw null; } }
        public System.DateTimeOffset? SessionStartDateTime { get { throw null; } }
        Azure.AI.Face.LivenessSessionItem System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSessionItem System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionItem>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionItem>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionItem>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessSessions
    {
        protected LivenessSessions() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.AI.Face.LivenessSessionCreationResult> CreateSession(Azure.AI.Face.LivenessSessionCreationContent livenessSessionCreationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateSession(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LivenessSessionCreationResult>> CreateSessionAsync(Azure.AI.Face.LivenessSessionCreationContent livenessSessionCreationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateSessionAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteSession(string sessionId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteSessionAsync(string sessionId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetSession(string sessionId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LivenessSession> GetSession(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSessionAsync(string sessionId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LivenessSession>> GetSessionAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSessionAuditEntries(string sessionId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessSessionAuditEntry>> GetSessionAuditEntries(string sessionId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSessionAuditEntriesAsync(string sessionId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessSessionAuditEntry>>> GetSessionAuditEntriesAsync(string sessionId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSessions(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessSessionItem>> GetSessions(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSessionsAsync(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessSessionItem>>> GetSessionsAsync(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LivenessSessionWithVerifyImageCreationContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>
    {
        public LivenessSessionWithVerifyImageCreationContent(Azure.AI.Face.LivenessSessionCreationContentForMultipart creationContent, System.BinaryData verifyImage) { }
        public Azure.AI.Face.LivenessSessionCreationContentForMultipart CreationContent { get { throw null; } }
        public System.BinaryData VerifyImage { get { throw null; } }
        Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessWithVerifySession : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessWithVerifySession>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySession>
    {
        internal LivenessWithVerifySession() { }
        public int? AuthTokenTimeToLiveInSeconds { get { throw null; } }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public string DeviceCorrelationId { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.AI.Face.LivenessWithVerifySessionAuditEntry Result { get { throw null; } }
        public bool SessionExpired { get { throw null; } }
        public System.DateTimeOffset? SessionStartDateTime { get { throw null; } }
        public Azure.AI.Face.SessionStatus Status { get { throw null; } }
        Azure.AI.Face.LivenessWithVerifySession System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessWithVerifySession>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessWithVerifySession>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessWithVerifySession System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySession>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySession>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySession>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessWithVerifySessionAuditEntry : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>
    {
        internal LivenessWithVerifySessionAuditEntry() { }
        public string ClientRequestId { get { throw null; } }
        public string Digest { get { throw null; } }
        public long Id { get { throw null; } }
        public System.DateTimeOffset ReceivedDateTime { get { throw null; } }
        public Azure.AI.Face.SessionAuditEntryRequestInfo Request { get { throw null; } }
        public string RequestId { get { throw null; } }
        public Azure.AI.Face.SessionAuditEntryResponseInfo Response { get { throw null; } }
        public string SessionId { get { throw null; } }
        Azure.AI.Face.LivenessWithVerifySessionAuditEntry System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.LivenessWithVerifySessionAuditEntry System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LivenessWithVerifySessions
    {
        protected LivenessWithVerifySessions() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.AI.Face.LivenessSessionCreationResult> CreateSession(Azure.AI.Face.LivenessSessionCreationContent livenessSessionCreationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateSession(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LivenessSessionCreationResult>> CreateSessionAsync(Azure.AI.Face.LivenessSessionCreationContent livenessSessionCreationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateSessionAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LivenessSessionCreationResult> CreateSessionWithVerifyImage(Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent livenessSessionWithVerifyImageCreationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateSessionWithVerifyImage(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LivenessSessionCreationResult>> CreateSessionWithVerifyImageAsync(Azure.AI.Face.LivenessSessionWithVerifyImageCreationContent livenessSessionWithVerifyImageCreationContent, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateSessionWithVerifyImageAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteSession(string sessionId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteSessionAsync(string sessionId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetSession(string sessionId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.LivenessWithVerifySession> GetSession(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSessionAsync(string sessionId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.LivenessWithVerifySession>> GetSessionAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSessionAuditEntries(string sessionId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>> GetSessionAuditEntries(string sessionId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSessionAuditEntriesAsync(string sessionId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessWithVerifySessionAuditEntry>>> GetSessionAuditEntriesAsync(string sessionId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSessions(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessSessionItem>> GetSessions(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSessionsAsync(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.LivenessSessionItem>>> GetSessionsAsync(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MaskProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.MaskProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.MaskProperties>
    {
        internal MaskProperties() { }
        public bool NoseAndMouthCovered { get { throw null; } }
        public Azure.AI.Face.MaskType Type { get { throw null; } }
        Azure.AI.Face.MaskProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.MaskProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.MaskProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.MaskProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.MaskProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.MaskProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.MaskProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MaskType : System.IEquatable<Azure.AI.Face.MaskType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MaskType(string value) { throw null; }
        public static Azure.AI.Face.MaskType FaceMask { get { throw null; } }
        public static Azure.AI.Face.MaskType NoMask { get { throw null; } }
        public static Azure.AI.Face.MaskType OtherMaskOrOcclusion { get { throw null; } }
        public static Azure.AI.Face.MaskType Uncertain { get { throw null; } }
        public bool Equals(Azure.AI.Face.MaskType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.MaskType left, Azure.AI.Face.MaskType right) { throw null; }
        public static implicit operator Azure.AI.Face.MaskType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.MaskType left, Azure.AI.Face.MaskType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NoiseLevel : System.IEquatable<Azure.AI.Face.NoiseLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NoiseLevel(string value) { throw null; }
        public static Azure.AI.Face.NoiseLevel High { get { throw null; } }
        public static Azure.AI.Face.NoiseLevel Low { get { throw null; } }
        public static Azure.AI.Face.NoiseLevel Medium { get { throw null; } }
        public bool Equals(Azure.AI.Face.NoiseLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.NoiseLevel left, Azure.AI.Face.NoiseLevel right) { throw null; }
        public static implicit operator Azure.AI.Face.NoiseLevel (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.NoiseLevel left, Azure.AI.Face.NoiseLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NoiseProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.NoiseProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.NoiseProperties>
    {
        internal NoiseProperties() { }
        public Azure.AI.Face.NoiseLevel NoiseLevel { get { throw null; } }
        public float Value { get { throw null; } }
        Azure.AI.Face.NoiseProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.NoiseProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.NoiseProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.NoiseProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.NoiseProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.NoiseProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.NoiseProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OcclusionProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.OcclusionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.OcclusionProperties>
    {
        internal OcclusionProperties() { }
        public bool EyeOccluded { get { throw null; } }
        public bool ForeheadOccluded { get { throw null; } }
        public bool MouthOccluded { get { throw null; } }
        Azure.AI.Face.OcclusionProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.OcclusionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.OcclusionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.OcclusionProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.OcclusionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.OcclusionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.OcclusionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OperationStatus : System.IEquatable<Azure.AI.Face.OperationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OperationStatus(string value) { throw null; }
        public static Azure.AI.Face.OperationStatus Failed { get { throw null; } }
        public static Azure.AI.Face.OperationStatus Notstarted { get { throw null; } }
        public static Azure.AI.Face.OperationStatus Running { get { throw null; } }
        public static Azure.AI.Face.OperationStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.Face.OperationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.OperationStatus left, Azure.AI.Face.OperationStatus right) { throw null; }
        public static implicit operator Azure.AI.Face.OperationStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.OperationStatus left, Azure.AI.Face.OperationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PersonDirectoryDynamicPersonGroups
    {
        protected PersonDirectoryDynamicPersonGroups() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation<Azure.AI.Face.DynamicPersonGroup> CreateGroup(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.AI.Face.DynamicPersonGroup resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> CreateGroup(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Face.DynamicPersonGroup>> CreateGroupAsync(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.AI.Face.DynamicPersonGroup resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> CreateGroupAsync(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteGroup(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteGroupAsync(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGroup(string dynamicPersonGroupId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.DynamicPersonGroup> GetGroup(string dynamicPersonGroupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupAsync(string dynamicPersonGroupId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.DynamicPersonGroup>> GetGroupAsync(string dynamicPersonGroupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetGroupPeople(string dynamicPersonGroupId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.ListPersonResult> GetGroupPeople(string dynamicPersonGroupId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupPeopleAsync(string dynamicPersonGroupId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.ListPersonResult>> GetGroupPeopleAsync(string dynamicPersonGroupId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetGroups(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.DynamicPersonGroup>> GetGroups(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupsAsync(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.DynamicPersonGroup>>> GetGroupsAsync(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response IdentifyFromDynamicPersonGroup(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>> IdentifyFromDynamicPersonGroup(System.Collections.Generic.IEnumerable<string> faceIds, string dynamicPersonGroupId, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> IdentifyFromDynamicPersonGroupAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>>> IdentifyFromDynamicPersonGroupAsync(System.Collections.Generic.IEnumerable<string> faceIds, string dynamicPersonGroupId, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> UpdateGroup(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> UpdateGroupAsync(Azure.WaitUntil waitUntil, string dynamicPersonGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class PersonDirectoryFace : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonDirectoryFace>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryFace>
    {
        internal PersonDirectoryFace() { }
        public string PersistedFaceId { get { throw null; } }
        public string UserData { get { throw null; } }
        Azure.AI.Face.PersonDirectoryFace System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonDirectoryFace>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonDirectoryFace>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.PersonDirectoryFace System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryFace>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryFace>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryFace>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PersonDirectoryPerson : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonDirectoryPerson>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryPerson>
    {
        public PersonDirectoryPerson(string name) { }
        public string Name { get { throw null; } set { } }
        public string PersonId { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.PersonDirectoryPerson System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonDirectoryPerson>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonDirectoryPerson>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.PersonDirectoryPerson System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryPerson>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryPerson>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonDirectoryPerson>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PersonDirectoryPersons
    {
        protected PersonDirectoryPersons() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation<Azure.AI.Face.AddFaceResult> AddFaceFromStream(Azure.WaitUntil waitUntil, string personId, Azure.AI.Face.RecognitionModel recognitionModel, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> AddFaceFromStream(Azure.WaitUntil waitUntil, string personId, string recognitionModel, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Face.AddFaceResult>> AddFaceFromStreamAsync(Azure.WaitUntil waitUntil, string personId, Azure.AI.Face.RecognitionModel recognitionModel, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> AddFaceFromStreamAsync(Azure.WaitUntil waitUntil, string personId, string recognitionModel, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.AI.Face.AddFaceResult> AddFaceFromUrl(Azure.WaitUntil waitUntil, string personId, Azure.AI.Face.RecognitionModel recognitionModel, Azure.AI.Face.AddFaceFromUrlContent body, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> AddFaceFromUrl(Azure.WaitUntil waitUntil, string personId, string recognitionModel, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Face.AddFaceResult>> AddFaceFromUrlAsync(Azure.WaitUntil waitUntil, string personId, Azure.AI.Face.RecognitionModel recognitionModel, Azure.AI.Face.AddFaceFromUrlContent body, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> AddFaceFromUrlAsync(Azure.WaitUntil waitUntil, string personId, string recognitionModel, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.AI.Face.CreatePersonResult> CreatePerson(Azure.WaitUntil waitUntil, Azure.AI.Face.PersonDirectoryPerson resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> CreatePerson(Azure.WaitUntil waitUntil, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Face.CreatePersonResult>> CreatePersonAsync(Azure.WaitUntil waitUntil, Azure.AI.Face.PersonDirectoryPerson resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> CreatePersonAsync(Azure.WaitUntil waitUntil, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteFace(Azure.WaitUntil waitUntil, string personId, Azure.AI.Face.RecognitionModel recognitionModel, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation DeleteFace(Azure.WaitUntil waitUntil, string personId, string recognitionModel, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteFaceAsync(Azure.WaitUntil waitUntil, string personId, Azure.AI.Face.RecognitionModel recognitionModel, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteFaceAsync(Azure.WaitUntil waitUntil, string personId, string recognitionModel, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeletePerson(Azure.WaitUntil waitUntil, string personId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeletePersonAsync(Azure.WaitUntil waitUntil, string personId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.PersonDirectoryFace> GetFace(string personId, Azure.AI.Face.RecognitionModel recognitionModel, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetFace(string personId, string recognitionModel, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.PersonDirectoryFace>> GetFaceAsync(string personId, Azure.AI.Face.RecognitionModel recognitionModel, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetFaceAsync(string personId, string recognitionModel, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.ListFaceResult> GetFaces(string personId, Azure.AI.Face.RecognitionModel recognitionModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetFaces(string personId, string recognitionModel, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.ListFaceResult>> GetFacesAsync(string personId, Azure.AI.Face.RecognitionModel recognitionModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetFacesAsync(string personId, string recognitionModel, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGroupReferences(string personId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.ListGroupReferenceResult> GetGroupReferences(string personId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupReferencesAsync(string personId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.ListGroupReferenceResult>> GetGroupReferencesAsync(string personId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetPeople(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.PersonDirectoryPerson>> GetPeople(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPeopleAsync(string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.PersonDirectoryPerson>>> GetPeopleAsync(string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetPerson(string personId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.PersonDirectoryPerson> GetPerson(string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPersonAsync(string personId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.PersonDirectoryPerson>> GetPersonAsync(string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response IdentifyFromPersonDirectory(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>> IdentifyFromPersonDirectory(System.Collections.Generic.IEnumerable<string> faceIds, System.Collections.Generic.IEnumerable<string> personIds, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> IdentifyFromPersonDirectoryAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>>> IdentifyFromPersonDirectoryAsync(System.Collections.Generic.IEnumerable<string> faceIds, System.Collections.Generic.IEnumerable<string> personIds, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateFace(string personId, string recognitionModel, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateFaceAsync(string personId, string recognitionModel, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdatePerson(string personId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdatePersonAsync(string personId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response VerifyFromPersonDirectory(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.VerifyResult> VerifyFromPersonDirectory(string faceId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyFromPersonDirectoryAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.VerifyResult>> VerifyFromPersonDirectoryAsync(string faceId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PersonGroup : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroup>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroup>
    {
        public PersonGroup(string name) { }
        public string Name { get { throw null; } set { } }
        public string PersonGroupId { get { throw null; } }
        public Azure.AI.Face.RecognitionModel? RecognitionModel { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.PersonGroup System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroup>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.PersonGroup System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroup>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroup>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroup>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PersonGroupPerson : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroupPerson>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPerson>
    {
        public PersonGroupPerson(string name) { }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> PersistedFaceIds { get { throw null; } }
        public string PersonId { get { throw null; } }
        public string UserData { get { throw null; } set { } }
        Azure.AI.Face.PersonGroupPerson System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroupPerson>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroupPerson>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.PersonGroupPerson System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPerson>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPerson>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPerson>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PersonGroupPersonFace : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroupPersonFace>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPersonFace>
    {
        internal PersonGroupPersonFace() { }
        public string PersistedFaceId { get { throw null; } }
        public string UserData { get { throw null; } }
        Azure.AI.Face.PersonGroupPersonFace System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroupPersonFace>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.PersonGroupPersonFace>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.PersonGroupPersonFace System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPersonFace>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPersonFace>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.PersonGroupPersonFace>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PersonGroups
    {
        protected PersonGroups() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddFaceFromStream(string personGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromStream(string personGroupId, string personId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromStreamAsync(string personGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromStreamAsync(string personGroupId, string personId, System.BinaryData imageContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.AddFaceResult> AddFaceFromUrl(string personGroupId, string personId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response AddFaceFromUrl(string personGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.AddFaceResult>> AddFaceFromUrlAsync(string personGroupId, string personId, Azure.AI.Face.AddFaceFromUrlContent addFaceFromUrlContent, string targetFace = null, Azure.AI.Face.DetectionModel? detectionModel = default(Azure.AI.Face.DetectionModel?), string userData = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFaceFromUrlAsync(string personGroupId, string personId, Azure.Core.RequestContent content, string targetFace = null, string detectionModel = null, string userData = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGroup(string personGroupId, Azure.AI.Face.PersonGroup resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateGroup(string personGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGroupAsync(string personGroupId, Azure.AI.Face.PersonGroup resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGroupAsync(string personGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.PersonGroupPerson> CreatePerson(string personGroupId, Azure.AI.Face.PersonGroupPerson resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreatePerson(string personGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.PersonGroupPerson>> CreatePersonAsync(string personGroupId, Azure.AI.Face.PersonGroupPerson resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreatePersonAsync(string personGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteFace(string personGroupId, string personId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteFaceAsync(string personGroupId, string personId, string persistedFaceId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteGroup(string personGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGroupAsync(string personGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeletePerson(string personGroupId, string personId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeletePersonAsync(string personGroupId, string personId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetFace(string personGroupId, string personId, string persistedFaceId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.PersonGroupPersonFace> GetFace(string personGroupId, string personId, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetFaceAsync(string personGroupId, string personId, string persistedFaceId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.PersonGroupPersonFace>> GetFaceAsync(string personGroupId, string personId, string persistedFaceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetGroup(string personGroupId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.PersonGroup> GetGroup(string personGroupId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupAsync(string personGroupId, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.PersonGroup>> GetGroupAsync(string personGroupId, bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetGroups(string start, int? top, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.PersonGroup>> GetGroups(string start = null, int? top = default(int?), bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGroupsAsync(string start, int? top, bool? returnRecognitionModel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.PersonGroup>>> GetGroupsAsync(string start = null, int? top = default(int?), bool? returnRecognitionModel = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetPeople(string personGroupId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.PersonGroupPerson>> GetPeople(string personGroupId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPeopleAsync(string personGroupId, string start, int? top, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.PersonGroupPerson>>> GetPeopleAsync(string personGroupId, string start = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetPerson(string personGroupId, string personId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.PersonGroupPerson> GetPerson(string personGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPersonAsync(string personGroupId, string personId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.PersonGroupPerson>> GetPersonAsync(string personGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainingStatus(string personGroupId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.TrainingStatus> GetTrainingStatus(string personGroupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainingStatusAsync(string personGroupId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.TrainingStatus>> GetTrainingStatusAsync(string personGroupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response IdentifyFromPersonGroup(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>> IdentifyFromPersonGroup(System.Collections.Generic.IEnumerable<string> faceIds, string personGroupId, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> IdentifyFromPersonGroupAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.Face.IdentifyResult>>> IdentifyFromPersonGroupAsync(System.Collections.Generic.IEnumerable<string> faceIds, string personGroupId, int? maxNumOfCandidatesReturned = default(int?), float? confidenceThreshold = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation TrainGroup(Azure.WaitUntil waitUntil, string personGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> TrainGroupAsync(Azure.WaitUntil waitUntil, string personGroupId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateFace(string personGroupId, string personId, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateFaceAsync(string personGroupId, string personId, string persistedFaceId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateGroup(string personGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGroupAsync(string personGroupId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdatePerson(string personGroupId, string personId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdatePersonAsync(string personGroupId, string personId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response VerifyFromPersonGroup(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Face.VerifyResult> VerifyFromPersonGroup(string faceId, string personGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyFromPersonGroupAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Face.VerifyResult>> VerifyFromPersonGroupAsync(string faceId, string personGroupId, string personId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QualityForRecognition : System.IEquatable<Azure.AI.Face.QualityForRecognition>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QualityForRecognition(string value) { throw null; }
        public static Azure.AI.Face.QualityForRecognition High { get { throw null; } }
        public static Azure.AI.Face.QualityForRecognition Low { get { throw null; } }
        public static Azure.AI.Face.QualityForRecognition Medium { get { throw null; } }
        public bool Equals(Azure.AI.Face.QualityForRecognition other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.QualityForRecognition left, Azure.AI.Face.QualityForRecognition right) { throw null; }
        public static implicit operator Azure.AI.Face.QualityForRecognition (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.QualityForRecognition left, Azure.AI.Face.QualityForRecognition right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecognitionModel : System.IEquatable<Azure.AI.Face.RecognitionModel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecognitionModel(string value) { throw null; }
        public static Azure.AI.Face.RecognitionModel Recognition01 { get { throw null; } }
        public static Azure.AI.Face.RecognitionModel Recognition02 { get { throw null; } }
        public static Azure.AI.Face.RecognitionModel Recognition03 { get { throw null; } }
        public static Azure.AI.Face.RecognitionModel Recognition04 { get { throw null; } }
        public bool Equals(Azure.AI.Face.RecognitionModel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.RecognitionModel left, Azure.AI.Face.RecognitionModel right) { throw null; }
        public static implicit operator Azure.AI.Face.RecognitionModel (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.RecognitionModel left, Azure.AI.Face.RecognitionModel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SessionAuditEntryRequestInfo : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.SessionAuditEntryRequestInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryRequestInfo>
    {
        internal SessionAuditEntryRequestInfo() { }
        public long? ContentLength { get { throw null; } }
        public string ContentType { get { throw null; } }
        public string Method { get { throw null; } }
        public System.Uri Url { get { throw null; } }
        public string UserAgent { get { throw null; } }
        Azure.AI.Face.SessionAuditEntryRequestInfo System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.SessionAuditEntryRequestInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.SessionAuditEntryRequestInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.SessionAuditEntryRequestInfo System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryRequestInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryRequestInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryRequestInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SessionAuditEntryResponseInfo : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.SessionAuditEntryResponseInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryResponseInfo>
    {
        internal SessionAuditEntryResponseInfo() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> Body { get { throw null; } }
        public long LatencyInMilliseconds { get { throw null; } }
        public int StatusCode { get { throw null; } }
        Azure.AI.Face.SessionAuditEntryResponseInfo System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.SessionAuditEntryResponseInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.SessionAuditEntryResponseInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.SessionAuditEntryResponseInfo System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryResponseInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryResponseInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.SessionAuditEntryResponseInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SessionStatus : System.IEquatable<Azure.AI.Face.SessionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SessionStatus(string value) { throw null; }
        public static Azure.AI.Face.SessionStatus NotStarted { get { throw null; } }
        public static Azure.AI.Face.SessionStatus ResultAvailable { get { throw null; } }
        public static Azure.AI.Face.SessionStatus Started { get { throw null; } }
        public bool Equals(Azure.AI.Face.SessionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.SessionStatus left, Azure.AI.Face.SessionStatus right) { throw null; }
        public static implicit operator Azure.AI.Face.SessionStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.SessionStatus left, Azure.AI.Face.SessionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TrainingStatus : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.TrainingStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.TrainingStatus>
    {
        internal TrainingStatus() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.DateTimeOffset LastActionDateTime { get { throw null; } }
        public System.DateTimeOffset LastSuccessfulTrainingDateTime { get { throw null; } }
        public string Message { get { throw null; } }
        public Azure.AI.Face.TrainingStatusType Status { get { throw null; } }
        Azure.AI.Face.TrainingStatus System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.TrainingStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.TrainingStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.TrainingStatus System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.TrainingStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.TrainingStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.TrainingStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TrainingStatusType : System.IEquatable<Azure.AI.Face.TrainingStatusType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TrainingStatusType(string value) { throw null; }
        public static Azure.AI.Face.TrainingStatusType Failed { get { throw null; } }
        public static Azure.AI.Face.TrainingStatusType Nonstarted { get { throw null; } }
        public static Azure.AI.Face.TrainingStatusType Running { get { throw null; } }
        public static Azure.AI.Face.TrainingStatusType Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.Face.TrainingStatusType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Face.TrainingStatusType left, Azure.AI.Face.TrainingStatusType right) { throw null; }
        public static implicit operator Azure.AI.Face.TrainingStatusType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Face.TrainingStatusType left, Azure.AI.Face.TrainingStatusType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VerifyResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.VerifyResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.VerifyResult>
    {
        internal VerifyResult() { }
        public float Confidence { get { throw null; } }
        public bool IsIdentical { get { throw null; } }
        Azure.AI.Face.VerifyResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.VerifyResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Face.VerifyResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Face.VerifyResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.VerifyResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.VerifyResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Face.VerifyResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AIFaceClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Face.FaceClient, Azure.AI.Face.FaceClientOptions> AddFaceClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Face.FaceClient, Azure.AI.Face.FaceClientOptions> AddFaceClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Face.FaceClient, Azure.AI.Face.FaceClientOptions> AddFaceClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
