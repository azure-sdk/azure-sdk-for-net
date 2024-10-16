// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Identity for the resource.
/// </summary>
public partial class ArmApplicationManagedIdentity : ProvisionableConstruct
{
    /// <summary>
    /// The principal ID of resource identity.
    /// </summary>
    public BicepValue<Guid> PrincipalId { get => _principalId; }
    private readonly BicepValue<Guid> _principalId;

    /// <summary>
    /// The tenant ID of resource.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// The identity type.
    /// </summary>
    public BicepValue<ArmApplicationManagedIdentityType> IdentityType { get => _identityType; set => _identityType.Assign(value); }
    private readonly BicepValue<ArmApplicationManagedIdentityType> _identityType;

    /// <summary>
    /// The list of user identities associated with the resource. The user
    /// identity dictionary key references will be resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    public BicepDictionary<ArmApplicationUserAssignedIdentity> UserAssignedIdentities { get => _userAssignedIdentities; set => _userAssignedIdentities.Assign(value); }
    private readonly BicepDictionary<ArmApplicationUserAssignedIdentity> _userAssignedIdentities;

    /// <summary>
    /// Creates a new ArmApplicationManagedIdentity.
    /// </summary>
    public ArmApplicationManagedIdentity()
    {
        _principalId = BicepValue<Guid>.DefineProperty(this, "PrincipalId", ["principalId"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"], isOutput: true);
        _identityType = BicepValue<ArmApplicationManagedIdentityType>.DefineProperty(this, "IdentityType", ["type"]);
        _userAssignedIdentities = BicepDictionary<ArmApplicationUserAssignedIdentity>.DefineProperty(this, "UserAssignedIdentities", ["userAssignedIdentities"]);
    }
}
