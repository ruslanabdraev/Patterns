using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteProductB : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine("ProductA interacts with ProductB");
        }
    }
}
