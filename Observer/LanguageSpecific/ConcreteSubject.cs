using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LanguageSpecific
{
    public class ConcreteSubject : Subject
    {
        public override string State { get; set; }

        public override void Notify()
        {
            observers.Invoke(State);
        }
    }
}
