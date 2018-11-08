// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Azure.Devices.Routing.Core
{
    public interface IEndpointFactory
    {
        Endpoint CreateFunctionEndpoint(string function, string parameterString);

        Endpoint CreateSystemEndpoint(string systemEndpoint);
    }
}
