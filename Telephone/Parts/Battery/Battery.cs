using System;
using System.CodeDom;

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

        public int Capacity => _capacity;
        readonly int _capacity;

        public BatteryConfig BatteryConfig => _batteryConfig;
        private readonly BatteryConfig _batteryConfig = new BatteryConfig();



        public int ChargeLevel { get; set; }
        public BatteryStatus GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}