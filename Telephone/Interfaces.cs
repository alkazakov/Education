using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{

    
     interface ITurnOn
    {
        void TurnOn();
    }
     interface ITurnOff
    {
        void TurnOff();
    }

    interface ITurnOnOffable : ITurnOn, ITurnOff
    {
        
    }
     interface IKeyboard : ITurnOnOffable
    {
        void Click();
    }
    interface IWifiModule : ITurnOnOffable
    {
        void Connect();
        string GetData(string url);
        void SendData(string data);
    }
     interface ICamera : ITurnOnOffable
    {
         void TakePhoto();
     }
     interface IMemory : ITurnOnOffable
    {
         int SaveData(string data);
         string GetData(int address);
     }
     interface IHardDrive : ITurnOnOffable
    {
         int SaveData(string data);
         string GetData(int address);
     }
    interface IDisplay : ITurnOnOffable
    {
        void Show(string data);
    }
    interface IOperationSystem : ITurnOnOffable
    {
        void Load();
        void Login();
        int SaveData(string data);
        string GetData(int address);
    }

}
