using System;

namespace AbstractFactory
{
    public class ALIENWARE : Laptop
    {
        public override string DeviceName { get => "ALIENWARE"; set => DeviceName = value; }
    }
}
