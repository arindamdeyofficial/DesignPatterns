namespace ArrayOps
{
    public interface IQueueHelper<T>: IArrayHelper<T>
        where T : class, new()
    {
        public bool Enqueue(T[] arr);
        public T DeQueue(T[] arr);
    }
}