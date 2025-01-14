// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin. </summary>
    internal partial class SharedPrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of SharedPrivateLinkResourceProperties. </summary>
        internal SharedPrivateLinkResourceProperties()
        {
        }

        /// <summary> The resource id of the resource the shared private link resource is for. </summary>
        internal WritableSubResource PrivateLink { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateLinkId
        {
            get => PrivateLink.Id;
            set => PrivateLink.Id = value;
        }

        /// <summary> The location of the shared private link resource. </summary>
        public string PrivateLinkLocation { get; }
        /// <summary> The group id from the provider of resource the shared private link resource is for. </summary>
        public string GroupId { get; }
        /// <summary> The request message for requesting approval of the shared private link resource. </summary>
        public string RequestMessage { get; }
        /// <summary> Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout. </summary>
        public SharedPrivateLinkResourceStatus? Status { get; }
    }
}
