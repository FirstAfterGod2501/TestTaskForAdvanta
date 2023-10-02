using System.Reflection;

namespace ds.test.impl;

public class Plugins : IPluginFactory
{
    public int PluginsCount { get; private set; }

    public List<string> GetPluginNames { get; }

    public Plugins()
    {
        GetPluginNames = new List<string>();

        // get all implementations of IPlugin interface classes
        var interfaceType = typeof(IPlugin);
        var assembly = Assembly.GetExecutingAssembly();

        foreach (var type in assembly.GetTypes())
        {
            if (interfaceType.IsAssignableFrom(type) && !type.IsInterface)
            {
                GetPluginNames.Add(type.FullName);
            }
        }

        // getting all child classes from PluginBase
        var baseType = typeof(PluginBase);

        foreach (var type in assembly.GetTypes())
        {
            if (type.IsSubclassOf(baseType))
            {
                GetPluginNames.Add(type.FullName);
            }
        }
    }

    public IPlugin GetPlugin(string pluginName)
    {
        foreach (var classType in 
                 from name in GetPluginNames
                 where name.Contains(pluginName)
                 select Type.GetType(name)
                 into classType
                 where classType != null
                 select classType)
        {
            //create Instance
            PluginsCount++;
            
            return (IPlugin)Activator.CreateInstance(classType)!;
        }

        throw new Exception("type not found");
    }
}