using System;
using System.Collections.Generic;

namespace Passwords
{
    class Program
    {
        static string numbers = "1234567890";

        static char left = '<';
        static char right = '>';
        static char stay = '=';
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string directions = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string currentPass = string.Empty;
            bool flag = true;
            int indexLeft = 1;
            int indexRight = 1;
            int index = 1;
            int length = 1;
            List<string> possiblePasswords = new List<string>();
            var temp = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int counter = 0;

            foreach (var dir in directions)
            {
                length++;
                counter = temp.Count;
                //currentPass = string.Empty + numbers[i];
                //flag = true;
                for (int m = 0; m < counter; m++)
                {
                    for (int j = int.Parse(temp[m]) % 10 - 1; j < 10; j++)
                    {
                        int pointer = j;
                        if (pointer < 0 || pointer > 9)
                        {
                            break;
                        }
                        if (dir == left)
                        {
                            pointer -= index;
                        }
                        else if (dir == right)
                        {
                            pointer += index;
                        }
                        if (pointer < 0 || pointer > 9)
                        {
                            break;
                        }
                        temp.Add(temp[m] + numbers[pointer]);
                    }
                }

                temp.RemoveAll(x => x.Length < length);
                // currentPass += possibilities(currentPass, pointer, dir, indexLeft, indexRight);
            }

            //if (flag && !possiblePasswords.Contains(currentPass) && currentPass.Length == n)
            //{
            //    possiblePasswords.Add(currentPass);
            //}
            //possiblePasswords.Sort();
            //Console.WriteLine(possiblePasswords[k - 1]);

            //temp.ForEach(Console.WriteLine);
            Console.WriteLine(temp.Contains("0112665"));
        }

        static string possibilities(string currentPass, int pointer, char dir, int indexLeft, int indexRight)
        {
            if (dir == left)
            {
                pointer -= indexLeft;
            }
            else if (dir == right)
            {
                pointer += indexRight;
            }

            if (pointer < 0 || pointer > 9)
            {
                return string.Empty;
            }

            return numbers[pointer].ToString();
        }
    }
}
