﻿using System;

namespace Factory
{
    public class Mobile : IDevice
    {
        public string DeviceType { get => DeviceEnum.MOBILE.ToString(); set => DeviceType = value; }
    }
}
