using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class SortListExamp
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("dfhjlkds", 251);
            sl.Add("wreyur", 768);
            sl.Add("vvvv", 897);
            sl.Add("sfjgg", 2324);
            sl.Add("art", 453);
            Console.WriteLine("display key elements only");
            foreach (string s in sl.Keys)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("display value elements only");
            foreach (int i in sl.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("display sorted list elements");
            foreach(KeyValuePair<string,int> kp in sl)
            {
                Console.WriteLine(kp);
            }
        }
                   
    }
}
