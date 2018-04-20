// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Internal;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up SignalR services in an <see cref="IServiceCollection" />.
    /// </summary>
    public static class SignalRDependencyInjectionExtensions
    {
        public static ISignalRServerBuilder AddHubOptions<THub>(this ISignalRServerBuilder signalrBuilder, Action<HubOptions<THub>> options) where THub : Hub
        {
            signalrBuilder.Services.AddSingleton<IConfigureOptions<HubOptions<THub>>, HubOptionsSetup<THub>>();
            signalrBuilder.Services.Configure(options);
            return signalrBuilder;
        }

        /// <summary>
        /// Adds SignalR services to the specified <see cref="IServiceCollection" />.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <returns>An <see cref="ISignalRServerBuilder"/> that can be used to further configure the SignalR services.</returns>
        public static ISignalRServerBuilder AddSignalR(this IServiceCollection services)
        {
            services.AddConnections();
            services.AddSingleton<IConfigureOptions<HubOptions>, HubOptionsSetup>();
            return services.AddSignalRCore();
        }

        /// <summary>
        /// Adds SignalR services to the specified <see cref="IServiceCollection" />.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <param name="options">An <see cref="Action{MvcOptions}"/> to configure the provided <see cref="HubOptions"/>.</param>
        /// <returns>An <see cref="ISignalRServerBuilder"/> that can be used to further configure the SignalR services.</returns>
        public static ISignalRServerBuilder AddSignalR(this IServiceCollection services, Action<HubOptions> options)
        {
            return services.Configure(options)
                .AddSignalR();
        }
    }
}
