using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 记录需要恢复得实体（备忘录实体）
    /// </summary>
    public class Memento
    {
        public string State
        {
            get;set;
        }
    }
}