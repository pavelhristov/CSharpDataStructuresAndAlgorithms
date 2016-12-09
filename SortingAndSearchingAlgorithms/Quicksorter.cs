namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private static void QuickSort(IList<T> collection, int low, int high)
        {
            if (low < high)
            {
                var p = Partition(collection, low, high);
                QuickSort(collection, low, p - 1);
                QuickSort(collection, p + 1, high);
            }
        }

        private static int Partition(IList<T> collection, int low, int high)
        {
            var pivot = collection[high];

            var i = low;
            for (int j = low; j < high; j++)
            {
                if (collection[j].CompareTo(pivot) <= 0)
                {
                    Swap(collection, i, j);
                    i++;
                }
            }

            Swap(collection, i, high);
            return i;
        }

        private static void Swap(IList<T> collection, int i, int j)
        {
            var temp = collection[i];
            collection[i] = collection[j];
            collection[j] = temp;
        }
    }
}
