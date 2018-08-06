using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.HissingMicrophone
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();
            string userText = scan.Next();
            string hiss = "ss";

            if (userText.Contains(hiss))
            {
                Console.Clear();
                Console.WriteLine("hiss");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("no hiss");
            }

            Console.ReadKey();
        }
    }
}
