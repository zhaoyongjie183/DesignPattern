using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 原型模式
{
    class Program
    {

        /// <summary>
        /// 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象
        /// 深拷贝：切断引用地址
        /// 浅拷贝：不切断引用地址（拷贝引用地址）
        /// 启示：
        /// 邮件外发模块的开发：比如某银行有个理财活动想通过邮件的形式群发给客户推广。
        /// 通过分析，我们知道邮件的内容部分即活动内容是固定的，发件人都是银行，不同的是，接收人邮箱及对客户的称呼。
        /// 如果每次外发邮件都要重新构建一个邮件对象，如果仅仅是几百用户也无可厚非，但对于几百万的客户，这样做肯定是不行的，
        /// 我们可以通过对象复制的方式来进行对象的创建，再更改不同的部分，以提高性能。
        /// 优点：
        /// 原型模式向客户隐藏了创建新实例的复杂性
        /// 缺点：
        /// 1、每个类必须配备一个克隆方法
        /// 2、配备克隆方法需要对类的功能进行通盘考虑，这对于全新的类不是很难，但对于已有的类不一定很容易，
        /// 特别当一个类引用不支持串行化的间接对象，或者引用含有循环结构的时候。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "张三",
                Age = 27,
                ChildPerson = new ChildPerson
                {
                    Shengfen = "四川"
                }
            };

            Person person2 = (Person)person.Clone();

            //深拷贝的原理是就是实现
            MemoryStream ms = new MemoryStream();

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, person);

            ms.Seek(0, SeekOrigin.Begin);

            var person3 = (Person)bf.Deserialize(ms);

            ms.Close();


            Console.ReadLine();
        }
    }
}
