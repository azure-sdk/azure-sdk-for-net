// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Enforce a minimal Tls version for the server.
/// </summary>
public enum PostgreSqlMinimalTlsVersionEnum
{
    /// <summary>
    /// TLS1_0.
    /// </summary>
    [DataMember(Name = "TLS1_0")]
    Tls1_0,

    /// <summary>
    /// TLS1_1.
    /// </summary>
    [DataMember(Name = "TLS1_1")]
    Tls1_1,

    /// <summary>
    /// TLS1_2.
    /// </summary>
    [DataMember(Name = "TLS1_2")]
    Tls1_2,

    /// <summary>
    /// TLSEnforcementDisabled.
    /// </summary>
    TLSEnforcementDisabled,
}
