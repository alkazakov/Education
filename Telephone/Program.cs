using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("------Create Samsung J5------");
            TelePhoneFactory samsungFactory = new TelePhoneFactory();
            var samsungBuilder = samsungFactory.Create<SamsungPhoneBuilder>();
            var samsungJ5 = samsungBuilder.Construct();
            samsungJ5.TurnOn();

            Console.WriteLine("------Create Primitive Phone------");
            TelePhoneFactory primitivePhoneFactory = new TelePhoneFactory();
            var primitivePhoneBuilder = primitivePhoneFactory.Create<PrimitivePhoneBuilder>();
            var primitivePhone = primitivePhoneBuilder.Construct();
            primitivePhone.TurnOn();

            Console.ReadKey();
        }
    }
}
