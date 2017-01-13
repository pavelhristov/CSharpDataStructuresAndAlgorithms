using System;
using System.Collections.Generic;
using System.Linq;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // 1. Dictionary
            //Dictionary<long, int> occurencies = new Dictionary<long, int>();
            //long current;

            //for (int i = 0; i < n; i++)
            //{
            //    current = long.Parse(Console.ReadLine());
            //    if (!occurencies.ContainsKey(current))
            //    {
            //        occurencies.Add(current, 0);
            //    }

            //    occurencies[current]++;
            //}

            //var result = occurencies.First(x => x.Value % 2 == 1).Key;

            // 2. Binary
            //long result = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    result ^= long.Parse(Console.ReadLine());
            //}

            // 3. SortedDictionary
            //SortedDictionary<long, int> occ = new SortedDictionary<long, int>();
            //long current;

            //for (int i = 0; i < n; i++)
            //{
            //    current = long.Parse(Console.ReadLine());
            //    if (!occ.ContainsKey(current))
            //    {
            //        occ.Add(current, 0);
            //    }

            //    occ[current]++;
            //}

            //var result = occ.First(x => x.Value % 2 == 1).Key;

            // 4. List
            //List<long> list = new List<long>();
            //long current;

            //for (int i = 0; i < n; i++)
            //{
            //    current = long.Parse(Console.ReadLine());

            //    if (list.Contains(current))
            //    {
            //        list.Remove(current);
            //    }
            //    else
            //    {
            //        list.Add(current);
            //    }
            //}

            //var result = list[0];

            // 5. HashSet
            HashSet<long> set = new HashSet<long>();
            long current;

            for (int i = 0; i < n; i++)
            {
                current = long.Parse(Console.ReadLine());

                if (set.Contains(current))
                {
                    set.Remove(current);
                }
                else
                {
                    set.Add(current);
                }
            }

            var result = string.Join(" ", set);

            // 5. 2x HashSet
            //HashSet<long> set2 = new HashSet<long>();
            //HashSet<long> set = new HashSet<long>();
            //long current;

            //for (int i = 0; i < n; i++)
            //{
            //    current = long.Parse(Console.ReadLine());

            //    if (set.Contains(current))
            //    {
            //        set2.Add(current);
            //    }
            //    else
            //    {
            //        set.Add(current);
            //    }
            //}

            //set.SymmetricExceptWith(set2);
            //var result = string.Join(" ", set);

            // 6. LinkedList
            //LinkedList<long> linked = new LinkedList<long>();
            //long current;

            //for (int i = 0; i < n; i++)
            //{
            //    current = long.Parse(Console.ReadLine());
            //    if (!linked.Contains(current))
            //    {
            //        linked.AddLast(current);
            //    }
            //    else
            //    {
            //        linked.Remove(current);
            //    }
            //}

            //var result = linked.First.Value;

            Console.WriteLine(result);
        }
    }
}
