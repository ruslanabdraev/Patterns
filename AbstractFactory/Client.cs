using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory();

            AbstractProductA productA = factory.CreateProductA();
            AbstractProductB productB = factory.CreateProductB();

            productB.Interact(productA);

            Console.ReadLine();
        }
    }
}
