# Azure.AI.TextAnalytics

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- https://github.com/Azure/azure-rest-api-specs/blob/ce46dc3e04b0bc3a7b04d9c715c1107186978a5c/specification/cognitiveservices/data-plane/Language/stable/2023-04-01/analyzetext.json
generation1-convenience-client: true
```

### Suppress Abstract Base Class

``` yaml
suppress-abstract-base-class:
- AnalyzeTextTask
- AnalyzeTextTaskResult
```

### Modify operationId names

``` yaml
directive:
- rename-operation:
    from: AnalyzeText
    to: Analyze

- from: swagger-document
  where: $.paths.*
  transform: >
    for (var op of Object.values($)) {
      if (op["operationId"] && op["operationId"].includes("AnalyzeText_")) {
        op["operationId"] = op["operationId"].replace("AnalyzeText_", "AnalyzeBatch");
      }
    }
```

### Make generated models internal by default

``` yaml
directive:
- from: swagger-document
  where: $.definitions.*
  transform: >
    $["x-accessibility"] = "internal"
- from: swagger-document
  where: $.definitions..properties.*
  transform: >
    $["x-accessibility"] = "internal"
```

### Add nullable annotations

This is to guarantee that we don't introduce breaking changes now that we autogerate the code.

``` yaml
directive:
- from: swagger-document
  where: $.definitions.DetectedLanguage
  transform: >
    $.properties.name["x-nullable"] = true;
    $.properties.iso6391Name["x-nullable"] = true;

- from: swagger-document
  where: $.definitions.LanguageInput
  transform: >
    $.properties.id["x-nullable"] = true;
    $.properties.text["x-nullable"] = true;

- from: swagger-document
  where: $.definitions.MultiLanguageInput
  transform: >
    $.properties.id["x-nullable"] = true;
    $.properties.text["x-nullable"] = true;
```
