// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// TCPSocket specifies an action involving a TCP port. TCP hooks not yet
/// supported.
/// </summary>
public partial class ContainerAppTcpSocketRequestInfo : ProvisionableConstruct
{
    /// <summary>
    /// Optional: Host name to connect to, defaults to the pod IP.
    /// </summary>
    public BicepValue<string> Host { get => _host; set => _host.Assign(value); }
    private readonly BicepValue<string> _host;

    /// <summary>
    /// Number or name of the port to access on the container. Number must be
    /// in the range 1 to 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    public BicepValue<int> Port { get => _port; set => _port.Assign(value); }
    private readonly BicepValue<int> _port;

    /// <summary>
    /// Creates a new ContainerAppTcpSocketRequestInfo.
    /// </summary>
    public ContainerAppTcpSocketRequestInfo()
    {
        _host = BicepValue<string>.DefineProperty(this, "Host", ["host"]);
        _port = BicepValue<int>.DefineProperty(this, "Port", ["port"]);
    }
}
