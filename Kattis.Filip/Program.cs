using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Filip
{
    class Program
    {
        static void Main(string[] args)
        {

            Scanner scan = new Scanner();
            uint firstNmr = scan.NextUInt();
            uint secondNmr = scan.NextUInt();

            firstNmr = ReverseNmr(firstNmr);
            secondNmr = ReverseNmr(secondNmr);

            Console.Clear();
            if (firstNmr > secondNmr)
            {
                Console.WriteLine(firstNmr);
            }
            else
            {
                Console.WriteLine(secondNmr);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Reversing given number
        /// </summary>
        /// <param name="inputNmr"></param>
        /// <returns></returns>
        static uint ReverseNmr(uint inputNmr)
        {
            uint left = inputNmr;
            uint reverse = 0;
            uint r = 0;

            while (left > 0)
            {
                r = (uint)(left % 10);
                reverse = (uint)(reverse * 10 + r);
                left = (uint)(left / 10);  //left = Math.floor(left / 10); 
            }

            return reverse;
        }

    }
}
