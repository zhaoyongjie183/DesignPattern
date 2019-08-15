using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {

            TaskFactory taskFactory = new TaskFactory();
            List<Task> taskList = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                taskList.Add(taskFactory.StartNew(() =>
                {
                    Singleton singleton = Singleton.getInstance();
                }));
            }
            Console.ReadKey();
        }
    }
}
