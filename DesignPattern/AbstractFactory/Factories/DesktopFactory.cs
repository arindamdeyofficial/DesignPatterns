using System;

namespace AbstractFactory
{
    public class DesktopFactory : DeviceFactoryAbstract
    {
        private int DesktopType { get;set;}
        public DesktopFactory(int desktopType)
        {
            DesktopType = desktopType;
        }
        public override IDevice Device { 
            get                
                {
                IDevice device;
                switch (DesktopType)
                {
                    case 0:
                        device = new SAMSUNGI3();break;
                    case 1:
                        device = new MACBASIC(); break;
                    case 2:
                        device = new ASSEMBELED(); break;
                    default:
                        device = new SAMSUNGI3(); break;
                };
                return device;
            }
        set => Device=value; }
    }
}
