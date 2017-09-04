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
     interface IKeyboard : ITurnOnOff, IHardware
    {
        void Click();
    }
    interface IWifiModule : ITurnOnOff, IHardware
    {
        void Connect();
        string GetData(string url);
        void SendData(string data);
    }
     interface ICamera : ITurnOnOff, IHardware
    {
         void TakePhoto();
     }
     interface IMemory : ITurnOnOff, IHardware
    {
         int SaveData(string data);
         string GetData(int address);
     }
     interface IHardDrive : ITurnOnOff
    {
         int SaveData(string data);
         string GetData(int address);
     }
    interface IDisplay : ITurnOnOff, IHardware
    {
        void Show(string data);
    }
    interface IOperationSystem : ITurnOnOff, IHardware
    {
        void Load();
        void Login();
        int SaveData(string data);
        string GetData(int address);
    }

}
