using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteClass : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("TemplateMethod.ConcreteClass.PrimitiveOperation1 method call.");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("TemplateMethod.ConcreteClass.PrimitiveOperation2 method call.");
        }
    }
}
