using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.GrassSeedInc
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            double cost = scan.NextDouble();
            byte lawns = scan.NextByte();
            double width = 0d;
            double length = 0d;
            float result = 0f;

            for (int i = 0; i < lawns; i++)
            {
                width = scan.NextDouble();
                length = scan.NextDouble();
                result += (float)((width * length) * cost);
            }

            Console.Clear();
            Console.WriteLine(result.ToString("F6"));
            Console.ReadKey();
        }
    }
}
