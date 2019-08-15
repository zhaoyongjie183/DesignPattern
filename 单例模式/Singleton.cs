using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    /// <summary>	
    /// 描述：
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
            lock (Singleton_Lock)
            {
                Console.WriteLine("未被创建");
                if (singleton == null)
                {
                    Console.WriteLine("被创建");
                    singleton = new Singleton();
                }
            }
            return singleton;
        }
    }
}
