// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR.Internal;

namespace Microsoft.AspNetCore.SignalR
{
    public class DynamicHubClients
    {
        private readonly IHubCallerClients _clients;

        public DynamicHubClients(IHubCallerClients clients)
        {
            _clients = clients;
        }

        /// <summary>
        /// Gets a caller to all hub clients.
        /// </summary>
        /// <returns>A client caller.</returns>
        public dynamic All => new DynamicClientProxy(_clients.All);

        /// <summary>
        /// Gets a caller to all hub clients excluding the specified client connections.
        /// </summary>
        /// <param name="excludedConnectionIds">A collection of connection IDs to exclude.</param>
        /// <returns>A client caller.</returns>
        public dynamic AllExcept(IReadOnlyList<string> excludedConnectionIds) => new DynamicClientProxy(_clients.AllExcept(excludedConnectionIds));

        /// <summary>
        /// Gets a caller to the current caller connection.
        /// </summary>
        public dynamic Caller => new DynamicClientProxy(_clients.Caller);

        /// <summary>
        /// Gets a caller to the specified client connection.
        /// </summary>
        /// <param name="connectionId">The connection ID.</param>
        /// <returns>A client caller.</returns>
        public dynamic Client(string connectionId) => new DynamicClientProxy(_clients.Client(connectionId));

        /// <summary>
        /// Gets a caller to the specified client connections.
        /// </summary>
        /// <param name="connectionIds">The connection IDs.</param>
        /// <returns>A client caller.</returns>
        public dynamic Clients(IReadOnlyList<string> connectionIds) => new DynamicClientProxy(_clients.Clients(connectionIds));

        /// <summary>
        /// Gets a caller to the specified group.
        /// </summary>
        /// <param name="groupName">The group name.</param>
        /// <returns>A client caller.</returns>
        public dynamic Group(string groupName) => new DynamicClientProxy(_clients.Group(groupName));

        /// <summary>
        /// Gets a caller to the specified groups.
        /// </summary>
        /// <param name="groupNames">The group names.</param>
        /// <returns>A client caller.</returns>
        public dynamic Groups(IReadOnlyList<string> groupNames) => new DynamicClientProxy(_clients.Groups(groupNames));

        /// <summary>
        /// Gets a caller to the specified group excluding the specified client connections.
        /// </summary>
        /// <param name="groupName">The group name.</param>
        /// <param name="excludedConnectionIds">A collection of connection IDs to exclude.</param>
        /// <returns>A client caller.</returns>
        public dynamic GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds) => new DynamicClientProxy(_clients.GroupExcept(groupName, excludedConnectionIds));

        /// <summary>
        /// Gets a caller to connections in a group other than the current caller.
        /// </summary>
        /// <returns>A client caller.</returns>
        public dynamic OthersInGroup(string groupName) => new DynamicClientProxy(_clients.OthersInGroup(groupName));

        /// <summary>
        /// Gets a caller to connections other than the current caller.
        /// </summary>
        public dynamic Others => new DynamicClientProxy(_clients.Others);

        /// <summary>
        /// Gets a caller to the specified user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A client caller.</returns>
        public dynamic User(string userId) => new DynamicClientProxy(_clients.User(userId));

        /// <summary>
        /// Gets a caller to the specified users.
        /// </summary>
        /// <param name="users">The user IDs.</param>
        /// <returns>A client caller.</returns>
        public dynamic Users(IReadOnlyList<string> users) => new DynamicClientProxy(_clients.Users(users));
    }
}