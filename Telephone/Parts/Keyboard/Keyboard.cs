using System;

namespace Telephone
{
    public class Keyboard : IKeyboard
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(Keyboard)} is on");
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