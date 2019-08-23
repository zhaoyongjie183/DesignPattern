using System;
using System.Collections.Generic;
using System.Text;

namespace 中介模式
{
    /// <summary>
    /// 同事具体实现
    /// </summary>
    public class Colleague : AbstractColleague
    {
        AbstractMediator abstractMediator = null;
        public Colleague(string name,AbstractMediator abstractMediator)
        {
            this.Name = name;
            this.abstractMediator = abstractMediator;
        }
        public override void Receive(string msg)
        {
            Console.WriteLine(msg);
        }

        public override void Send(string name, string msg)
        {
            this.abstractMediator.Send(name, msg);
        }
    }
}