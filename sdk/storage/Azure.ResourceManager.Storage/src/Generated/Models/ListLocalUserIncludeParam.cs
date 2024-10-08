// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The ListLocalUserIncludeParam. </summary>
    public readonly partial struct ListLocalUserIncludeParam : IEquatable<ListLocalUserIncludeParam>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListLocalUserIncludeParam"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListLocalUserIncludeParam(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Nfsv3Value = "nfsv3";

        /// <summary> nfsv3. </summary>
        public static ListLocalUserIncludeParam Nfsv3 { get; } = new ListLocalUserIncludeParam(Nfsv3Value);
        /// <summary> Determines if two <see cref="ListLocalUserIncludeParam"/> values are the same. </summary>
        public static bool operator ==(ListLocalUserIncludeParam left, ListLocalUserIncludeParam right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListLocalUserIncludeParam"/> values are not the same. </summary>
        public static bool operator !=(ListLocalUserIncludeParam left, ListLocalUserIncludeParam right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ListLocalUserIncludeParam"/>. </summary>
        public static implicit operator ListLocalUserIncludeParam(string value) => new ListLocalUserIncludeParam(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListLocalUserIncludeParam other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListLocalUserIncludeParam other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
