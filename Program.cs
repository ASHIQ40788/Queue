using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(56);
            queue1.Enqueue(30);
            queue1.Enqueue(70);

            foreach(int num in queue1)
            {
                Console.WriteLine(num);
            }

            queue1.Dequeue();
            Console.WriteLine("After delete");
            foreach (int num in queue1)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();


        }
    }
}
