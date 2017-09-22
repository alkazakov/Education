using System;

namespace Telephone
{
    public class PrimitiveDisplay : Display
    {     
        public override void TurnOn()
        {
            Console.WriteLine($"{DisplayInfo} is turned on");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{DisplayInfo} is turned off");
        }
        public override void Show(string data)
        {
            throw new NotImplementedException();
        }
    }
}