using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
namespace ArrayOps
{
    public class QueueHelper<T> : IQueueHelper<T>
        where T : class, new()
    {
        public int Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsEmpty => throw new NotImplementedException();

        public T DeQueue(T[] arr)
        {
            throw new NotImplementedException();
        }

        public T[] Discrete(T[] otherArray)
        {
            throw new NotImplementedException();
        }

        public T[] Distinct()
        {
            throw new NotImplementedException();
        }

        public bool Enqueue(T[] arr)
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
            throw new NotImplementedException();
        }
    }
}