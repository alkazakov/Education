using System;

namespace Telephone
{
    /// <summary>
    /// This Display can only for Apple Phone implemented
    /// </summary>
    public class RetinaDisplay : Display
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{DisplayInfo} is turned on");
        }
        public override  void TurnOff()
        {
            Console.WriteLine($"{DisplayInfo} is turned off");
        }
        public override void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}