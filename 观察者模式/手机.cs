using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public class 手机: 注册观察者
    {
        List<响铃> list = new List<响铃>();
        public void add(响铃 a)
        {
            list.Add(a);
        }

        public void 来电了()
        {
            Console.WriteLine("叮叮叮，李四来电了");
            foreach (var item in list)
            {
                item.通知();
            }
        }


    }
}