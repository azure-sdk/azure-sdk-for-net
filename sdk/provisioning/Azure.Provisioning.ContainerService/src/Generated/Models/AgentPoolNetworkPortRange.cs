// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// The port range.
/// </summary>
public partial class AgentPoolNetworkPortRange : ProvisionableConstruct
{
    /// <summary>
    /// The minimum port that is included in the range. It should be ranged
    /// from 1 to 65535, and be less than or equal to portEnd.
    /// </summary>
    public BicepValue<int> PortStart { get => _portStart; set => _portStart.Assign(value); }
    private readonly BicepValue<int> _portStart;

    /// <summary>
    /// The maximum port that is included in the range. It should be ranged
    /// from 1 to 65535, and be greater than or equal to portStart.
    /// </summary>
    public BicepValue<int> PortEnd { get => _portEnd; set => _portEnd.Assign(value); }
    private readonly BicepValue<int> _portEnd;

    /// <summary>
    /// The network protocol of the port.
    /// </summary>
    public BicepValue<AgentPoolNetworkPortProtocol> Protocol { get => _protocol; set => _protocol.Assign(value); }
    private readonly BicepValue<AgentPoolNetworkPortProtocol> _protocol;

    /// <summary>
    /// Creates a new AgentPoolNetworkPortRange.
    /// </summary>
    public AgentPoolNetworkPortRange()
    {
        _portStart = BicepValue<int>.DefineProperty(this, "PortStart", ["portStart"]);
        _portEnd = BicepValue<int>.DefineProperty(this, "PortEnd", ["portEnd"]);
        _protocol = BicepValue<AgentPoolNetworkPortProtocol>.DefineProperty(this, "Protocol", ["protocol"]);
    }
}
