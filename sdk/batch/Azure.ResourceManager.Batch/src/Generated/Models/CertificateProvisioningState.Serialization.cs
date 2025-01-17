// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class CertificateProvisioningStateExtensions
    {
        public static string ToSerialString(this CertificateProvisioningState value) => value switch
        {
            CertificateProvisioningState.Succeeded => "Succeeded",
            CertificateProvisioningState.Deleting => "Deleting",
            CertificateProvisioningState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateProvisioningState value.")
        };

        public static CertificateProvisioningState ToCertificateProvisioningState(this string value)
        {
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return CertificateProvisioningState.Succeeded;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return CertificateProvisioningState.Deleting;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return CertificateProvisioningState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateProvisioningState value.");
        }
    }
}
