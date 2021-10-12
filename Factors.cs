using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Factors
    {
        public static void factor()
        {
            Console.WriteLine("Please Enter the Number Whose Prime Factors are to be Computed");
            int number = Console.Read();
            while(number%2==0)
            {
                Console.WriteLine(2 + "");
                number /= 2;
            }
            for(int i=3;i<=Math.Sqrt(number);i+=2)
            {
                while(number%i==0)
                {
                    Console.WriteLine(i + "");
                    number /= i;
                }
            }
            if(number>2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
