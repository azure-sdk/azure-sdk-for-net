// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Properties of a managed Cassandra cluster.
/// </summary>
public partial class CassandraClusterProperties : ProvisionableConstruct
{
    /// <summary>
    /// The status of the resource at the time the operation was called.
    /// </summary>
    public BicepValue<CassandraProvisioningState> ProvisioningState { get => _provisioningState; set => _provisioningState.Assign(value); }
    private readonly BicepValue<CassandraProvisioningState> _provisioningState;

    /// <summary>
    /// To create an empty cluster, omit this field or set it to null. To
    /// restore a backup into a new cluster, set this field to the resource id
    /// of the backup.
    /// </summary>
    public BicepValue<string> RestoreFromBackupId { get => _restoreFromBackupId; set => _restoreFromBackupId.Assign(value); }
    private readonly BicepValue<string> _restoreFromBackupId;

    /// <summary>
    /// Resource id of a subnet that this cluster&apos;s management service
    /// should have its network interface attached to. The subnet must be
    /// routable to all subnets that will be delegated to data centers. The
    /// resource id must be of the form &apos;/subscriptions/&lt;subscription
    /// id&gt;/resourceGroups/&lt;resource
    /// group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual
    /// network&gt;/subnets/&lt;subnet&gt;&apos;.
    /// </summary>
    public BicepValue<ResourceIdentifier> DelegatedManagementSubnetId { get => _delegatedManagementSubnetId; set => _delegatedManagementSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _delegatedManagementSubnetId;

    /// <summary>
    /// Which version of Cassandra should this cluster converge to running
    /// (e.g., 3.11). When updated, the cluster may take some time to migrate
    /// to the new version.
    /// </summary>
    public BicepValue<string> CassandraVersion { get => _cassandraVersion; set => _cassandraVersion.Assign(value); }
    private readonly BicepValue<string> _cassandraVersion;

    /// <summary>
    /// If you need to set the clusterName property in cassandra.yaml to
    /// something besides the resource name of the cluster, set the value to
    /// use on this property.
    /// </summary>
    public BicepValue<string> ClusterNameOverride { get => _clusterNameOverride; set => _clusterNameOverride.Assign(value); }
    private readonly BicepValue<string> _clusterNameOverride;

    /// <summary>
    /// Which authentication method Cassandra should use to authenticate
    /// clients. &apos;None&apos; turns off authentication, so should not be
    /// used except in emergencies. &apos;Cassandra&apos; is the default
    /// password based authentication. The default is &apos;Cassandra&apos;.
    /// </summary>
    public BicepValue<CassandraAuthenticationMethod> AuthenticationMethod { get => _authenticationMethod; set => _authenticationMethod.Assign(value); }
    private readonly BicepValue<CassandraAuthenticationMethod> _authenticationMethod;

    /// <summary>
    /// Initial password for clients connecting as admin to the cluster. Should
    /// be changed after cluster creation. Returns null on GET. This field
    /// only applies when the authenticationMethod field is
    /// &apos;Cassandra&apos;.
    /// </summary>
    public BicepValue<string> InitialCassandraAdminPassword { get => _initialCassandraAdminPassword; set => _initialCassandraAdminPassword.Assign(value); }
    private readonly BicepValue<string> _initialCassandraAdminPassword;

    /// <summary>
    /// IP address of this seed node.
    /// </summary>
    public BicepValue<string> PrometheusEndpointIPAddress { get => _prometheusEndpointIPAddress; set => _prometheusEndpointIPAddress.Assign(value); }
    private readonly BicepValue<string> _prometheusEndpointIPAddress;

    /// <summary>
    /// Should automatic repairs run on this cluster? If omitted, this is true,
    /// and should stay true unless you are running a hybrid cluster where you
    /// are already doing your own repairs.
    /// </summary>
    public BicepValue<bool> IsRepairEnabled { get => _isRepairEnabled; set => _isRepairEnabled.Assign(value); }
    private readonly BicepValue<bool> _isRepairEnabled;

    /// <summary>
    /// The form of AutoReplicate that is being used by this cluster.
    /// </summary>
    public BicepValue<CassandraAutoReplicateForm> AutoReplicate { get => _autoReplicate; set => _autoReplicate.Assign(value); }
    private readonly BicepValue<CassandraAutoReplicateForm> _autoReplicate;

    /// <summary>
    /// List of TLS certificates used to authorize clients connecting to the
    /// cluster. All connections are TLS encrypted whether clientCertificates
    /// is set or not, but if clientCertificates is set, the managed Cassandra
    /// cluster will reject all connections not bearing a TLS client
    /// certificate that can be validated from one or more of the public
    /// certificates in this property.
    /// </summary>
    public BicepList<CassandraCertificate> ClientCertificates { get => _clientCertificates; set => _clientCertificates.Assign(value); }
    private readonly BicepList<CassandraCertificate> _clientCertificates;

    /// <summary>
    /// List of TLS certificates used to authorize gossip from unmanaged data
    /// centers. The TLS certificates of all nodes in unmanaged data centers
    /// must be verifiable using one of the certificates provided in this
    /// property.
    /// </summary>
    public BicepList<CassandraCertificate> ExternalGossipCertificates { get => _externalGossipCertificates; set => _externalGossipCertificates.Assign(value); }
    private readonly BicepList<CassandraCertificate> _externalGossipCertificates;

    /// <summary>
    /// List of TLS certificates that unmanaged nodes must trust for gossip
    /// with managed nodes. All managed nodes will present TLS client
    /// certificates that are verifiable using one of the certificates
    /// provided in this property.
    /// </summary>
    public BicepList<CassandraCertificate> GossipCertificates { get => _gossipCertificates; }
    private readonly BicepList<CassandraCertificate> _gossipCertificates;

    /// <summary>
    /// List of IP addresses of seed nodes in unmanaged data centers. These
    /// will be added to the seed node lists of all managed nodes.
    /// </summary>
    public BicepList<CassandraDataCenterSeedNode> ExternalSeedNodes { get => _externalSeedNodes; set => _externalSeedNodes.Assign(value); }
    private readonly BicepList<CassandraDataCenterSeedNode> _externalSeedNodes;

    /// <summary>
    /// List of IP addresses of seed nodes in the managed data centers. These
    /// should be added to the seed node lists of all unmanaged nodes.
    /// </summary>
    public BicepList<CassandraDataCenterSeedNode> SeedNodes { get => _seedNodes; }
    private readonly BicepList<CassandraDataCenterSeedNode> _seedNodes;

    /// <summary>
    /// List of the data center names for unmanaged data centers in this
    /// cluster to be included in auto-replication.
    /// </summary>
    public BicepList<string> ExternalDataCenters { get => _externalDataCenters; set => _externalDataCenters.Assign(value); }
    private readonly BicepList<string> _externalDataCenters;

    /// <summary>
    /// (Deprecated) Number of hours to wait between taking a backup of the
    /// cluster.
    /// </summary>
    public BicepValue<int> HoursBetweenBackups { get => _hoursBetweenBackups; set => _hoursBetweenBackups.Assign(value); }
    private readonly BicepValue<int> _hoursBetweenBackups;

    /// <summary>
    /// Whether the cluster and associated data centers has been deallocated.
    /// </summary>
    public BicepValue<bool> IsDeallocated { get => _isDeallocated; set => _isDeallocated.Assign(value); }
    private readonly BicepValue<bool> _isDeallocated;

    /// <summary>
    /// Whether Cassandra audit logging is enabled.
    /// </summary>
    public BicepValue<bool> IsCassandraAuditLoggingEnabled { get => _isCassandraAuditLoggingEnabled; set => _isCassandraAuditLoggingEnabled.Assign(value); }
    private readonly BicepValue<bool> _isCassandraAuditLoggingEnabled;

    /// <summary>
    /// Type of the cluster. If set to Production, some operations might not be
    /// permitted on cluster.
    /// </summary>
    public BicepValue<CassandraClusterType> ClusterType { get => _clusterType; set => _clusterType.Assign(value); }
    private readonly BicepValue<CassandraClusterType> _clusterType;

    /// <summary>
    /// Error related to resource provisioning.
    /// </summary>
    public BicepValue<CassandraError> ProvisionError { get => _provisionError; set => _provisionError.Assign(value); }
    private readonly BicepValue<CassandraError> _provisionError;

    /// <summary>
    /// Extensions to be added or updated on cluster.
    /// </summary>
    public BicepList<string> Extensions { get => _extensions; set => _extensions.Assign(value); }
    private readonly BicepList<string> _extensions;

    /// <summary>
    /// List of backup schedules that define when you want to back up your data.
    /// </summary>
    public BicepList<CassandraClusterBackupSchedule> BackupSchedules { get => _backupSchedules; set => _backupSchedules.Assign(value); }
    private readonly BicepList<CassandraClusterBackupSchedule> _backupSchedules;

    /// <summary>
    /// How the nodes in the cluster react to scheduled events.
    /// </summary>
    public BicepValue<ScheduledEventStrategy> ScheduledEventStrategy { get => _scheduledEventStrategy; set => _scheduledEventStrategy.Assign(value); }
    private readonly BicepValue<ScheduledEventStrategy> _scheduledEventStrategy;

    /// <summary>
    /// How to connect to the azure services needed for running the cluster.
    /// </summary>
    public BicepValue<ServiceConnectionType> AzureConnectionMethod { get => _azureConnectionMethod; set => _azureConnectionMethod.Assign(value); }
    private readonly BicepValue<ServiceConnectionType> _azureConnectionMethod;

    /// <summary>
    /// If the Connection Method is Vpn, this is the Id of the private link
    /// resource that the datacenters need to connect to.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateLinkResourceId { get => _privateLinkResourceId; }
    private readonly BicepValue<ResourceIdentifier> _privateLinkResourceId;

    /// <summary>
    /// Creates a new CassandraClusterProperties.
    /// </summary>
    public CassandraClusterProperties()
    {
        _provisioningState = BicepValue<CassandraProvisioningState>.DefineProperty(this, "ProvisioningState", ["provisioningState"]);
        _restoreFromBackupId = BicepValue<string>.DefineProperty(this, "RestoreFromBackupId", ["restoreFromBackupId"]);
        _delegatedManagementSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "DelegatedManagementSubnetId", ["delegatedManagementSubnetId"]);
        _cassandraVersion = BicepValue<string>.DefineProperty(this, "CassandraVersion", ["cassandraVersion"]);
        _clusterNameOverride = BicepValue<string>.DefineProperty(this, "ClusterNameOverride", ["clusterNameOverride"]);
        _authenticationMethod = BicepValue<CassandraAuthenticationMethod>.DefineProperty(this, "AuthenticationMethod", ["authenticationMethod"]);
        _initialCassandraAdminPassword = BicepValue<string>.DefineProperty(this, "InitialCassandraAdminPassword", ["initialCassandraAdminPassword"]);
        _prometheusEndpointIPAddress = BicepValue<string>.DefineProperty(this, "PrometheusEndpointIPAddress", ["prometheusEndpoint", "ipAddress"]);
        _isRepairEnabled = BicepValue<bool>.DefineProperty(this, "IsRepairEnabled", ["repairEnabled"]);
        _autoReplicate = BicepValue<CassandraAutoReplicateForm>.DefineProperty(this, "AutoReplicate", ["autoReplicate"]);
        _clientCertificates = BicepList<CassandraCertificate>.DefineProperty(this, "ClientCertificates", ["clientCertificates"]);
        _externalGossipCertificates = BicepList<CassandraCertificate>.DefineProperty(this, "ExternalGossipCertificates", ["externalGossipCertificates"]);
        _gossipCertificates = BicepList<CassandraCertificate>.DefineProperty(this, "GossipCertificates", ["gossipCertificates"], isOutput: true);
        _externalSeedNodes = BicepList<CassandraDataCenterSeedNode>.DefineProperty(this, "ExternalSeedNodes", ["externalSeedNodes"]);
        _seedNodes = BicepList<CassandraDataCenterSeedNode>.DefineProperty(this, "SeedNodes", ["seedNodes"], isOutput: true);
        _externalDataCenters = BicepList<string>.DefineProperty(this, "ExternalDataCenters", ["externalDataCenters"]);
        _hoursBetweenBackups = BicepValue<int>.DefineProperty(this, "HoursBetweenBackups", ["hoursBetweenBackups"]);
        _isDeallocated = BicepValue<bool>.DefineProperty(this, "IsDeallocated", ["deallocated"]);
        _isCassandraAuditLoggingEnabled = BicepValue<bool>.DefineProperty(this, "IsCassandraAuditLoggingEnabled", ["cassandraAuditLoggingEnabled"]);
        _clusterType = BicepValue<CassandraClusterType>.DefineProperty(this, "ClusterType", ["clusterType"]);
        _provisionError = BicepValue<CassandraError>.DefineProperty(this, "ProvisionError", ["provisionError"]);
        _extensions = BicepList<string>.DefineProperty(this, "Extensions", ["extensions"]);
        _backupSchedules = BicepList<CassandraClusterBackupSchedule>.DefineProperty(this, "BackupSchedules", ["backupSchedules"]);
        _scheduledEventStrategy = BicepValue<ScheduledEventStrategy>.DefineProperty(this, "ScheduledEventStrategy", ["scheduledEventStrategy"]);
        _azureConnectionMethod = BicepValue<ServiceConnectionType>.DefineProperty(this, "AzureConnectionMethod", ["azureConnectionMethod"]);
        _privateLinkResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateLinkResourceId", ["privateLinkResourceId"], isOutput: true);
    }
}
