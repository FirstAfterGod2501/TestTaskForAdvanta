namespace TestProject1;
using ds.test.impl;

public class Tests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void GetPluginTest()
    {
        var pluginFactory = new Plugins();
        var plugin = pluginFactory.GetPlugin("MultiplicationPlugin");
        if (plugin.PluginName == "MultiplicationPlugin")
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }
    
    [Test]
    public void GetNotExistsPluginTest()
    {
        var pluginFactory = new Plugins();
        try
        {
            var plugin = pluginFactory.GetPlugin("Not exists plugin");
        }
        catch (Exception e)
        { 
            Assert.Pass();
        }
    }
}