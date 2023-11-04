using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
namespace ArrayOps
{
    public class StackHelper<T> : IStackHelper<T>
        where T : class, new()
    {
        private readonly int _size;
        private int top;
        private readonly T[] _stack;
        public StackHelper(int size) 
        {
            _size = size;
            top = -1;
            _stack = new T[size];
        }
        public int Length { get => top; }

        public bool IsEmpty => top < 0;

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

        public bool Push(T data)
        {
            if (top >= _size) return false;
            else
            {
                _stack[++top] = data;
                return true;
            }
        }

        public T Pop()
        {
            if (top < 0) return null;
            else
            {
                return _stack[top--];
            }
        }

        public T Peek()
        {
            if (top < 0) return null;
            else
                return _stack[top];
        }

        public void Print()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(_stack[i]);
                }
            }
        }
    }
}