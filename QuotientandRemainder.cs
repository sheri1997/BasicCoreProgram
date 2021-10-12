using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class QuotientandRemainder
    {
        public static void QR()//method declaration
        {
            Console.WriteLine("Pkease Enter the Dividend");
            double dividend = Console.Read();//divedend entered by the user
            Console.WriteLine("Please Enter the Divisor");
            double divisor = Console.Read();//divisor entered by the user
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
