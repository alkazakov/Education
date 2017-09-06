using System;

namespace Telephone
{
    public class Memory : IMemory
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(Memory)} is on");
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public int SaveData(string data)
        {
            throw new NotImplementedException();
        }
        public string GetData(int address)
        {
            throw new NotImplementedException();
        }
    }
}