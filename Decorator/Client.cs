using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Client
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            Component decoratedComponent = new ConcreteDecoratorB(new ConcreteDecoratorA(component));

            decoratedComponent.Operation();

            Console.ReadLine();
        }
    }
}
