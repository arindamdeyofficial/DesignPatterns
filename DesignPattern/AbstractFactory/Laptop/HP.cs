using System;

namespace AbstractFactory
{
    public class HP : Laptop
    {
        public override string DeviceName { get => "HP"; set => DeviceName = value; }
    }
}
