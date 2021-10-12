using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class VowelConsonent
    {
        public static void vowelconsonent()
        {
            Console.WriteLine("Please Enter the Alphabet");
            char alpha = Convert.ToChar(Console.ReadLine());//converting the string to charater
            if(alpha=='a' || alpha=='e' || alpha=='i' || alpha=='o'|| alpha=='u')//condition check
            {
                Console.WriteLine("The Alphbet is a Vowel");
            }
            else
            {
                Console.WriteLine("The Alphbet is a Consonent");
            }
        }
    }
}
