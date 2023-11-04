using AbstractFactory;
using System;

namespace Observer
{
    public class ObserverPattern : IObserverPattern
    {
        public IDevice CreateDevice(int deviceType, int model)
        {
            IDevice device;
            switch (deviceType)
            {
                case 0:
                default:
                    device = new Device();
                    break;
            }
            return device;
        }
    }
}
