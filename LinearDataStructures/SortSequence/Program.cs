using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Utils.ReadList();

            numList.Sort();
            Console.WriteLine(string.Join(Environment.NewLine,numList));
        }
    }
}
