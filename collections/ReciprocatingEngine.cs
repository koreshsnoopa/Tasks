﻿using System;
namespace collections
{
    [Serializable]
    public class ReciprocatingEngine : Engine
    {
        public ReciprocatingEngine()
        {
        }

        public ReciprocatingEngine(string serialNumber, double power, double volume) : base(serialNumber, power, volume)
        {
            EngineType = "ReciprocatingEngine";
        }

        public override string ToString()
        {
            return $"\nEngine:\nSerial number: {SerialNumber}" +
                $"\nPower: {Power}\nVolume: {Volume}\nType: Reciprocating engine";
        }
    }
}