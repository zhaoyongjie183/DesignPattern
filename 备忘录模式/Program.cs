using System;

namespace 备忘录模式
{
    /// <summary>
    /// 定义：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将该对象恢复到原先保存的状态。
    ///      记录某一个对象在某一个时刻得状态，在需要得时候进行恢复
    /// 总结：备忘录模式看似简单，但具体使用时会有多种变体。在对对象进行备份时，需要考虑到对象的深浅拷贝问题。
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //原状态
            Originator originator = new Originator() {
                State="王二",
                State2="礼物"
            };

            Console.WriteLine("原始值:{0}", originator.State);

            //快照
            originator.CreaterMemento();

            CareTaker careTaker = new CareTaker();

            careTaker.Memento = originator.CreaterMemento();

            originator.State = "张三";


            Console.WriteLine("修改后得值：{0}",originator.State);

            //撤销
            originator.RemoveMemento(careTaker.Memento);

            Console.WriteLine("赋值错误修复中{0}",originator.State);

            Console.ReadLine();
        }
    }
}
