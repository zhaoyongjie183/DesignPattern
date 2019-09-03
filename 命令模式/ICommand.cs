using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 抽象方法命令要执行得方法
    /// </summary>
    public interface ICommand
    {
        void Execute();
        
    }
}