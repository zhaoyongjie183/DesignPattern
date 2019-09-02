using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    public abstract class AbstractState
    {
        public abstract void Handler(Context context);
    }
}