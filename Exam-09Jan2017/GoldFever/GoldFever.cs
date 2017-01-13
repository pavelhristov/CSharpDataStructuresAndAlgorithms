using System;
using System.Linq;

namespace GoldFever
{
    class GoldFever
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var rates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int goldOwned = 0;
            long profit = 0;
            long lose = 0;

            Console.WriteLine(Recursion(profit, lose, goldOwned, rates, 0));
        }

        static double Recursion(long profit, long lose, int goldOwned, int[] rates, int day)
        {
            if (day >= rates.Length)
            {
                return profit - lose;
            }

            return Math.Max(Math.Max(Recursion(profit + goldOwned * rates[day], lose, 0, rates, day + 1),
                Recursion(profit, lose + rates[day], goldOwned + 1, rates, day + 1)),
                Recursion(profit, lose, goldOwned, rates, day + 1));
        }
    }
}
