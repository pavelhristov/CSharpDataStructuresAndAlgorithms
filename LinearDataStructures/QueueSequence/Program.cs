using Common;
using System;
using System.Collections.Generic;

namespace QueueSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);
            int[] result = new int[50];

            int currentNum = N;

            for (int i = 0; i < 50; i++)
            {
                currentNum = queue.Dequeue();

                queue.Enqueue(currentNum + 1);
                queue.Enqueue(2 * currentNum + 1);
                queue.Enqueue(currentNum + 2);

                result[i] = currentNum;
            }

            Utils.PrintArray(result);
        }
    }
}
