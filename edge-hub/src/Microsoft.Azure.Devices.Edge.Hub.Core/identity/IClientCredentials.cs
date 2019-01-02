// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Hub.Core.Identity
{
    public interface IClientCredentials
    {
        AuthenticationType AuthenticationType { get; }

        IIdentity Identity { get; }

        string ProductInfo { get; }
    }
}
