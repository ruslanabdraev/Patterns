using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerC: Handler
    {
        public override void HandleRequest()
        {
            Console.WriteLine("ChainOfResponsibility.ConcreteHandlerC.HandleRequest method call.");

            base.HandleRequest();
        }
    }
}
