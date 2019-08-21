using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public interface 注册观察者
    {
        void add(响铃 a);

        void 来电了();
    }
}