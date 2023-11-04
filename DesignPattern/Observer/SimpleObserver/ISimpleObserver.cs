using AbstractFactory;
using System;

namespace Observer
{
    public interface ISimpleObserver
    {
        IDevice UpdateDevice(IDevice device);
    }
}
