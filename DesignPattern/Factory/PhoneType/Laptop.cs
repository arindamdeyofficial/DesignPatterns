﻿using System;

namespace Factory
{
    public class Laptop:IDevice
    {
        public string DeviceType { get => DeviceEnum.LAPTOP.ToString(); set => DeviceType = value; }
    }
}
