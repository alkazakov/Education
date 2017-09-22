using System.Drawing;

namespace Telephone
{
    /// <summary>
    /// Supported types:
    /// Front Camera, Rear Camera
    /// </summary>
    public enum CameraType
    {
        Front,
        Rear
    };
    public abstract class Camera: ICamera
    {
        public abstract CameraType CameraType { get;}
        public abstract string Model { get; }
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void TakePhoto();
        public abstract void SavePhoto(Bitmap photo);
    }
}