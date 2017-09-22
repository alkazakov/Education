using System;

namespace Telephone
{
    /// <summary>
    /// This is a base class for all Displays.
    /// </summary>
    public abstract class Display : IDisplay
    {  
        public abstract void TurnOn();
        public abstract void TurnOff();
        public virtual string DisplayInfo { get; set; } = "Abstract Display";
        public abstract void Show(string data);
    }
}