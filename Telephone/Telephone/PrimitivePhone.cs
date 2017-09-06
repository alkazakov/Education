using System;
using System.Data;
using System.Reflection;

namespace Telephone
{
    class PrimitivePhone : ITelephone
    {
        public IDisplay Display { get; }
        public IKeyboard Keyboard { get; }
        public IMemory Memory { get; }

        public PrimitivePhone(IDisplay display, IKeyboard keyboard, IMemory memory)
        {
            Display = display;
            Keyboard = keyboard;
            Memory = memory;
        }

        public void TurnOn()
        {
            Display.TurnOn();
            Keyboard.TurnOn();
            Memory.TurnOn();           
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}