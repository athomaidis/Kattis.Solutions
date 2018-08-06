using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int numbers = scan.NextInt();
            double sum = 0; // sum of the numbers

            for (int i = 0; i < numbers; i++)
            {
                int number = scan.NextInt();
                int num = number / 10; // divide by 10 and keep only the integer part
                int power = number % 10; // use the remainder of division with 10 as the power
                sum += Math.Pow(num, power);
            }

            Console.Clear();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
