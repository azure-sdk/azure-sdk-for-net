namespace Azure.AI.Language.Authoring.AnalyzeText
{
    public partial class AnalyzeTextClient
    {
        protected AnalyzeTextClient() { }
        public AnalyzeTextClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public AnalyzeTextClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions options) { }
        public AnalyzeTextClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public AnalyzeTextClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.AI.Language.Authoring.AnalyzeText.TextAnalysisAuthoring GetTextAnalysisAuthoringClient(string apiVersion = "2024-11-15-preview") { throw null; }
    }
    public partial class AnalyzeTextClientOptions : Azure.Core.ClientOptions
    {
        public AnalyzeTextClientOptions(Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions.ServiceVersion version = Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions.ServiceVersion.V2024_11_15_Preview) { }
        public enum ServiceVersion
        {
            V2023_04_01 = 1,
            V2023_04_15_Preview = 2,
            V2024_11_15_Preview = 3,
        }
    }
    public partial class TextAnalysisAuthoring
    {
        protected TextAnalysisAuthoring() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation AssignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation AssignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AssignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AssignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> CancelTrainingJob(Azure.WaitUntil waitUntil, string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Operation<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult> CancelTrainingJob(Azure.WaitUntil waitUntil, string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> CancelTrainingJobAsync(Azure.WaitUntil waitUntil, string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>> CancelTrainingJobAsync(Azure.WaitUntil waitUntil, string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation CopyProject(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation CopyProject(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CopyProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CopyProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig> CopyProjectAuthorization(string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind projectKind, string storageInputContainerName = null, bool? allowOverwrite = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CopyProjectAuthorization(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>> CopyProjectAuthorizationAsync(string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind projectKind, string storageInputContainerName = null, bool? allowOverwrite = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CopyProjectAuthorizationAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation CreateOrUpdateExportedModel(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation CreateOrUpdateExportedModel(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CreateOrUpdateExportedModelAsync(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CreateOrUpdateExportedModelAsync(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateProject(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateProjectAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteDeployment(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteDeploymentAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteDeploymentFromResources(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation DeleteDeploymentFromResources(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteDeploymentFromResourcesAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteDeploymentFromResourcesAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteExportedModel(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteExportedModelAsync(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteProject(Azure.WaitUntil waitUntil, string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteTrainedModel(string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTrainedModelAsync(string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeployProject(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation DeployProject(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeployProjectAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeployProjectAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult> EvaluateModel(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> EvaluateModel(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>> EvaluateModelAsync(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> EvaluateModelAsync(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation Export(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType stringIndexType, string assetKind = null, string trainedModelLabel = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation Export(Azure.WaitUntil waitUntil, string projectName, string stringIndexType, string assetKind = null, string trainedModelLabel = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ExportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType stringIndexType, string assetKind = null, string trainedModelLabel = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ExportAsync(Azure.WaitUntil waitUntil, string projectName, string stringIndexType, string assetKind = null, string trainedModelLabel = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetAssignDeploymentResourcesStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState> GetAssignDeploymentResourcesStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAssignDeploymentResourcesStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>> GetAssignDeploymentResourcesStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetAssignedResourceDeployments(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata> GetAssignedResourceDeployments(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetAssignedResourceDeploymentsAsync(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata> GetAssignedResourceDeploymentsAsync(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetCopyProjectStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState> GetCopyProjectStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCopyProjectStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>> GetCopyProjectStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDeployment(string projectName, string deploymentName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment> GetDeployment(string projectName, string deploymentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeploymentAsync(string projectName, string deploymentName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>> GetDeploymentAsync(string projectName, string deploymentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDeploymentDeleteFromResourcesStatus(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState> GetDeploymentDeleteFromResourcesStatus(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeploymentDeleteFromResourcesStatusAsync(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>> GetDeploymentDeleteFromResourcesStatusAsync(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetDeploymentResources(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource> GetDeploymentResources(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetDeploymentResourcesAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource> GetDeploymentResourcesAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetDeployments(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment> GetDeployments(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetDeploymentsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment> GetDeploymentsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDeploymentStatus(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState> GetDeploymentStatus(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeploymentStatusAsync(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>> GetDeploymentStatusAsync(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetEvaluationStatus(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState> GetEvaluationStatus(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEvaluationStatusAsync(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>> GetEvaluationStatusAsync(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportedModel(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel> GetExportedModel(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportedModelAsync(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>> GetExportedModelAsync(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportedModelJobStatus(string projectName, string exportedModelName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState> GetExportedModelJobStatus(string projectName, string exportedModelName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportedModelJobStatusAsync(string projectName, string exportedModelName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>> GetExportedModelJobStatusAsync(string projectName, string exportedModelName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportedModelManifest(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest> GetExportedModelManifest(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportedModelManifestAsync(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>> GetExportedModelManifestAsync(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetExportedModels(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel> GetExportedModels(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetExportedModelsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel> GetExportedModelsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState> GetExportStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>> GetExportStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetImportStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState> GetImportStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetImportStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>> GetImportStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetLoadSnapshotStatus(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState> GetLoadSnapshotStatus(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetLoadSnapshotStatusAsync(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>> GetLoadSnapshotStatusAsync(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult> GetModelEvaluationResults(string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetModelEvaluationResults(string projectName, string trainedModelLabel, string stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult> GetModelEvaluationResultsAsync(string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetModelEvaluationResultsAsync(string projectName, string trainedModelLabel, string stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetModelEvaluationSummary(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary> GetModelEvaluationSummary(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetModelEvaluationSummaryAsync(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>> GetModelEvaluationSummaryAsync(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetProject(string projectName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata> GetProject(string projectName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetProjectAsync(string projectName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>> GetProjectAsync(string projectName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetProjectDeletionStatus(string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState> GetProjectDeletionStatus(string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetProjectDeletionStatusAsync(string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>> GetProjectDeletionStatusAsync(string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetProjects(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata> GetProjects(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetProjectsAsync(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata> GetProjectsAsync(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage> GetSupportedLanguages(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetSupportedLanguages(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage> GetSupportedLanguagesAsync(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetSupportedLanguagesAsync(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetSupportedPrebuiltEntities(Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity> GetSupportedPrebuiltEntities(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetSupportedPrebuiltEntitiesAsync(Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity> GetSupportedPrebuiltEntitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSwapDeploymentsStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState> GetSwapDeploymentsStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSwapDeploymentsStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>> GetSwapDeploymentsStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainedModel(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel> GetTrainedModel(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainedModelAsync(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>> GetTrainedModelAsync(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTrainedModels(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel> GetTrainedModels(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTrainedModelsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel> GetTrainedModelsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion> GetTrainingConfigVersions(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTrainingConfigVersions(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion> GetTrainingConfigVersionsAsync(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTrainingConfigVersionsAsync(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTrainingJobs(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState> GetTrainingJobs(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTrainingJobsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState> GetTrainingJobsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainingStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState> GetTrainingStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainingStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>> GetTrainingStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetUnassignDeploymentResourcesStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState> GetUnassignDeploymentResourcesStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetUnassignDeploymentResourcesStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>> GetUnassignDeploymentResourcesStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation Import(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject body, string format = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation Import(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, string format = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ImportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject body, string format = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ImportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, string format = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation LoadSnapshot(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> LoadSnapshotAsync(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation SwapDeployments(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation SwapDeployments(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> SwapDeploymentsAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> SwapDeploymentsAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult> Train(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> Train(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>> TrainAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> TrainAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation UnassignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation UnassignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> UnassignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> UnassignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
}
namespace Azure.AI.Language.Authoring.AnalyzeText.Models
{
    public static partial class AILanguageAuthoringAnalyzeTextModelFactory
    {
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState AssignDeploymentResourcesJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource AssignedDeploymentResource(string azureResourceId = null, string region = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata AssignedProjectDeploymentMetadata(string deploymentName = null, System.DateTimeOffset lastDeployedDateTime = default(System.DateTimeOffset), System.DateTimeOffset deploymentExpirationDate = default(System.DateTimeOffset)) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata AssignedProjectDeploymentsMetadata(string projectName = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata> deploymentsMetadata = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix ConfusionMatrix(System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> additionalProperties = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell ConfusionMatrixCell(float normalizedValue = 0f, float rawValue = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow ConfusionMatrixRow(System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> additionalProperties = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState CopyProjectJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig CreateDeploymentConfig(string trainedModelLabel = null, System.Collections.Generic.IEnumerable<string> assignedResourceIds = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig CreateProjectConfig(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind projectKind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind), string storageInputContainerName = null, Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings settings = null, string projectName = null, bool? multilingual = default(bool?), string description = null, string language = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult CustomEntityRecognitionDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult customEntityRecognitionResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary CustomEntityRecognitionEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary customEntityRecognitionEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult CustomHealthcareDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult customHealthcareResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary CustomHealthcareEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary customHealthcareEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult CustomMultiLabelClassificationDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult customMultiLabelClassificationResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary CustomMultiLabelClassificationEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary customMultiLabelClassificationEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult CustomSingleLabelClassificationDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult customSingleLabelClassificationResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary CustomSingleLabelClassificationEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary customSingleLabelClassificationEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult CustomTextSentimentDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult customTextSentimentResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary CustomTextSentimentEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary customTextSentimentEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo DataGenerationConnectionInfo(Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind kind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind), string resourceId = null, string deploymentName = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState DeploymentDeleteFromResourcesJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState DeploymentJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource DeploymentResource(string resourceId = null, string region = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult DocumentEntityLabelEvaluationResult(string category = null, int offset = 0, int length = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult DocumentEntityRecognitionEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult> entities = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult DocumentEntityRegionEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult> expectedEntities = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult> predictedEntities = null, int regionOffset = 0, int regionLength = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult DocumentEvaluationResult(string projectKind = null, string location = null, string language = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult DocumentHealthcareEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult> entities = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult DocumentMultiLabelClassificationEvaluationResult(System.Collections.Generic.IEnumerable<string> expectedClasses = null, System.Collections.Generic.IEnumerable<string> predictedClasses = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult DocumentSentimentLabelEvaluationResult(Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment category = default(Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment), int offset = 0, int length = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult DocumentSingleLabelClassificationEvaluationResult(string expectedClass = null, string predictedClass = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult DocumentTextSentimentEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult> expectedSentimentSpans = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult> predictedSentimentSpans = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary EntityEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary EntityRecognitionEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix confusionMatrix = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary> entities = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult EvaluationJobResult(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, string modelLabel = null, string trainingConfigVersion = null, int percentComplete = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState EvaluationJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult result = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary EvaluationSummary(string projectKind = null, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument ExportedCustomAbstractiveSummarizationDocument(string summaryLocation = null, string location = null, string language = null, string dataset = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState ExportedModelJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest ExportedModelManifest(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile> modelFiles = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject ExportedProject(string projectFileVersion = null, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType stringIndexType = default(Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType), Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig metadata = null, Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets assets = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel ExportedTrainedModel(string exportedModelName = null, string modelId = null, System.DateTimeOffset lastTrainedDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastExportedModelDateTime = default(System.DateTimeOffset), System.DateTimeOffset modelExpirationDate = default(System.DateTimeOffset), string modelTrainingConfigVersion = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState ExportProjectJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null, string resultUrl = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState ImportProjectJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel InnerErrorModel(Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode code = default(Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode), string message = null, System.Collections.Generic.IReadOnlyDictionary<string, string> details = null, string target = null, Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel innererror = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState LoadSnapshotJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile ModelFile(string name = null, System.Uri contentUri = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary MultiLabelClassEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary MultiLabelClassificationEvaluationSummary(System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary> classes = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity PrebuiltEntity(string category = null, string description = null, string examples = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState ProjectDeletionJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment ProjectDeployment(string deploymentName = null, string modelId = null, System.DateTimeOffset lastTrainedDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastDeployedDateTime = default(System.DateTimeOffset), System.DateTimeOffset deploymentExpirationDate = default(System.DateTimeOffset), string modelTrainingConfigVersion = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource> assignedResources = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata ProjectMetadata(System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastModifiedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? lastTrainedDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? lastDeployedDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind projectKind = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind), string storageInputContainerName = null, Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings settings = null, string projectName = null, bool? multilingual = default(bool?), string description = null, string language = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel ProjectTrainedModel(string label = null, string modelId = null, System.DateTimeOffset lastTrainedDateTime = default(System.DateTimeOffset), int lastTrainingDurationInSeconds = 0, System.DateTimeOffset modelExpirationDate = default(System.DateTimeOffset), string modelTrainingConfigVersion = null, bool hasSnapshot = false) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary SentimentEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary SingleLabelClassEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary SingleLabelClassificationEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix confusionMatrix = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary> classes = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary SpanSentimentEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix confusionMatrix = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary> sentiments = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState SubTrainingJobState(int percentComplete = 0, System.DateTimeOffset? startDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? endDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus)) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage SupportedLanguage(string languageName = null, string languageCode = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState SwapDeploymentsJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError TextAnalysisAuthoringError(Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode code = default(Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode), string message = null, string target = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> details = null, Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel innererror = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning TextAnalysisAuthoringWarning(string code = null, string message = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary TextSentimentEvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary spanSentimentsEvaluation = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion TrainingConfigVersion(string trainingConfigVersionProperty = null, System.DateTimeOffset modelExpirationDate = default(System.DateTimeOffset)) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig TrainingJobConfig(string modelLabel = null, string trainingConfigVersion = null, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings dataGenerationSettings = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult TrainingJobResult(string modelLabel = null, string trainingConfigVersion = null, Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState trainingStatus = null, Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState evaluationStatus = null, System.DateTimeOffset? estimatedEndDateTime = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState TrainingJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null, Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult result = null) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState UnassignDeploymentResourcesJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus status = default(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
    }
    public partial class AssignDeploymentResourcesConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>
    {
        public AssignDeploymentResourcesConfig(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata> resourcesMetadata) { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata> ResourcesMetadata { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignDeploymentResourcesJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>
    {
        internal AssignDeploymentResourcesJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignDeploymentResourcesJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignedDeploymentResource : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>
    {
        internal AssignedDeploymentResource() { }
        public string AzureResourceId { get { throw null; } }
        public string Region { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedDeploymentResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignedProjectDeploymentMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>
    {
        internal AssignedProjectDeploymentMetadata() { }
        public System.DateTimeOffset DeploymentExpirationDate { get { throw null; } }
        public string DeploymentName { get { throw null; } }
        public System.DateTimeOffset LastDeployedDateTime { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignedProjectDeploymentsMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>
    {
        internal AssignedProjectDeploymentsMetadata() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentMetadata> DeploymentsMetadata { get { throw null; } }
        public string ProjectName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.AssignedProjectDeploymentsMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CompositionSetting : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CompositionSetting(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting CombineComponents { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting SeparateComponents { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting left, Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting left, Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfusionMatrix : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>
    {
        internal ConfusionMatrix() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfusionMatrixCell : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>
    {
        internal ConfusionMatrixCell() { }
        public float NormalizedValue { get { throw null; } }
        public float RawValue { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixCell>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfusionMatrixRow : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>
    {
        internal ConfusionMatrixRow() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrixRow>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CopyProjectConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>
    {
        public CopyProjectConfig(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind projectKind, string targetProjectName, string accessToken, System.DateTimeOffset expiresAt, string targetResourceId, string targetResourceRegion) { }
        public string AccessToken { get { throw null; } set { } }
        public System.DateTimeOffset ExpiresAt { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind ProjectKind { get { throw null; } set { } }
        public string TargetProjectName { get { throw null; } set { } }
        public string TargetResourceId { get { throw null; } set { } }
        public string TargetResourceRegion { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CopyProjectJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>
    {
        internal CopyProjectJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CopyProjectJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreateDeploymentConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>
    {
        public CreateDeploymentConfig(string trainedModelLabel) { }
        public System.Collections.Generic.IList<string> AssignedResourceIds { get { throw null; } }
        public string TrainedModelLabel { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateDeploymentConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreateProjectConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>
    {
        public CreateProjectConfig(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind projectKind, string storageInputContainerName, string projectName, string language) { }
        public string Description { get { throw null; } set { } }
        public string Language { get { throw null; } }
        public bool? Multilingual { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind ProjectKind { get { throw null; } }
        public string ProjectName { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings Settings { get { throw null; } set { } }
        public string StorageInputContainerName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomEntityRecognitionDocumentEvaluationResult : Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>
    {
        internal CustomEntityRecognitionDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult CustomEntityRecognitionResult { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomEntityRecognitionEvaluationSummary : Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>
    {
        internal CustomEntityRecognitionEvaluationSummary() : base (default(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary CustomEntityRecognitionEvaluation { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomEntityRecognitionEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomHealthcareDocumentEvaluationResult : Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>
    {
        internal CustomHealthcareDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult CustomHealthcareResult { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomHealthcareEvaluationSummary : Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>
    {
        internal CustomHealthcareEvaluationSummary() : base (default(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary CustomHealthcareEvaluation { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomHealthcareEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomMultiLabelClassificationDocumentEvaluationResult : Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>
    {
        internal CustomMultiLabelClassificationDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult CustomMultiLabelClassificationResult { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomMultiLabelClassificationEvaluationSummary : Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>
    {
        internal CustomMultiLabelClassificationEvaluationSummary() : base (default(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary CustomMultiLabelClassificationEvaluation { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomMultiLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomSingleLabelClassificationDocumentEvaluationResult : Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>
    {
        internal CustomSingleLabelClassificationDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult CustomSingleLabelClassificationResult { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomSingleLabelClassificationEvaluationSummary : Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>
    {
        internal CustomSingleLabelClassificationEvaluationSummary() : base (default(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary CustomSingleLabelClassificationEvaluation { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomSingleLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomTextSentimentDocumentEvaluationResult : Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>
    {
        internal CustomTextSentimentDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult CustomTextSentimentResult { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomTextSentimentEvaluationSummary : Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>
    {
        internal CustomTextSentimentEvaluationSummary() : base (default(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary CustomTextSentimentEvaluation { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.CustomTextSentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataGenerationConnectionInfo : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>
    {
        public DataGenerationConnectionInfo(string resourceId, string deploymentName) { }
        public string DeploymentName { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind Kind { get { throw null; } }
        public string ResourceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataGenerationConnectionInfoKind : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataGenerationConnectionInfoKind(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind AzureOpenAI { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind left, Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind left, Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfoKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataGenerationSettings : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>
    {
        public DataGenerationSettings(bool enableDataGeneration, Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo dataGenerationConnectionInfo) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationConnectionInfo DataGenerationConnectionInfo { get { throw null; } }
        public bool EnableDataGeneration { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeleteDeploymentConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>
    {
        public DeleteDeploymentConfig() { }
        public System.Collections.Generic.IList<string> AssignedResourceIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeleteDeploymentConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentDeleteFromResourcesJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>
    {
        internal DeploymentDeleteFromResourcesJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentDeleteFromResourcesJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>
    {
        internal DeploymentJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentResource : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>
    {
        internal DeploymentResource() { }
        public string Region { get { throw null; } }
        public string ResourceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentEntityLabelEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>
    {
        internal DocumentEntityLabelEvaluationResult() { }
        public string Category { get { throw null; } }
        public int Length { get { throw null; } }
        public int Offset { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentEntityRecognitionEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>
    {
        internal DocumentEntityRecognitionEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult> Entities { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRecognitionEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentEntityRegionEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>
    {
        internal DocumentEntityRegionEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult> ExpectedEntities { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityLabelEvaluationResult> PredictedEntities { get { throw null; } }
        public int RegionLength { get { throw null; } }
        public int RegionOffset { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class DocumentEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>
    {
        protected DocumentEvaluationResult(string location, string language) { }
        public string Language { get { throw null; } }
        public string Location { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentHealthcareEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>
    {
        internal DocumentHealthcareEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentEntityRegionEvaluationResult> Entities { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentHealthcareEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentMultiLabelClassificationEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>
    {
        internal DocumentMultiLabelClassificationEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<string> ExpectedClasses { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> PredictedClasses { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentMultiLabelClassificationEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentSentimentLabelEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>
    {
        internal DocumentSentimentLabelEvaluationResult() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment Category { get { throw null; } }
        public int Length { get { throw null; } }
        public int Offset { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentSingleLabelClassificationEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>
    {
        internal DocumentSingleLabelClassificationEvaluationResult() { }
        public string ExpectedClass { get { throw null; } }
        public string PredictedClass { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSingleLabelClassificationEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentTextSentimentEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>
    {
        internal DocumentTextSentimentEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult> ExpectedSentimentSpans { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentSentimentLabelEvaluationResult> PredictedSentimentSpans { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.DocumentTextSentimentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>
    {
        internal EntityEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityRecognitionEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>
    {
        internal EntityRecognitionEvaluationSummary() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix ConfusionMatrix { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.EntityEvaluationSummary> Entities { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EntityRecognitionEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ErrorCode : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ErrorCode(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode AzureCognitiveSearchIndexLimitReached { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode AzureCognitiveSearchIndexNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode AzureCognitiveSearchNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode AzureCognitiveSearchThrottling { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode Conflict { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode Forbidden { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode InternalServerError { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode InvalidArgument { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode InvalidRequest { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode NotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode OperationNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode ProjectNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode QuotaExceeded { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode ServiceUnavailable { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode Timeout { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode TooManyRequests { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode Unauthorized { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode Warning { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode left, Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode left, Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EvaluationConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>
    {
        public EvaluationConfig() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind? Kind { get { throw null; } set { } }
        public int? TestingSplitPercentage { get { throw null; } set { } }
        public int? TrainingSplitPercentage { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EvaluationJobResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>
    {
        internal EvaluationJobResult() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig EvaluationOptions { get { throw null; } }
        public string ModelLabel { get { throw null; } }
        public int PercentComplete { get { throw null; } }
        public string TrainingConfigVersion { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EvaluationJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>
    {
        internal EvaluationJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobResult Result { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EvaluationKind : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EvaluationKind(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind Manual { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind Percentage { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind left, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind left, Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class EvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>
    {
        protected EvaluationSummary(Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig evaluationOptions) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig EvaluationOptions { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedClass : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>
    {
        public ExportedClass() { }
        public string Category { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCompositeEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>
    {
        public ExportedCompositeEntity() { }
        public string Category { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.CompositionSetting? CompositionSetting { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList List { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity> Prebuilts { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomAbstractiveSummarizationDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>
    {
        public ExportedCustomAbstractiveSummarizationDocument(string summaryLocation) { }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public string SummaryLocation { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomAbstractiveSummarizationProjectAssets : Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>
    {
        public ExportedCustomAbstractiveSummarizationProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationDocument> Documents { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomEntityRecognitionDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>
    {
        public ExportedCustomEntityRecognitionDocument() { }
        public string Dataset { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion> Entities { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomEntityRecognitionProjectAssets : Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>
    {
        public ExportedCustomEntityRecognitionProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionDocument> Documents { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity> Entities { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomEntityRecognitionProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomHealthcareDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>
    {
        public ExportedCustomHealthcareDocument() { }
        public string Dataset { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion> Entities { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomHealthcareProjectAssets : Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>
    {
        public ExportedCustomHealthcareProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareDocument> Documents { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCompositeEntity> Entities { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomHealthcareProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomMultiLabelClassificationDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>
    {
        public ExportedCustomMultiLabelClassificationDocument() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass> Classes { get { throw null; } }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomMultiLabelClassificationProjectAssets : Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>
    {
        public ExportedCustomMultiLabelClassificationProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass> Classes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationDocument> Documents { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomSingleLabelClassificationDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>
    {
        public ExportedCustomSingleLabelClassificationDocument() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass Class { get { throw null; } set { } }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomSingleLabelClassificationProjectAssets : Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>
    {
        public ExportedCustomSingleLabelClassificationProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedClass> Classes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationDocument> Documents { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomTextSentimentDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>
    {
        public ExportedCustomTextSentimentDocument() { }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel> SentimentSpans { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomTextSentimentProjectAssets : Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>
    {
        public ExportedCustomTextSentimentProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentDocument> Documents { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedCustomTextSentimentProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentClass : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>
    {
        public ExportedDocumentClass() { }
        public string Category { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentClass>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentEntityLabel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>
    {
        public ExportedDocumentEntityLabel() { }
        public string Category { get { throw null; } set { } }
        public int? Length { get { throw null; } set { } }
        public int? Offset { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentEntityRegion : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>
    {
        public ExportedDocumentEntityRegion() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityLabel> Labels { get { throw null; } }
        public int? RegionLength { get { throw null; } set { } }
        public int? RegionOffset { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentEntityRegion>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentSentimentLabel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>
    {
        public ExportedDocumentSentimentLabel() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment? Category { get { throw null; } set { } }
        public int? Length { get { throw null; } set { } }
        public int? Offset { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedDocumentSentimentLabel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>
    {
        public ExportedEntity() { }
        public string Category { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntityList : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>
    {
        public ExportedEntityList() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist> Sublists { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityList>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntityListSynonym : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>
    {
        public ExportedEntityListSynonym() { }
        public string Language { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Values { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntitySublist : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>
    {
        public ExportedEntitySublist() { }
        public string ListKey { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntityListSynonym> Synonyms { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedEntitySublist>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedModelConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>
    {
        public ExportedModelConfig(string trainedModelLabel) { }
        public string TrainedModelLabel { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedModelJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>
    {
        internal ExportedModelJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedModelManifest : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>
    {
        internal ExportedModelManifest() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile> ModelFiles { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedModelManifest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedPrebuiltEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>
    {
        public ExportedPrebuiltEntity(string category) { }
        public string Category { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedPrebuiltEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedProject : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>
    {
        public ExportedProject(string projectFileVersion, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType stringIndexType, Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig metadata) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets Assets { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.CreateProjectConfig Metadata { get { throw null; } }
        public string ProjectFileVersion { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType StringIndexType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProject>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ExportedProjectAssets : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>
    {
        protected ExportedProjectAssets() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedTrainedModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>
    {
        internal ExportedTrainedModel() { }
        public string ExportedModelName { get { throw null; } }
        public System.DateTimeOffset LastExportedModelDateTime { get { throw null; } }
        public System.DateTimeOffset LastTrainedDateTime { get { throw null; } }
        public System.DateTimeOffset ModelExpirationDate { get { throw null; } }
        public string ModelId { get { throw null; } }
        public string ModelTrainingConfigVersion { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportedTrainedModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportProjectJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>
    {
        internal ExportProjectJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public string ResultUrl { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ExportProjectJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ImportProjectJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>
    {
        internal ImportProjectJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ImportProjectJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InnerErrorCode : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InnerErrorCode(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode AzureCognitiveSearchNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode AzureCognitiveSearchThrottling { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode EmptyRequest { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode ExtractionFailure { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode InvalidCountryHint { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode InvalidDocument { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode InvalidDocumentBatch { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode InvalidParameterValue { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode InvalidRequest { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode InvalidRequestBodyFormat { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode KnowledgeBaseNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode MissingInputDocuments { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode ModelVersionIncorrect { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode UnsupportedLanguageCode { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode left, Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode left, Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InnerErrorModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>
    {
        internal InnerErrorModel() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorCode Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Details { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JobStatus : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JobStatus(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Cancelled { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Cancelling { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Failed { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus NotStarted { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus PartiallyCompleted { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Running { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus left, Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus left, Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LoadSnapshotJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>
    {
        internal LoadSnapshotJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.LoadSnapshotJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ModelFile : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>
    {
        internal ModelFile() { }
        public System.Uri ContentUri { get { throw null; } }
        public string Name { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ModelFile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiLabelClassEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>
    {
        internal MultiLabelClassEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiLabelClassificationEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>
    {
        internal MultiLabelClassificationEvaluationSummary() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassEvaluationSummary> Classes { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.MultiLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrebuiltEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>
    {
        internal PrebuiltEntity() { }
        public string Category { get { throw null; } }
        public string Description { get { throw null; } }
        public string Examples { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.PrebuiltEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectDeletionJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>
    {
        internal ProjectDeletionJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeletionJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectDeployment : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>
    {
        internal ProjectDeployment() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.DeploymentResource> AssignedResources { get { throw null; } }
        public System.DateTimeOffset DeploymentExpirationDate { get { throw null; } }
        public string DeploymentName { get { throw null; } }
        public System.DateTimeOffset LastDeployedDateTime { get { throw null; } }
        public System.DateTimeOffset LastTrainedDateTime { get { throw null; } }
        public string ModelId { get { throw null; } }
        public string ModelTrainingConfigVersion { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectDeployment>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProjectKind : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProjectKind(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind CustomAbstractiveSummarization { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind CustomEntityRecognition { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind CustomHealthcare { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind CustomMultiLabelClassification { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind CustomSingleLabelClassification { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind CustomTextSentiment { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind left, Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind left, Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProjectMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>
    {
        internal ProjectMetadata() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public string Description { get { throw null; } }
        public string Language { get { throw null; } }
        public System.DateTimeOffset? LastDeployedDateTime { get { throw null; } }
        public System.DateTimeOffset LastModifiedDateTime { get { throw null; } }
        public System.DateTimeOffset? LastTrainedDateTime { get { throw null; } }
        public bool? Multilingual { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectKind ProjectKind { get { throw null; } }
        public string ProjectName { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings Settings { get { throw null; } }
        public string StorageInputContainerName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectSettings : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>
    {
        public ProjectSettings() { }
        public string AmlProjectPath { get { throw null; } set { } }
        public float? ConfidenceThreshold { get { throw null; } set { } }
        public int? GptPredictiveLookahead { get { throw null; } set { } }
        public bool? IsLabelingLocked { get { throw null; } set { } }
        public bool? RunGptPredictions { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectTrainedModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>
    {
        internal ProjectTrainedModel() { }
        public bool HasSnapshot { get { throw null; } }
        public string Label { get { throw null; } }
        public System.DateTimeOffset LastTrainedDateTime { get { throw null; } }
        public int LastTrainingDurationInSeconds { get { throw null; } }
        public System.DateTimeOffset ModelExpirationDate { get { throw null; } }
        public string ModelId { get { throw null; } }
        public string ModelTrainingConfigVersion { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ProjectTrainedModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>
    {
        public ResourceMetadata(string azureResourceId, string customDomain, string region) { }
        public string AzureResourceId { get { throw null; } }
        public string CustomDomain { get { throw null; } }
        public string Region { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.ResourceMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SentimentEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>
    {
        internal SentimentEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleLabelClassEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>
    {
        internal SingleLabelClassEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleLabelClassificationEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>
    {
        internal SingleLabelClassificationEvaluationSummary() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassEvaluationSummary> Classes { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix ConfusionMatrix { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SingleLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpanSentimentEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>
    {
        internal SpanSentimentEvaluationSummary() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ConfusionMatrix ConfusionMatrix { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.AnalyzeText.Models.SentimentEvaluationSummary> Sentiments { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StringIndexType : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StringIndexType(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType Utf16CodeUnit { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType left, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType left, Azure.AI.Language.Authoring.AnalyzeText.Models.StringIndexType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SubTrainingJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>
    {
        internal SubTrainingJobState() { }
        public System.DateTimeOffset? EndDateTime { get { throw null; } }
        public int PercentComplete { get { throw null; } }
        public System.DateTimeOffset? StartDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SupportedLanguage : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>
    {
        internal SupportedLanguage() { }
        public string LanguageCode { get { throw null; } }
        public string LanguageName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SupportedLanguage>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SwapDeploymentsConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>
    {
        public SwapDeploymentsConfig(string firstDeploymentName, string secondDeploymentName) { }
        public string FirstDeploymentName { get { throw null; } }
        public string SecondDeploymentName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SwapDeploymentsJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>
    {
        internal SwapDeploymentsJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.SwapDeploymentsJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TextAnalysisAuthoringError : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>
    {
        internal TextAnalysisAuthoringError() { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.ErrorCode Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Details { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.InnerErrorModel Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TextAnalysisAuthoringSentiment : System.IEquatable<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TextAnalysisAuthoringSentiment(string value) { throw null; }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment Negative { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment Neutral { get { throw null; } }
        public static Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment Positive { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment left, Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment left, Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringSentiment right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TextAnalysisAuthoringWarning : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>
    {
        internal TextAnalysisAuthoringWarning() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TextSentimentEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>
    {
        internal TextSentimentEvaluationSummary() { }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.SpanSentimentEvaluationSummary SpanSentimentsEvaluation { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TextSentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingConfigVersion : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>
    {
        internal TrainingConfigVersion() { }
        public System.DateTimeOffset ModelExpirationDate { get { throw null; } }
        public string TrainingConfigVersionProperty { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingConfigVersion>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingJobConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>
    {
        public TrainingJobConfig(string modelLabel, string trainingConfigVersion) { }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.DataGenerationSettings DataGenerationSettings { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.EvaluationConfig EvaluationOptions { get { throw null; } set { } }
        public string ModelLabel { get { throw null; } }
        public string TrainingConfigVersion { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingJobResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>
    {
        internal TrainingJobResult() { }
        public System.DateTimeOffset? EstimatedEndDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState EvaluationStatus { get { throw null; } }
        public string ModelLabel { get { throw null; } }
        public string TrainingConfigVersion { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.SubTrainingJobState TrainingStatus { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>
    {
        internal TrainingJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobResult Result { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.TrainingJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UnassignDeploymentResourcesConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>
    {
        public UnassignDeploymentResourcesConfig(System.Collections.Generic.IEnumerable<string> assignedResourceIds) { }
        public System.Collections.Generic.IList<string> AssignedResourceIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UnassignDeploymentResourcesJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>
    {
        internal UnassignDeploymentResourcesJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.AnalyzeText.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.AnalyzeText.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.AnalyzeText.Models.UnassignDeploymentResourcesJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AILanguageAuthoringAnalyzeTextClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClient, Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions> AddAnalyzeTextClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClient, Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions> AddAnalyzeTextClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClient, Azure.AI.Language.Authoring.AnalyzeText.AnalyzeTextClientOptions> AddAnalyzeTextClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
