namespace Telephone
{
    interface ITelephone : ITurnOnOffable
    {
        IDisplay Display { get; }
        IKeyboard Keyboard { get; }
        IMemory Memory { get; }
    }
}