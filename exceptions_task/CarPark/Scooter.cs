﻿using System;
namespace exceptions_task
{
    public class Scooter : Transport
    {
        public int NumberOfSeats { get; set; }

        public Scooter(int numberOfSeats, ElectricEngine engine, Chassis chassis, Transmission transmission, int Id)
            : base(transmission, chassis, engine, Id)
        {
            if (numberOfSeats > 0)
            {
                NumberOfSeats = numberOfSeats;
            }
            else
            {
                throw new InitializationException("Number of seats must be more then 0!");
            }
        }

        public override string ToString()
        {
            return $"\nScooter:\n{base.ToString()}\n{transmission}\n{chassis}\n{engine}\nNumber of seats:\n{NumberOfSeats}";
        }
    }
}