using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    /// <summary>	
    /// 描述：实现ICloneable实现深拷贝
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/20 14:44:02
    /// </summary>
    [Serializable]
    public class ChildPerson:ICloneable
    {
        public string Shengfen { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
