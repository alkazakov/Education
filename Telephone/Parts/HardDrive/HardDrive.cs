using System;

namespace Telephone
{
    public class HardDrive : IHardDrive
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(HardDrive)} is on");
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