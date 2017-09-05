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

        public Phone(IDisplay display, ICamera camera)
        {
            _display = display;
            _camera = camera;
        }

        public void TurnOn()
        {
           _display.TurnOn();
            _camera.TurnOn();

        }
        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}