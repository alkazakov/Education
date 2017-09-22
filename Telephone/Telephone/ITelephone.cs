namespace Telephone
{
    interface IPhone : ITurnOnOffable
    {
        IDisplay Display { get; set; }
        IKeyboard Keyboard { get; set; }
        IMemory Memory { get; set; }
    }
}