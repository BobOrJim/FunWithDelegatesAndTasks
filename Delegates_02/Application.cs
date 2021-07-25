using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    public delegate void OutputDelegate(object? sender, string message);

    internal class Application
    {
        OutputController outputController = new OutputController();
        NumberGenerator_01 numberGenerator_01 = new NumberGenerator_01();
        NumberGenerator_02 numberGenerator_02 = new NumberGenerator_02();
        OutputDelegate outputDelegate;
        public void Run()
        {
            outputDelegate += outputController.ToDebugConsole;
            numberGenerator_01.EvenNumberGenerator(outputDelegate);
            numberGenerator_02.OddNumberGenerator(outputDelegate);




        }

    }
}
