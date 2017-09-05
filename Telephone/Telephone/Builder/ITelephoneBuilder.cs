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
}