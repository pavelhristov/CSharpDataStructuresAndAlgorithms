namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var value in items)
            {
                if (value.CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            // not looking for range of this item in the list, its asked only to be found

            int startIndex = 0;
            int endIndex = items.Count - 1;
            int middleIndex;
            while (true)
            {
                if (startIndex + 1 == endIndex)
                {
                    return false;
                }

                middleIndex = (startIndex + endIndex) / 2;
                if (item.CompareTo(items[middleIndex]) == 0)
                {
                    // Console.WriteLine(middleIndex);
                    return true;
                }
                else if (item.CompareTo(items[middleIndex]) < 0)
                {
                    endIndex = middleIndex;
                }
                else
                {
                    startIndex = middleIndex;
                }
            }
        }

        public void Shuffle()
        {
            var rng = new Random();
            int n = items.Count;
            for (var i = 0; i < n; i++)
            {
                int r = i + rng.Next(0, n - i);
                var temp = items[i];
                items[i] = items[r];
                items[r] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
