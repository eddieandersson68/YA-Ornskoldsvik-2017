using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class Hour
    {
        public int hourValue {get; set;}
        

        public void Tick()
        {
            if( hourValue == 23)
            {
                hourValue = 0;
                
            }
            else
            {
                hourValue += 1;
                
            }
        }
    }
}
