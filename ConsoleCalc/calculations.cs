using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class calculations
    {
        public static int fibonacci(int place)
        {
            if (place < 1) throw new ArgumentOutOfRangeException("place", "Argument 'place' must be greater than 0.");
            if (place > 46) throw new ArgumentOutOfRangeException("place", "This function does not support a 'place' value about 46.");
            if (place < 3) return 1;
            else
            {
                int i = 3;
                int a = 1, b = 1;
                int c = 0;
            
                while (i <= place)
                {
                    c = a + b;
                    a = b; b = c;
                    i++;
                }

                return c;
            }
        }
    }
}
