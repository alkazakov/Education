using System;

namespace Telephone
{
    public class WifiModule: IWifiModule
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(WifiModule)} is on");
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