using System;

namespace AbstractFactory
{
    public abstract class Mobile : IMobile
    {
        public string DeviceType { get => DeviceEnum.MOBILE.ToString(); set => DeviceType = value; }
        public abstract string DeviceName { get; set; }
    }
}
