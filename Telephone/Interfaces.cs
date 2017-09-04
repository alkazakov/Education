using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    interface IHardware
    {
        
    }
     interface ITurnOn
    {
        void TurnOn();
    }
     interface ITurnOff
    {
        void TurnOff();
    }

    interface ITurnOnOff : ITurnOn, ITurnOff
    {
        
    }
     interface IKeyboard : ITurnOnOff
    {
        void Click();
    }
    interface IWifiModule : ITurnOnOff
    {
        void Connect();
        string GetData(string url);
        void SendData(string data);
    }
     interface ICamera : ITurnOnOff
    {
         void TakePhoto();
     }
     interface IMemory : ITurnOnOff
    {
         int SaveData(string data);
         string GetData(int address);
     }
     interface IHardDrive : ITurnOnOff
    {
         int SaveData(string data);
         string GetData(int address);
     }
    interface IDisplay : ITurnOnOff
    {
        void Show(string data);
    }
    interface IOperationSystem : ITurnOnOff
    {
        void Load();
        void Login();
        int SaveData(string data);
        string GetData(int address);
    }

}
