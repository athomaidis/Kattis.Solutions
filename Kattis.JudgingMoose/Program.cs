using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.JudgingMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            byte left = scan.NextByte();
            byte right = scan.NextByte();
            byte result = 0;
            Console.Clear();

            if (left == right)
            {
                if (left == 0 && right == 0)
                {
                    Console.WriteLine("Not a moose");
                }
                else
                    Console.WriteLine("Even " + (left * 2));
            }
            else
            {
                if (left > right)
                {
                    Console.WriteLine("Odd " + (left * 2));
                }
                else
                {
                    Console.WriteLine("Odd " + (right * 2));
                }
            }

            Console.ReadKey();
        }
    }
}
