using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.SolvingForCarrots
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int contestants = scan.NextInt();
            int problemsSolved = scan.NextInt();
            var contestantNames = new string[contestants];

            for (int i = 0; i < contestants; i++)
            {
                contestantNames[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine(problemsSolved);
            Console.ReadKey();
        }
    }
}
