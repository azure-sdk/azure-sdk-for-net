// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Describes a managed rule set definition.
    /// Serialized Name: ManagedRuleSetDefinition
    /// </summary>
    public partial class ManagedRuleSetDefinition : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSetDefinition"/>. </summary>
        public ManagedRuleSetDefinition()
        {
            RuleGroups = new ChangeTrackingList<ManagedRuleGroupDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSetDefinition"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku">
        /// The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
        /// Serialized Name: ManagedRuleSetDefinition.sku
        /// </param>
        /// <param name="provisioningState">
        /// Provisioning state of the managed rule set.
        /// Serialized Name: ManagedRuleSetDefinition.properties.provisioningState
        /// </param>
        /// <param name="ruleSetType">
        /// Type of the managed rule set.
        /// Serialized Name: ManagedRuleSetDefinition.properties.ruleSetType
        /// </param>
        /// <param name="ruleSetVersion">
        /// Version of the managed rule set type.
        /// Serialized Name: ManagedRuleSetDefinition.properties.ruleSetVersion
        /// </param>
        /// <param name="ruleGroups">
        /// Rule groups of the managed rule set.
        /// Serialized Name: ManagedRuleSetDefinition.properties.ruleGroups
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleSetDefinition(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CdnSku sku, string provisioningState, string ruleSetType, string ruleSetVersion, IReadOnlyList<ManagedRuleGroupDefinition> ruleGroups, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
        /// Serialized Name: ManagedRuleSetDefinition.sku
        /// </summary>
        internal CdnSku Sku { get; set; }
        /// <summary>
        /// Name of the pricing tier.
        /// Serialized Name: Sku.name
        /// </summary>
        public CdnSkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new CdnSku();
                Sku.Name = value;
            }
        }

        /// <summary>
        /// Provisioning state of the managed rule set.
        /// Serialized Name: ManagedRuleSetDefinition.properties.provisioningState
        /// </summary>
        public string ProvisioningState { get; }
        /// <summary>
        /// Type of the managed rule set.
        /// Serialized Name: ManagedRuleSetDefinition.properties.ruleSetType
        /// </summary>
        public string RuleSetType { get; }
        /// <summary>
        /// Version of the managed rule set type.
        /// Serialized Name: ManagedRuleSetDefinition.properties.ruleSetVersion
        /// </summary>
        public string RuleSetVersion { get; }
        /// <summary>
        /// Rule groups of the managed rule set.
        /// Serialized Name: ManagedRuleSetDefinition.properties.ruleGroups
        /// </summary>
        public IReadOnlyList<ManagedRuleGroupDefinition> RuleGroups { get; }
    }
}
