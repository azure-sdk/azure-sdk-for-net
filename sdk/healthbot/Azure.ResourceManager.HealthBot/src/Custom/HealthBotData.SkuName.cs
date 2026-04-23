// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.ResourceManager.HealthBot.Models;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.HealthBot
{
    public partial class HealthBotData
    {
        /// <summary> The name of the Azure Health Bot SKU. </summary>
        [CodeGenMember("SkuName")]
        public HealthBotSkuName? SkuName
        {
            get => Sku?.Name;
            set
            {
                if (value.HasValue)
                {
                    Sku = new HealthBotSku(value.Value);
                }
                else
                {
                    Sku = null;
                }
            }
        }
    }
}
