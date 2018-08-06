using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Planina
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int iterations = scan.NextInt();
            double totalPoints = Math.Pow(2, iterations) + 1;


            Console.Clear();
            Console.WriteLine(Math.Pow(totalPoints, 2));
            Console.ReadKey();
        }
    }
}
