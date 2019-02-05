using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Client
    {
        static void Main(string[] args)
        {
            Handler handlerA = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Handler handlerC = new ConcreteHandlerC();

            handlerA.Successor = handlerB;
            handlerB.Successor = handlerC;
            handlerA.HandleRequest();

            Console.ReadLine();
        }
    }
}
