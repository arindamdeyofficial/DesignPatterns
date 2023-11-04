using AbstractFactory;
using System;

namespace Observer
{
    public class SimpleObserver: ISimpleObserver
    {
        public IDevice UpdateDevice(IDevice device)
        {
            //if ((subject as Subject).State < 3)
            //{
            //    Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            //}
            return device;
        }
    }
}
