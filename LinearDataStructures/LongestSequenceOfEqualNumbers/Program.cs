using Common;
using System.Collections.Generic;
using System.Linq;

namespace LongestSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 1, 3, 4, 5, 3, 3, 3, 1, 7, 6, 1, 2, 2, 2, 1 };

            List<int> resultList = FindLongestSequenceOfEqualNumbers(numList);


            Utils.PrintList(numList);
        }

        public static List<int> FindLongestSequenceOfEqualNumbers(IList<int> list)
        {
            List<int> resultList = new List<int>();
            List<int> tempList = new List<int>() { list[0] };

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == tempList[0])
                {
                }
                else if (tempList.Count <= resultList.Count)
                {
                    tempList.RemoveRange(0, tempList.Count);
                }
                else
                {
                    resultList = tempList.ToList();
                    tempList.RemoveRange(0, tempList.Count);
                }

                tempList.Add(list[i]);
            }

            return resultList;
        }
    }
}
