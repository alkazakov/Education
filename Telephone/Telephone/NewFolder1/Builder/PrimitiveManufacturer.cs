namespace Telephone
{
    class PrimitiveManufacturer: IManufacturer
    {
        
        public void Construct(IPhoneBuilder iPhoneBuilder)
        {
            iPhoneBuilder.BuildKeyboard();
            iPhoneBuilder.BuildDisplay();
            iPhoneBuilder.BuildMemory();
        }
    }
}