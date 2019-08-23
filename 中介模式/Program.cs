using System;

namespace 中介模式
{
    /// <summary>
    /// 定义：用一个中介对象封装一系列的对象交互，中介者使各对象不需要显示地相互作用，从而使耦合松散，而且可以独立地改变它们之间的交互。
    /// 应用场景：当类图中出现了蜘蛛网状结构时一定要考虑使用中介者模式，这有利于把蜘蛛网梳理为星型结构，使原本复杂混乱的关系变得清晰简单。
    /// 优缺点：优点：中介者模式的优点就是减少类间的依赖，把原有的一对多的依赖变成了一对一的依赖，同事类只依赖中介者，减少了依赖，当然同时也降低了类间的耦合
    /// 缺点：中介者模式的缺点就是中介者会膨胀得很大，而且逻辑复杂，原本N个对象直接的相互依赖关系转换为中介者和同事类的依赖关系，同事类越多，中介者的逻辑就越复杂。
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            AbstractMediator abstractMediator = new ConcreteMediator();

            AbstractColleague abstractColleague = new Colleague("张三",abstractMediator);

            AbstractColleague abstractColleague2 = new Colleague("李四",abstractMediator);

            abstractMediator.Add(abstractColleague);

            abstractMediator.Add(abstractColleague2);

            abstractColleague.Send("张三", "在吗");

            abstractColleague2.Send("李四", "在");

            Console.ReadLine();
        }
    }
}
