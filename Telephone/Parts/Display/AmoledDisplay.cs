using System;

namespace Telephone
{
    public class AmoledDisplay : Display, IDisplay
    {
        public override string DisplayInfo { get; } = nameof(AmoledDisplay);
        public  void TurnOn()
        {
            Console.WriteLine($"{nameof(AmoledDisplay)} is turned on");
        }
        public  void TurnOff()
        {
            Console.WriteLine($"{nameof(AmoledDisplay)} is turned off");
        }
        public  void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}