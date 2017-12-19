using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video () { Title = "Video 1" };
            VideoEncoder videoEncoder = new VideoEncoder(); // publisher
            MailService mailservice = new MailService(); // Subscriber
            MessageService messageservice = new MessageService(); // Subscriber

            videoEncoder.VideoEncoded += mailservice.OnVideoEncoded; // Reference to the method OnVideoEncoded AKA subscribed
            videoEncoder.VideoEncoded += messageservice.OnVideoEncoded; // Reference to the method OnVideoEncoded AKA subscribed

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
