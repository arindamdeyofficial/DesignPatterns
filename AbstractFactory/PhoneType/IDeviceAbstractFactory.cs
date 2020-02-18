using System;

namespace AbstractFactory
{
    public interface IDeviceAbstractFactory
    {
        IDevice CreateDevice(string deviceType);
    }
}
