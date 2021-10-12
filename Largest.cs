using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Largest
    {
        public static void largest()
        {
            Console.WriteLine("Please Enter the First Number");
            double Number1 = Console.Read();
            Console.WriteLine("Please Enter the Second Number");
            double Number2 = Console.Read();
            Console.WriteLine("Please Enter the Third Number");
            double Number3 = Console.Read();
            if(Number1>Number2 && Number1>Number3)
            {
                Console.WriteLine("First Number is the Largest");
            }
            else if(Number2>Number1 && Number2>Number3)
            {
                Console.WriteLine("Second Number is the Largest");
            }
            else
            {
                Console.WriteLine("Third Number is the Largest");
            }
        }
    }
}
