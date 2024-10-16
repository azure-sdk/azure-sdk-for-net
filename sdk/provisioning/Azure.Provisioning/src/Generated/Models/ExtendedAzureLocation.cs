// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Resource extended location.
/// </summary>
public partial class ExtendedAzureLocation : ProvisionableConstruct
{
    /// <summary>
    /// The extended location type.
    /// </summary>
    public BicepValue<ExtendedLocationType> ExtendedLocationType { get => _extendedLocationType; set => _extendedLocationType.Assign(value); }
    private readonly BicepValue<ExtendedLocationType> _extendedLocationType;

    /// <summary>
    /// The extended location name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Creates a new ExtendedAzureLocation.
    /// </summary>
    public ExtendedAzureLocation()
    {
        _extendedLocationType = BicepValue<ExtendedLocationType>.DefineProperty(this, "ExtendedLocationType", ["type"]);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
    }
}
