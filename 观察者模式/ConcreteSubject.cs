using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public string SubjectStatus { get; set; }

      

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Nodify()
        {
            foreach (var item in observers)
            {
                item.Motify();
            }
        }

        

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}