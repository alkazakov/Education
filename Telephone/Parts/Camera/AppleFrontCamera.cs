using System;
using System.Drawing;

namespace Telephone
{
    public class AppleFrontCamera : Camera, ICamera
    {
        public override CameraType CameraType { get; } = CameraType.Front;
        public override string Model { get; } = nameof(AppleFrontCamera);
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
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