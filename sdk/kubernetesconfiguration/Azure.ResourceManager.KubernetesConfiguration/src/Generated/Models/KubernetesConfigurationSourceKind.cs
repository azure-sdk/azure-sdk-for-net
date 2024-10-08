// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Source Kind to pull the configuration data from. </summary>
    public readonly partial struct KubernetesConfigurationSourceKind : IEquatable<KubernetesConfigurationSourceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesConfigurationSourceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesConfigurationSourceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GitRepositoryValue = "GitRepository";
        private const string BucketValue = "Bucket";
        private const string AzureBlobValue = "AzureBlob";

        /// <summary> GitRepository. </summary>
        public static KubernetesConfigurationSourceKind GitRepository { get; } = new KubernetesConfigurationSourceKind(GitRepositoryValue);
        /// <summary> Bucket. </summary>
        public static KubernetesConfigurationSourceKind Bucket { get; } = new KubernetesConfigurationSourceKind(BucketValue);
        /// <summary> AzureBlob. </summary>
        public static KubernetesConfigurationSourceKind AzureBlob { get; } = new KubernetesConfigurationSourceKind(AzureBlobValue);
        /// <summary> Determines if two <see cref="KubernetesConfigurationSourceKind"/> values are the same. </summary>
        public static bool operator ==(KubernetesConfigurationSourceKind left, KubernetesConfigurationSourceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesConfigurationSourceKind"/> values are not the same. </summary>
        public static bool operator !=(KubernetesConfigurationSourceKind left, KubernetesConfigurationSourceKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KubernetesConfigurationSourceKind"/>. </summary>
        public static implicit operator KubernetesConfigurationSourceKind(string value) => new KubernetesConfigurationSourceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesConfigurationSourceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesConfigurationSourceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
