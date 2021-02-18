using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class StackPro
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            Console.WriteLine("all elements in stack:");
            s.Push("zdurga");
            s.Push("mule");
            s.Push("koti");
            s.Push("kavya");
            foreach(string ss in s)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine("count no of elements in stack:"+s.Count());
            Console.WriteLine ("pop element is:"+s.Pop());
            Console.WriteLine("count no of elements after pop in stack:" + s.Count());
            foreach (string ss in s)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine ("max ele in stack is :"+s.Max<string>());
            Console.WriteLine("min ele in stack is :" + s.Min<string>());
        }
    }
}
