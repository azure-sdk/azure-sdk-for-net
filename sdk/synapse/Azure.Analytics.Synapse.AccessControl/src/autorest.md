# Microsoft.Azure.Synapse

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
tag: package-access-control-2020-12-01
require:
- /mnt/vss/_work/1/s/azure-rest-api-specs/specification/synapse/data-plane/readme.md
namespace: Azure.Analytics.Synapse.AccessControl
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

