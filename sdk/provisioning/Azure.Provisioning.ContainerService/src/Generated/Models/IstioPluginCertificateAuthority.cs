// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Plugin certificates information for Service Mesh.
/// </summary>
public partial class IstioPluginCertificateAuthority : ProvisionableConstruct
{
    /// <summary>
    /// The resource ID of the Key Vault.
    /// </summary>
    public BicepValue<ResourceIdentifier> KeyVaultId { get => _keyVaultId; set => _keyVaultId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _keyVaultId;

    /// <summary>
    /// Intermediate certificate object name in Azure Key Vault.
    /// </summary>
    public BicepValue<string> CertObjectName { get => _certObjectName; set => _certObjectName.Assign(value); }
    private readonly BicepValue<string> _certObjectName;

    /// <summary>
    /// Intermediate certificate private key object name in Azure Key Vault.
    /// </summary>
    public BicepValue<string> KeyObjectName { get => _keyObjectName; set => _keyObjectName.Assign(value); }
    private readonly BicepValue<string> _keyObjectName;

    /// <summary>
    /// Root certificate object name in Azure Key Vault.
    /// </summary>
    public BicepValue<string> RootCertObjectName { get => _rootCertObjectName; set => _rootCertObjectName.Assign(value); }
    private readonly BicepValue<string> _rootCertObjectName;

    /// <summary>
    /// Certificate chain object name in Azure Key Vault.
    /// </summary>
    public BicepValue<string> CertChainObjectName { get => _certChainObjectName; set => _certChainObjectName.Assign(value); }
    private readonly BicepValue<string> _certChainObjectName;

    /// <summary>
    /// Creates a new IstioPluginCertificateAuthority.
    /// </summary>
    public IstioPluginCertificateAuthority()
    {
        _keyVaultId = BicepValue<ResourceIdentifier>.DefineProperty(this, "KeyVaultId", ["keyVaultId"]);
        _certObjectName = BicepValue<string>.DefineProperty(this, "CertObjectName", ["certObjectName"]);
        _keyObjectName = BicepValue<string>.DefineProperty(this, "KeyObjectName", ["keyObjectName"]);
        _rootCertObjectName = BicepValue<string>.DefineProperty(this, "RootCertObjectName", ["rootCertObjectName"]);
        _certChainObjectName = BicepValue<string>.DefineProperty(this, "CertChainObjectName", ["certChainObjectName"]);
    }
}
