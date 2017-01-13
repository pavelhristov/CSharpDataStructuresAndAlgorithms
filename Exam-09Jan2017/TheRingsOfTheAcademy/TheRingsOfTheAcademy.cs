using System;
using System.Collections.Generic;

namespace TheRingsOfTheAcademy
{
    class TheRingsOfTheAcademy
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] array = new List<int>[n + 1];

            for (int i = 0; i <= n; i++)
            {
                array[i] = new List<int>();
            }

            for (int i = 1; i <= n; i++)
            {
                int parrent = int.Parse(Console.ReadLine());

                array[parrent].Add(i);
            }

            Console.WriteLine(Recursion(array, 0));
        }

        static long Recursion(List<int>[] array, int index)
        {
            if (array[index].Count <= 0)
            {
                return 1;
            }

            long result = 1;
            foreach (var item in array[index])
            {
                result *= Recursion(array, item);
            }

            return result * Factoriel(array[index].Count);
        }

        static long Factoriel(long n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
