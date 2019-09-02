using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    public class EveningState : AbstractState
    {
        public override void Handler(Context context)
        {
            Console.WriteLine("晚上好");
        }
    }
}