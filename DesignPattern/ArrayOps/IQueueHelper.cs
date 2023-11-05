namespace ArrayOps
{
    public interface IQueueHelper<T>: IArrayHelper<T>
        where T : class
    {
        public bool Enqueue(T item);
        public T DeQueue();
    }
}