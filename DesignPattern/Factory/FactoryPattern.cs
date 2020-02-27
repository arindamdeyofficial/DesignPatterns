using Factory;
using System;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryPattern: IFactoryPattern
    {        
        public IDevice CreateDevice(int deviceType)
        {
            switch (deviceType)
            {
                case 2:
                    return new Desktop();
                case 3:
                    return new Mobile();
                case 1:
                    return new Laptop();
                case 4:
                    return new Tablet();
                default:
                    return new NoDevice();
            }
        }
    }
}
