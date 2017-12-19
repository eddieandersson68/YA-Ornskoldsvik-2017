using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesAndEvents
{
    class MessageService
    {


        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: send a text..."+ e.Video.Title);
        }
    }

}
