using System;

namespace AbstractFactory
{
    public class LaptopFactory : DeviceFactoryAbstract
    {
        private int LaptopType { get;set;}
        public LaptopFactory(int laptopType)
        {
            LaptopType = laptopType;
        }
        public override IDevice Device { 
            get                
                {
                IDevice device;
                switch (LaptopType)
                {
                    case 0:
                        device = new ALIENWARE();break;
                    case 1:
                        device = new DELL(); break;
                    case 2:
                        device = new HP(); break;
                    default:
                        device = new ALIENWARE(); break;
                };
                return device;
            }
        set => Device=value; }
    }
}
