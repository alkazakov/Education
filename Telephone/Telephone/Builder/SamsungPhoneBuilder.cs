using System;

namespace Telephone
{
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
}