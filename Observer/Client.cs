using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Client
    {
        static void Main(string[] args)
        {
            Subject subject = new ConcreteSubject();
            Observer observer = new Observer((observerState) => Console.WriteLine(observerState + " 1"));
            subject.Event += observer;
            subject.Event += (observerState) => Console.WriteLine(observerState + " 2");
            subject.State = "State ...";

            subject.Notify();

            Console.ReadLine();
        }
    }
}
