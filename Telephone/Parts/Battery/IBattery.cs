using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    interface IBattery : ITurnOnOffable
    {
        int Capacity { get; }
        int ChargeLevel { get; set; }
        BatteryStatus GetStatus();
    }
}