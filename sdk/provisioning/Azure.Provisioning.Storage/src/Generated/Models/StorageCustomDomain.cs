// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The custom domain assigned to this storage account. This can be set via
/// Update.
/// </summary>
public partial class StorageCustomDomain : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets the custom domain name assigned to the storage account.
    /// Name is the CNAME source.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Indicates whether indirect CName validation is enabled. Default value
    /// is false. This should only be set on updates.
    /// </summary>
    public BicepValue<bool> IsUseSubDomainNameEnabled { get => _isUseSubDomainNameEnabled; set => _isUseSubDomainNameEnabled.Assign(value); }
    private readonly BicepValue<bool> _isUseSubDomainNameEnabled;

    /// <summary>
    /// Creates a new StorageCustomDomain.
    /// </summary>
    public StorageCustomDomain()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _isUseSubDomainNameEnabled = BicepValue<bool>.DefineProperty(this, "IsUseSubDomainNameEnabled", ["useSubDomainName"]);
    }
}
