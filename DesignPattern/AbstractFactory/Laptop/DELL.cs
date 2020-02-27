using System;

namespace AbstractFactory
{
    public class DELL : Laptop
    {
        public override string DeviceName { get => "DELL"; set => DeviceName=value; }
    }
}
