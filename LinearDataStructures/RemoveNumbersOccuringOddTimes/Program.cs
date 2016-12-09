using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNumbersOccuringOddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Utils.ReadList();
            Dictionary<int, int> occurency = new Dictionary<int, int>();

            foreach (var item in numList)
            {
                if (occurency.ContainsKey(item))
                {
                    occurency[item]++;
                }
                else
                {
                    occurency.Add(item, 1);
                }
            }

            foreach (var item in occurency)
            {
                if (item.Value % 2 == 1)
                {
                    numList.RemoveAll(x => x == item.Key);
                }
            }

            Utils.PrintList(numList);
        }
    }
}
