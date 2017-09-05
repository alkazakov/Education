using System;

namespace Telephone
{
    interface ITelephoneBuilder
    {
        IDisplay BuildDisplay();
        IKeyboard BuildKeyboard();
        IOperationSystem BuildOperatingSystem();
        IHardDrive BuildHardDrive();
        IMemory BuildMemory();
        ICamera BuildCamera();
        IWifiModule BuildWifiModule();
        Phone Phone {get;}
    }

    class SamsungPhoneBuilder : ITelephoneBuilder
    {
        public IDisplay BuildDisplay()
        {
            DisplayFactory displayFactory = new DisplayFactory();
            return displayFactory.Create<AmoledDisplay>();
        }

        public IKeyboard BuildKeyboard()
        {
            throw new NotImplementedException();
        }

        public IOperationSystem BuildOperatingSystem()
        {
            throw new NotImplementedException();
        }

        public IHardDrive BuildHardDrive()
        {
            throw new NotImplementedException();
        }

        public IMemory BuildMemory()
        {
            throw new NotImplementedException();
        }

        public ICamera BuildCamera()
        {
            CameraFactory cameraFactory = new CameraFactory();
            return cameraFactory.Create<SamsungFrontCamera>();
        }

        public IWifiModule BuildWifiModule()
        {
            throw new NotImplementedException();
        }

        public Phone Phone { get; }

        public Phone Construct()
        {
           return  new Phone(BuildDisplay(),BuildCamera());
        }
    }



    class Phone : ITurnOnOffable
    {
        private IDisplay _display;

        private IKeyboard _keyboard;

        private IOperationSystem _operationSystem;

        private IHardDrive _hardDrive;

        private IMemory _memory;

        private ICamera _camera;

        private IWifiModule _wifiModule;

        public Phone(IDisplay display, ICamera camera)
        {
            _display = display;
            _camera = camera;
        }

        public void TurnOn()
        {
           _display.TurnOn();
        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}