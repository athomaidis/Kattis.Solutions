using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Cold_puterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int numberOfTemperatures = scan.NextInt();
            int temperature = 0;
            byte counter = 0;

            for (int i = 0; i < numberOfTemperatures; i++)
            {
                temperature = scan.NextInt();
                if (temperature < 0)
                {
                    counter++;
                }
            }

            Console.Clear();
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
