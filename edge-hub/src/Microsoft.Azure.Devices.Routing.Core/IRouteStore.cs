// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Azure.Devices.Routing.Core
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRouteStore
    {
        Task<RouterConfig> GetRouterConfigAsync(string iotHubName, CancellationToken token);
    }
}
