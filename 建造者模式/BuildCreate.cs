using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式
{
    public class BuildCreate
    {
        Phone phone = null;
        public BuildCreate(Phone phone)
        {
            this.phone = phone;
        }

        public void Create()
        {
            phone.CreateZhuBan();
            phone.CreateCpu();
            phone.CreatePingmu();
            Console.WriteLine("构建完成");
        }
    }
}