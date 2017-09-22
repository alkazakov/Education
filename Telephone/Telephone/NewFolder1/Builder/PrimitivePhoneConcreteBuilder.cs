using System;
using System.Collections.Generic;

namespace Telephone
{
    class PrimitivePhoneConcreteBuilder : IPhoneBuilder
    {
        readonly Phone _primitivePhone = new Phone();

        public void BuildDisplay()
        {
            DisplayFactory displayFactory = new DisplayFactory();
            _primitivePhone.Display=displayFactory.Create<PrimitiveDisplay>();
        }

        public void BuildKeyboard()
        {
            KeyboardFactory keyboardFactory = new KeyboardFactory();
            _primitivePhone.Keyboard=keyboardFactory.Create<PrimitiveKeyboard>();
        }
        public void BuildMemory()
        {
            MemoryFactory memoryFactory = new MemoryFactory();
             _primitivePhone.Memory=memoryFactory.Create<Memory>();
        }

        public Phone GetResult() => _primitivePhone;
   
    }
}