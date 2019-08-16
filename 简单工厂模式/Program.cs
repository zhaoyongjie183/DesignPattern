using System;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
             Factory.CreateInstance(ClassTypeEnum.Child);

            Console.ReadLine();
        }
    }
}
