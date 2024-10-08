// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Resource Health Status. </summary>
    public readonly partial struct ResourceHealthStatus : IEquatable<ResourceHealthStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceHealthStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HealthyValue = "Healthy";
        private const string TransientDegradedValue = "TransientDegraded";
        private const string PersistentDegradedValue = "PersistentDegraded";
        private const string TransientUnhealthyValue = "TransientUnhealthy";
        private const string PersistentUnhealthyValue = "PersistentUnhealthy";
        private const string InvalidValue = "Invalid";

        /// <summary> Healthy. </summary>
        public static ResourceHealthStatus Healthy { get; } = new ResourceHealthStatus(HealthyValue);
        /// <summary> TransientDegraded. </summary>
        public static ResourceHealthStatus TransientDegraded { get; } = new ResourceHealthStatus(TransientDegradedValue);
        /// <summary> PersistentDegraded. </summary>
        public static ResourceHealthStatus PersistentDegraded { get; } = new ResourceHealthStatus(PersistentDegradedValue);
        /// <summary> TransientUnhealthy. </summary>
        public static ResourceHealthStatus TransientUnhealthy { get; } = new ResourceHealthStatus(TransientUnhealthyValue);
        /// <summary> PersistentUnhealthy. </summary>
        public static ResourceHealthStatus PersistentUnhealthy { get; } = new ResourceHealthStatus(PersistentUnhealthyValue);
        /// <summary> Invalid. </summary>
        public static ResourceHealthStatus Invalid { get; } = new ResourceHealthStatus(InvalidValue);
        /// <summary> Determines if two <see cref="ResourceHealthStatus"/> values are the same. </summary>
        public static bool operator ==(ResourceHealthStatus left, ResourceHealthStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceHealthStatus"/> values are not the same. </summary>
        public static bool operator !=(ResourceHealthStatus left, ResourceHealthStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceHealthStatus"/>. </summary>
        public static implicit operator ResourceHealthStatus(string value) => new ResourceHealthStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceHealthStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceHealthStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
