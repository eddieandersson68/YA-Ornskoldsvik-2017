using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeligatesAndEvents
{
    public class VideoEncoder
    {
        /// <summary>
        /// The right way to do it
        /// </summary>
        /// 
        // 1. Define a deligate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // Evenhandler
        // EventHandler<TEvenvtArgs>


        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        /// <summary>
        /// Simpler syntax to do the same thing as using a delegate
        /// </summary>

        public event EventHandler<VideoEventArgs> VideoEncoded;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            // Encoding logic
            //...
            OnVideoEncoded(video);

        }
        protected virtual void OnVideoEncoded(Video video)
        {
           if  (VideoEncoded !=null)
            VideoEncoded(this, new VideoEventArgs() { Video = video });

            // simpler syntax
            //VideoEncoded?.Invoke(this, EventArgs.Empty);
        }






        /// <summary>
        /// The wromg way to do it
        /// </summary>

        //public void Encode(VideoEncoder video)
        //{
        //    Encoding logic
        //    ...
        //    _mailService.Send(new Mail());
        //    _mailService.Send(new Text());

        //}
    }
}
