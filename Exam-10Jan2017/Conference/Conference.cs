using System;
using System.Collections.Generic;
using System.Linq;

namespace Conference
{
    class Conference
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];
            int total = 0;

            List<HashSet<int>> list = new List<HashSet<int>>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                HashSet<int> hash1 = null,
                    hash2 = null;

                foreach (var item in list)
                {
                    if (item.Contains(input[0]))
                    {
                        hash1 = item;
                    }
                    if (item.Contains(input[1]))
                    {
                        hash2 = item;
                    }
                }
                
                if (hash1 == null && hash2 == null)
                {
                    hash1 = new HashSet<int>();
                    hash1.Add(input[0]);
                    hash1.Add(input[1]);
                    list.Add(hash1);
                    total += 2;
                }
                else if (hash1 == null)
                {
                    hash2.Add(input[0]);
                    total++;
                }
                else if (hash2 == null)
                {
                    hash1.Add(input[1]);
                    total++;
                }
                else
                {
                    if (hash1 != hash2)
                    {
                        list.Remove(hash2);
                        hash1.UnionWith(hash2);
                    }
                }
            }
            
            long variants = 0;
            for (int i = 0; i < list.Count + n - total - 1; i++)
            {
                int currentCount;
                if (i < list.Count)
                {
                    currentCount = list[i].Count;
                }
                else
                {
                    currentCount = 1;
                }
                for (int j = i + 1; j < list.Count + n - total; j++)
                {
                    int secondCount;
                    if (j < list.Count)
                    {
                        secondCount = list[j].Count;
                    }
                    else
                    {
                        secondCount = 1;
                    }

                    variants += currentCount * secondCount;
                }
            }

            Console.WriteLine(variants);
        }
    }
}
