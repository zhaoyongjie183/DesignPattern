using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    public class GuangxiTravel : TravelStrategy
    {
        public GuangxiTravel()
        {
            this.PlanName = "广西桂林山水甲天下，心向往之！";
        }
        public override void TravelPlan()
        {
            Console.WriteLine("广西旅游计划：");
            Console.WriteLine(string.Format("计划名称：{0}预算：{1}", this.PlanName, this.Budget));
            if (this.Budget >= 4000)
            {
                Console.WriteLine("选择高铁出行！");
            }
            else
            {
                Console.WriteLine("选择大巴出行！");
            }
        }
    }
}