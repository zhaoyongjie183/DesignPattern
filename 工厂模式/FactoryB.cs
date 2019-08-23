using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    public class FactoryMethodA : IFactory
    {
        public IFactoryMethod CreateInstat()
        {
            return new ConcreateMethodA();
        }
    }
}