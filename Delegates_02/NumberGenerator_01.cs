using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    public class NumberGenerator_01
    {
        public async Task EvenNumberGenerator(OutputDelegate outputDelegate)
        {
            int counter=0;
            while (true)
            {
                await Task.Delay(1000);
                counter++;
                if (counter %2 == 0)
                {
                    outputDelegate(this, counter.ToString());
                }
            }
        }
    }
}
