using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    /// <summary>	
    /// 描述：单例模式
    /// 避免产生多个对象消耗过多的资源（特别是一个对象需要频繁的创建和销毁时）
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/15 11:47:11
    /// </summary>
    public class Singleton
    {
        private static Singleton singleton = null;

        private static object Singleton_Lock = new object(); //锁同步
        private Singleton()
        {
            
        }
        public static Singleton getInstance()
        {
            if (singleton == null)//双检锁  这样不用每次都去锁定耗费资源
            {
                lock (Singleton_Lock)
                {
                    Console.WriteLine("未被创建");
                    if (singleton == null)
                    {
                        Console.WriteLine("被创建");
                        singleton = new Singleton();
                    }
                }
            }
            return singleton;
        }
    }
}
