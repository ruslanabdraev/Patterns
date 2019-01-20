using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creator
    {
        private Product _product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            Console.WriteLine("FactoryMethod.Creator.AnOperation method call.");

            _product = FactoryMethod();
        }
    }
}
