using AbstractFactory;
using System;

namespace Observer
{
    public class MobileObserver : DeviceObserverAbstract
    {
        public override int DeviceType { get => (int)DeviceEnum.MOBILE; set => DeviceType = value; }
        public override IDevice Notify { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IDevice UpdateDevice(IDevice device)
        {
            if ((device as Device).State == (int)StateEnum.ADDED)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
            return device;
        }
    }
}
