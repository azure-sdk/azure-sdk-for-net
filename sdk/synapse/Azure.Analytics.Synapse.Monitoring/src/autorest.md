# Microsoft.Azure.Synapse

Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
tag: package-monitoring-2019-11-01-preview
require:
- /mnt/vss/_work/1/s/azure-rest-api-specs/specification/synapse/data-plane/readme.md
namespace: Azure.Analytics.Synapse.Monitoring
generation1-convenience-client: true
public-clients: true
security: AADToken
security-scopes: https://dev.azuresynapse.net/.default
```

### Make Endpoint type as Uri

``` yaml
directive:
  from: swagger-document
  where: $.parameters.Endpoint
  transform: $.format = "url"
```
