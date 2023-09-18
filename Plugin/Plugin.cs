using DatabaseLayer.Models;
using PluginInterface;

namespace Plugin;

public class Plugin : IPlugin
{
    public void Do()
    {
        using var context = new DatabaseContext();

        var list = context.Tables.ToList();
    }
}