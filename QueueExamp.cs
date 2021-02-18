using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class QueueExamp    //FIFO
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            Console.WriteLine("count no of elements in queue are :"+ q.Count()); //0 bcz empty queue
            Console.WriteLine("no of elements in queue:");
            q.Enqueue(3425);
            q.Enqueue(123);
            q.Enqueue(12);
            q.Enqueue(654748);
            q.Enqueue(2);
            foreach(int i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count no of elements in queue are :" + q.Count());   //5 bcz ele in queue
            Console.WriteLine( "remove ele in queue is :"+(q.Dequeue()));
            Console.WriteLine("elements in queue after removeing ele:");
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count no of elements in queue after removeing :" + q.Count());
        }
    }
}
