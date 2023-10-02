using ds.test.impl;

namespace TestProject1;

public class DivisionPluginTest
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void GetPluginRunTest()
    {
        var pluginFactory = new Plugins();
        var plugin = pluginFactory.GetPlugin("DivisionPlugin");

        var result = plugin.Run(5, 5);
        
        if (result == 1)
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }

    [Test]
    public void DivideByZeroTest()
    {
        var pluginFactory = new Plugins();
        var plugin = pluginFactory.GetPlugin("DivisionPlugin");

        try
        {
            var result = plugin.Run(5, 0);
        }
        catch (DivideByZeroException e)
        {
            Assert.Pass();
        }
        Assert.Fail();
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
        Assert.Fail();
    }
}