using System;

namespace Kattis.Trik
{
    class Program
    {
        static void Main(string[] args)
        {

            string sequence = Console.ReadLine();
            var sequenceSteps = new char[sequence.Length];

            sequenceSteps = sequence.ToCharArray();

            var cups = new int[3] { 1, 0, 0 };
            int temp;

            for (int i = 0; i < sequenceSteps.Length; i++)
            {
                //Console.WriteLine(sequenceSteps[i]);
                if (sequenceSteps[i].ToString().Equals("A"))
                {
                    temp = cups[0];
                    cups[0] = cups[1];
                    cups[1] = temp;
                    //Console.WriteLine("Change A");
                }

                if (sequenceSteps[i].ToString().Equals("B"))
                {
                    temp = cups[1];
                    cups[1] = cups[2];
                    cups[2] = temp;
                    //Console.WriteLine("Change B");
                }

                if (sequenceSteps[i].ToString().Equals("C"))
                {
                    temp = cups[0];
                    cups[0] = cups[2];
                    cups[2] = temp;
                    //Console.WriteLine("Change C");
                }
            }

            for (int i = 0; i <= 2; i++)
            {
                if (cups[i] == 1)
                {
                    Console.WriteLine(i + 1);
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Calculate the sum of digits
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static int SumOfDigits(int input)
        {
            int result = 0;

            while (input != 0)
            {
                result += input % 10;
                input /= 10;
            }

            return result;
        }
    }
}
