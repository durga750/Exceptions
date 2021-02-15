using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    class ValidForVote:Exception
    {
        public ValidForVote()
        {
           
            Console.WriteLine("not eligible for vote");
        }
    }
    class UserdefinedExce
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter a age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    throw new ValidForVote();
                }
                else
                {
                    Console.WriteLine("eligible for vote");
                }
            }
        }
    }

}
