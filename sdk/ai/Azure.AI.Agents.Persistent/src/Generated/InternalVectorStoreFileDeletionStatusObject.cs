// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The InternalVectorStoreFileDeletionStatusObject. </summary>
    internal readonly partial struct InternalVectorStoreFileDeletionStatusObject : IEquatable<InternalVectorStoreFileDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalVectorStoreFileDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalVectorStoreFileDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VectorStoreFileDeletedValue = "vector_store.file.deleted";

        /// <summary> vector_store.file.deleted. </summary>
        public static InternalVectorStoreFileDeletionStatusObject VectorStoreFileDeleted { get; } = new InternalVectorStoreFileDeletionStatusObject(VectorStoreFileDeletedValue);
        /// <summary> Determines if two <see cref="InternalVectorStoreFileDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(InternalVectorStoreFileDeletionStatusObject left, InternalVectorStoreFileDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalVectorStoreFileDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(InternalVectorStoreFileDeletionStatusObject left, InternalVectorStoreFileDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InternalVectorStoreFileDeletionStatusObject"/>. </summary>
        public static implicit operator InternalVectorStoreFileDeletionStatusObject(string value) => new InternalVectorStoreFileDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalVectorStoreFileDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalVectorStoreFileDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
