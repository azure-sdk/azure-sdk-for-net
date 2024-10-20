// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NamespaceTopic.
/// </summary>
public partial class NamespaceTopic : ProvisionableResource
{
    /// <summary>
    /// Name of the namespace topic.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Event retention for the namespace topic expressed in days. The property
    /// default value is 1 day.             Min event retention duration value
    /// is 1 day and max event retention duration value is 1 day.
    /// </summary>
    public BicepValue<int> EventRetentionInDays { get => _eventRetentionInDays; set => _eventRetentionInDays.Assign(value); }
    private readonly BicepValue<int> _eventRetentionInDays;

    /// <summary>
    /// This determines the format that is expected for incoming events
    /// published to the topic.
    /// </summary>
    public BicepValue<EventInputSchema> InputSchema { get => _inputSchema; set => _inputSchema.Assign(value); }
    private readonly BicepValue<EventInputSchema> _inputSchema;

    /// <summary>
    /// Publisher type of the namespace topic.
    /// </summary>
    public BicepValue<PublisherType> PublisherType { get => _publisherType; set => _publisherType.Assign(value); }
    private readonly BicepValue<PublisherType> _publisherType;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the namespace topic.
    /// </summary>
    public BicepValue<NamespaceTopicProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<NamespaceTopicProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridNamespace.
    /// </summary>
    public EventGridNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventGridNamespace> _parent;

    /// <summary>
    /// Creates a new NamespaceTopic.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the NamespaceTopic resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the NamespaceTopic.</param>
    public NamespaceTopic(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/namespaces/topics", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _eventRetentionInDays = BicepValue<int>.DefineProperty(this, "EventRetentionInDays", ["properties", "eventRetentionInDays"]);
        _inputSchema = BicepValue<EventInputSchema>.DefineProperty(this, "InputSchema", ["properties", "inputSchema"]);
        _publisherType = BicepValue<PublisherType>.DefineProperty(this, "PublisherType", ["properties", "publisherType"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<NamespaceTopicProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventGridNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing NamespaceTopic.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the NamespaceTopic resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the NamespaceTopic.</param>
    /// <returns>The existing NamespaceTopic resource.</returns>
    public static NamespaceTopic FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
