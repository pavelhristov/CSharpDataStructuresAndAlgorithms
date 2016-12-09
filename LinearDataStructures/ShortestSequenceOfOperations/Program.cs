using System;
using System.Collections.Generic;

namespace ShortestSequenceOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);

            while (M > N)
            {
                if (M / 2 > N)
                {
                    N = N * 2;
                }
                else if (M - 2 > N)
                {
                    N = N + 2;
                }
                else if (M - 1 > N)
                {
                    N = N + 1;
                }
                else
                {
                    break;
                }

                queue.Enqueue(N);
            }

            Console.WriteLine(string.Join("->", queue));
        }
    }
}
