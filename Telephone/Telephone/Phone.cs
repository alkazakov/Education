using System;
using System.Data;
using System.Reflection;

namespace Telephone
{
    class Phone : IPhone
    {
        public IDisplay Display { get; set;}
        public IKeyboard Keyboard { get; set; }
        public IMemory Memory { get; set; }

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