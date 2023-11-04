using AbstractFactory;
using System;

namespace Observer
{
    public interface IDeviceObserver
    {
        // Attach an observer to the subject.
        void Attach(ISimpleObserver observer);

        // Detach an observer from the subject.
        void Detach(ISimpleObserver observer);

        // Notify all observers about an event.
        IDevice Notify { get; set; }
    }
}
