using System;

namespace Telephone
{
    interface ITelephoneBuilder
    {
        IDisplay BuildDisplay();
        void BuildKeyboard();
        void BuildOperatingSystem();
        void BuildHardDrive();
        void BuildMemory();
        void BuildCamera();
        void BuildWifiModule();
        Phone Phone {get;}
    }

    class SamsungPhoneBuilder : ITelephoneBuilder
    {
        public IDisplay BuildDisplay()
        {
            DisplayFactory displayFactory = new DisplayFactory();
            return displayFactory.Create<AmoledDisplay>();
        }

        public void BuildKeyboard()
        {
            throw new NotImplementedException();
        }

        public void BuildOperatingSystem()
        {
            throw new NotImplementedException();
        }

        public void BuildHardDrive()
        {
            throw new NotImplementedException();
        }

        public void BuildMemory()
        {
            throw new NotImplementedException();
        }

        public void BuildCamera()
        {
            throw new NotImplementedException();
        }

        public void BuildWifiModule()
        {
            throw new NotImplementedException();
        }

        public Phone Phone { get; }
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

        public Phone(DisplayFactory displayFactory)
        {
            _display = displayFactory.Create<RetinaDisplay>();
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