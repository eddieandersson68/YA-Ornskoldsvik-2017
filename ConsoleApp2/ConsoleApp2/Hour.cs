using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hour
    {
        private int _hour;

        public int HourValue
        {
            get { return _hour; }

            set
            {
                if (_hour <= 23)
                {
                    _hour = value;
                    _hour++;
                }
                else _hour = 0;
            }
        }
    }
}
