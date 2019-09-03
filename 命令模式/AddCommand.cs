using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 将方法抽象成类
    /// </summary>
    public class AddCommand : ICommand
    {
        Receive Receive = null;

        public AddCommand(Receive receive)
        {
            this.Receive = receive;
        }
        public void Execute()
        {
            this.Receive.Add();
        }
    }
}