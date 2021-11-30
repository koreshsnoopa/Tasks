﻿using System;
namespace collections
{
    [Serializable]
    public abstract class Engine
    {
        public string SerialNumber { get; set; }
        public double Power { get; set; }
        public double Volume { get; set; }
        public string EngineType { get; protected set; }

        public Engine()
        {
        }

        public Engine(string serialNumber, double power, double volume)
        {
            SerialNumber = serialNumber;
            Power = power;
            Volume = volume;
        }
    }
}