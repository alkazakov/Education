namespace Telephone
{
    public enum CameraType
    {
        Front,
        Rear
    };
    public abstract class Camera 
    {
        public abstract CameraType CameraType { get; }
        public abstract string Model { get; }
    }
}