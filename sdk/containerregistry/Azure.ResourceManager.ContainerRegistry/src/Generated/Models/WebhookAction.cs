// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The WebhookAction. </summary>
    public readonly partial struct WebhookAction : IEquatable<WebhookAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebhookAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebhookAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PushValue = "push";
        private const string DeleteValue = "delete";
        private const string QuarantineValue = "quarantine";
        private const string ChartPushValue = "chart_push";
        private const string ChartDeleteValue = "chart_delete";

        /// <summary> push. </summary>
        public static WebhookAction Push { get; } = new WebhookAction(PushValue);
        /// <summary> delete. </summary>
        public static WebhookAction Delete { get; } = new WebhookAction(DeleteValue);
        /// <summary> quarantine. </summary>
        public static WebhookAction Quarantine { get; } = new WebhookAction(QuarantineValue);
        /// <summary> chart_push. </summary>
        public static WebhookAction ChartPush { get; } = new WebhookAction(ChartPushValue);
        /// <summary> chart_delete. </summary>
        public static WebhookAction ChartDelete { get; } = new WebhookAction(ChartDeleteValue);
        /// <summary> Determines if two <see cref="WebhookAction"/> values are the same. </summary>
        public static bool operator ==(WebhookAction left, WebhookAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebhookAction"/> values are not the same. </summary>
        public static bool operator !=(WebhookAction left, WebhookAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebhookAction"/>. </summary>
        public static implicit operator WebhookAction(string value) => new WebhookAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebhookAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebhookAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
