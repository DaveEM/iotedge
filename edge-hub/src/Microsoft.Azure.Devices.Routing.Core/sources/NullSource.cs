// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Azure.Devices.Routing.Core.Sources
{
    using System.Threading.Tasks;

    using Microsoft.Azure.Devices.Routing.Core.Util;

    public class NullSource : Source
    {
        public NullSource(Router router)
            : base(router)
        {
        }

        public override Task RunAsync() => TaskEx.Done;
    }
}
