using System.Drawing;

namespace ds.test.impl;

internal class MultiplicationPlugin : PluginBase
{
    public override string PluginName => "MultiplicationPlugin";

    public override string Version => "1.0";

    public override Image Image => new Bitmap("");

    public override string Description => "The plugin multiplies two numbers and returns the result";

    public override int Run(int input1, int input2)
    {
        return input1 * input2;
    }
}