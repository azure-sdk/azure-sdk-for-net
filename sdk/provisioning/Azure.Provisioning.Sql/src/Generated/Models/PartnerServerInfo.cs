// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Partner server information for the failover group.
/// </summary>
public partial class PartnerServerInfo : ProvisionableConstruct
{
    /// <summary>
    /// Resource identifier of the partner server.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
        set { Initialize(); _id!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Geo location of the partner server.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Replication role of the partner server.
    /// </summary>
    public BicepValue<FailoverGroupReplicationRole> ReplicationRole 
    {
        get { Initialize(); return _replicationRole!; }
    }
    private BicepValue<FailoverGroupReplicationRole>? _replicationRole;

    /// <summary>
    /// Creates a new PartnerServerInfo.
    /// </summary>
    public PartnerServerInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PartnerServerInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"]);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _replicationRole = DefineProperty<FailoverGroupReplicationRole>("ReplicationRole", ["replicationRole"], isOutput: true);
    }
}
