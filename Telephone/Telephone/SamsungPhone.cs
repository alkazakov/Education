using System;

namespace Telephone
{
    class SamsungPhone: ISmartPhone
    {
        public IDisplay Display { get; }
        public IKeyboard Keyboard { get; }
        public IHardDrive HardDrive { get; }
        public IMemory Memory { get; }
        public ICamera FrontCamera { get; }
        public ICamera RearCamera { get; }
        public IOperationSystem OperationSystem { get; }
        public IWifiModule WifiModule { get; }

        public SamsungPhone(IDisplay display, IKeyboard keyboard, IOperationSystem operationSystem, IHardDrive hardDrive, IMemory memory, ICamera frontCamera, ICamera rearCamera, IWifiModule wifiModule) 
           
        {
            Display = display;
            Keyboard = keyboard;
            OperationSystem = operationSystem;
            HardDrive = hardDrive;
            Memory = memory;
            FrontCamera = frontCamera;
            RearCamera = rearCamera;
            WifiModule = wifiModule;
        } 

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