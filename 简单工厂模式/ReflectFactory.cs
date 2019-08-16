using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式
{
    /// <summary>	
    /// 描述：反射工厂模式
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/16 14:00:23
    /// </summary>
    public class ReflectFactory
    {
        public static T Create<T>(string typeName) where T:class
        {
            Type type = Type.GetType(typeName, true, true);
            var instance = type?.Assembly.CreateInstance(typeName) as T;

            return instance;
        }
    }
}
