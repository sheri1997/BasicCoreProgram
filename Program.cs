using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Number from the below Menu");
            Console.WriteLine("1:Flip Coin\n2:Leap Year\n3:Power of 2\n4:Harmonic Number\n5:Factors\n6:Quotient and Remainder\n7:Swap two Numbers\n8:Even or Odd\n9:Vowel or Consonent\n10:Largest Amoung 3 Numbers");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    FlipCoin.flip();
                    break;
                case 2:
                    leapYear.Leap();
                    break;
                case 3:
                    Powerof2.Power();
                    break;
                case 4:
                    Harmonic.harmonic();
                    break;
                case 5:
                    Factors.factor();
                    break;
                case 6:
                    QuotientandRemainder.QR();
                    break;
                case 7:
                    Swap.swap();
                    break;
                case 8:
                    EvenOdd.evenodd();
                    break;
                case 9:
                    VowelConsonent.vowelconsonent();
                    break;
                case 10:
                    Largest.largest();
                    break;
                default:
                    Console.WriteLine("Invalid Choice, Please Enter a Number between 1 to 10 only");
                    break;
            }
        }
    }
}
