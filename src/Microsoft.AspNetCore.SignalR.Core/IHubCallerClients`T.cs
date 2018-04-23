// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR
{
    /// <summary>
    /// A clients caller abstraction for a hub.
    /// </summary>
    /// <typeparam name="T">The client caller type.</typeparam>
    public interface IHubCallerClients<T> : IHubClients<T>
    {
        /// <summary>
        /// Gets a caller to the current caller connection.
        /// </summary>
        T Caller { get; }

        /// <summary>
        /// Gets a caller to connections other than the current caller.
        /// </summary>
        T Others { get; }

        /// <summary>
        /// Gets a caller to connections in a group other than the current caller.
        /// </summary>
        /// <returns>A client caller.</returns>
        T OthersInGroup(string groupName);
    }
}
