using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class DaignoalsOfMatrix
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    else if (i + j == 2)
                    {
                        Console.Write(a[i, j] + "\t");

                    }
                    else
                    {
                        Console.Write( "\t");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
