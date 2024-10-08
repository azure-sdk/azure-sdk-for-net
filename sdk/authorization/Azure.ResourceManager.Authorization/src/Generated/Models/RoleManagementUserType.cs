// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The type of user. </summary>
    public readonly partial struct RoleManagementUserType : IEquatable<RoleManagementUserType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleManagementUserType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleManagementUserType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string GroupValue = "Group";

        /// <summary> User. </summary>
        public static RoleManagementUserType User { get; } = new RoleManagementUserType(UserValue);
        /// <summary> Group. </summary>
        public static RoleManagementUserType Group { get; } = new RoleManagementUserType(GroupValue);
        /// <summary> Determines if two <see cref="RoleManagementUserType"/> values are the same. </summary>
        public static bool operator ==(RoleManagementUserType left, RoleManagementUserType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleManagementUserType"/> values are not the same. </summary>
        public static bool operator !=(RoleManagementUserType left, RoleManagementUserType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RoleManagementUserType"/>. </summary>
        public static implicit operator RoleManagementUserType(string value) => new RoleManagementUserType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleManagementUserType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleManagementUserType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
