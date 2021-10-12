using System;

namespace BasicCoreProgram
{
    class leapYear
    {
        public static void Leap()
        {
            Console.WriteLine("Please Enter the Year");//user will enter a year
            int Year = Console.Read();
            if (Year < 10000 && Year > 999)//to check wheater it is 4 digit or not
            {
                if (Year % 4 == 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not a Leap Year");
                }
            }
            else//if the number is not a 4 digit number
            {
                Console.WriteLine("Please Enter a valid Year");
            }
        }
    }
}
