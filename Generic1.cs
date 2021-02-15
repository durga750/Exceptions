using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Gen<T>
    {
        public void display(T x,T y)
        {
            Console.WriteLine($"x={x}\t y={y}");
        }
    }
    class Generic1
    {
        static void Main(string[] args)
        {
            Gen<int> p = new Gen<int>();
            p.display(2, 3);
            Gen<float> b = new Gen<float>();
            b.display(2.3f, 45.7f);

        }
    }
}
