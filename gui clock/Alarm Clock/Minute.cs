using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class Minute
    {
        public int minuteValue { get; set; }

        public bool Tick()
        {
          
            if (minuteValue == 59)
            {
                minuteValue = 0;
                return true;
            }       
            else
            {
                minuteValue += 1;
                return false;
            }
          
            
        }

    }
}
