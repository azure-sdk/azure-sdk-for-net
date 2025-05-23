// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The IsDeviceMatchConditionMatchValue.
    /// Serialized Name: IsDeviceMatchValue
    /// </summary>
    public readonly partial struct IsDeviceMatchConditionMatchValue : IEquatable<IsDeviceMatchConditionMatchValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsDeviceMatchConditionMatchValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsDeviceMatchConditionMatchValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MobileValue = "Mobile";
        private const string DesktopValue = "Desktop";

        /// <summary>
        /// Mobile
        /// Serialized Name: IsDeviceMatchValue.Mobile
        /// </summary>
        public static IsDeviceMatchConditionMatchValue Mobile { get; } = new IsDeviceMatchConditionMatchValue(MobileValue);
        /// <summary>
        /// Desktop
        /// Serialized Name: IsDeviceMatchValue.Desktop
        /// </summary>
        public static IsDeviceMatchConditionMatchValue Desktop { get; } = new IsDeviceMatchConditionMatchValue(DesktopValue);
        /// <summary> Determines if two <see cref="IsDeviceMatchConditionMatchValue"/> values are the same. </summary>
        public static bool operator ==(IsDeviceMatchConditionMatchValue left, IsDeviceMatchConditionMatchValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsDeviceMatchConditionMatchValue"/> values are not the same. </summary>
        public static bool operator !=(IsDeviceMatchConditionMatchValue left, IsDeviceMatchConditionMatchValue right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IsDeviceMatchConditionMatchValue"/>. </summary>
        public static implicit operator IsDeviceMatchConditionMatchValue(string value) => new IsDeviceMatchConditionMatchValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsDeviceMatchConditionMatchValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsDeviceMatchConditionMatchValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
