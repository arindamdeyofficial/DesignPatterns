using AbstractFactory;
using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class DeviceObserverAbstract : IDeviceObserver
    {
        public abstract int DeviceType { get; set; }
        public StateEnum State { get; set; } = StateEnum.UPDATENOTREQUIRED;
        private List<ISimpleObserver> _observers = new List<ISimpleObserver>();
        public void Attach(ISimpleObserver observer)
        {
            _observers.Add(observer);
        }
        public void Detach(ISimpleObserver observer)
        {
            _observers.Remove(observer);
        }

        // Trigger an update in each subscriber.
        public abstract IDevice Notify { get; set; }
    }
}
