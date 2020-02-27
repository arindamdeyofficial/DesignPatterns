using System;

namespace AbstractFactory
{
    public abstract class Desktop : IDesktop
    {
        public string DeviceType { get => DeviceEnum.DESKTOP.ToString(); set => DeviceType = value; }
        public abstract string DeviceName { get; set; }
    }
}
