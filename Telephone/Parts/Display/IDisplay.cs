namespace Telephone
{
    /// <summary>
    /// Common Interface for all Displays.
    /// This interface inherit ITurnOnOffable Interface
    /// </summary>
    interface IDisplay : ITurnOnOffable
    {
        string DisplayInfo { get;}
        void Show(string data);
    }
}