using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    public interface IFactory
    {
        IFactoryMethod CreateInstat();
    }
}