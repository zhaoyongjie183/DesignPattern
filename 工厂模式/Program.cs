using System;

namespace 工厂方法模式
{
    /// <summary>
    /// 优点：符合开闭原则
    /// 缺点：把实现暴露给客户端 当需求发生变化的时候  多个客户端修改麻烦
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //var fa= Factory.CreateInstat("A");
            //fa.Create();

            IFactory factory = new FactoryMethodA();
           var c=  factory.CreateInstat();
            c.Create();
            Console.ReadLine();
        }
    }
}
