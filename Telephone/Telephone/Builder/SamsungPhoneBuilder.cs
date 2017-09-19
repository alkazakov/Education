using System;
using System.Collections.Generic;

namespace Telephone
{
    class SamsungPhoneBuilder : ISmartPhoneBuilder
    {
        public IDisplay BuildDisplay()
        {
            DisplayFactory displayFactory = new DisplayFactory();         
            return displayFactory.Create<AmoledDisplay>();
        }

        public IKeyboard BuildKeyboard()
        {
            KeyboardFactory keyboardFactory = new KeyboardFactory();
            return keyboardFactory.Create<Keyboard>();
        }

        public IOperationSystem BuildOperatingSystem()
        {
            OperationSystemFactory operationSystemFactory = new OperationSystemFactory();
            return operationSystemFactory.Create<OperationSystem>();
        }

        public IHardDrive BuildHardDrive()
        {
            HardDriveFactory hardDriveFactory = new HardDriveFactory();
            return hardDriveFactory.Create<HardDrive>();
        }

        public IMemory BuildMemory()
        {
            MemoryFactory memoryFactory = new MemoryFactory();
            return memoryFactory.Create<Memory>();
        }

        public ICamera BuildFrontCamera()
        {
            CameraFactory cameraFactory = new CameraFactory();         
            return cameraFactory.Create<SamsungFrontCamera>();
        }

        public ICamera BuildRearCamera()
        {
            CameraFactory cameraFactory = new CameraFactory();
            return cameraFactory.Create<SamsungRearCamera>();
        }

        public IWifiModule BuildWifiModule()
        {
          WifiModuleFactory wifiModuleFactory = new WifiModuleFactory();
            return wifiModuleFactory.Create<WifiModule>();
        }

        public ITelephone Construct()
        {
            return new SamsungPhone(BuildDisplay(), BuildKeyboard(), BuildOperatingSystem(), BuildHardDrive(),
                BuildMemory(), BuildFrontCamera(), BuildRearCamera(), BuildWifiModule());

        }
    }
}