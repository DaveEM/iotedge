// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Azure.Devices.Edge.Hub.Amqp
{
    public enum LinkType
    {
        Cbs,
        Events,
        C2D,
        ModuleMessages,
        TwinReceiving,
        TwinSending,
        MethodReceiving,
        MethodSending,
    }
}
