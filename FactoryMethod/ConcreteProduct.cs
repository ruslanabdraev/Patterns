using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine("FactoryMethod.ConcreteProduct constructor call. HashCode is equals to " + this.GetHashCode());
        }
    }
}
