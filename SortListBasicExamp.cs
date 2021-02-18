using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class SortListBasicExamp
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(12, "hjkl");
            sl.Add(34, "bnm");
            sl.Add(7, "ytey");               //<keys,values> 
            sl.Add(87, "aghfjj");            //keys may not be duplicate but values be duplicate
            sl.Add(6, "tey");
            sl.Add(67, "tey");
            foreach (object ob in sl)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
