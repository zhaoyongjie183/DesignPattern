using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 命令得调用者 给客户端
    /// </summary>
    public class Invoker
    {
        List<ICommand> commands = new List<ICommand>();

        public void SetCommand(ICommand command)
        {
            commands.Add(command);
        }

        /// <summary>
        /// 执行批量得命令
        /// </summary>
        public void Exceute()
        {
            foreach (var item in commands)
            {
                item.Execute();
            }
        }

        /// <summary>
        /// 从命令当中删除一条
        /// </summary>
        public void Undo()
        {
            this.commands.RemoveAt(this.commands.Count - 1);
        }
    }
}