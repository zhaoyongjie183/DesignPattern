using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介模式
{
    /// <summary>
    /// 实现中介
    /// </summary>
    public class ConcreteMediator : AbstractMediator
    {
        private List<AbstractColleague> abstractColleagues = new List<AbstractColleague>();
        public override void Add(AbstractColleague abstractColleague)
        {
            abstractColleagues.Add(abstractColleague);
        }

        public override void Send(string name,string msg)
        {
            var coll = abstractColleagues.FirstOrDefault(i => i.Name == name);
            if (coll != null)
            {
                coll.Receive(string.Format("{0}:{1}",name,msg));
            }
        }
    }
}