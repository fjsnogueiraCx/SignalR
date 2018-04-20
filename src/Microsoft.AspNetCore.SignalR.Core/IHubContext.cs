// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR
{
    /// <summary>
    /// A context abstraction for a hub.
    /// </summary>
    public interface IHubContext<THub> where THub : Hub
    {
        /// <summary>
        /// Gets the clients for the hub.
        /// </summary>
        IHubClients Clients { get; }

        /// <summary>
        /// Gets the group manager for the hub.
        /// </summary>
        IGroupManager Groups { get; }
    }
}
