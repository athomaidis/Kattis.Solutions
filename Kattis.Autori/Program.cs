using System;
using System.Text;
using static Kattis.Shared.KattisIO;

namespace Kattis.Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            string userInput = Console.ReadLine();
            string[] words = userInput.Split('-');
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {

                if (Char.IsUpper(words[i], 0))
                {
                    builder.Append(words[i][0]);
                }
            }
            Console.WriteLine(builder);

            Console.ReadKey();
        }
    }
}
