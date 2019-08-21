using System;

namespace 策略模式
{
    class Program
    {
        /// <summary>
        /// 定义：定义一组算法，将每个算法都封装起来，并且使它们之间可以互换。
        /// 总结：策略模式是一个非常简单的模式。它在项目中使用得非常多，但它单独使用的地方就比较少了，
        /// 因为它有致命缺陷：所有的策略都需要暴露出去，这样才方便客户端决定使用哪一个策略。
        /// 用途不一样 
        ///工厂是创建型模式,它的作用就是创建对象； 
        ///策略是行为型模式,它的作用是让一个对象在许多行为中选择一种行为;
        ///关注点不一样
        ///一个关注对象创建
        ///一个关注行为的封装
        ///解决不同的问题
        ///工厂模式是创建型的设计模式，它接受指令，创建出符合要求的实例；它主要解决的是资源的统一分发，将对象的创建完全独立出来，
        ///让对象的创建和具体的使用客户无关。主要应用在多数据库选择，类库文件加载等。 
        ///策略模式是为了解决的是策略的切换与扩展，更简洁的说是定义策略族，分别封装起来，让他们之间可以相互替换，
        ///策略模式让策略的变化独立于使用策略的客户。
        ///工厂相当于黑盒子，策略相当于白盒子
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            TravelStrategyContext travelStrategyContext = new TravelStrategyContext();
            travelStrategyContext.TravelPlan(Weather.Rain);
            Console.ReadLine();
        }
    }
}
