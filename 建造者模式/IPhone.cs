using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式
{
    public class IPhone : Phone
    {
        public override void CreateCpu()
        {
            Console.WriteLine("组装CPU");
        }

        public override void CreatePingmu()
        {
            Console.WriteLine("组装屏幕");
        }

        public override void CreateZhuBan()
        {
            Console.WriteLine("组装主板");
        }
    }
}