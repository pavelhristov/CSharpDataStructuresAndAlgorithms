using System;
using System.Linq;

namespace Swapping
{
    class Swapping
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            WeirdStructure wtf = new WeirdStructure();

            for (int i = 1; i <= n; i++)
            {
                wtf.Add(new Node(i));
            }

            foreach (var item in numbers)
            {
                wtf.Swap(item);
            }

            Console.WriteLine(wtf.ToString(n));
        }

        class Node
        {
            private Node left;
            private Node right;
            private int value;

            public Node(int value)
            {
                this.Left = null;
                this.Right = null;
                this.Value = value;
            }

            public Node Left
            {
                get
                {
                    return left;
                }

                set
                {
                    left = value;
                }
            }

            public Node Right
            {
                get
                {
                    return right;
                }

                set
                {
                    right = value;
                }
            }

            public int Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }
        }

        class WeirdStructure
        {
            // more like custom LinkedList with required functionality
            private Node start;
            private Node end;

            public WeirdStructure()
            {
                this.start = null;
                this.end = null;
            }

            public void Add(Node element)
            {
                if (this.start == null)
                {
                    this.start = element;
                }
                else
                {
                    this.end.Right = element;
                }

                element.Left = this.end;
                this.end = element;
            }

            public void Swap(int number)
            {
                Node found = Find(number);
                if (found == null)
                {
                    throw new ArgumentNullException("Value not found!");
                }

                Node currentRight = found.Right;
                Node currentLeft = found.Left;

                this.end.Right = found;
                this.start.Left = found;

                found.Left = this.end;
                found.Right = this.start;

                if (currentLeft != null)
                {
                    this.end = currentLeft;
                }
                else
                {
                    this.end = found;
                }

                if (currentRight != null)
                {
                    this.start = currentRight;
                }
                else
                {
                    this.start = found;
                }

                this.start.Left = null;
                this.end.Right = null;

            }

            private Node Find(int number)
            {
                if (this.start == null)
                {
                    return null;
                }

                Node currentLeft = this.start;
                Node currentRight = this.end;

                while (true)
                {
                    if (currentLeft.Value == number)
                    {
                        return currentLeft;
                    }
                    if (currentLeft.Right == null)
                    {
                        return null;
                    }

                    currentLeft = currentLeft.Right;

                    if (currentRight.Value == number)
                    {
                        return currentRight;
                    }
                    if (currentRight.Left == null)
                    {
                        return null;
                    }

                    currentRight = currentRight.Left;
                }
            }

            public string ToString(int length)
            {
                var currentLeft = this.start;
                var currentRight = this.end;
                int[] array = new int[length];

                for (int i = 0, j = length - 1; i < length / 2 && j >= length / 2; i++, j--)
                {
                    if (currentLeft != null)
                    {
                        array[i] = currentLeft.Value;
                    }

                    if (currentRight != null)
                    {
                        array[j] = currentRight.Value;
                    }

                    if (currentLeft.Right != null && currentRight.Left != null)
                    {
                        currentLeft = currentLeft.Right;
                        currentRight = currentRight.Left;
                    }
                    else
                    {
                        break;
                    }
                }

                return string.Join(" ", array);
            }
        }
    }
}
