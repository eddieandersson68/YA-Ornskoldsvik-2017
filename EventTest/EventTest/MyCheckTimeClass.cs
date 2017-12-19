using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventTest
{
    class MyCheckTimeClass
    {
        public event EventHandler Every10SecEvent;
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (DateTime.Now.Second % 10 == 0)
                {
                    // Fire the event
                    Every10_Sec();
                }
            }
        }


        private void Every10_Sec()
        {
            if (Every10SecEvent != null)
                Every10SecEvent(this, new EventArgs());
        }
    }

    //private void Every_sec()
    //{
    //    if (Every10SecEvent != null)
    //        Every10SecEvent(this, new EventArgs());
    //}
}


