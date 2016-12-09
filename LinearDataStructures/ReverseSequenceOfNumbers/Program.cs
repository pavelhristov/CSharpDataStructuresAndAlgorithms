using System;
using System.Collections.Generic;

namespace ReverseSequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackedNumbers = new Stack<int>();
            while (true)
            {
                string currentLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(currentLine))
                {
                    break;
                }

                int currentNumber;
                if (!int.TryParse(currentLine, out currentNumber))
                {
                    Console.WriteLine("Invalid number input!");
                    return;
                }

                stackedNumbers.Push(currentNumber);
            }

            while (stackedNumbers.Count>0)
            {
                int currentNum = stackedNumbers.Pop();
                Console.WriteLine(currentNum);
            }
        }
    }
}
