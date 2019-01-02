// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Agent.Core
{
    public interface IModuleIdentity
    {
        ICredentials Credentials { get; }

        string DeviceId { get; }

        string GatewayHostname { get; }

        string IotHubHostname { get; }

        string ModuleId { get; }
    }
}
