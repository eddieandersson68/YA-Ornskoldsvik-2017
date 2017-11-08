using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        private Timer t1;
        Hour hour = new Hour();
        Minute minute = new Minute();
        public event EventHandler Timechanged;
        private Clock c1;
        
        public Clock(int secondinterval = 1000)
        {
            c1 = new Clock();
            t1 = new Timer();
            t1.Interval = secondinterval;
            t1.Elapsed += Timer_Elapsed;
        }

        public void Timer_Elapsed(object sender, EventArgs e)
        {
            if (minute.MinuteValue == 59 )
            {
                minute.MinuteValue = 0;
                hour.HourValue++;
            }
            if (hour.HourValue == 23)
            {
                hour.HourValue = 0;
            }

        }

    }
}
