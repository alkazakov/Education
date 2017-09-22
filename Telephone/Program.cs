using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PhoneShop phoneShop = new PhoneShop();
            var phone = phoneShop.GetPhone<Phone>();

            phone.TurnOn();

            Console.ReadKey();
        }
    }
}
