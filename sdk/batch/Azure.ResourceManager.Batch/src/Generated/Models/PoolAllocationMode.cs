// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The allocation mode for creating pools in the Batch account. </summary>
    public enum PoolAllocationMode
    {
        /// <summary> Pools will be allocated in subscriptions owned by the Batch service. </summary>
        BatchService,
        /// <summary> Pools will be allocated in a subscription owned by the user. </summary>
        UserSubscription
    }
}
