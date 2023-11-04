using AbstractFactory;

namespace Observer
{
    internal class Device : IDevice
    {
        public int State { get; internal set; }
        public string DeviceType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}