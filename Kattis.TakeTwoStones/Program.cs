using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.TakeTwoStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int stones = scan.NextInt();

            if (stones % 2 == 0)
            {
                Console.Clear();
                Console.WriteLine("Bob");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Alice");
            }

            Console.ReadKey();
        }
    }
}
