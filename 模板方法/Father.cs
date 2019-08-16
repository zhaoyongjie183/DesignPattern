using System;
using System.Collections.Generic;
using System.Text;

namespace 模板方法
{
    /// <summary>	
    /// 描述：封装不可变部分，可变部分延迟到子类
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/16 14:30:51
    /// </summary>
    public abstract class Father
    {
        public virtual string Name { get; set; }
        public void WriteLine()
        {
            Console.WriteLine("{0}今日打卡时间：{1}",Name, GetDateTime());
        }

        public virtual string GetDateTime()
        {
            return DateTime.MinValue.ToString();
        }
    }
}
