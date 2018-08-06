using System;
using static Kattis.Shared.KattisIO;

namespace Kattis.Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scan = new Scanner();

            int monthlyData = scan.NextInt();
            int firstMonths = scan.NextInt();
            int dataSpentThisMonth = 0;
            int dataLeft = 0;

            int totalDataAvailable = monthlyData;

            for (int month = 1; month <= firstMonths; month++)
            {
                dataSpentThisMonth = scan.NextInt();
                dataLeft = totalDataAvailable - dataSpentThisMonth;
                totalDataAvailable = monthlyData + dataLeft;
            }

            Console.Clear();
            Console.WriteLine(totalDataAvailable);
            Console.ReadKey();
        }
    }
}
