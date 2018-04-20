// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR
{
    /// <summary>
    /// A clients caller abstraction for a hub.
    /// </summary>
    /// <typeparam name="T">The client caller type.</typeparam>
    public interface IHubClients<T>
    {
        /// <summary>
        /// Gets a caller to all hub clients.
        /// </summary>
        /// <returns>A client caller.</returns>
        T All { get; }

        /// <summary>
        /// Gets a caller to all hub clients excluding the specified client connections.
        /// </summary>
        /// <param name="excludedConnectionIds">A collection of connection IDs to exclude.</param>
        /// <returns>A client caller.</returns>
        T AllExcept(IReadOnlyList<string> excludedConnectionIds);

        /// <summary>
        /// Gets a caller to the specified client connection.
        /// </summary>
        /// <param name="connectionId">The connection ID.</param>
        /// <returns>A client caller.</returns>
        T Client(string connectionId);

        /// <summary>
        /// Gets a caller to the specified client connections.
        /// </summary>
        /// <param name="connectionIds">The connection IDs.</param>
        /// <returns>A client caller.</returns>
        T Clients(IReadOnlyList<string> connectionIds);

        /// <summary>
        /// Gets a caller to the specified group.
        /// </summary>
        /// <param name="groupName">The group name.</param>
        /// <returns>A client caller.</returns>
        T Group(string groupName);

        /// <summary>
        /// Gets a caller to the specified groups.
        /// </summary>
        /// <param name="groupNames">The group names.</param>
        /// <returns>A client caller.</returns>
        T Groups(IReadOnlyList<string> groupNames);

        /// <summary>
        /// Gets a caller to the specified group excluding the specified client connections.
        /// </summary>
        /// <param name="groupName">The group name.</param>
        /// <param name="excludedConnectionIds">A collection of connection IDs to exclude.</param>
        /// <returns>A client caller.</returns>
        T GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds);

        /// <summary>
        /// Gets a caller to the specified user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A client caller.</returns>
        T User(string userId);

        /// <summary>
        /// Gets a caller to the specified users.
        /// </summary>
        /// <param name="userIds">The user IDs.</param>
        /// <returns>A client caller.</returns>
        T Users(IReadOnlyList<string> userIds);
    }
}

