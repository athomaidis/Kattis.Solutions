using System;
using System.Linq;

namespace Kattis.SevenWonders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scanner scan = new Scanner();

            string line = Console.ReadLine();
            var cards = line.ToArray();

            int cardsC = CountCharacter(cards, 'C');
            //Console.WriteLine(cardsC);
            int cardsT = CountCharacter(cards, 'T');
            //Console.WriteLine(cardsT);
            int cardsG = CountCharacter(cards, 'G');
            //Console.WriteLine(cardsG);

            int setsOfUniques = Math.Min(cardsC, Math.Min(cardsG, cardsT));

            var result = Math.Pow((double)cardsT, 2) +
                         Math.Pow((double)cardsC, 2) +
                         Math.Pow((double)cardsG, 2) + setsOfUniques * 7;

            Console.Clear();
            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// count the appearances of a character in the array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="character"></param>
        /// <returns></returns>            
        public static int CountCharacter(char[] input, char character)
            {
                int result = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == character)
                        result += 1;
                }

                return result;
            }
    }
}
