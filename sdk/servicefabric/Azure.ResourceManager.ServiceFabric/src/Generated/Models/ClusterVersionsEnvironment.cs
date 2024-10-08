// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The ClusterVersionsEnvironment. </summary>
    public readonly partial struct ClusterVersionsEnvironment : IEquatable<ClusterVersionsEnvironment>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterVersionsEnvironment"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterVersionsEnvironment(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";

        /// <summary> Windows. </summary>
        public static ClusterVersionsEnvironment Windows { get; } = new ClusterVersionsEnvironment(WindowsValue);
        /// <summary> Linux. </summary>
        public static ClusterVersionsEnvironment Linux { get; } = new ClusterVersionsEnvironment(LinuxValue);
        /// <summary> Determines if two <see cref="ClusterVersionsEnvironment"/> values are the same. </summary>
        public static bool operator ==(ClusterVersionsEnvironment left, ClusterVersionsEnvironment right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterVersionsEnvironment"/> values are not the same. </summary>
        public static bool operator !=(ClusterVersionsEnvironment left, ClusterVersionsEnvironment right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterVersionsEnvironment"/>. </summary>
        public static implicit operator ClusterVersionsEnvironment(string value) => new ClusterVersionsEnvironment(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterVersionsEnvironment other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterVersionsEnvironment other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
