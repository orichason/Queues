using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> linkedList = new LinkedQueue<int>();

            ArrayQueue<int> arrayQueue = new ArrayQueue<int>();

            arrayQueue.Enqueue(10);
            arrayQueue.Enqueue(15);
            arrayQueue.Enqueue(20);

            Deque(arrayQueue, 2);

            arrayQueue.Enqueue(30);
            arrayQueue.Enqueue(90);
            arrayQueue.Enqueue(87);

            arrayQueue.Enqueue(10);
            arrayQueue.Enqueue(15);
            arrayQueue.Enqueue(20);

            ;
        }

        public static void Deque<T>(ArrayQueue<T> queue, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
