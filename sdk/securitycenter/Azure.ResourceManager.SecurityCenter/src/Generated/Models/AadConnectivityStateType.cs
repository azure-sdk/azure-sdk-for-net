// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The connectivity state of the external AAD solution. </summary>
    public readonly partial struct AadConnectivityStateType : IEquatable<AadConnectivityStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AadConnectivityStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AadConnectivityStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DiscoveredValue = "Discovered";
        private const string NotLicensedValue = "NotLicensed";
        private const string ConnectedValue = "Connected";

        /// <summary> Discovered. </summary>
        public static AadConnectivityStateType Discovered { get; } = new AadConnectivityStateType(DiscoveredValue);
        /// <summary> NotLicensed. </summary>
        public static AadConnectivityStateType NotLicensed { get; } = new AadConnectivityStateType(NotLicensedValue);
        /// <summary> Connected. </summary>
        public static AadConnectivityStateType Connected { get; } = new AadConnectivityStateType(ConnectedValue);
        /// <summary> Determines if two <see cref="AadConnectivityStateType"/> values are the same. </summary>
        public static bool operator ==(AadConnectivityStateType left, AadConnectivityStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AadConnectivityStateType"/> values are not the same. </summary>
        public static bool operator !=(AadConnectivityStateType left, AadConnectivityStateType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AadConnectivityStateType"/>. </summary>
        public static implicit operator AadConnectivityStateType(string value) => new AadConnectivityStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AadConnectivityStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AadConnectivityStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
