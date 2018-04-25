// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections.Features;

namespace Microsoft.AspNetCore.SignalR
{
    /// <summary>
    /// Extension methods for accessing <see cref="HttpContext"/> from a hub context.
    /// </summary>
    public static class GetHttpContextExtensions
    {
        /// <summary>
        /// Gets <see cref="HttpContext"/> from the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <returns>The connection's <see cref="HttpContext"/>.</returns>
        public static HttpContext GetHttpContext(this HubCallerContext connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            return connection.Features.Get<IHttpContextFeature>()?.HttpContext;
        }

        /// <summary>
        /// Gets <see cref="HttpContext"/> from the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <returns>The connection's <see cref="HttpContext"/>.</returns>
        public static HttpContext GetHttpContext(this HubConnectionContext connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            return connection.Features.Get<IHttpContextFeature>()?.HttpContext;
        }
    }
}
