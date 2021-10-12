using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class EvenOdd
    {
        public static void evenodd()
        {
            Console.WriteLine("Please Enter the Number");
            int Number = Console.Read();
            if(Number%2==0)//if the remainder is 0
            {
                Console.WriteLine("Even Numeber");
            }
            else//if the remainder is not 0
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
