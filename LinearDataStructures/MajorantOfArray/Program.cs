using System;
using System.Collections.Generic;

namespace MajorantOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
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
                if (item.Value >= ((array.Length/2) + 1))
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
