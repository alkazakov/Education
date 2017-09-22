namespace Telephone
{
    interface IPhoneBuilder
    {
        void BuildDisplay();
        void BuildKeyboard();     
        void BuildMemory();
        Phone GetResult();
    }
}