using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Swap
    {
        public static void swap()
        {
            Console.WriteLine("Please Enter the first Number");
            double Number1 = Console.Read();//user input first number
            Console.WriteLine("Please Enter the second Number");
            double Number2 = Console.Read();//user input second number
            double c = Number1;//temporary variable = first number
            Number1 = Number2;//first number = second number
            Number2 = c;//second number = temporary variable
            Console.WriteLine("Numbers After Swapping" + Number1 + Number2);//printing the swapped numbers
        }
    }
}
