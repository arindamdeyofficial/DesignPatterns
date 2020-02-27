using System;

namespace Factory
{
    public class Tablet : IDevice
    {
        public string DeviceType { get => DeviceEnum.TABLET.ToString(); set => DeviceType = value; }
    }
}
