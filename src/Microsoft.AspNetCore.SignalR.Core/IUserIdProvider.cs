// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR
{
    /// <summary>
    /// A provider abstraction for getting the user ID from a <see cref="HubConnectionContext"/>.
    /// </summary>
    public interface IUserIdProvider
    {
        /// <summary>
        /// Gets the user ID from the specified connection.
        /// </summary>
        /// <param name="connection">The connection get get the user ID from.</param>
        /// <returns>The user ID from the specified connection.</returns>
        string GetUserId(HubConnectionContext connection);
    }
}