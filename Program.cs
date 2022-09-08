using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> LinkedList = new LinkedQueue<int>();

            LinkedList.Enqueue(40);
            LinkedList.Enqueue(10);
            LinkedList.Enqueue(80);
            LinkedList.Enqueue(60);

            LinkedList.Dequeue();
            LinkedList.Dequeue();

            int peek = LinkedList.Peek();
            ;
        }
    }
}
