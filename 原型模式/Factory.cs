using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    /// <summary>
    /// aaaaa
    /// </summary>
    [Serializable]
    public abstract class Factory
    {
        public abstract object Clone();
    }
}