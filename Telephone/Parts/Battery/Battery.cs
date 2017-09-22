using System;

namespace Telephone
{
    public class Battery : IBattery
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(Battery)} is on");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{nameof(Battery)} is off");
        }

        public int Capacity { get; } = 1250;
        public int ChargeLevel { get; set; }
        public BatteryStatus GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}