using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace classwork4_2
{
    class Clock
    {   

        //闹钟的几个基本属性
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public delegate void Clockhandler(object sender);

        //定义事件
        public event Clockhandler Tick;
        public event Clockhandler Alarm;

        //读秒
        public void TimeGoesBy()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            if (minute == 60)
            {
                minute = 0;
                hour++;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine(DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second);
        }

        //闹钟响铃的方法
        public void ClockRing()
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            int passbytime = 0;
            while (true)
            {
                Tick(this);
                passbytime++;
                if (this.hour==10&&this.minute==12&&this.second==0)
                { 
                    Alarm(this);
                    passbytime = 0;
                }
                TimeGoesBy();
                Thread.Sleep(1000);
            }
        }
    }
}
