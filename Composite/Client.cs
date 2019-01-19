using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Composite
{
    class Client
    {
        static void Main(string[] args)
        {
            Component component = new Composite("Root");
            Component subcomponent = new Composite("Sub");
            Component leaf1 = new Composite("Leaf1");
            Component leaf2 = new Composite("Leaf2");
            
            component.Add(subcomponent);
            subcomponent.Add(leaf1);
            subcomponent.Add(leaf2);

            component.Operation();

            Console.ReadLine();
        }
    }
}
