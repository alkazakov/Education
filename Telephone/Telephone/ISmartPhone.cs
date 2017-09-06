namespace Telephone
{
    interface ISmartPhone : ITelephone
    {
        ICamera FrontCamera { get; }
        IHardDrive HardDrive { get; }
        ICamera RearCamera { get; }
        IOperationSystem OperationSystem { get; }
        IWifiModule WifiModule { get; }
    }
}