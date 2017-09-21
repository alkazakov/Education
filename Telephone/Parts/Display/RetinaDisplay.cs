using System;

namespace Telephone
{
    public class RetinaDisplay : Display, IDisplay
    {
        public override string DisplayInfo { get; } = nameof(RetinaDisplay);
        public override void TurnOn()
        {
            Console.WriteLine($"{nameof(RetinaDisplay)} is turned on");
        }
        public override  void TurnOff()
        {
            Console.WriteLine($"{nameof(RetinaDisplay)} is turned off");
        }
        public new  void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}