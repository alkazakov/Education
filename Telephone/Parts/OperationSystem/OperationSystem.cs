using System;

namespace Telephone
{
    public class OperationSystem: IOperationSystem
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(OperationSystem)} is on");
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public void Load()
        {
            throw new NotImplementedException();
        }
        public void Login()
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