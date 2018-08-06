using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int numbers = scan.NextInt();
            var numberAr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                numberAr[i] = scan.NextInt();
            }
            Console.Clear();

            for (int i = 0; i < numbers; i++)
            {

                if (numberAr[i] % 2 == 0)
                {
                    Console.WriteLine(numberAr[i] + " is even");
                }
                else
                {
                    Console.WriteLine(numberAr[i] + " is odd");
                }
            }

            Console.ReadKey();
        }
    }
}
