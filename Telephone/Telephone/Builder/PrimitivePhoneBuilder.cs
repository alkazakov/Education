namespace Telephone
{
    class PrimitivePhoneBuilder : ITelephoneBuilder
    {
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