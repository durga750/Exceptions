using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class RemoveSListEle
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("dfhj", 251);
            sl.Add("wreyur", 768);
            sl.Add("vv", 897);
            sl.Add("sfjgg", 2324);
            sl.Add("art", 453);
            foreach(KeyValuePair<string,int> sr in sl)
            {
                Console.WriteLine(sr);
            }
            Console.WriteLine("=======sortedList Elements===========" );
            foreach(string s in sl.Keys)
            {
                Console.WriteLine($"{s} \t {sl[s]}");
            }
            Console.WriteLine("==============================================");
            if(sl.ContainsKey("vv"))
            {
                Console.WriteLine(sl["vv"]);
            }
            Console.WriteLine(sl.Remove("art"));
            Console.WriteLine("=====after removing key===========");
            foreach (KeyValuePair<string, int> sr in sl)
            {
                Console.WriteLine(sr);
            }
        }
    }
}
