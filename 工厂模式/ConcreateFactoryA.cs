﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    public class ConcreateMethodA : IFactoryMethod
    {
        public void Create()
        {
            Console.WriteLine("A工厂");
        }
    }
}