using System;
namespace Queues
{
    public class ArrayQueue<T>
    {
        public int Count { get; private set; }
        private T[] data;
        private int head;
        private int tail;

        public ArrayQueue()
        {
            Count = 0;
            data = new T[4];
            head = 0;
            tail = 0;
        }

        private void Resize()
        {
            T[] newArray = new T[data.Length * 2];

            for (int i = 0; i < data.Length; i++)
            {
                int current = (i + head) % data.Length;
                newArray[i] = data[current];
            }
            head = 0;
            tail = data.Length;

            data = newArray;
        }

        public void Enqueue(T value)
        {
            if (!IsEmpty() && tail == head)
            {
                Resize();
            }

            data[tail] = value;
            tail = (tail + 1) % data.Length;
            Count++;
        }

        public T Dequeue ()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("fuck off");
            }
            T headData = data[head];

            head = (head + 1) % data.Length;
            Count--;

            return headData;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
