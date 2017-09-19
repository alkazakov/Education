using System.Collections.Generic;

namespace Telephone
{
    class PrimitivePhoneBuilder : ITelephoneBuilder
    {
        private IList<ITurnOnOffable> _hardwareList = new List<ITurnOnOffable>();
        public IDisplay BuildDisplay()
        {
            DisplayFactory displayFactory = new DisplayFactory();
            return displayFactory.Create<PrimitiveDisplay>();
        }

        public IKeyboard BuildKeyboard()
        {
            KeyboardFactory keyboardFactory = new KeyboardFactory();
            return keyboardFactory.Create<PrimitiveKeyboard>();
        }
        public IMemory BuildMemory()
        {
            MemoryFactory memoryFactory = new MemoryFactory();
            return memoryFactory.Create<Memory>();
        }
        public ITelephone Construct()
        {
           
            return new PrimitivePhone(BuildDisplay(), BuildKeyboard(),BuildMemory());
        }
    }
}