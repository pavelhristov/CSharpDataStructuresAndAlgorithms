using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Utils
    {
        public static List<int> ReadList()
        {

            List<int> numList = new List<int>();

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
                    throw new ArgumentException("Invalid number input!");
                }

                numList.Add(currentNumber);
            }

            return numList;
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
