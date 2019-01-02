// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Hub.Amqp.LinkHandlers
{
    using System;
    using System.Threading.Tasks;

    public interface ILinkHandler
    {
        string CorrelationId { get; }

        IAmqpLink Link { get; }

        Uri LinkUri { get; }

        LinkType Type { get; }

        Task OpenAsync(TimeSpan timeout);

        Task CloseAsync(TimeSpan timeout);
    }
}
