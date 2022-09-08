using System;
using System.Collections.Generic;
using System.Linq;

namespace Queues
{
    public class LinkedQueue<T>
    {
        public int Count { get; private set; }
        private LinkedList<T> data;

        public LinkedQueue()
        {
            Count = 0;
            data = new LinkedList<T>();
        }

        public void Enqueue (T value)
        {
            data.AddLast(value);
            Count++;
        }

        public T Dequeue()
        {
            data.RemoveFirst();
            Count--;

            return data.First();
        }

        public T Peek()
        {
            return data.First();
        }

        public bool IsEmpty()
        {
            if(data.First().Equals(null))
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            data.Clear();
        }
    }
}
