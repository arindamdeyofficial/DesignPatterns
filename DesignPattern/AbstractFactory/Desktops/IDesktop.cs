using System;

namespace AbstractFactory
{
    public interface IDesktop: IDevice
    {
        string DeviceName { get; set; }
    }
}
