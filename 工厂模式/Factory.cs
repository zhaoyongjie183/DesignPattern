using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    public class Factory
    {
        public static IFactoryMethod CreateInstat(string name)
        {
            switch (name)
            {
                case "A":
                    return new ConcreateMethodA();
                default:
                    break;
            }
            return null;
        }
    }
}