using System;

namespace AbstractFactory
{
    public class MobileFactory : DeviceFactoryAbstract
    {
        private int PhoneType {get;set;}
        public MobileFactory(int phoneType)
        {
            PhoneType = phoneType;
        }
        public override IDevice Device { 
            get                
                {
                IDevice device;
                switch (PhoneType)
                {
                    case 0:
                        device = new SAMSUNGM30();break;
                    case 1:
                        device = new LGV30PLUS(); break;
                    case 2:
                        device = new VIVOU20(); break;
                    case 3:
                        device = new NOKIA6PLUS(); break;
                    default:
                        device = new LGV30PLUS(); break;
                };
                return device;
            }
        set => Device=value; }
    }
}
