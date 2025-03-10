// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// Permissions the identity has for keys, secrets, certificates and storage.
/// </summary>
public partial class IdentityAccessPermissions : ProvisionableConstruct
{
    /// <summary>
    /// Permissions to keys.
    /// </summary>
    public BicepList<IdentityAccessKeyPermission> Keys 
    {
        get { Initialize(); return _keys!; }
        set { Initialize(); _keys!.Assign(value); }
    }
    private BicepList<IdentityAccessKeyPermission>? _keys;

    /// <summary>
    /// Permissions to secrets.
    /// </summary>
    public BicepList<IdentityAccessSecretPermission> Secrets 
    {
        get { Initialize(); return _secrets!; }
        set { Initialize(); _secrets!.Assign(value); }
    }
    private BicepList<IdentityAccessSecretPermission>? _secrets;

    /// <summary>
    /// Permissions to certificates.
    /// </summary>
    public BicepList<IdentityAccessCertificatePermission> Certificates 
    {
        get { Initialize(); return _certificates!; }
        set { Initialize(); _certificates!.Assign(value); }
    }
    private BicepList<IdentityAccessCertificatePermission>? _certificates;

    /// <summary>
    /// Permissions to storage accounts.
    /// </summary>
    public BicepList<IdentityAccessStoragePermission> Storage 
    {
        get { Initialize(); return _storage!; }
        set { Initialize(); _storage!.Assign(value); }
    }
    private BicepList<IdentityAccessStoragePermission>? _storage;

    /// <summary>
    /// Creates a new IdentityAccessPermissions.
    /// </summary>
    public IdentityAccessPermissions()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of IdentityAccessPermissions.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _keys = DefineListProperty<IdentityAccessKeyPermission>("Keys", ["keys"]);
        _secrets = DefineListProperty<IdentityAccessSecretPermission>("Secrets", ["secrets"]);
        _certificates = DefineListProperty<IdentityAccessCertificatePermission>("Certificates", ["certificates"]);
        _storage = DefineListProperty<IdentityAccessStoragePermission>("Storage", ["storage"]);
    }
}
