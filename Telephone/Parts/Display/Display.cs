using System;

namespace Telephone
{
    public abstract class Display : IDisplay
    {
        public abstract string DisplayInfo { get; }
        public abstract void TurnOn();


        public abstract void TurnOff();


        public void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}