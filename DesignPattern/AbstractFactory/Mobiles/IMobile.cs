using System;

namespace AbstractFactory
{
    public interface IMobile: IDevice
    {
        string DeviceName { get; set; }
    }
}
