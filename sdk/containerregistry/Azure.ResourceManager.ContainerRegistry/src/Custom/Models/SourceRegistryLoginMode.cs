// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The authentication mode which determines the source registry login scope. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This type is no longer supported.")]
    public readonly partial struct SourceRegistryLoginMode : IEquatable<SourceRegistryLoginMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceRegistryLoginMode"/>. </summary>
        public SourceRegistryLoginMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <inheritdoc />
        public bool Equals(SourceRegistryLoginMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        /// <inheritdoc />
        public override bool Equals(object obj) => obj is SourceRegistryLoginMode other && Equals(other);
        /// <inheritdoc />
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
