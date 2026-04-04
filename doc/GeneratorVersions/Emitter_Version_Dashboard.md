# Emitter Version Dashboard

<<<<<<< HEAD
> **Auto-generated** by `Emitter_Version_Dashboard` on 2026-04-04 01:49:57 UTC.
=======
> **Auto-generated** by `Emitter_Version_Dashboard` on 2026-04-03 18:30:52 UTC.
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
> Run that script to refresh this file after dependency version changes.

## Dependency Chain

```
<<<<<<< HEAD
@typespec/http-client-csharp (alpha.20260403.13)
  └─ @azure-typespec/http-client-csharp (alpha.20260403.2)
=======
@typespec/http-client-csharp (alpha.20260403.5)
  └─ @azure-typespec/http-client-csharp (alpha.20260402.4)
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
       └─ @azure-typespec/http-client-csharp-mgmt (alpha.20260403.1)
            └─ @azure-typespec/http-client-csharp-provisioning (alpha.20260327.1)
```

## Emitter Versions

| Emitter | Depends On | Dependency Version | Latest on npm | Dependency Commit |
|---|---|---|---|---|
<<<<<<< HEAD
| `@azure-typespec/http-client-csharp` | `@typespec/http-client-csharp` | [1.0.0-alpha.20260403.13](https://www.npmjs.com/package/@typespec/http-client-csharp/v/1.0.0-alpha.20260403.13) | [1.0.0-alpha.20260403.13](https://www.npmjs.com/package/@typespec/http-client-csharp/v/1.0.0-alpha.20260403.13) | [051d4b8](https://github.com/microsoft/typespec/commit/051d4b89dafbaeaadf4e968f67d2e23ef3f46135) |
| `@azure-typespec/http-client-csharp-mgmt` | `@azure-typespec/http-client-csharp` | [1.0.0-alpha.20260331.4](https://www.npmjs.com/package/@azure-typespec/http-client-csharp/v/1.0.0-alpha.20260331.4) | [1.0.0-alpha.20260403.2](https://www.npmjs.com/package/@azure-typespec/http-client-csharp/v/1.0.0-alpha.20260403.2) | [97c14b2](https://github.com/Azure/azure-sdk-for-net/commit/97c14b2679e311a9485d2a477b54813048c4d0d6) |
=======
| `@azure-typespec/http-client-csharp` | `@typespec/http-client-csharp` | [1.0.0-alpha.20260403.5](https://www.npmjs.com/package/@typespec/http-client-csharp/v/1.0.0-alpha.20260403.5) | [1.0.0-alpha.20260403.5](https://www.npmjs.com/package/@typespec/http-client-csharp/v/1.0.0-alpha.20260403.5) | [ce6ef84](https://github.com/microsoft/typespec/commit/ce6ef8404cb311f85dee7eb3aa98fcd1b26bcb70) |
| `@azure-typespec/http-client-csharp-mgmt` | `@azure-typespec/http-client-csharp` | [1.0.0-alpha.20260331.4](https://www.npmjs.com/package/@azure-typespec/http-client-csharp/v/1.0.0-alpha.20260331.4) | [1.0.0-alpha.20260402.4](https://www.npmjs.com/package/@azure-typespec/http-client-csharp/v/1.0.0-alpha.20260402.4) | [97c14b2](https://github.com/Azure/azure-sdk-for-net/commit/97c14b2679e311a9485d2a477b54813048c4d0d6) |
>>>>>>> da5fe643f (fix: pass diagnosticScope to custom collection result constructors)
| `@azure-typespec/http-client-csharp-provisioning` | `@azure-typespec/http-client-csharp-mgmt` | [1.0.0-alpha.20260322.2](https://www.npmjs.com/package/@azure-typespec/http-client-csharp-mgmt/v/1.0.0-alpha.20260322.2) | [1.0.0-alpha.20260403.1](https://www.npmjs.com/package/@azure-typespec/http-client-csharp-mgmt/v/1.0.0-alpha.20260403.1) | [e413cb9](https://github.com/Azure/azure-sdk-for-net/commit/e413cb9dfdf6460c14915fe09126ca3b39f050e2) |

## Source Files

These are the files where versions are defined:

| File | What it controls |
|---|---|
| [eng/packages/http-client-csharp/package.json](https://github.com/Azure/azure-sdk-for-net/blob/main/eng/packages/http-client-csharp/package.json) | Azure emitter's dependency on `@typespec/http-client-csharp` |
| [eng/packages/http-client-csharp-mgmt/package.json](https://github.com/Azure/azure-sdk-for-net/blob/main/eng/packages/http-client-csharp-mgmt/package.json) | Mgmt emitter's dependency on `@azure-typespec/http-client-csharp` |
| [eng/packages/http-client-csharp-provisioning/package.json](https://github.com/Azure/azure-sdk-for-net/blob/main/eng/packages/http-client-csharp-provisioning/package.json) | Provisioning emitter's dependency on `@azure-typespec/http-client-csharp-mgmt` |
| [eng/centralpackagemanagement/Directory.Generation.Packages.props](https://github.com/Azure/azure-sdk-for-net/blob/main/eng/centralpackagemanagement/Directory.Generation.Packages.props) | NuGet versions for generator packages |
