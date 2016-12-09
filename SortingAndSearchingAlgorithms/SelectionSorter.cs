namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count -1; i++)
            {
                var maxIndex = i;
                for (int j = i+1; j < collection.Count; j++)
                {
                    if (collection[i].CompareTo( collection[j])== 1)
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    var temp = collection[i];
                    collection[i] = collection[maxIndex];
                    collection[maxIndex] = temp;
                }
            }
        }
    }
}
