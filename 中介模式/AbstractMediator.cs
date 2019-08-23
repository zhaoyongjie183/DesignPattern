using System;
using System.Collections.Generic;
using System.Text;

namespace 中介模式
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class AbstractMediator
    {
        public abstract void Send(string name,string msg);

        public abstract void Add(AbstractColleague abstractColleague);
       
    }
}