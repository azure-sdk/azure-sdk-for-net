// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting
{
    /// <summary> Metric unit. </summary>
    public readonly partial struct MetricUnit : IEquatable<MetricUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string PercentValue = "Percent";
        private const string CountValue = "Count";
        private const string SecondsValue = "Seconds";
        private const string MillisecondsValue = "Milliseconds";
        private const string BytesValue = "Bytes";
        private const string BytesPerSecondValue = "BytesPerSecond";
        private const string CountPerSecondValue = "CountPerSecond";

        /// <summary> No unit specified. </summary>
        public static MetricUnit NotSpecified { get; } = new MetricUnit(NotSpecifiedValue);
        /// <summary> Percentage. </summary>
        public static MetricUnit Percent { get; } = new MetricUnit(PercentValue);
        /// <summary> Value count. </summary>
        public static MetricUnit Count { get; } = new MetricUnit(CountValue);
        /// <summary> Seconds. </summary>
        public static MetricUnit Seconds { get; } = new MetricUnit(SecondsValue);
        /// <summary> Milliseconds. </summary>
        public static MetricUnit Milliseconds { get; } = new MetricUnit(MillisecondsValue);
        /// <summary> Bytes. </summary>
        public static MetricUnit Bytes { get; } = new MetricUnit(BytesValue);
        /// <summary> Bytes per second. </summary>
        public static MetricUnit BytesPerSecond { get; } = new MetricUnit(BytesPerSecondValue);
        /// <summary> Count per second. </summary>
        public static MetricUnit CountPerSecond { get; } = new MetricUnit(CountPerSecondValue);
        /// <summary> Determines if two <see cref="MetricUnit"/> values are the same. </summary>
        public static bool operator ==(MetricUnit left, MetricUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricUnit"/> values are not the same. </summary>
        public static bool operator !=(MetricUnit left, MetricUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MetricUnit"/>. </summary>
        public static implicit operator MetricUnit(string value) => new MetricUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
