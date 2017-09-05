using System;

namespace Telephone
{
    public class AmoledDisplay : Display
    {
        public override string DisplayInfo { get; } = nameof(AmoledDisplay);
        public override void TurnOn()
        {
            Console.WriteLine($"{nameof(AmoledDisplay)} is turned on");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{nameof(AmoledDisplay)} is turned off");
        }
        public override void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}