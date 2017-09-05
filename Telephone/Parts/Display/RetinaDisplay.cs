using System;

namespace Telephone
{
    public class RetinaDisplay : Display, IDisplay
    {
        public override string DisplayInfo { get; } = nameof(RetinaDisplay);
        public  void TurnOn()
        {
            Console.WriteLine($"{nameof(RetinaDisplay)} is turned on");
        }
        public  void TurnOff()
        {
            Console.WriteLine($"{nameof(RetinaDisplay)} is turned off");
        }
        public  void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}