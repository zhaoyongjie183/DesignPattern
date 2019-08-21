using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public class 客服人员 : 响铃
    {
        string name = string.Empty;
        public 客服人员(string name)
        {
            this.name = name;
        }
        public void 通知()
        {
            Console.WriteLine("响铃以后{0}接通了电话", name);
        }
    }
}