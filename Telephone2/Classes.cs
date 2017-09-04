using System;
using System.Collections.Generic;

namespace Telephone
{
    public class Display : IDisplay
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public void Show(string data)
        {
            throw new NotImplementedException();
        }
    }
    public class Keyboard : IKeyboard
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public void Click()
        {
            throw new NotImplementedException();
        }
    }

    public class OperationSystem: IOperationSystem
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
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

    public class HardDrive : IHardDrive
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
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
    public class Memory : IMemory
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
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
    public class Camera : ICamera
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public void TakePhoto()
        {
            Console.WriteLine("Hello");
        }
    }

    public class WifiModule: IWifiModule
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
        public void Connect()
        {
            throw new NotImplementedException();
        }
        public string GetData(string url)
        {
            throw new NotImplementedException();
        }
        public void SendData(string data)
        {
            throw new NotImplementedException();
        }
    }


}