// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct DesktopVirtualizationPrivateEndpointConnectionProvisioningState : IEquatable<DesktopVirtualizationPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DesktopVirtualizationPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DesktopVirtualizationPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static DesktopVirtualizationPrivateEndpointConnectionProvisioningState Succeeded { get; } = new DesktopVirtualizationPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static DesktopVirtualizationPrivateEndpointConnectionProvisioningState Creating { get; } = new DesktopVirtualizationPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static DesktopVirtualizationPrivateEndpointConnectionProvisioningState Deleting { get; } = new DesktopVirtualizationPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static DesktopVirtualizationPrivateEndpointConnectionProvisioningState Failed { get; } = new DesktopVirtualizationPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="DesktopVirtualizationPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DesktopVirtualizationPrivateEndpointConnectionProvisioningState left, DesktopVirtualizationPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DesktopVirtualizationPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DesktopVirtualizationPrivateEndpointConnectionProvisioningState left, DesktopVirtualizationPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DesktopVirtualizationPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator DesktopVirtualizationPrivateEndpointConnectionProvisioningState(string value) => new DesktopVirtualizationPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DesktopVirtualizationPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DesktopVirtualizationPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
