# Stationeers Visual Studio BepInEx Example Plugin
Based on code from silentdeth and his BepInEx plugins for Stationeers.

This produces a dll in the plugins directory. 

The PluginInfo.cs file has the const strings used to define the properties for the plugin.

The PLUGIN_ID is the workshop item id for uploading to the stationeers workshop.

## Plugin Settings
#### `Stationeers.VS.props`
This needs the path to your Stationeers installation.

#### `Source\PluginInfo.cs`
Contains the name, id, author, version, Harmony GUID, and other properties for the Plugin

#### `About\About.tt`
This is the T4 template used to generate `About.xml` from `PluginInfo.cs`, `description.ttinclude`, and `tags.ttinclude`

:warning: Don't modify this template unless you know what you're doing! :warning:

#### `About\description.ttinclude`
Description shown in the Workshop for the plugin

#### `About\tags.ttinclude`
A list of tags for the plugin. These are the tags that are listed in the workshop. One tag per line.

Available tags are:
- World Save
- Mod
- Crafting
- Starting Conditions
- World Settings
- Mineables
- IC Code
- Scenario
- Incident
- Tool

## Folders
The `GameData` folder contains the xml files for standard configuration mods (ie. StartingCondition, Recipe settings, etc.)
This folder needs to exist, hence the dont.remove empty file. The `Language` subfolder contains the language localization files.

The `About` folder contains the About.xml file that the workshop uses to describe your mod/plugin and the png images used.



