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
            Classic.PushModel.ConcreteSubject subjectPushModel = new Classic.PushModel.ConcreteSubject();
            subjectPushModel.Attach(new Classic.PushModel.ConcreteObserver(subjectPushModel));
            subjectPushModel.Attach(new Classic.PushModel.ConcreteObserver(subjectPushModel));
            subjectPushModel.State = "Some State ...";
            subjectPushModel.Notify();
            Console.WriteLine();

            Classic.PullModel.ConcreteSubject subjectPullModel = new Classic.PullModel.ConcreteSubject();
            subjectPullModel.Attach(new Classic.PullModel.ConcreteObserver(subjectPullModel));
            subjectPullModel.Attach(new Classic.PullModel.ConcreteObserver(subjectPullModel));
            subjectPullModel.State = "Some State ...";
            subjectPullModel.Notify();
            Console.WriteLine();

            LanguageSpecific.Subject subject = new LanguageSpecific.ConcreteSubject();
            LanguageSpecific.Observer observer = new LanguageSpecific.Observer((observerState) => Console.WriteLine(observerState + " 1"));
            subject.Event += observer;
            subject.Event += (observerState) => Console.WriteLine(observerState + " 2");
            subject.State = "State ...";
            subject.Notify();

            Console.ReadLine();
        }
    }
}
