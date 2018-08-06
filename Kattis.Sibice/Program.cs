using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Sibice
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            byte matches = scan.NextByte();
            var fitsOrNot = new string[matches];
            byte width = scan.NextByte();
            byte length = scan.NextByte();

            byte match;

            for (int i = 0; i < matches; i++)
            {
                match = scan.NextByte();
                if (match <= width || match <= length || match <= (Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2))))
                {
                    fitsOrNot[i] = "DA";
                }
                else
                {
                    fitsOrNot[i] = "NE";
                }
            }

            Console.Clear();
            for (int i = 0; i < matches; i++)
            {
                Console.WriteLine(fitsOrNot[i]);
            }

            Console.ReadKey();
        }
    }
}
