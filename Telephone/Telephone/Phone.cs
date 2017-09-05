using System;

namespace Telephone
{
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