using System;
using System.Drawing;

namespace Telephone
{
    public class SamsungFrontCamera : Camera, ICamera
    {
        public override CameraType CameraType { get; } = CameraType.Front;
        public override string Model { get; } = nameof(SamsungFrontCamera);
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(SamsungFrontCamera)} is on");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{CameraType}: {nameof(SamsungFrontCamera)} is off");
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