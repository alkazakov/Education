using System;
using System.Collections.Generic;

namespace Telephone
{
    class SamsungPhoneConcreteBuilder : ISmartPhoneBuilder
    {
        readonly SamsungPhone _samsungPhone = new SamsungPhone();

        public void BuildDisplay()
        {
            DisplayFactory displayFactory = new DisplayFactory();         
             _samsungPhone.Display=displayFactory.Create<AmoledDisplay>();
        }
        public void BuildKeyboard()
        {
            KeyboardFactory keyboardFactory = new KeyboardFactory();
            _samsungPhone.Keyboard=keyboardFactory.Create<TouchKeyboard>();
        }
        public void BuildOperatingSystem()
        {
            OperationSystemFactory operationSystemFactory = new OperationSystemFactory();
             _samsungPhone.OperationSystem=operationSystemFactory.Create<OperationSystem>();
        }
        public void BuildHardDrive()
        {
            HardDriveFactory hardDriveFactory = new HardDriveFactory();
            _samsungPhone.HardDrive=hardDriveFactory.Create<HardDrive>();
        }
        public void BuildMemory()
        {
            MemoryFactory memoryFactory = new MemoryFactory();
            _samsungPhone.Memory=memoryFactory.Create<Memory>();
        }

        Phone IPhoneBuilder.GetResult()
        {
            throw new NotImplementedException();
        }

        public void BuildFrontCamera()
        {
            CameraFactory cameraFactory = new CameraFactory();
            _samsungPhone.FrontCamera=cameraFactory.Create<SamsungCamera>();
        }

        public void BuildRearCamera()
        {
            CameraFactory cameraFactory = new CameraFactory();
            _samsungPhone.RearCamera=cameraFactory.Create<SamsungCamera>();
        }
        public void BuildWifiModule()
        {
            WifiModuleFactory wifiModuleFactory = new WifiModuleFactory();
            _samsungPhone.WifiModule=wifiModuleFactory.Create<WifiModule>();
        }
        public SamsungPhone GetResult() => _samsungPhone;
    }
}