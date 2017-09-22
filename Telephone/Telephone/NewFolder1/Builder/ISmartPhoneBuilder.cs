using System.Runtime.InteropServices;

namespace Telephone
{
    interface ISmartPhoneBuilder: IPhoneBuilder
    {
        void BuildOperatingSystem();
        void BuildHardDrive();
        void BuildFrontCamera();
        void BuildRearCamera();
        void BuildWifiModule();
    }
}