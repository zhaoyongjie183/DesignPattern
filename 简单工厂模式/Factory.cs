using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    /// <summary>	
    /// 描述：工厂类包含了必要的逻辑判断，根据客户端的选择条件动态实例化相关的类。对于客户端来说，去除了对具体产品的依赖。
    ///不符合【OCP】。
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/16 11:38:52
    /// </summary>
    public class Factory
    {
        public static  Parents CreateInstance(ClassTypeEnum classTypeEnum)
        {
           
            switch (classTypeEnum)
            {
                case ClassTypeEnum.Child:
                    return  new Child();
                default:
                    return null;
            }
        }
    }

    public enum ClassTypeEnum
    {
        Child,
    }
}
