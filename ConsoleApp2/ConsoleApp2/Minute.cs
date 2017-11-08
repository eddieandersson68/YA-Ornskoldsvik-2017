using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Minute
    {
        private int _minute;
        public int MinuteValue
        {
            get { return _minute; }

            set
            {
                if (_minute <= 59)
                {
                    _minute = value;
                    _minute++;
                }
                else _minute = 0;
            }
        }
        public void Tick()
        {
        }
    }
}
