// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the endpoints used for the custom Open ID
/// Connect provider.
/// </summary>
public partial class ContainerAppOpenIdConnectConfig : ProvisionableConstruct
{
    /// <summary>
    /// The endpoint to be used to make an authorization request.
    /// </summary>
    public BicepValue<string> AuthorizationEndpoint { get => _authorizationEndpoint; set => _authorizationEndpoint.Assign(value); }
    private readonly BicepValue<string> _authorizationEndpoint;

    /// <summary>
    /// The endpoint to be used to request a token.
    /// </summary>
    public BicepValue<string> TokenEndpoint { get => _tokenEndpoint; set => _tokenEndpoint.Assign(value); }
    private readonly BicepValue<string> _tokenEndpoint;

    /// <summary>
    /// The endpoint that issues the token.
    /// </summary>
    public BicepValue<string> Issuer { get => _issuer; set => _issuer.Assign(value); }
    private readonly BicepValue<string> _issuer;

    /// <summary>
    /// The endpoint that provides the keys necessary to validate the token.
    /// </summary>
    public BicepValue<Uri> CertificationUri { get => _certificationUri; set => _certificationUri.Assign(value); }
    private readonly BicepValue<Uri> _certificationUri;

    /// <summary>
    /// The endpoint that contains all the configuration endpoints for the
    /// provider.
    /// </summary>
    public BicepValue<string> WellKnownOpenIdConfiguration { get => _wellKnownOpenIdConfiguration; set => _wellKnownOpenIdConfiguration.Assign(value); }
    private readonly BicepValue<string> _wellKnownOpenIdConfiguration;

    /// <summary>
    /// Creates a new ContainerAppOpenIdConnectConfig.
    /// </summary>
    public ContainerAppOpenIdConnectConfig()
    {
        _authorizationEndpoint = BicepValue<string>.DefineProperty(this, "AuthorizationEndpoint", ["authorizationEndpoint"]);
        _tokenEndpoint = BicepValue<string>.DefineProperty(this, "TokenEndpoint", ["tokenEndpoint"]);
        _issuer = BicepValue<string>.DefineProperty(this, "Issuer", ["issuer"]);
        _certificationUri = BicepValue<Uri>.DefineProperty(this, "CertificationUri", ["certificationUri"]);
        _wellKnownOpenIdConfiguration = BicepValue<string>.DefineProperty(this, "WellKnownOpenIdConfiguration", ["wellKnownOpenIdConfiguration"]);
    }
}
