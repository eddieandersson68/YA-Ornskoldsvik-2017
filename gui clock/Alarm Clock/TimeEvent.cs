using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Form1
{
    public class TimeEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public TimeEventArgs(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
    }
}
