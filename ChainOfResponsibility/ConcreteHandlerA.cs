using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest()
        {
            Console.WriteLine("ChainOfResponsibility.ConcreteHandlerA.HandleRequest method call.");

            base.HandleRequest();
        }

    }
}
