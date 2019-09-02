using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    /// <summary>	
    /// 描述：发起者
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/9/2 15:53:51
    /// </summary>
    public class Originator
    {
        public string State
        {
            get;set;
        }

        public string State2 { get; set; }

        public Memento CreaterMemento()
        {
            return new Memento() { State=this.State};
        }

        public void RemoveMemento(Memento memento)
        {
            this.State = memento.State;
        }
    }
}
