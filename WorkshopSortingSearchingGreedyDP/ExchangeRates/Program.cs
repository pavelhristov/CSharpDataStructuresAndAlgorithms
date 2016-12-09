using System;
using System.Linq;

namespace ExchangeRates
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal c = decimal.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            decimal lastCurrencyOne = c;

            decimal[] firstCurrencyRates = new decimal[n];
            decimal[] secondCurrencyRates = new decimal[n];

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine().Split(' ');
                firstCurrencyRates[i] = decimal.Parse(current[0]);
                secondCurrencyRates[i] = decimal.Parse(current[1]);

            }

            bool isCurrencyOne = true;
            decimal[] sortedFirst = new decimal[n];
            firstCurrencyRates.CopyTo(sortedFirst, 0);
            sortedFirst = sortedFirst.OrderByDescending(x => x).ToArray();

            decimal[] sortedSecond = new decimal[n];
            secondCurrencyRates.CopyTo(sortedSecond, 0);
            sortedSecond = sortedSecond.OrderByDescending(x => x).ToArray();

            int counterFirst = 0;
            int counterSecond = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (isCurrencyOne)
                {
                    if (firstCurrencyRates[i] != sortedFirst[counterFirst])
                    {
                        continue;
                    }
                    else
                    {
                        c *= firstCurrencyRates[i];
                        isCurrencyOne = false;
                        counterFirst++;
                    }
                }
                else
                {
                    if (secondCurrencyRates[i] != sortedSecond[counterSecond])
                    {
                        continue;
                    }
                    else
                    {
                        c *= secondCurrencyRates[i];
                        lastCurrencyOne = Math.Max(lastCurrencyOne, c);
                        isCurrencyOne = true;
                        counterSecond++;
                    }
                }
            }


            Console.WriteLine("{0:F2}", lastCurrencyOne);
        }
    }
}
