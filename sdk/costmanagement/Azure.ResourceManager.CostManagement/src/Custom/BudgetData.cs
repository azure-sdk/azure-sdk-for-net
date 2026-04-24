// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.CostManagement.Models;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.CostManagement
{
    public partial class BudgetData
    {
        /// <summary>
        /// The category of the budget.
        /// <list type="bullet"><item><description>'Cost' defines a Budget.</description></item><item><description>'ReservationUtilization' defines a Reservation Utilization Alert Rule.</description></item></list>
        /// </summary>
        [CodeGenMember("Category")]
        public CategoryType Category
        {
            get => Properties is null ? default : Properties.Category;
            set
            {
                if (Properties is null)
                {
                    Properties = new BudgetProperties();
                }
                Properties.Category = value;
            }
        }

        /// <summary>
        /// The time covered by a budget. Tracking of the amount will be reset based on the time grain.
        /// </summary>
        [CodeGenMember("TimeGrain")]
        public TimeGrainType TimeGrain
        {
            get => Properties is null ? default : Properties.TimeGrain;
            set
            {
                if (Properties is null)
                {
                    Properties = new BudgetProperties();
                }
                Properties.TimeGrain = value;
            }
        }
    }
}
