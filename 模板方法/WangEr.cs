using System;
using System.Collections.Generic;
using System.Text;

namespace 模板方法
{
    /// <summary>	
    /// 描述：
    /// 创建人： zhaoyongjie
    /// 创建时间：2019/8/16 14:35:40
    /// </summary>
    public class WangEr:Father
    {
        public override string Name { get => "王二"; }
        public override string GetDateTime()
        {
            return DateTime.Now.ToString();
        }

    }
}
