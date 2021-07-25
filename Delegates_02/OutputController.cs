using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    internal class OutputController
    {
        public void ToDebugConsole(object? sender, string message)
        {
            //Debug.WriteLine("TestMessage");
            Debug.WriteLine($"Message from {sender}. The message is {message} ");
        }
    }
}
