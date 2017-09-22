using System;

namespace Telephone
{
    public abstract class Keyboard : IKeyboard
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void Click();
    }
}