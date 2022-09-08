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

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = data[i];
            }

            data = newArray;
        }

        public void Enqueue(T value)
        {
            Count++;
            data[tail] = value;
            if(Count > data.Length)
            {

            }
        }
    }
}
