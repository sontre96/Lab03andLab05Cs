using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Ex4Lab05
{
    class Mainclass
    {
        public static int AnExceptionFunction(int value)
        {
            if (value == 0)
                throw new DivideByZeroException("Divide by 0 error!");
            int x = 20 / value;
            return x;
        }

        public static void Main(string[] args)
        {
            int value = 0;
            try
            {
                value = AnExceptionFunction(10);
                Console.WriteLine("Value = {0}", value);
                AnExceptionFunction(0);
                Console.WriteLine("Value = {0}", value);

            }
            catch (Exception e)
            {
                Console.WriteLine("Caught and exception {0} . Continuing", e);
            }
            Console.WriteLine("Done");  
        }
    }
}

