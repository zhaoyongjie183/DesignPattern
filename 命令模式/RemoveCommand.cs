using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    public class RemoveCommand : ICommand
    {
        Receive Receive = null;

        public RemoveCommand(Receive receive)
        {
            this.Receive = receive;
        }
        public void Execute()
        {
            this.Receive.Remove();
        }
    }
}