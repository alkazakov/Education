using System;

namespace Telephone
{
    public class PrimitiveKeyboard : Keyboard
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{nameof(PrimitiveKeyboard)} is on");
        }
        public override void TurnOff()
        {
            throw new NotImplementedException();
        }
        public override void Click()
        {
            throw new NotImplementedException();
        }
    }
}