using System;

namespace 模板方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Father father = new WangEr();

            father.WriteLine();
            Console.ReadLine();
        }
    }
}
