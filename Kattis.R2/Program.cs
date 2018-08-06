using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.R2
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int R1 = scan.NextInt();
            int S = scan.NextInt();

            int R2 = 2 * S - R1;

            Console.Clear();
            Console.WriteLine(R2);
            Console.ReadKey();
        }
    }
}
