using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayOps
{ //insert from rear and delete from front
    public class QueueHelper<T> : IQueueHelper<T>
        where T : class
    {
        private int front, rear;
        private readonly T[] _queue;
        private readonly int _size;

        public QueueHelper(int size)
        {
            _size = size;
            front = rear = 0;
            _queue = new T[size];
        }

        public int Length { get => rear-front; }

        public bool IsEmpty => front == rear;

        public bool Enqueue(T item)
        {
            if (_size == rear) return false; //Queue is full
            _queue[rear] = item;
            rear++;
            return true;
        }

        public T DeQueue()
        {
            if (front == rear) return null; //Queue is empty
            T ele = _queue[rear-1];
            // shift all the elements from index 1 (starting from 0) till rear front by one
            for (int i = 0; i < rear - 1; i++)
            {
                _queue[i] = _queue[i + 1];
            }

            // store null at rear indicating there's no element
            if (rear < _size)
                _queue[rear-1] = null;
            
            // decrement rear
            rear--;
            return ele;
        }

        public T[] Discrete(T[] otherArray)
        {
            throw new NotImplementedException();
        }

        public T[] Distinct()
        {
            throw new NotImplementedException();
        }        

        public T Find(IQueryable<T> query)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T element)
        {
            throw new NotImplementedException();
        }

        public T[] Matching(T[] otherArray)
        {
            throw new NotImplementedException();
        }

        public T[] Merge(T[] otherArray)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            T[] arrToShow = GetArray();

            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            // traverse front to rear and print elements
            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} <-- ", arrToShow[i]);
            }
            return;
        }

        public T[] GetArray()
        {
            T[] arrToShow = new T[rear];
            for (int i = 0; i <= rear; i++)
            {
                if (_queue[i] == null) break;
                arrToShow[i] = _queue[i];
            }
            return arrToShow;
        }
    }
}