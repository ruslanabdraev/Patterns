using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classic.PullModel
{
    public class ConcreteObserver : Observer
    {
        private string observerState;
        private readonly ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            Console.WriteLine("Observer.Classic.PullModel.ConcreteObserver.Update method call. State: " + subject.State);

            observerState = subject.State;
        }
    }
}
