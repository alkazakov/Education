using System;
using System.Drawing;

namespace Telephone
{
    public class SamsungCamera : Camera
    {
        public override CameraType CameraType { get; } = CameraType.Front;
        public override string Model { get; } = nameof(SamsungCamera);
        public override void TurnOn()
        {
            Console.WriteLine($"{nameof(SamsungCamera)} is on");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{CameraType}: {nameof(SamsungCamera)} is off");
        }

        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }

        public override void SavePhoto(Bitmap photo)
        {
            throw new NotImplementedException();
        }
    }
}