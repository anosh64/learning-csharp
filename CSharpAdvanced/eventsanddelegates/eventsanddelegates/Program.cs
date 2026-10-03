using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsanddelegates
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // subscribing
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // subscribing

            videoEncoder.Encode(video);

        }
    }
}
