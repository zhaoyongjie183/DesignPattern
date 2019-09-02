using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    public class MorningState : AbstractState
    {
        public override void Handler(Context context)
        {
            if (context.Houser > 0 && context.Houser < 12)
            {
                Console.WriteLine("早上好");
            }
            else
            {
                context.State =new NoonState();

                context.Request();
            }
        }
    }
}