# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: HybridCompute
namespace: Azure.ResourceManager.HybridCompute
# default tag is a preview version
require: https://github.com/Azure/azure-rest-api-specs/blob/f7f085ca7d370195f9dc75eb26e94ad5364ffb55/specification/hybridcompute/resource-manager/readme.md
output-folder: $(this-folder)/Generated
clear-output-folder: true
sample-gen:
  output-folder: $(this-folder)/../samples/Generated
  clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

prepend-rp-prefix:
  - Location
  - Machine
  - MachineExtension
  - ResourceUpdate

rename-mapping:
  StatusLevelTypes: HybridComputeStatusLevelType
  StatusTypes: HybridComputeStatusType
  ServiceStatus: HybridComputeServiceStatus
  ServiceStatuses: HybridComputeServiceStatuses

format-by-name-rules:
  'tenantId': 'uuid'
  'ETag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

acronym-mapping:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs|ips
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4|ipv4
  Ipv6: IPv6|ipv6
  Ipsec: IPsec|ipsec
  SSO: Sso
  URI: Uri
  Etag: ETag|etag

models-to-treat-empty-string-as-null:
  - AgentConfiguration

```
