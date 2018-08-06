using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.BatterUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int atBats = scan.NextInt();
            int pointAtBat = 0;
            int points = 0;
            int counter = 0;
            decimal sluggingP = 0;

            for (int i = 0; i < atBats; i++)
            {
                pointAtBat = scan.NextInt();
                if (pointAtBat != -1)
                {
                    points += pointAtBat;
                    counter += 1;
                }
            }

            sluggingP = Decimal.Round((Convert.ToDecimal(points) / counter), 18, MidpointRounding.AwayFromZero);
            Console.Clear();
            Console.WriteLine(sluggingP);
            Console.ReadKey();
        }
    }
}
