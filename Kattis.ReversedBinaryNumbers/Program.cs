using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.ReversedBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int inputNum = scan.NextInt();
            string inputBinary = Convert.ToString(inputNum, 2);
            string resultBinary = ReverseString(inputBinary);
            int resultInt = ConvertS(resultBinary);

            Console.Clear();
            Console.WriteLine(resultInt); ;
            Console.ReadKey();
        }

        // method to reverse a string
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// convert a binary string to an integer without using the Convert.ToInt32 class
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ConvertS(string s)
        {
            if (s == "")
                throw new Exception("Invalid input");

            int OnOff = 0;
            int result = 0;

            //Loop through each character in the passed string
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    //Parse each char of the passed string
                    OnOff = Int32.Parse(s[i].ToString());

                    //If the char is a 1, add 2^(the position it's in) to the result
                    if (OnOff == 1)
                        result += (int)Math.Pow(2, s.Length - 1 - i);

                    else if (OnOff > 1)
                        throw new Exception("Invalid input");
                }
                catch
                {
                    throw new Exception("Invalid input");
                }
            }
            return result;
        }
    }
}
