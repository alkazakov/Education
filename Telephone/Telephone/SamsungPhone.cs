using System;

namespace Telephone
{
    class SamsungPhone: ISmartPhone
    {
        public IDisplay Display { get; set; }
        public IKeyboard Keyboard { get; set; }
        public IHardDrive HardDrive { get; set; }
        public IMemory Memory { get; set; }
        public ICamera FrontCamera { get; set; }
        public ICamera RearCamera { get; set; }
        public IOperationSystem OperationSystem { get; set; }
        public IWifiModule WifiModule { get; set; }
   
        public void TurnOn()
        {
            Display.TurnOn();
            Keyboard.TurnOn();
            OperationSystem.TurnOn();
            HardDrive.TurnOn();
            Memory.TurnOn();
            FrontCamera.TurnOn();
            RearCamera.TurnOn();
            WifiModule.TurnOn();
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }

       
    }
}