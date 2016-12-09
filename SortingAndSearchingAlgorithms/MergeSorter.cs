namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            // was not able to figure out how to keep the reference to original collection while cutting it into pieces, 
            // thought about passing indexes but implementation was looking a lot more like quick sort.
            // Will be happy to hear any suggestions.

            Console.WriteLine(string.Join("-",MergeSort(collection)));
        }

        private static IList<T> MergeSort(IList<T> collection)
        {
            if (collection.Count < 2)
            {
                return collection;
            }
            
            IList<T> left = new List<T>();
            IList<T> right = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (i < collection.Count/2)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);
            
            return Merge(left, right);
        }
        
        private static IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> result = new List<T>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].CompareTo(right[0]) <= 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }
    }
}
