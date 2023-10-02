namespace TestProject1;
using ds.test.impl;

public class AdditionPluginTests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void GetPluginRunTest()
    {
        var pluginFactory = new Plugins();
        var plugin = pluginFactory.GetPlugin("AdditionPlugin");

        var result = plugin.Run(5, 5);
        
        if (result == 10)
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
        Assert.Fail();
    }
}