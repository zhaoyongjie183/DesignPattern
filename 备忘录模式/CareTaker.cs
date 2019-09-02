using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 得到需要恢复得数据
    /// </summary>
    public class CareTaker
    {
        public Memento Memento
        {
            get;set;
        }
    }
}