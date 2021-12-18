﻿namespace exceptions_task
{
    public class ElectricEngine : Engine
    {

        public ElectricEngine(string serialNumber, double power, double volume) : base(serialNumber, power, volume)
        {
            EngineType = "ElectricEngine";
        }

        public override string ToString()
        {
            return $"\nEngine:\nSerial number: {SerialNumber}" +
                $"\nPower: {Power}\nVolume: {Volume}\nType: Electric engine";
        }
    }
}