﻿using System.Reflection;
using McMaster.NETCore.Plugins;
using PluginInterface;

var currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

var pluginPath = Path.Combine(currentPath, "Plugin.dll");

var pluginInterfaceType = typeof(IPlugin);

var loader = PluginLoader.CreateFromAssemblyFile(
    assemblyFile: pluginPath,
    sharedTypes: new[] { pluginInterfaceType });

var assembly = loader.LoadDefaultAssembly();

var pluginType = assembly.GetExportedTypes()
    .Where(t => t.IsAssignableTo(pluginInterfaceType))
    .First();

var plugin = (IPlugin)Activator.CreateInstance(pluginType);

plugin.Do();

Console.ReadLine();