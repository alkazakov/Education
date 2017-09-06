using System;

namespace Telephone
{
    public class PrimitiveDisplay : Display, IDisplay
    {
        public override string DisplayInfo { get; } = nameof(PrimitiveDisplay);
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(PrimitiveDisplay)} is turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{nameof(PrimitiveDisplay)} is turned off");
        }
        public void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}