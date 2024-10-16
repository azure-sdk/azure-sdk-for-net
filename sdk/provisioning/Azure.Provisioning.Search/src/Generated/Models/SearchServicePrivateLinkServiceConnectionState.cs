// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// Describes the current state of an existing Azure Private Link service
/// connection to the private endpoint.
/// </summary>
public partial class SearchServicePrivateLinkServiceConnectionState : ProvisionableConstruct
{
    /// <summary>
    /// Status of the the private link service connection. Valid values are
    /// Pending, Approved, Rejected, or Disconnected.
    /// </summary>
    public BicepValue<SearchServicePrivateLinkServiceConnectionStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<SearchServicePrivateLinkServiceConnectionStatus> _status;

    /// <summary>
    /// The description for the private link service connection state.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// A description of any extra actions that may be required.
    /// </summary>
    public BicepValue<string> ActionsRequired { get => _actionsRequired; set => _actionsRequired.Assign(value); }
    private readonly BicepValue<string> _actionsRequired;

    /// <summary>
    /// Creates a new SearchServicePrivateLinkServiceConnectionState.
    /// </summary>
    public SearchServicePrivateLinkServiceConnectionState()
    {
        _status = BicepValue<SearchServicePrivateLinkServiceConnectionStatus>.DefineProperty(this, "Status", ["status"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _actionsRequired = BicepValue<string>.DefineProperty(this, "ActionsRequired", ["actionsRequired"]);
    }
}
