// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Routing.Core.Query
{
    using System;

    public interface IArgs
    {
        int Arity { get; }

        Type[] Types { get; }

        bool Match(Type[] args, bool matchQueryValue);
    }
}
