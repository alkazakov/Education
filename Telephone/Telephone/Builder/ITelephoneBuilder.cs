namespace Telephone
{
    interface ITelephoneBuilder
    {
        IDisplay BuildDisplay();
        IKeyboard BuildKeyboard();
       
        IMemory BuildMemory();
       
        ITelephone Construct();
    }

    interface ISmartPhoneBuilder: ITelephoneBuilder
    {
        IOperationSystem BuildOperatingSystem();
        IHardDrive BuildHardDrive();
        ICamera BuildFrontCamera();
        ICamera BuildRearCamera();
        IWifiModule BuildWifiModule();
    }
}