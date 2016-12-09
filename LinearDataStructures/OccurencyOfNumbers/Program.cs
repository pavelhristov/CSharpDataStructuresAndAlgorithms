using System;
using System.Collections.Generic;

namespace OccurencyOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Dictionary<int, int> occurency = new Dictionary<int, int>();

            foreach (var item in array)
            {
                if (occurency.ContainsKey(item))
                {
                    occurency[item]++;
                }
                else
                {
                    occurency.Add(item, 1);
                }
            }

            foreach (var item in occurency)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }


        }
    }
}
