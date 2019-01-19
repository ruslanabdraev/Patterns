using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteFactory : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }
    }
}
