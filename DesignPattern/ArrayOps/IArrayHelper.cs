using System.ComponentModel.DataAnnotations;

namespace ArrayOps
{
    //        FIFO(first in = first out) is a queue, a list where you add things at the tail and remove them from the head.
    //        (LIFO (last in = first out) is a stack, where you both add and remove from the top.)

    //A(max) heap is, compared to these, a very strange beast.You put things in a vaguely descending order, with the
    //nth element always greater than or equal to the ones at 2n and 2n+1 (if they exist). Then you remove things(successive maximum values)
    //from the apex(element 1) and add more things to be sorted at the base/end.After every operation, you promote internal elements
    //if it is necessary to maintain the relative order.By keeping it relatively, rather than completely, ordered, you can use it
    //to sort things with minimal wasted time.
    //        One of the uses for such a thing, other than a complete sort, is a simple priority ‘queue’. New items enter,
    //        with various levels of importance.You always pick the most important one first, but new data is free to arrive
    //        without making you sort all over from scratch.
    public interface IArrayHelper<T>
        where T : class, new()
    {
        public int Length { get; }
        public bool IsEmpty { get;}
        public T Find(IQueryable<T> query);
        public T[] Merge(T[] otherArray);
        public T[] Matching(T[] otherArray);
        public T[] Discrete(T[] otherArray);
        public T[] Distinct();
        public int IndexOf(T element);
        public void Print();
    }
}