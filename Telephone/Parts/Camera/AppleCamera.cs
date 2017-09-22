using System;
using System.Drawing;

namespace Telephone
{
    public class AppleCamera : Camera
    {
        public override CameraType CameraType { get; }
        public override string Model { get; }

        public override void TurnOn()
        {
            Console.WriteLine($"{nameof(AppleCamera)} is on");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{nameof(AppleCamera)} is off");
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