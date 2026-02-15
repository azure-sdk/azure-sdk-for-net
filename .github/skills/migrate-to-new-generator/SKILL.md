---
name: migrate-to-new-generator
description: Migrate an Azure SDK for .NET data-plane library from the old AutoRest-based generator to the new TypeSpec generator. Updates configuration, replaces deprecated attributes and APIs, regenerates code, and iteratively fixes build errors.
---

# Migrate Azure SDK Library to New Generator

Migrate a .NET data-plane SDK library from the old AutoRest-based C# code generator to the new TypeSpec-based generator. This skill performs configuration updates, code transformations, code regeneration, and iterative build-error fixing.

## Prerequisites

- The library must already have a `tsp-location.yaml` file (it is a TypeSpec-based library).
- The library path must be provided (e.g., `sdk/cognitivelanguage/Azure.AI.Language.Text`).

## Step 1: Identify the library path

**Goal**: Determine the target library to migrate.
**Actions**:

- If the user has not provided a library path, ask for it. The path should be relative to the repo root and point to the package directory (e.g., `sdk/storage/Azure.Storage.Blobs`).
- Verify the directory exists and contains a `tsp-location.yaml` file and a `src/` subdirectory.

---

## Step 2: Update `tsp-location.yaml`

**Goal**: Point the library at the new TypeSpec emitter.
**Actions**:

- Read `{libraryPath}/tsp-location.yaml`.
- Replace the `emitterPackageJsonPath` value with:
  ```
  eng/azure-typespec-http-client-csharp-emitter-package.json
  ```
- If `emitterPackageJsonPath` is not present, add it.
- If the file already contains the new emitter path, skip this step.

---

## Step 3: Update commit SHA to latest

**Goal**: Ensure the library generates against the latest spec.
**Actions**:

- Parse `repo` and `directory` from `tsp-location.yaml`.
- Use the GitHub API or MCP tools to find the latest commit SHA for the spec path on the `main` branch of the spec repo (typically `Azure/azure-rest-api-specs`).
- Update the `commit` field in `tsp-location.yaml`.
- If the spec path no longer exists in the repo, search for the new location by looking for TypeSpec projects (`tspconfig.yaml`) with similar service names, and update both `directory` and `commit`.

---

## Step 4: Update `.csproj` files

**Goal**: Remove old AutoRest dependencies.
**Actions**:

- Find all `.csproj` files under `{libraryPath}/src/`.
- Remove the `<IncludeAutorestDependency>true</IncludeAutorestDependency>` element if present.
- Clean up any resulting empty lines.

---

## Step 5: Update CodeGen namespace

**Goal**: Switch custom code files to the new customization namespace.
**Actions**:

- Find all `.cs` files under `{libraryPath}/src/` that are **NOT** in `Generated/` folders.
- For each file that contains `[CodeGen` attributes (not commented out) and does not already have the new using:
  - Add `using Microsoft.TypeSpec.Generator.Customizations;` after the last `using` statement.

---

## Step 6: Replace `CodeGenClient` / `CodeGenModel` with `CodeGenType`

**Goal**: Update deprecated attributes to the new unified attribute.
**Actions**:

- In all non-Generated `.cs` files under `{libraryPath}/src/`:
  - Replace `CodeGenClient` → `CodeGenType`
  - Replace `CodeGenModel` → `CodeGenType`

---

## Step 7: Replace `_pipeline` with `Pipeline`

**Goal**: Update the private pipeline field reference to the new public property.
**Actions**:

- In all non-Generated `.cs` files under `{libraryPath}/src/`:
  - Replace `_pipeline` → `Pipeline` (word-boundary match only).

---

## Step 8: Remove `Autorest.CSharp.Core` using statements

**Goal**: Remove references to the old generator namespace.
**Actions**:

- In all non-Generated `.cs` files under `{libraryPath}/src/`:
  - Remove lines matching `using Autorest.CSharp.Core;`.

---

## Step 9: Replace `_serializedAdditionalRawData` with `_additionalBinaryDataProperties`

**Goal**: Update the backing field name to match the new generator output.
**Actions**:

- In all non-Generated `.cs` files under `{libraryPath}/src/`:
  - Replace `_serializedAdditionalRawData` → `_additionalBinaryDataProperties`
  - Replace `serializedAdditionalRawData` → `additionalBinaryDataProperties`

---

## Step 10: Run code generation

**Goal**: Regenerate code with the new generator.
**Actions**:

- Run:
  ```shell
  dotnet build {libraryPath}/src/{PackageName}.csproj /t:GenerateCode
  ```
- This will generate new code under `src/Generated/` using the new TypeSpec emitter.

---

## Step 11: Build and fix errors iteratively

**Goal**: Get the library to compile successfully.
**Actions**:

1. Run `dotnet build {libraryPath}/src/{PackageName}.csproj` to check for compilation errors.
2. If the build succeeds, proceed to Step 12.
3. If the build fails, analyze the errors and apply fixes using the migration patterns below.
4. After applying fixes, re-run `dotnet build /t:GenerateCode` (fixes may affect generated output), then rebuild.
5. Repeat up to 10 times or until the build succeeds.

### CRITICAL RULE: Never modify files under `Generated/` folders

All fixes must be made in non-Generated customization files. If an error originates from a Generated file, create or edit a partial class in the parallel non-Generated location.

### Migration Patterns to Apply

#### `GeneratorPageableHelpers` → `CollectionResult` pattern
- If code uses `GeneratorPageableHelpers.CreatePageable` or similar, replace it with the corresponding generated `CollectionResult` type from the `Generated/` folder.
- If no `CollectionResult` type exists in `Generated/`:
  1. Look for a `[CodeGenSuppress]` attribute that suppresses the internal method which would create the `CollectionResult`.
  2. Comment out or remove that `[CodeGenSuppress]` attribute.
  3. Re-run code generation to produce the `CollectionResult` type.
  4. After regeneration, use the generated type.
- Do NOT create `CollectionResult` types manually.

#### `ToRequestContent()` removal
- Input models now have an implicit cast to `RequestContent`.
- Replace `foo.ToRequestContent()` with just `foo`.
- Example: `using RequestContent content = details.ToRequestContent();` → `using RequestContent content = details;`
- **Keep** the `using` statement; only remove the `.ToRequestContent()` call.

#### `FromCancellationToken` replacement
- Replace `RequestContext context = FromCancellationToken(cancellationToken);`
- With `RequestContext context = cancellationToken.ToRequestContext();`

#### Mismatched `ModelFactory` type names
- If a custom type ending in `ModelFactory` has a different name than the generated type ending in `ModelFactory`, update the `CodeGenType` attribute in the custom type to match the generated type name.

#### Mismatched `ClientBuilderExtensions` type names
- If a custom type ending in `ClientBuilderExtensions` has a different name than the generated type ending in `ClientBuilderExtensions`, update the `CodeGenType` attribute in the custom type to match the generated type name.

#### Fetch methods in custom LRO methods
- The old `Fetch` methods are replaced by static `FromLroResponse` methods on the response models.
- Update custom LRO methods to use `ResponseModel.FromLroResponse(response)` instead of calling `Fetch` methods.
- Do NOT create `Fetch` methods manually.

#### `FromResponse` method removal
- `FromResponse` methods have been removed from models.
- Use explicit cast from `Response` to the model type instead.
- Example: `var model = ModelType.FromResponse(response);` → `var model = (ModelType)response;`

---

## Step 12: Build the full solution (including tests)

**Goal**: Ensure tests also compile after migration.
**Actions**:

1. Run `dotnet build` from the library root directory `{libraryPath}` to build the full solution including tests.
2. If build errors occur in test projects, apply the same migration patterns above to fix them (test files are not generated, so they can be edited directly).
3. Repeat until the solution builds successfully.

---

## Step 13: Verify and summarize

**Goal**: Confirm migration is complete.
**Actions**:

- Report a summary of all completed steps and any warnings.
- Note if any `CodeGenType` attributes may need manual updates due to type name changes.
- Remind the user to review the changes with `git diff` before committing.
- Suggest running `pre-commit-checks` skill before committing.
