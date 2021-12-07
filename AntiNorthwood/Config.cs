using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Interfaces;

namespace AntiNorthwood
{
    public sealed class Config : IConfig
    {
        [Description("Whether the plugin is enabled or not.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Message shown to nortwood member if he's gonna get kicked from server")]
        public string message { get; set; } = "gay";
    }
}
