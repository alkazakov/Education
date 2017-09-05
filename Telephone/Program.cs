using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFactory displayFactory = new DisplayFactory();
            displayFactory.Initialize();
            var a =displayFactory.Create<AmoledDisplay>();

            a.Show($"Hello from {a.GetType().Name}");
            a.TurnOn();

            Console.ReadKey();
        }
    }
}
