using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class FlipCoin
    {
        public static void flip() //method declaration
        {
            Console.WriteLine("Please Enter the Number of times to Flip Coin");
            int numberFlip = Console.Read(); //user input number to show how many times will the coin will flip
            int head = 0, tail = 0, headpercentage = 0, tailpercentage = 0;
            if (numberFlip >= 1)//ensure that it is a positive number
            {
                for (int i = 1; i <= numberFlip; i++) //loop will go from 1 to user input number
                {
                    Random random = new Random();
                    int rNumber = random.Next(0, 1);//random function to generate either 0 or 1.
                    if (rNumber < 0.5)
                    {
                        tail++;
                    }
                    else
                    {
                        head++;
                    }
                }
                headpercentage = ((head / numberFlip) * 100);
                tailpercentage = ((tail / numberFlip) * 100);
                Console.WriteLine("heads was flipped {0} times", head);
                Console.WriteLine("tails was flipped {0} times", tail);
                Console.WriteLine("Percentage of Head", headpercentage);
                Console.WriteLine("Percentage of Tails", tailpercentage);
            }
            else
            {
                Console.WriteLine("Please Enter a Positive Number");
            }
        }
    }
}
