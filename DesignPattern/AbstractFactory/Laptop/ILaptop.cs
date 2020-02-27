using System;

namespace AbstractFactory
{
    public interface ILaptop : IDevice
    {
        string DeviceName { get; set; }
    }
}
