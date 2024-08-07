# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

```yaml
title: PurviewAdministration
input-file:
  - https://github.com/test-repo-billy/azure-rest-api-specs/blob/981c678e48cce6ba430dcf965618670f7015c8a0/specification/purview/data-plane/Azure.Analytics.Purview.Account/preview/2019-11-01-preview/account.json
  - https://github.com/test-repo-billy/azure-rest-api-specs/blob/981c678e48cce6ba430dcf965618670f7015c8a0/specification/purview/data-plane/Azure.Analytics.Purview.MetadataPolicies/preview/2021-07-01-preview/purviewMetadataPolicy.json
namespace: Azure.Analytics.Purview.Administration
modelerfour:
    lenient-model-deduplication: true
security: AADToken
security-scopes:  https://purview.azure.net/.default
```

# Model endpoint parameter as a url, not a string.

```yaml
directive:
  - from: swagger-document
    where: $.parameters.endpoint
    transform: >
      if ($.format === undefined) {
        $.format = "url";
      }
  - from: swagger-document
    where: $.parameters.Endpoint
    transform: >
      if ($.format === undefined) {
        $.format = "url";
      }
```

# Promote collectionName to be a client parameter.

```yaml
directive:
  - from: swagger-document
    where: $.parameters
    transform: >
      $["collectionName"] = {
        "in": "path",
        "name": "collectionName",
        "required": true,
        "type": "string",
        "x-ms-parameter-location": "client"
      };

  - from: swagger-document
    where: $.paths..parameters[?(@.name=='collectionName')]
    transform: >
      $ = { "$ref": "#/parameters/collectionName" };
```

# Rename or reorganize methods

```yaml
directive:
  - from: swagger-document
    where: $..[?(@.operationId !== undefined)]
    transform: >
      const mappingTable = {
        "Collections_ListCollections": "Accounts_GetCollections",
        "ResourceSetRules_ListResourceSetRules": "Accounts_GetResourceSetRules",
        "MetadataRoles_List": "MetadataRoles_GetMetadataRoles",
        "MetadataPolicy_ListAll": "MetadataPolicy_GetMetadataPolicies",
        "MetadataPolicy_Get": "MetadataPolicy_GetMetadataPolicy",
        "MetadataPolicy_Update": "MetadataPolicy_UpdateMetadataPolicy",
      };

      $.operationId = (mappingTable[$.operationId] ?? $.operationId);
```

# Add `Purview` To Metadata Clients

```yaml
directive:
  - from: swagger-document
    where: $..[?(@.operationId !== undefined)]
    transform: >
      if ($.operationId.startsWith("Metadata")) {
          $.operationId = "Purview" + $.operationId;
      }
```
