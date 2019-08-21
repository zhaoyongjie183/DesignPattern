using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    public class TravelStrategyContext
    {
        public void TravelPlan(Weather weather)
        {
            TravelStrategy travelPlan = null;

            switch (weather)
            {
                case Weather.Rain:
                    Console.WriteLine("天气糟糕");
                    travelPlan = new BackupTravel();
                    break;
                case Weather.Sunny:
                    Console.WriteLine("天气晴好");
                    travelPlan = new GuangxiTravel() { Budget = 3000 };
                    break;
            }

            travelPlan.TravelPlan();
        }
    }
}