using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Client
    {
        static void Main(string[] args)
        {
            Class.ITarget classAdapter = new Class.Adapter();
            classAdapter.Request();

            Object.Target objectAdapter = new Object.Adapter();
            objectAdapter.Request();

            Console.ReadLine();
        }
    }
}
