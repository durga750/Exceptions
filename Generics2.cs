using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Gen<A1,A2>
    {
        public void show(A1 a,A2 b)
        {
            Console.WriteLine($"{a}\t{b}");
        }
    }
    class Generics2
    {
        static void Main(string[] args)
        {
            Gen<bool, int> i = new Gen<bool, int>();
            i.show(true, 43);

            Gen<float, double> j = new Gen<float, double>();
            j.show(4.5f, 4.3);

            Gen<double, string> k = new Gen<double, string>();
            k.show(6.7,"Durga ");

        }
    }
}
