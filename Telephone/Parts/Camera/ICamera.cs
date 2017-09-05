using System.Drawing;
namespace Telephone
{
    interface ICamera : ITurnOnOffable
    {
        void TakePhoto();
        void SavePhoto(Bitmap photo);
    }
}