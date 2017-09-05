using System;
using System.Drawing;

namespace Telephone
{
    public class SamsungRearCamera : Camera, ICamera
    {
        public override CameraType CameraType { get; } = CameraType.Rear;
        public override string Model { get; } = nameof(SamsungRearCamera);
        public void TurnOn()
        {
            Console.WriteLine($"{CameraType}: {nameof(SamsungRearCamera)} is on");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{CameraType}: {nameof(SamsungRearCamera)} is off");
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