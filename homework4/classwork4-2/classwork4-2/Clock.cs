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
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public delegate void Clockhandler(object sender);
        public event Clockhandler Tick;
        public event Clockhandler Alarm;
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
        }

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
                if (passbytime == 5)
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
