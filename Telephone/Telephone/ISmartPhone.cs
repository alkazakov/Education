namespace Telephone
{
    interface ISmartPhone : IPhone
    {
        ICamera FrontCamera { get; set; }
        IHardDrive HardDrive { get; set; }
        ICamera RearCamera { get; set; }
        IOperationSystem OperationSystem { get; set; }
        IWifiModule WifiModule { get; set; }
    }
}