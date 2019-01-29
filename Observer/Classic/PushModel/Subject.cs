using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classic.PushModel
{
    public abstract class Subject
    {
        protected  List<Observer> observers = new List<Observer>();
        public virtual string State { get; set; }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Dettach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Observer.Classic.PushModel.Subject.Notify method call.");

            foreach (var observer in observers)
            {
                observer.Update(State);
            }
        }
    }
}
