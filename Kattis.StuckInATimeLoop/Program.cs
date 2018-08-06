using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();
            string word = " Abracadabra";

            int spell = scan.NextInt();
            Console.Clear();

            for (int i = 1; i <= spell; i++)
            {
                Console.WriteLine(i + word);
            }

            Console.ReadKey();
        }
    }
}
