using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();
            var scores = new byte[5];
            byte maxScore = 0;
            byte maxScoreLoc = 6;

            for (int i = 0; i < 5; i++)
            {
                byte pointsSum = 0;

                for (int m = 0; m < 4; m++)
                {
                    pointsSum += scan.NextByte();
                }

                scores[i] = pointsSum;
                if (pointsSum > maxScore)
                {
                    maxScore = pointsSum;
                    maxScoreLoc = (byte)i;
                }
            }

            Console.Clear();
            Console.WriteLine((maxScoreLoc + 1) + " " + maxScore);
            Console.ReadKey();
        }
    }
}
