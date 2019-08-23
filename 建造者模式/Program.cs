using System;

namespace 建造者模式
{
    class Program
    {
        /// <summary>
        /// 定义：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示
        /// 应用场景;创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时。建造者模式关注的是零件类型和装配工艺（顺序）。最主要的功能是基本方法的调用顺序安排。
        /// 抽象工厂模式解决了“系列产品”的需求变化，而建造者模式解决的是 “产品部分” 的需要变化。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BuildCreate buildCreate = new BuildCreate(new IPhone());
            buildCreate.Create();
            Console.ReadLine();
        }
    }
}
