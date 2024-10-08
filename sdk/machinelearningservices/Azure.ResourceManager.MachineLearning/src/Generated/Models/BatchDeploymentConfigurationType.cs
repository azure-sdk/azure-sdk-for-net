// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The enumerated property types for batch deployments. </summary>
    internal readonly partial struct BatchDeploymentConfigurationType : IEquatable<BatchDeploymentConfigurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchDeploymentConfigurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchDeploymentConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ModelValue = "Model";
        private const string PipelineComponentValue = "PipelineComponent";

        /// <summary> Model. </summary>
        public static BatchDeploymentConfigurationType Model { get; } = new BatchDeploymentConfigurationType(ModelValue);
        /// <summary> PipelineComponent. </summary>
        public static BatchDeploymentConfigurationType PipelineComponent { get; } = new BatchDeploymentConfigurationType(PipelineComponentValue);
        /// <summary> Determines if two <see cref="BatchDeploymentConfigurationType"/> values are the same. </summary>
        public static bool operator ==(BatchDeploymentConfigurationType left, BatchDeploymentConfigurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchDeploymentConfigurationType"/> values are not the same. </summary>
        public static bool operator !=(BatchDeploymentConfigurationType left, BatchDeploymentConfigurationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchDeploymentConfigurationType"/>. </summary>
        public static implicit operator BatchDeploymentConfigurationType(string value) => new BatchDeploymentConfigurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchDeploymentConfigurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchDeploymentConfigurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
