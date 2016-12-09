using Common;
using System;
using System.Collections.Generic;

namespace RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Utils.ReadList();

            numList.RemoveAll(x => x < 0);

            Utils.PrintList(numList);
        }
    }
}
