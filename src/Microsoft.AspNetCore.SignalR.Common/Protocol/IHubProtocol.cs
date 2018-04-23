// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Buffers;
using Microsoft.AspNetCore.Connections;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
    /// <summary>
    /// A protocol abstraction for communicating with SignalR hubs.
    /// </summary>
    public interface IHubProtocol
    {
        /// <summary>
        /// Gets the name of the protocol. The name is used by SignalR to resolve the protocol between the client and server.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the version of the protocol.
        /// </summary>
        int Version { get; }

        /// <summary>
        /// Gets the transfer format of the protocol.
        /// </summary>
        TransferFormat TransferFormat { get; }

        /// <summary>
        /// Creates a new <see cref="HubMessage"/> using the specified bytes and binder.
        /// </summary>
        /// <param name="input">The byte representation of the message.</param>
        /// <param name="binder">The binder used to parse the message.</param>
        /// <param name="message">When this method returns, contains the parsed message.</param>
        /// <returns>A value that is <c>true</c> if the <see cref="HubMessage"/> was successfully parsed; otherwise, <c>false</c>.</returns>
        bool TryParseMessage(ref ReadOnlySequence<byte> input, IInvocationBinder binder, out HubMessage message);

        /// <summary>
        /// Writes the specified <see cref="HubMessage"/> to a writer.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="output">The output writer.</param>
        void WriteMessage(HubMessage message, IBufferWriter<byte> output);

        /// <summary>
        /// Converts the specified <see cref="HubMessage"/> to its bytes.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <returns>The byte representation of the message.</returns>
        ReadOnlyMemory<byte> GetMessageBytes(HubMessage message);

        /// <summary>
        /// Gets a value indicating whether the protocol supports the specified version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>A value indicating whether the protocol supports the specified version.</returns>
        bool IsVersionSupported(int version);
    }
}
