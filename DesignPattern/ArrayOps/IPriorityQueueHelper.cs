namespace ArrayOps
{
    public interface IPriorityQueueHelper<TPriority, TValue>
    {
        public bool Remove(KeyValuePair<TPriority, TValue> item, TValue[][] arr);
        public bool Clear(TValue[][] arr);
        public TValue DeQueue(TValue[][] arr);
        public bool DeQueue(KeyValuePair<TPriority, TValue> item, TValue[][] arr);
    }
}