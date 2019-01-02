// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Hub.Mqtt
{
    using Microsoft.Azure.Devices.Edge.Hub.Core.Identity;
    using Microsoft.Azure.Devices.Edge.Util;
    using Microsoft.Azure.Devices.ProtocolGateway.Identity;

    class ProtocolGatewayIdentity : IDeviceIdentity
    {
        public ProtocolGatewayIdentity(IClientCredentials clientCredentials)
        {
            this.ClientCredentials = Preconditions.CheckNotNull(clientCredentials, nameof(clientCredentials));
        }

        public IClientCredentials ClientCredentials { get; }

        public string Id => this.ClientCredentials.Identity.Id;

        public bool IsAuthenticated => true;

        public override string ToString() => this.Id;
    }
}
