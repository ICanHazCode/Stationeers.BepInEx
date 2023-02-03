using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HarmonyLib;

using UnityEngine;
namespace ExamplePlugin.Source.Scripts
{
	//This is just an example class structure that you can use to organize your patchers
	public class WorldManagerPatches
	{

		//Since there is only one Prefix/Postfix/Finalizer function per class... we've named the class after the function we're patching.
		[HarmonyPatch(typeof(WorldManager),"Awake")]
		public class AwakePatch
		{
			/// <summary>
			/// A Prefix patch that has no return value, so other prefix patchers can run.
			/// Arguments referencing private fields must be prepended with 3 underscores "fieldType ___somePrivateField"
			/// if you wish to write to the field, use the ref keyword: ref fieldType ___somePrivateField
			/// </summary>
			/// <param name="__instance">example argument: the "instance" (live object).</param>
			public static void Prefix(WorldManager __instance)
			{
				// We're just announcing that we've successfully patched the function.
				// We use a property from the class instance to 
				Debug.Log(
					string.Format("Hello world from {0}! WorldManager is {1}", 
						PluginInfo.PLUGIN_NAME,
						__instance.enabled ? "enabled" : "disabled")
					);
			}

		}
	}
}
