// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Routing.Core.Query.Builtins
{
    using System;
    using System.Linq.Expressions;

    public class BuiltinExecutor
    {
        public IArgs ContextArgs { get; set; }

        public Func<Expression[], Expression[], Expression> ExecutorFunc { get; set; }

        public IArgs InputArgs { get; set; }

        public bool IsQueryValueSupported { get; set; }
    }
}
