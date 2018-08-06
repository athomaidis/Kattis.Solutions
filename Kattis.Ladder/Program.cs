using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int height = scan.NextInt();
            int maxAngle = scan.NextInt();
            double convertedAngle = (Math.PI / 180) * maxAngle;

            double ladder = 0;

            ladder = (int)Math.Ceiling(height / Math.Sin(convertedAngle));

            Console.WriteLine(ladder);
            Console.ReadKey();
        }
    }
}
