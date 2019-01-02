// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Agent.Edgelet.Test.TestServer.Controllers
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

#pragma warning disable // Disable all warnings

    [GeneratedCode("NSwag", "11.17.12.0 (NJsonSchema v9.10.50.0 (Newtonsoft.Json v9.0.0.0))")]
    public interface IController
    {
        /// <summary>List modules.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        Task<ModuleList> ListModulesAsync(string api_version);

        /// <summary>Create module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="module"></param>
        /// <returns>Created</returns>
        Task<ModuleDetails> CreateModuleAsync(string api_version, ModuleSpec module);

        /// <summary>Get a module's status.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to get. (urlencoded)</param>
        /// <returns>Ok</returns>
        Task<ModuleDetails> GetModuleAsync(string api_version, string name);

        /// <summary>Update a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to update. (urlencoded)</param>
        /// <param name="start">Flag indicating whether module should be started after updating.</param>
        /// <param name="module"></param>
        /// <returns>Ok</returns>
        Task<ModuleDetails> UpdateModuleAsync(string api_version, string name, bool start, ModuleSpec module);

        /// <summary>Delete a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to delete. (urlencoded)</param>
        /// <returns>No Content</returns>
        Task DeleteModuleAsync(string api_version, string name);

        /// <summary>Start a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to start. (urlencoded)</param>
        /// <returns>No Content</returns>
        Task StartModuleAsync(string api_version, string name);

        /// <summary>Stop a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to stop. (urlencoded)</param>
        /// <returns>Status code</returns>
        Task<int> StopModuleAsync(string api_version, string name);

        /// <summary>Restart a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to restart. (urlencoded)</param>
        /// <returns>No Content</returns>
        Task RestartModuleAsync(string api_version, string name);

        /// <summary>List identities.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        Task<IdentityList> ListIdentitiesAsync(string api_version);

        /// <summary>Create an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="identity"></param>
        /// <returns>Created</returns>
        Task<Identity> CreateIdentityAsync(string api_version, IdentitySpec identity);

        /// <summary>Update an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to update. (urlencoded)</param>
        /// <param name="updateinfo"></param>
        /// <returns>Updated</returns>
        Task<Identity> UpdateIdentityAsync(string api_version, string name, UpdateIdentity updateinfo);

        /// <summary>Delete an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to delete. (urlencoded)</param>
        /// <returns>Ok</returns>
        Task DeleteIdentityAsync(string api_version, string name);
    }

    [GeneratedCode("NSwag", "11.17.12.0 (NJsonSchema v9.10.50.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class Controller : AspNetCore.Mvc.Controller
    {
        private IController _implementation;

        public Controller(IController implementation)
        {
            _implementation = implementation;
        }

        /// <summary>List modules.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        [HttpGet, Route("modules")]
        public Task<ModuleList> ListModules(string api_version)
        {
            return _implementation.ListModulesAsync(api_version);
        }

        /// <summary>Create module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="module"></param>
        /// <returns>Created</returns>
        [HttpPost, Route("modules")]
        public Task<ModuleDetails> CreateModule(string api_version, [FromBody] ModuleSpec module)
        {
            return _implementation.CreateModuleAsync(api_version, module);
        }

        /// <summary>Get a module's status.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to get. (urlencoded)</param>
        /// <returns>Ok</returns>
        [HttpGet, Route("modules/{name}")]
        public Task<ModuleDetails> GetModule(string api_version, string name)
        {
            return _implementation.GetModuleAsync(api_version, name);
        }

        /// <summary>Update a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to update. (urlencoded)</param>
        /// <param name="start">Flag indicating whether module should be started after updating.</param>
        /// <param name="module"></param>
        /// <returns>Ok</returns>
        [HttpPut, Route("modules/{name}")]
        public Task<ModuleDetails> UpdateModule(string api_version, string name, bool? start, [FromBody] ModuleSpec module)
        {
            return _implementation.UpdateModuleAsync(api_version, name, start ?? false, module);
        }

        /// <summary>Delete a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to delete. (urlencoded)</param>
        /// <returns>No Content</returns>
        [HttpDelete, Route("modules/{name}")]
        public Task DeleteModule(string api_version, string name)
        {
            return _implementation.DeleteModuleAsync(api_version, name);
        }

        /// <summary>Start a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to start. (urlencoded)</param>
        /// <returns>No Content</returns>
        [HttpPost, Route("modules/{name}/start")]
        public Task StartModule(string api_version, string name)
        {
            return _implementation.StartModuleAsync(api_version, name);
        }

        /// <summary>Stop a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to stop. (urlencoded)</param>
        /// <returns>No Content</returns>
        [HttpPost, Route("modules/{name}/stop")]
        public async Task<IActionResult> StopModule(string api_version, string name)
        {
            int statusCode = await _implementation.StopModuleAsync(api_version, name);
            return StatusCode(statusCode);
        }

        /// <summary>Restart a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to restart. (urlencoded)</param>
        /// <returns>No Content</returns>
        [HttpPost, Route("modules/{name}/restart")]
        public Task RestartModule(string api_version, string name)
        {
            return _implementation.RestartModuleAsync(api_version, name);
        }

        /// <summary>List identities.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        [HttpGet, Route("identities/")]
        public Task<IdentityList> ListIdentities(string api_version)
        {
            return _implementation.ListIdentitiesAsync(api_version);
        }

        /// <summary>Create an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="identity"></param>
        /// <returns>Created</returns>
        [HttpPost, Route("identities/")]
        public Task<Identity> CreateIdentity(string api_version, [FromBody] IdentitySpec identity)
        {
            return _implementation.CreateIdentityAsync(api_version, identity);
        }

        /// <summary>Update an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to update. (urlencoded)</param>
        /// <param name="updateinfo"></param>
        /// <returns>Updated</returns>
        [HttpPut, Route("identities/{name}")]
        public Task<Identity> UpdateIdentity(string api_version, string name, [FromBody] UpdateIdentity updateinfo)
        {
            return _implementation.UpdateIdentityAsync(api_version, name, updateinfo);
        }

        /// <summary>Delete an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to delete. (urlencoded)</param>
        /// <returns>Ok</returns>
        [HttpDelete, Route("identities/{name}")]
        public Task DeleteIdentity(string api_version, string name)
        {
            return _implementation.DeleteIdentityAsync(api_version, name);
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ModuleList : INotifyPropertyChanged
    {
        private List<ModuleDetails> _modules = new List<ModuleDetails>();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("modules", Required = Required.Always)]
        [Required]
        public List<ModuleDetails> Modules
        {
            get { return _modules; }
            set
            {
                if (_modules != value)
                {
                    _modules = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ModuleList FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ModuleList>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ModuleDetails : INotifyPropertyChanged
    {
        private string _id;
        private string _name;
        private string _type;
        private Config _config = new Config();
        private Status _status = new Status();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("config", Required = Required.Always)]
        [Required]
        public Config Config
        {
            get { return _config; }
            set
            {
                if (_config != value)
                {
                    _config = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>System generated unique identitier.</summary>
        [JsonProperty("id", Required = Required.Always)]
        [Required]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the module.</summary>
        [JsonProperty("name", Required = Required.Always)]
        [Required]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("status", Required = Required.Always)]
        [Required]
        public Status Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The type of a module.</summary>
        [JsonProperty("type", Required = Required.Always)]
        [Required]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ModuleDetails FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ModuleDetails>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ModuleSpec : INotifyPropertyChanged
    {
        private string _name;
        private string _type;
        private Config _config = new Config();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("config", Required = Required.Always)]
        [Required]
        public Config Config
        {
            get { return _config; }
            set
            {
                if (_config != value)
                {
                    _config = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of a the module.</summary>
        [JsonProperty("name", Required = Required.Always)]
        [Required]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("type", Required = Required.Always)]
        [Required]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ModuleSpec FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ModuleSpec>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Config : INotifyPropertyChanged
    {
        private object _settings = new object();
        private List<EnvVar> _env;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("env", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<EnvVar> Env
        {
            get { return _env; }
            set
            {
                if (_env != value)
                {
                    _env = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("settings", Required = Required.Always)]
        [Required]
        public object Settings
        {
            get { return _settings; }
            set
            {
                if (_settings != value)
                {
                    _settings = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static Config FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Config>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Status : INotifyPropertyChanged
    {
        private DateTime? _startTime;
        private ExitStatus _exitStatus;
        private RuntimeStatus _runtimeStatus = new RuntimeStatus();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("exitStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExitStatus ExitStatus
        {
            get { return _exitStatus; }
            set
            {
                if (_exitStatus != value)
                {
                    _exitStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("runtimeStatus", Required = Required.Always)]
        [Required]
        public RuntimeStatus RuntimeStatus
        {
            get { return _runtimeStatus; }
            set
            {
                if (_runtimeStatus != value)
                {
                    _runtimeStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("startTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime
        {
            get { return _startTime; }
            set
            {
                if (_startTime != value)
                {
                    _startTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static Status FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Status>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EnvVar : INotifyPropertyChanged
    {
        private string _key;
        private string _value;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("key", Required = Required.Always)]
        [Required]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("value", Required = Required.Always)]
        [Required]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static EnvVar FromJson(string data)
        {
            return JsonConvert.DeserializeObject<EnvVar>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ExitStatus : INotifyPropertyChanged
    {
        private DateTime _exitTime;
        private string _statusCode;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("exitTime", Required = Required.Always)]
        [Required]
        public DateTime ExitTime
        {
            get { return _exitTime; }
            set
            {
                if (_exitTime != value)
                {
                    _exitTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("statusCode", Required = Required.Always)]
        [Required]
        public string StatusCode
        {
            get { return _statusCode; }
            set
            {
                if (_statusCode != value)
                {
                    _statusCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ExitStatus FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ExitStatus>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RuntimeStatus : INotifyPropertyChanged
    {
        private string _status;
        private string _description;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("status", Required = Required.Always)]
        [Required]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static RuntimeStatus FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RuntimeStatus>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentityList : INotifyPropertyChanged
    {
        private List<Identity> _identities = new List<Identity>();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("identities", Required = Required.Always)]
        [Required]
        public List<Identity> Identities
        {
            get { return _identities; }
            set
            {
                if (_identities != value)
                {
                    _identities = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static IdentityList FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IdentityList>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentitySpec : INotifyPropertyChanged
    {
        private string _moduleId;
        private string _managedBy;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("managedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedBy
        {
            get { return _managedBy; }
            set
            {
                if (_managedBy != value)
                {
                    _managedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("moduleId", Required = Required.Always)]
        [Required]
        public string ModuleId
        {
            get { return _moduleId; }
            set
            {
                if (_moduleId != value)
                {
                    _moduleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static IdentitySpec FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IdentitySpec>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UpdateIdentity : INotifyPropertyChanged
    {
        private string _generationId;
        private string _managedBy;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("generationId", Required = Required.Always)]
        [Required]
        public string GenerationId
        {
            get { return _generationId; }
            set
            {
                if (_generationId != value)
                {
                    _generationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("managedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedBy
        {
            get { return _managedBy; }
            set
            {
                if (_managedBy != value)
                {
                    _managedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static UpdateIdentity FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UpdateIdentity>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Identity : INotifyPropertyChanged
    {
        private string _moduleId;
        private string _managedBy;
        private string _generationId;
        private IdentityAuthType _authType;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("authType", Required = Required.Always)]
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public IdentityAuthType AuthType
        {
            get { return _authType; }
            set
            {
                if (_authType != value)
                {
                    _authType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("generationId", Required = Required.Always)]
        [Required]
        public string GenerationId
        {
            get { return _generationId; }
            set
            {
                if (_generationId != value)
                {
                    _generationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("managedBy", Required = Required.Always)]
        [Required]
        public string ManagedBy
        {
            get { return _managedBy; }
            set
            {
                if (_managedBy != value)
                {
                    _managedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("moduleId", Required = Required.Always)]
        [Required]
        public string ModuleId
        {
            get { return _moduleId; }
            set
            {
                if (_moduleId != value)
                {
                    _moduleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static Identity FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Identity>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ErrorResponse : INotifyPropertyChanged
    {
        private string _message;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("message", Required = Required.Always)]
        [Required]
        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ErrorResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ErrorResponse>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IdentityAuthType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Sas")]
        Sas = 1,

        [EnumMember(Value = "X509")]
        X509 = 2,
    }
}
