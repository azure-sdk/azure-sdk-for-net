// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Rendering
{
    /// <summary> The TrafficTilesetId. </summary>
    public readonly partial struct TrafficTilesetId : IEquatable<TrafficTilesetId>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrafficTilesetId"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrafficTilesetId(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftTrafficRelativeMainValue = "microsoft.traffic.relative.main";
        private const string NoneValue = "none";

        /// <summary> Supported traffic related tilesetId. </summary>
        public static TrafficTilesetId MicrosoftTrafficRelativeMain { get; } = new TrafficTilesetId(MicrosoftTrafficRelativeMainValue);
        /// <summary> Default value, no traffic flow overlay. </summary>
        public static TrafficTilesetId None { get; } = new TrafficTilesetId(NoneValue);
        /// <summary> Determines if two <see cref="TrafficTilesetId"/> values are the same. </summary>
        public static bool operator ==(TrafficTilesetId left, TrafficTilesetId right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrafficTilesetId"/> values are not the same. </summary>
        public static bool operator !=(TrafficTilesetId left, TrafficTilesetId right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrafficTilesetId"/>. </summary>
        public static implicit operator TrafficTilesetId(string value) => new TrafficTilesetId(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrafficTilesetId other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrafficTilesetId other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
