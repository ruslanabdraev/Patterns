﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Class
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adapter.Class.Adaptee.SpecificRequest method call.");
        }
    }
}
