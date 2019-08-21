using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public interface ISubject
    {
        string SubjectStatus { get; set; }

        void Add(IObserver observer);
        void Nodify();
        void Remove(IObserver observer);
    }
}