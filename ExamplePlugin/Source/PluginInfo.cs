using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlugin.Source
{
	public static class PluginInfo
	{
		public const string PLUGIN_GUID      = "org.stationeers.<author>.ExamplePlugin";
		public const string PLUGIN_NAME      = "Example BepInEx Stationeers Plugin";
		public const string PLUGIN_SHORTNAME = "Example.Plugin";
		public const string PLUGIN_VERSION   = "1.0.0";
		public const string PLUGIN_AUTHOR    = "author";
		public const uint   PLUGIN_ID        = 0u;
	}
}
