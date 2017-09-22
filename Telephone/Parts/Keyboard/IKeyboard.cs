namespace Telephone
{
    /// <summary>
    /// Common Interface for all Keyboard types
    /// </summary>
    interface IKeyboard : ITurnOnOffable
    {
        void Click();
    }
}