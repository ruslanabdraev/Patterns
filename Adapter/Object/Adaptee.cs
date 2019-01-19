using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Object
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adapter.Object.Adaptee.SpecificRequest method call.");
        }
    }
}
