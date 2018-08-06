using System;
using System.Linq;

namespace Kattis.NoDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                string[] distincts = split.Distinct().ToArray();

                if (split.Length <= distincts.Length)
                {
                    Console.WriteLine("yes");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("no");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }
        }
    }
}
