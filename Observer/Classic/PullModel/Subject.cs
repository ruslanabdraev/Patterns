using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classic.PullModel
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Observer.Classic.PullModel.Subject.Notify method call.");

            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
