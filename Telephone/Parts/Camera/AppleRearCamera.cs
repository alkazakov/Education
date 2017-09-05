using System;
using System.Drawing;

namespace Telephone
{
    public class AppleRearCamera : Camera, ICamera
    {
        public override CameraType CameraType { get; } = CameraType.Rear;
        public override string Model { get; } = nameof(AppleRearCamera);
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(AppleRearCamera)} is on");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{nameof(AppleRearCamera)} is off");
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }

        public void SavePhoto(Bitmap photo)
        {
            throw new NotImplementedException();
        }
    }
}