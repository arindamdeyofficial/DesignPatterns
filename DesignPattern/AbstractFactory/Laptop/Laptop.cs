using System;

namespace AbstractFactory
{
    public abstract class Laptop : ILaptop
    {
        public string DeviceType { get => DeviceEnum.LAPTOP.ToString(); set => DeviceType = value; }
        public abstract string DeviceName { get; set; }
    }
}
