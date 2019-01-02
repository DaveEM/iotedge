// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Agent.Core
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Newtonsoft.Json;

    public class UnknownModule : IModule
    {
        public virtual ConfigurationInfo ConfigurationInfo => new ConfigurationInfo();

        public virtual ModuleStatus DesiredStatus => ModuleStatus.Unknown;

        public IDictionary<string, EnvVal> Env { get; } = ImmutableDictionary<string, EnvVal>.Empty;

        public virtual string Name
        {
            get => Constants.Unknown;
            set { }
        }

        public virtual RestartPolicy RestartPolicy => RestartPolicy.Never;

        public virtual string Type => Constants.Unknown;

        public virtual string Version => string.Empty;

        public bool Equals(IModule other) => other != null && ReferenceEquals(this, other);
    }

    public class UnknownEdgeHubModule : UnknownModule, IEdgeHubModule
    {
        UnknownEdgeHubModule()
        {
        }

        public static UnknownEdgeHubModule Instance { get; } = new UnknownEdgeHubModule();

        [JsonIgnore]
        public override string Version => string.Empty;

        public IModule WithRuntimeStatus(ModuleStatus newStatus) => Instance;
    }

    public class UnknownEdgeAgentModule : UnknownModule, IEdgeAgentModule
    {
        UnknownEdgeAgentModule()
        {
        }

        public static UnknownEdgeAgentModule Instance { get; } = new UnknownEdgeAgentModule();

        [JsonIgnore]
        public override ModuleStatus DesiredStatus => ModuleStatus.Unknown;

        [JsonIgnore]
        public override RestartPolicy RestartPolicy => RestartPolicy.Never;

        [JsonIgnore]
        public override string Version => string.Empty;

        public IModule WithRuntimeStatus(ModuleStatus newStatus) => new UnknownEdgeAgentModule();
    }
}
