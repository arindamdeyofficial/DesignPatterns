using System;

namespace AbstractFactory
{
    public abstract class DeviceFactoryAbstract
    {
        public abstract IDevice Device { get; set; }
        public string SalesChannel { get => "Amazon"; set => SalesChannel = value; }
    }
}
