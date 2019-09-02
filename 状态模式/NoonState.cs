using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    public class NoonState : AbstractState
    {
        public override void Handler(Context context)
        {
            if (context.Houser > 11 && context.Houser < 19)
            {
                Console.WriteLine("中午好");
            }
            else
            {
                context.State = new NoonState();

                context.Request();
            }
        }
    }
}