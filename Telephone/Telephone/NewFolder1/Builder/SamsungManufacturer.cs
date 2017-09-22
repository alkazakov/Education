namespace Telephone
{
    class SamsungManufacturer :IManufacturer
    {
        public void Construct(ISmartPhoneBuilder iSmartPhoneBuilder)
        {
            iSmartPhoneBuilder.BuildDisplay();
            iSmartPhoneBuilder.BuildFrontCamera();
            iSmartPhoneBuilder.BuildHardDrive();
            iSmartPhoneBuilder.BuildKeyboard();
            iSmartPhoneBuilder.BuildMemory();
            iSmartPhoneBuilder.BuildOperatingSystem();
            iSmartPhoneBuilder.BuildRearCamera();
            iSmartPhoneBuilder.BuildRearCamera();
            iSmartPhoneBuilder.BuildWifiModule();
        }

        public void Construct(IPhoneBuilder iPhoneBuilder)
        {
            throw new System.NotImplementedException();
        }
    }
}