using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Form1
{
    public class Clock
    {
        private Timer timer;
        private Hour _hour = new Hour();
        private Minute _minute = new Minute();
        public event EventHandler<TimeEventArgs> Timechanged;
        
        public Clock(int secondinterval=1000)
        {
            timer = new Timer();
            timer.Interval = secondinterval;
            timer.Elapsed += Timer_Elapsed;
            
       
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_minute.Tick())
            {
                _hour.Tick();
            }
            if (Timechanged != null)
            {
             Timechanged.Invoke(this, new TimeEventArgs(_hour.hourValue, _minute.minuteValue));
            }
        }

        public void SetTime(int hour, int minute)
        {
            _hour.hourValue = hour;
            _minute.minuteValue = minute;
        }
        
        public void StartClock()
        {
            timer.Start();
        }
        public void StopClock()
        {
            timer.Stop();
            //StopClock stopClock = new StopClock();
            //stopClock.Start();
            //for (int i = 0;  i < 1000; i++)
            //{
            //    System.Threading.Thread.Sleep(10);
            //}
            //stopClock.Stop();
        }
    }
}
