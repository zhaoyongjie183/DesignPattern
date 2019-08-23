using System;
using System.Collections.Generic;
using System.Text;

namespace 中介模式
{
    /// <summary>
    /// 抽象同事接口
    /// </summary>
    public abstract class AbstractColleague
    {
        public string Name { get; set; }

        public abstract void Send(string name,string msg);


        public abstract void Receive(string msg);
       
    }
}