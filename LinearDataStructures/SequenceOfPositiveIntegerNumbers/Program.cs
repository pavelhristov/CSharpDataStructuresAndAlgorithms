using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceOfPositiveIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // I assume each line will contain single number, nothing was specified in the description!

            List<int> numList = Utils.ReadList();

            int sum = 0;
            double average = 0;
            if (numList.Count>0)
            {
                sum = numList.Sum();
                average = numList.Average();
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
