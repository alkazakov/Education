using System;

namespace Telephone
{
    public class AmoledDisplay : Display, IDisplay
    {
        public override string DisplayInfo { get; } = nameof(AmoledDisplay);
        public override  void TurnOn()
        {
            Console.WriteLine($"{nameof(AmoledDisplay)} is turned on");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{nameof(AmoledDisplay)} is turned off");
        }
        public  new void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}