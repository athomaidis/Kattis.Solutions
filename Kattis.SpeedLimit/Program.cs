using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {

            Scanner scan = new Scanner();

            int dataSet = 0;
            int speed = 0;
            int time1 = 0;
            int time2 = 0;
            int time3 = 0;
            int distance = 0;

            while (dataSet != -1)
            {
                dataSet = scan.NextInt();
                if (dataSet != -1)
                {
                    var distances = new int[dataSet];

                    for (int i = 0; i < dataSet; i++)
                    {
                        speed = scan.NextInt();
                        time2 = scan.NextInt();
                        time3 = Math.Abs(time2 - time1);
                        time1 = time2;
                        distances[i] = speed * time3;
                    }

                    for (int i = 0; i < dataSet; i++)
                    {
                        distance += distances[i];
                    }

                    Console.WriteLine(distance + " miles");
                    distance = 0;
                    time1 = 0;
                }
            }
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
