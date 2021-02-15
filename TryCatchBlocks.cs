using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    class TryCatchBlocks
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1}\t{num2}");
                    Console.WriteLine(num1 / num2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
