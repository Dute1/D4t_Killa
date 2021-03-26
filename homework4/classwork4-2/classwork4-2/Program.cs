using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4_2
{
    
    class Program
    {
        static void ShowTick(object sender)
        {
            Console.WriteLine("tick..");
        }
        static void ShowAlarm(object sender)
        {
            Console.WriteLine("闹钟响了！当前时间为" + DateTime.Now.Hour.ToString() + "时" + DateTime.Now.Minute.ToString() + "分" + DateTime.Now.Second.ToString() + "秒.");
        }

        static void Main(string[] args)
        {
           Clock clocktest = new Clock();
            clocktest.Tick += ShowTick;
            clocktest.Alarm += ShowAlarm;
            clocktest.ClockRing();
        }
    }
}
