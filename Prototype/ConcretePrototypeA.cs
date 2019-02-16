using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            Console.WriteLine("Prototype.ConcretePrototypeA.Clone method call.");

            return new ConcretePrototypeA(Id);
        }
    }
}
