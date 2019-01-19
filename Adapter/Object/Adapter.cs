using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Object
{
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
