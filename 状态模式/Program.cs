using System;

namespace 状态模式
{
    /// <summary>
    /// 定义：当一个对象内在状态改变时允许其改变行为，这个对象看起来像改变了其类。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.State = new MorningState();

            context.Houser = 18;

            context.Request();

            Console.ReadLine();
        }
    }
}
