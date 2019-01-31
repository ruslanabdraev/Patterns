using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("TemplateMethod.AbstractClass.TemplateMethod method call.");

            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

    }
}
