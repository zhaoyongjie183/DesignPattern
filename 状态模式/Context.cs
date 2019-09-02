using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    public class Context
    {

        public int Houser { get; set; }
        public AbstractState State
        {
            get;set;
        }

        public void Request()
        {
            this.State.Handler(this);
        }
    }
}