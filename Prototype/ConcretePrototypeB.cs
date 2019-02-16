using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcretePrototypeB : Prototype
    {
        public ConcretePrototypeB(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            Console.WriteLine("Prototype.ConcretePrototypeB.Clone method call.");

            return new ConcretePrototypeB(Id);
        }
    }
}
