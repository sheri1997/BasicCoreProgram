using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Harmonic
    {
        public static void harmonic()
        {
            Console.WriteLine("Please Enter A number");
            int Number = Console.Read();//user input
            double HarmonicNumber=1;
            while (Number != 0)//if the number is not 0
            {
                for(int i=1;i<=Number;i++)
                {
                    HarmonicNumber = HarmonicNumber+(1/ Number);//(1/1)+(1/2)+....(1/N)
                }
            }
            Console.WriteLine("Harmonic Number=" + HarmonicNumber);
        }
    }
}
