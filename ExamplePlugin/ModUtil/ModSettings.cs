// MoreStirlingLogic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MoreStirlingLogic.Source.ModSetting.LoadModSettings
using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Concurrent;
using System.Collections.Generic;

using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

using System.Linq;

using ExamplePlugin.Source.Scripts;
using ExamplePlugin.Source;
namespace ExamplePlugin.ModUtil
{
	public class ModSettings
	{
		public static ManualLogSource Log;
		public static ConfigEntry<bool> configDebug;

		public static ConfigFile configFile; 
		public static bool IsEnabled
		{
			get
			{
				if (WorkshopMenu.ModsConfig is null)
					LoadModConfig();
				bool enabled = false;
				foreach (ModData mod in WorkshopMenu.ModsConfig.GetEnabledMods())
				{
					if ((mod.IsLocal && mod.LocalPath.Contains(Source.PluginInfo.PLUGIN_SHORTNAME)) || mod.Id == Source.PluginInfo.PLUGIN_ID)
					{
						enabled = mod.IsEnabled;
						break;
					}
				}
				return enabled;
			}
		}

		public static void LoadModConfig()
		{
			configDebug = configFile.Bind("Debug", "EnableDebug",  false, "If true, writes debug information to log file.");
			if (WorkshopMenu.ModsConfig is null)
				WorkshopMenu.LoadModConfig();
			//ModsConfig = File.Exists("modconfig.xml") ? Deserialize<ModConfig>("modconfig.xml") : new ModConfig();
		}
	}
}