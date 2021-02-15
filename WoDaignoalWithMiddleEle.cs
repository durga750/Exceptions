using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class WoDaignoalWithMiddleEle
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i==1 && j == 1)
                    {
                        Console.Write(a[i, j] );
                    }
                    if(i==j || i+j==2)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
