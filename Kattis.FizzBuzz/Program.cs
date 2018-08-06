using System;

namespace Kattis.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                byte numberX = Byte.Parse(split[0]);
                byte numberY = Byte.Parse(split[1]);
                byte numberN = Byte.Parse(split[2]);


                // Print out the FizzBuzz sequence
                FizzBuzz(numberX, numberY, numberN);
                Console.ReadKey();
            }

        }

        /// <summary>
        /// Validates if the numbers triplet we have conform to the limitations ( 1 =< X < Y =< N =<100)
        /// </summary>
        /// <param name="numberX"></param>
        /// <param name="numberY"></param>
        /// <param name="numberN"></param>
        /// <returns></returns>
        static bool ValidateNumbers(byte numberX, byte numberY, byte numberN)
        {
            if ((numberX >= 1 && numberX < numberY) && (numberY <= numberN) && (numberN <= 100))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prints out the FizzBuzz sequence 
        /// </summary>
        /// <param name="numberX"></param>
        /// <param name="numberY"></param>
        /// <param name="numberN"></param>
        static void FizzBuzz(byte numberX, byte numberY, byte numberN)
        {
            if (ValidateNumbers(numberX, numberY, numberN)) // validate if the triplet of numbers conforms to the restrictions given
            {
                for (int i = 1; i <= numberN; i++)
                {
                    if (i % numberX == 0 && i % numberY == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % numberX == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % numberY == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("The triplet of numbers given does not conform to the restrictions given.");
            }
        }
    }
}
