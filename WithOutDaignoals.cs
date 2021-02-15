using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class WithOutDaignoals
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write("\t");
                    }
                    else if (i + j == 2)
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
