using System;

namespace Factory
{
    public class Desktop : IDevice
    {
        public string DeviceType { get => DeviceEnum.DESKTOP.ToString(); set => DeviceType=value; }
    }
}
