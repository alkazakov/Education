﻿using System;
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
            Phone phone = new Phone(new DisplayFactory());

            Console.ReadKey();
        }
    }
}
