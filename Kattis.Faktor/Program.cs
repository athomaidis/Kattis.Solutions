using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int articles = scan.NextInt();
            int impactFactor = scan.NextInt();
            int briberyCount = articles * (impactFactor - 1) + 1;

            Console.Clear();
            Console.WriteLine(briberyCount);
            Console.ReadKey();
        }
    }
}
