// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A Class representing a NamespaceWcfRelayAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NamespaceWcfRelayAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNamespaceWcfRelayAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="WcfRelayResource" /> using the GetNamespaceWcfRelayAuthorizationRule method.
    /// </summary>
    public partial class NamespaceWcfRelayAuthorizationRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NamespaceWcfRelayAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics;
        private readonly WCFRelaysRestOperations _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient;
        private readonly AuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="NamespaceWcfRelayAuthorizationRuleResource"/> class for mocking. </summary>
        protected NamespaceWcfRelayAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NamespaceWcfRelayAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NamespaceWcfRelayAuthorizationRuleResource(ArmClient client, AuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceWcfRelayAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NamespaceWcfRelayAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string namespaceWcfRelayAuthorizationRuleWCFRelaysApiVersion);
            _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient = new WCFRelaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, namespaceWcfRelayAuthorizationRuleWCFRelaysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Relay/namespaces/wcfRelays/authorizationRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AuthorizationRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get authorizationRule for a WCF relay by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: WCFRelays_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NamespaceWcfRelayAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceWcfRelayAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get authorizationRule for a WCF relay by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: WCFRelays_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NamespaceWcfRelayAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceWcfRelayAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a WCF relay authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: WCFRelays_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.DeleteAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a WCF relay authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: WCFRelays_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.DeleteAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RelayArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an authorization rule for a WCF relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: WCFRelays_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NamespaceWcfRelayAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, AuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation<NamespaceWcfRelayAuthorizationRuleResource>(Response.FromValue(new NamespaceWcfRelayAuthorizationRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an authorization rule for a WCF relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: WCFRelays_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NamespaceWcfRelayAuthorizationRuleResource> Update(WaitUntil waitUntil, AuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new RelayArmOperation<NamespaceWcfRelayAuthorizationRuleResource>(Response.FromValue(new NamespaceWcfRelayAuthorizationRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Primary and secondary connection strings to the WCF relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: WCFRelays_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Primary and secondary connection strings to the WCF relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: WCFRelays_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings to the WCF relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: WCFRelays_RegenerateKeys
        /// </summary>
        /// <param name="regenerateAccessKeyParameters"> Parameters supplied to regenerate authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regenerateAccessKeyParameters"/> is null. </exception>
        public virtual async Task<Response<AccessKeys>> RegenerateKeysAsync(RegenerateAccessKeyParameters regenerateAccessKeyParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(regenerateAccessKeyParameters, nameof(regenerateAccessKeyParameters));

            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, regenerateAccessKeyParameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings to the WCF relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: WCFRelays_RegenerateKeys
        /// </summary>
        /// <param name="regenerateAccessKeyParameters"> Parameters supplied to regenerate authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regenerateAccessKeyParameters"/> is null. </exception>
        public virtual Response<AccessKeys> RegenerateKeys(RegenerateAccessKeyParameters regenerateAccessKeyParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(regenerateAccessKeyParameters, nameof(regenerateAccessKeyParameters));

            using var scope = _namespaceWcfRelayAuthorizationRuleWCFRelaysClientDiagnostics.CreateScope("NamespaceWcfRelayAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _namespaceWcfRelayAuthorizationRuleWCFRelaysRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, regenerateAccessKeyParameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
