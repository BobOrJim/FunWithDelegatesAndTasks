using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    public class NumberGenerator_02
    {
        public async Task OddNumberGenerator(OutputDelegate outputDelegate)
        {
            int counter = 0;
            while (true)
            {
                await Task.Delay(1000);
                counter++;
                if (counter % 2 == 1)
                {
                    outputDelegate(this, counter.ToString());
                }
            }
        }
    }
}
