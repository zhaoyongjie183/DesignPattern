using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public class ConcreteObserver : IObserver
    {
        ISubject subject = null;
        string name = string.Empty;
        public ConcreteObserver(ISubject subject,string name)
        {
            this.subject = subject;
            this.name = name;

        } 
        public void Motify()
        {
            Console.WriteLine("{0}被修改，{1}出现了反应", subject.SubjectStatus, name);
        }
    }

   
}