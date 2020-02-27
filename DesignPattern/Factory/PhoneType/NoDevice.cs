using System;

namespace Factory
{
    public class NoDevice : IDevice
    {
        public string DeviceType { get => DeviceEnum.NODEVICE.ToString(); set => DeviceType = value; }
    }
}
