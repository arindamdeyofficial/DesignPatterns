using System;

namespace AbstractFactory
{
    public interface IAbstractFactoryPattern
    {
        IDevice CreateDevice(int deviceType, int deviceModel);
    }
}
