using System.Reflection;
using PluginInterface;

var assembly = Assembly.LoadFrom("Plugin.dll");

var pluginType = assembly.GetExportedTypes()
    .Where(t => t.IsAssignableTo(typeof(IPlugin)))
    .First();

var plugin = (IPlugin)Activator.CreateInstance(pluginType);

plugin.Do();

Console.ReadLine();