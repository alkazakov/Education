using System;

namespace Telephone
{
    public class PrimitiveKeyboard : IKeyboard
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(PrimitiveKeyboard)} is on");
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public void Click()
        {
            throw new NotImplementedException();
        }
    }
}