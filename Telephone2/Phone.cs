using System;
using System.Collections.Generic;

namespace Telephone
{
    abstract class Phone : ITurnOnOff
    {
        protected List<IHardware> _hardware = new List<IHardware>();

        public abstract string Brand { get; }
        public  abstract string Model { get; }
        public abstract string IMEI { get; }

        public abstract void TurnOn();
        public abstract void TurnOff();

        private void AddToHardWareList(IHardware hardware)
        {
            _hardware.Add(hardware);
        }
        public List<IHardware> GetHardWareList() => _hardware;
    }


    class SamsungPhone : Phone {
        public override string Brand { get; }
        public override string Model { get; }
        public override string IMEI { get; }

        public SamsungPhone(string brand, string model, string imei)
        {
            Brand = brand;
            Model = model;
            IMEI = imei;
            _hardware.Add(new Camera());
            _hardware.Add(new Display());
            _hardware.Add(new Keyboard());
            _hardware.Add(new Memory());
            _hardware.Add(new OperationSystem());
            _hardware.Add(new WifiModule());
        }
        public override void TurnOn()
        {
         
        }

        public override void TurnOff()
        {
          
        }
    }
   
}