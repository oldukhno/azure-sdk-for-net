// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The HDInsightRoleName.
    /// Serialized Name: RoleName
    /// </summary>
    public readonly partial struct HDInsightRoleName : IEquatable<HDInsightRoleName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightRoleName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightRoleName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WorkernodeValue = "workernode";

        /// <summary>
        /// workernode
        /// Serialized Name: RoleName.workernode
        /// </summary>
        public static HDInsightRoleName Workernode { get; } = new HDInsightRoleName(WorkernodeValue);
        /// <summary> Determines if two <see cref="HDInsightRoleName"/> values are the same. </summary>
        public static bool operator ==(HDInsightRoleName left, HDInsightRoleName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightRoleName"/> values are not the same. </summary>
        public static bool operator !=(HDInsightRoleName left, HDInsightRoleName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightRoleName"/>. </summary>
        public static implicit operator HDInsightRoleName(string value) => new HDInsightRoleName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightRoleName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightRoleName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
