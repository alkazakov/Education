using System;

namespace Telephone
{
    public abstract class Display : IDisplay
    {
        public abstract string DisplayInfo { get; }
        public abstract void TurnOn();
        public abstract void TurnOff();
        public virtual void Show(string data) => Console.WriteLine($"Abstract {nameof(Display)} can't show!");
    }
}