using System.Drawing;

namespace ds.test.impl;

internal class DivisionPlugin : PluginBase
{
    public override string PluginName => "DivisionPlugin";

    public override string Version => "1.0";

    public override Image Image => new Bitmap("");

    public override string Description => "The plugin multiplies two numbers and returns the result";

    public override int Run(int input1, int input2)
    {
        if (input2 == 0)
        {
            throw new DivideByZeroException();
        }
        return input1 / input2;
    }
}