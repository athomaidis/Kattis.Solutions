using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Zamka
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int lowerLimit = scan.NextInt();
            int upperLimit = scan.NextInt();
            int sum = scan.NextInt();
            int max = int.MinValue;
            int min = int.MaxValue;
            int x;

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                x = SumOfDigits(i);

                if (x == sum)
                {
                    if (i > max)
                    { max = i; }
                    if (i < min)
                    {
                        min = i;
                    }
                }
            }

            //Console.Clear();
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        /// <summary>
        /// Calculating the sum of digits
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static int SumOfDigits(int input)
        {
            int result = 0;

            while (input != 0)
            {
                result += input % 10;
                input /= 10;
            }

            return result;
        }
    }
}
