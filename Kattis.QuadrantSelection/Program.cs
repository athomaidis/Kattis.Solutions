using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.QuadrantSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int X = scan.NextInt();
            int Y = scan.NextInt();
            byte percentile = 0;

            if (X > 0)
            {
                if (Y > 0)
                {
                    percentile = 1;
                }
                else
                {
                    percentile = 4;
                }
            }
            else
            {
                if (Y > 0)
                {
                    percentile = 2;
                }
                else
                {
                    percentile = 3;
                }
            }

            Console.Clear();
            Console.WriteLine(percentile);
            Console.ReadKey();
        }
    }
}
