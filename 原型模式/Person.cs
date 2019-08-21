using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    [Serializable]
    public class Person:Factory
    {
        public string Name
        {
            get;set;
        }

        public int Age
        {
            get; set;
        }

        public ChildPerson ChildPerson { get; set; }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}