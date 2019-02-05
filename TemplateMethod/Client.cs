using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Client
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.TemplateMethod();

            Console.ReadLine();
        }
    }
}
