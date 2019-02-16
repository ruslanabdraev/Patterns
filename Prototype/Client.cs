using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Client
    {
        static void Main(string[] args)
        {
            Prototype prototype = null;
            Prototype clone = null;

            prototype = new ConcretePrototypeA(1);
            clone = prototype.Clone();

            prototype = new ConcretePrototypeB(2);
            clone = prototype.Clone();

            Console.ReadLine();
        }
    }
}
