using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    public class UnivConfig
    {
        public string DeviceId { get; private set; }

        public UnivConfig()
        {
            DeviceId =Guid.NewGuid().ToString();
        }
    }

    public class BatteryConfig : UnivConfig
    {
        public int Capacity { get; set; }
    }
}
