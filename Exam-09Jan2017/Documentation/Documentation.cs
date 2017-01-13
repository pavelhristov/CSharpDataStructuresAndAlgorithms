using System;
using System.Text;

namespace Documentation
{
    class Documentation
    {
        static void Main()
        {
            //string word = Console.ReadLine().ToLower();
            //StringBuilder builder = new StringBuilder();

            //foreach (var ch in word)
            //{
            //    if ('a' <= ch && ch <= 'z')
            //    {
            //        builder.Append(ch);
            //    }
            //}

            //char[] chars = builder.ToString().ToCharArray();
            //int length = chars.Length;
            int counter = 0;


            //for (int i = 0; i < length / 2; i++)
            //{
            //while (chars[i] != chars[length - i - 1])
            //{
            //    if (chars[i] > chars[length - i - 1])
            //    {
            //        if (Math.Abs(chars[i] - chars[length - i - 1]) < 13)
            //        {
            //            chars[i]--;
            //        }
            //        else
            //        {
            //            chars[i]++;
            //            if (chars[i] > 'z')
            //            {
            //                chars[i] = 'a';
            //            }
            //        }
            //        counter++;
            //    }
            //    else if (chars[i] < chars[length - i - 1])
            //    {
            //        if (Math.Abs(chars[i] - chars[length - i - 1]) < 13)
            //        {
            //            chars[i]++;
            //        }
            //        else
            //        {
            //            chars[i]--;
            //            if (chars[i] < 'a')
            //            {
            //                chars[i] = 'z';
            //            }
            //        }
            //        counter++;
            //    }
            //}
            //}


            char[] chars = Console.ReadLine().ToLower().ToCharArray();
            int i = 0;
            int j = chars.Length - 1;

            while (i < j)
            {
                while (!char.IsLetter(chars[i]))
                {
                    i++;
                }
                while (!char.IsLetter(chars[j]))
                {
                    j--;
                }
                while (chars[i] != chars[j])
                {
                    if (chars[i] > chars[j])
                    {
                        if (Math.Abs(chars[i] - chars[j]) < 13)
                        {
                            chars[i]--;
                        }
                        else
                        {
                            chars[i]++;
                            if (chars[i] > 'z')
                            {
                                chars[i] = 'a';
                            }
                        }
                        counter++;
                    }
                    else if (chars[i] < chars[j])
                    {
                        if (Math.Abs(chars[i] - chars[j]) < 13)
                        {
                            chars[i]++;
                        }
                        else
                        {
                            chars[i]--;
                            if (chars[i] < 'a')
                            {
                                chars[i] = 'z';
                            }
                        }
                        counter++;
                    }
                }

                j--;
                i++;
            }

            Console.WriteLine(counter);
        }
    }
}
