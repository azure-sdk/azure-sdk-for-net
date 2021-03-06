// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The expression root.
    /// </summary>
    public partial class ExpressionRoot : Expression
    {
        /// <summary>
        /// Initializes a new instance of the ExpressionRoot class.
        /// </summary>
        public ExpressionRoot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressionRoot class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="subexpressions">The sub expressions.</param>
        /// <param name="path">The path.</param>
        public ExpressionRoot(string text = default(string), object value = default(object), IList<Expression> subexpressions = default(IList<Expression>), AzureResourceErrorInfo error = default(AzureResourceErrorInfo), string path = default(string))
            : base(text, value, subexpressions, error)
        {
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
