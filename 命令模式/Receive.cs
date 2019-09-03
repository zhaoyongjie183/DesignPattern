using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{

    /// <summary>
    /// 最终命令得执行
    /// </summary>
    public class Receive
    {
        public void Add()
        {
            Console.WriteLine("add方法");
        }

        public void Remove()
        {
            Console.WriteLine("Remove方法");
        }
    }
}