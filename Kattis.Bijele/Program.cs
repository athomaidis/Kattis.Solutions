using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            var correctSet = new int[] { 1, 1, 2, 2, 2, 8 };
            var actualSet = new int[6];
            var result = new int[6];

            for (int i = 0; i <= 5; i++)
            {
                actualSet[i] = scan.NextInt();
                result[i] = correctSet[i] - actualSet[i];
            }
            Console.Clear();
            for (int i = 0; i <= 5; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
