using System.ComponentModel;
using System.IO;
using TShockAPI;
using CommonGround.Configuration;

namespace AntiCrash
{
    struct AntiCrashConfig : IPluginConfiguration
    {
        public string FilePath => Path.Combine(TShock.SavePath, "AntiCrash.json");

        [DefaultValue(true)]
        public bool Enabled { get; private set; }

        [DefaultValue(50)]
        public int MaxMessageLengthWithoutSpaces { get; private set; }

        [DefaultValue(true)]
        public bool AllowAntiCT { get; private set; }
    }
}
