using System.Drawing;
namespace Telephone
{
    interface ICamera : ITurnOnOffable
    {
        void TakePhoto();
        Bitmap GetPhoto();
        void SavePhoto(Bitmap photo);

    }
}