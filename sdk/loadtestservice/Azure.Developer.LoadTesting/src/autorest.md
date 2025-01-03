# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file: https://github.com/Azure/azure-rest-api-specs/blob/2afbad94f0e63c29bf70196ca1d7193f49ab8440/specification/loadtestservice/data-plane/Microsoft.LoadTestService/stable/2022-11-01/loadtestservice.json
namespace: Azure.Developer.LoadTesting
security: AADToken
security-scopes: https://cnt-prod.loadtesting.azure.com/.default
skip-csproj-packagereference: true
keep-non-overloadable-protocol-signature: true
directive:
    - from: swagger-document
      where: $["paths"]["/tests/{testId}/files/{fileName}"].put
      transform: >
        $["x-accessibility"] = "internal";
    - from: swagger-document
      where: $["paths"]["/test-runs/{testRunId}"].patch
      transform: >
        $["x-accessibility"] = "internal";
    - from: swagger-document
      where: $["paths"]["/test-runs/{testRunId}/metric-dimensions/{name}/values"].get
      transform: >
        $["parameters"][5]["x-ms-client-name"] = "timeInterval";
    - from: swagger-document
      where: $["paths"]["/test-runs/{testRunId}/metric-dimensions/{name}/values"].get
      transform: >
        $["parameters"][3]["x-ms-client-name"] = "metricName";
```
