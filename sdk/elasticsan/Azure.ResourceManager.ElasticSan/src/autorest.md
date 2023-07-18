# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: ElasticSan
namespace: Azure.ResourceManager.ElasticSan
# default tag is a preview version
require: https://github.com/Azure/azure-rest-api-specs/blob/d3af9ae230da00f4afa638dcbbc0ffa066d2354a/specification/elasticsan/resource-manager/readme.md
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

format-by-name-rules:
  'tenantId': 'uuid'
  'etag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

rename-rules:
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
  MBps: Mbps
  LRS: Lrs
  ZRS: Zrs

prepend-rp-prefix:
  - EncryptionType
  - Name
  - Tier
  - Volume
  - VolumeCreateOption
  - VolumeGroup
  - VolumeGroupList
  - VolumeList
  - SkuInformationList
  - SkuLocationInfo

rename-mapping:
  Volume.properties.volumeId: -|uuid
  VirtualNetworkRule.id: -|arm-id
  Action: ElasticSanVirtualNetworkRuleAction
  OperationalStatus: ResourceOperationalStatus
  ProvisioningStates: ElasticSanProvisioningState
  State: ElasticSanVirtualNetworkRuleState
  SKUCapability: ElasticSanSkuCapability
  SourceCreationData: ElasticSanVolumeDataSourceInfo
  VirtualNetworkRule: ElasticSanVirtualNetworkRule

```
