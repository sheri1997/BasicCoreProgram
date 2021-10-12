using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Powerof2
    {
        public static void Power()
        {
            Console.WriteLine("Please Enter the Number");//user input number
            double N = Console.Read();
            double pow=0.0;//user can input a double value also
            while (N <= 31)
            {
                pow = Math.Pow(2, N);//calculating power using power mathed of math class.
            }
            Console.WriteLine("Power =" + pow);
        }
    }
}
