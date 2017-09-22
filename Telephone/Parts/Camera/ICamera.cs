using System.Drawing;
namespace Telephone
{
    /// <summary>
    ///  Common Interface for all Cameras.
    /// This interface inherit ITurnOnOffable Interface
    /// </summary>
    interface ICamera : ITurnOnOffable
    {
        /// <summary>
        /// Installation place of a Camera.
        /// Front oder Rear
        /// </summary>
        CameraType CameraType { get; }
        string Model { get; }
        void TakePhoto();
        void SavePhoto(Bitmap photo);
    }
}