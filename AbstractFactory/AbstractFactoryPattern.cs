using System;

namespace AbstractFactory
{
    public class AbstractFactoryPattern : IAbstractFactoryPattern
    {        
        public IDevice CreateDevice(string deviceType)
        {
            DeviceEnum deviceTypeEnum;
            if (Enum.TryParse(deviceType.ToUpper(), out deviceTypeEnum)) deviceTypeEnum = DeviceEnum.NODEVICE;
            switch (deviceTypeEnum)
            {
                case DeviceEnum.DESKTOP:
                    return new Desktop();
                case DeviceEnum.MOBILE:
                    return new Mobile();
                case DeviceEnum.LAPTOP:
                    return new Laptop();
                case DeviceEnum.TABLET:
                    return new Tablet();
                default:
                    return new NoDevice();
            }
        }
    }
}
