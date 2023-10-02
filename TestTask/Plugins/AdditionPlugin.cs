using System.Drawing;

namespace ds.test.impl;

internal class AdditionPlugin : PluginBase
{
    public override string PluginName => "AdditionPlugin";

    public override string Version => "1.0";

    public override Image Image => new Bitmap("");

    public override string Description => "The plugin adds two numbers and returns the result of the addition";

    public override int Run(int input1, int input2)
    {
        return input1 + input2;
    }
}