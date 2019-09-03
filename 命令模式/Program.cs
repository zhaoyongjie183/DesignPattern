using System;

namespace 命令模式
{
    /// <summary>
    /// 定义：将行为得请求者和行为得实现者进行分离，命令模式属于对象的行为型模式。
    /// 命令模式是把一个操作或者行为抽象为一个对象中，
    /// 通过对命令的抽象化来使得发出命令的责任和执行命令的责任分隔开。
    /// 命令模式的实现可以提供命令的撤销和恢复功能。
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Receive receive = new Receive();

            ICommand command = new AddCommand(receive);

            ICommand command1 = new RemoveCommand(receive);

            Invoker invoker = new Invoker();

            invoker.SetCommand(command);

            invoker.SetCommand(command1);

            invoker.Exceute();

            Console.ReadLine();
        }
    }
}
