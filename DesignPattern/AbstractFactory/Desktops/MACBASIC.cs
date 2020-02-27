using System;

namespace AbstractFactory
{
    public class MACBASIC : Desktop
    {
        public override string DeviceName { get => "MAC BASIC"; set => DeviceName = value; }
    }
}
