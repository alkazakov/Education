using System;

namespace Telephone
{
    public class PrimitiveDisplay : Display
    {
        public override string DisplayInfo { get; } = nameof(PrimitiveDisplay);
        public override void TurnOn()
        {
            Console.WriteLine($"{nameof(PrimitiveDisplay)} is turned on");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{nameof(PrimitiveDisplay)} is turned off");
        }
    }
}