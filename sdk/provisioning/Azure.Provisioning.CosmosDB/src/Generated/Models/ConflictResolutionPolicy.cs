// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The conflict resolution policy for the container.
/// </summary>
public partial class ConflictResolutionPolicy : ProvisionableConstruct
{
    /// <summary>
    /// Indicates the conflict resolution mode.
    /// </summary>
    public BicepValue<ConflictResolutionMode> Mode { get => _mode; set => _mode.Assign(value); }
    private readonly BicepValue<ConflictResolutionMode> _mode;

    /// <summary>
    /// The conflict resolution path in the case of LastWriterWins mode.
    /// </summary>
    public BicepValue<string> ConflictResolutionPath { get => _conflictResolutionPath; set => _conflictResolutionPath.Assign(value); }
    private readonly BicepValue<string> _conflictResolutionPath;

    /// <summary>
    /// The procedure to resolve conflicts in the case of custom mode.
    /// </summary>
    public BicepValue<string> ConflictResolutionProcedure { get => _conflictResolutionProcedure; set => _conflictResolutionProcedure.Assign(value); }
    private readonly BicepValue<string> _conflictResolutionProcedure;

    /// <summary>
    /// Creates a new ConflictResolutionPolicy.
    /// </summary>
    public ConflictResolutionPolicy()
    {
        _mode = BicepValue<ConflictResolutionMode>.DefineProperty(this, "Mode", ["mode"]);
        _conflictResolutionPath = BicepValue<string>.DefineProperty(this, "ConflictResolutionPath", ["conflictResolutionPath"]);
        _conflictResolutionProcedure = BicepValue<string>.DefineProperty(this, "ConflictResolutionProcedure", ["conflictResolutionProcedure"]);
    }
}
