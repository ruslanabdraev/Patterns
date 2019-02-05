using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteBuilder : Builder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            Console.WriteLine("Builder.ConcreteBuilder.BuildPartA method call.");

            product.Add("PartA");
        }

        public override void BuildPartB()
        {
            Console.WriteLine("Builder.ConcreteBuilder.BuildPartB method call.");

            product.Add("PartB");
        }

        public override void BuildPartC()
        {
            Console.WriteLine("Builder.ConcreteBuilder.BuildPartB method call.");

            product.Add("PartC");
        }

        public override Product GetResult()
        {
            Console.WriteLine("Builder.ConcreteBuilder.GetResult method call.");

            return product;
        }
    }
}
