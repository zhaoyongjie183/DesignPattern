using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    /// <summary>	
    /// 描述：
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/16 11:28:38
    /// </summary>
    public class Child:Parents
    {
        public Child()
        {
            Console.WriteLine("构建了子类");
        }
    }
}
