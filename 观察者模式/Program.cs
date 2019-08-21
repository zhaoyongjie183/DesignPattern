using System;

namespace 观察者模式
{
    /// <summary>
    /// 定义：定义对象间一种一对多的依赖关系，使得每当一个对象改变状态，则所有依赖于它的对象都会得到通知并被自动更新。
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            //ISubject subject = new ConcreteSubject() {
            //    SubjectStatus="zyj"
            //};
            //IObserver observer = new ConcreteObserver(subject,"李四");

            //IObserver observer2 = new ConcreteObserver(subject, "王五");

            //subject.Add(observer);

            //subject.Add(observer2);

            //subject.SubjectStatus = "hello的中文";

            //subject.Nodify();


            //注册观察者 注册 = new 手机();

            //响铃 响铃 = new 客服人员("李静");

            //注册.add(响铃);

            //注册.来电了();

            RunSports runsport = new RunSports();//实例化事件发布者
            Yundong judgment = new Yundong();//实例化事件订阅者
            judgment.eventRun += new Yundong.delegateRun(runsport.Run);//订阅事件
            judgment.Begin();//引发事件
            Console.ReadLine();
        }
    }

    /// <summary>
    /// 被观察者
    /// </summary>
    public class Yundong
    {
        //定义一个委托
        public delegate void delegateRun();
        //定义一个事件
        public event delegateRun eventRun;

        /// <summary>
        /// 引发事件的方法(触发观察者)
        /// </summary>
        public void Begin()
        {
            eventRun();
        }
    }

    /// <summary>
    /// 观察者
    /// </summary>
    class RunSports
    {
        //定义事件处理方法
        public void Run()
        {
            Console.WriteLine("运动员开始比赛");
        }
    }
}
