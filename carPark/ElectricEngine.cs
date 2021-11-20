﻿namespace carPark
{
    public class ElectricEngine : Engine
    {

        public ElectricEngine(string serialNumber, double power, double volume) : base(serialNumber, power, volume)
        {
        }

        public ElectricEngine()
        {
        }

        public override string ToString()
        {
            return $"\nEngine:\nSerial number: {SerialNumber}" +
                $"\nPower: {Power}\nVolume: {Volume}\nType: Electric engine";
        }
    }
}