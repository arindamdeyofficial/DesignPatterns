namespace ArrayOps
{
    public interface IStackHelper<T>: IArrayHelper<T>
        where T : class
    {
        public bool Push(T ele);
        public T Pop();
        public T Peek();
    }
}