using System;

namespace AbstractFactory
{
    public class AbstractFactoryPattern : IAbstractFactoryPattern
    {        
        public IDevice CreateDevice(int deviceType, int deviceModel)
        {
            IDevice device;
            DeviceFactoryAbstract factory;
            switch (deviceType)
            {
                case 2:
                    factory = new DesktopFactory(deviceModel); 
                    device = factory.Device;
                    break;
                case 3:
                    factory = new MobileFactory(deviceModel);
                    device = factory.Device; 
                    break;
                case 1:
                    factory = new LaptopFactory(deviceModel);
                    device = factory.Device; 
                    break;
                default:
                    factory = new DesktopFactory(deviceModel);
                    device = factory.Device; 
                    break;
            }
            return device;
        }
    }
}
