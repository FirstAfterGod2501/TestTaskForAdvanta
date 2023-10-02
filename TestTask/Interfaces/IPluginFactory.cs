namespace ds.test.impl;

internal interface IPluginFactory
{
    int PluginsCount { get; }
    
    List<string> GetPluginNames { get; }
    
    IPlugin? GetPlugin (string pluginName);
}