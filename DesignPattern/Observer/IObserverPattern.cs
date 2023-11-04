using AbstractFactory;
using System;

namespace Observer
{
    public interface IObserverPattern
    {
        IDevice CreateDevice(int deviceType, int model);
    }
}
