using System.Drawing;

namespace ds.test.impl;

internal class SubtractionPlugin : IPlugin
{
    public string PluginName => "SubtractionPlugin";

    public string Version => "1.0";

    public Image Image => new Bitmap("");

    public string Description => "The plugin multiplies two numbers and returns the result";

    public int Run(int input1, int input2)
    {
        return input1 - input2;
    }
}