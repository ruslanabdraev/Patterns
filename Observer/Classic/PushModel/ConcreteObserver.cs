using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classic.PushModel
{
    public class ConcreteObserver: Observer
    {
        private string objectState;
        private readonly ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update(string state)
        {
            Console.WriteLine("Observer.Classic.PushModel.ConcreteObserver.Update method call. State: " + state);

            objectState = state;
        }
    }
}
